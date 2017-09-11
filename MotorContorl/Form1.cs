using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MotorContorl
{
    public partial class Form1 : Office2007RibbonForm
    {
        string[] ports = SerialPort.GetPortNames();          // 获取串口连接列表
        public List<byte> buffer = new List<byte>(1024);     // 定义串口数据缓存
        public static byte[] binary_data_1 = new byte[128];
        string path = string.Empty;                          //文件路径
        private byte[] sendData = new byte[12];              //发送数据帧为：55 AA 01 06 50 04 05 02 01 01 XOR F0
        bool isMotorWork = false;
        string time;
        string fileName;


        public Form1()
        {
            InitializeComponent();
            initCommPort();
            
        }
        //初始化串口
        private void initCommPort()
        {
            Control.CheckForIllegalCrossThreadCalls = false;                    //防止跨线程访问出错
            Array.Sort(ports);
            cmbComports.Items.AddRange(ports);
            cmbComports.SelectedIndex = cmbComports.Items.Count > 0 ? 0 : -1;    //COM1
            cmbCmbBaurate.SelectedItem = cmbCmbBaurate.Items[2];                 //波特率115200
            cbSplit.SelectedItem = cbSplit.Items[5];                             //细分32
            tbspeed.Text = "0";
            tbMotorSpeed.Text = "5";
            disableBtn();

            //初始化数据帧
            sendData[0] = 0x55;
            sendData[1] = 0xAA;
            sendData[2] = 0x01;
            sendData[3] = 0x06; //长度位
            sendData[4] = 0x50; //开始
            sendData[5] = 0x04; //命令段长度
            sendData[11] = 0xF0;
        }


        /// <summary>
        /// 位置模式按钮使能
        /// </summary>
        private void ableBtn()
        {
            cbSplit.Enabled = true;
            tbNumOfPulse.Enabled = true;
            tbNumOfCircle.Enabled = true;
            btnSendLoc.Enabled = true;
        }
        /// <summary>
        /// 位置模式按钮失能
        /// </summary>
        private void disableBtn()
        {
            cbSplit.Enabled = false;
            tbNumOfPulse.Enabled = false;
            tbNumOfCircle.Enabled = false;
            btnSendLoc.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 开始按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swtButton_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (swtButton.Value == true)
                {
                    serialPort1.PortName = cmbComports.Text;
                    serialPort1.BaudRate = int.Parse(cmbCmbBaurate.Text);
                    serialPort1.Open();
                    cmbComports.Enabled = false;
                    cmbCmbBaurate.Enabled = false;
                }
                else
                {
                    serialPort1.Close();
                    cmbCmbBaurate.Enabled = true;
                    cmbComports.Enabled = true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                swtButton.Value = !swtButton.Value;
                return;
            }
        }
        //打开保存的数据
        private void btnSaveData_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = path.Replace(".txt", "");
            openFileDialog1.Filter = "txt|*.txt*|所有文件|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Process.Start(openFileDialog1.FileName);
            }
        }

        //电机转动模式选择
        private void rbLocMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLocMode.Checked == true)
            {
                ableBtn();
            }
            else
            {
                disableBtn();
            }
        }
       
        

        private void cmbCmbBaurate_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = int.Parse(cmbCmbBaurate.Text);
        }

        private void cmbComports_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cmbComports.Text;
        }
        //电机开始转动
        private void btnStart_Click(object sender, EventArgs e)
        {
           if(swtButton.Value == false)
            {
                MessageBox.Show("请打开串口！");
                return;
            }
            isMotorWork = true;
            updataCheckBoxData();
            this.serialPort1.Write(sendData, 0, 12);  //发送数据

            printLog(sendData);
        }
        //电机停止转动
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (swtButton.Value == false)
            {
                MessageBox.Show("请打开串口！");
                return;
            }
            isMotorWork = false;
            updataCheckBoxData();
            this.serialPort1.Write(sendData, 0, 12);  //发送数据 

            printLog(sendData);
            //Console.WriteLine(BitConverter.ToString(sendData)); //log 打印

        }
        //清空消息
        private void btnClnMsg_Click(object sender, EventArgs e)
        {
            rtbDspMsg.Text = "";
        }
        // 串口接收数据
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int encoderPulse = 0x00000000, otrEncoderPulse = 0x00000000;
                ushort bytChk = 0x00, bytTailByte = 0x00;;
                int dataSize = 0,errorNum = 0;
                int n = serialPort1.BytesToRead;
                byte[] dataBuff = new byte[n];
                byte[] cmdata = new byte[3];                                                    //接收数据命令段缓存
                serialPort1.Read(dataBuff, 0, dataBuff.Length);                                 //获取串口数据
                buffer.AddRange(dataBuff);                                                      //将读取的数据放入buffer中
                serialPort1.DiscardInBuffer();                                                  //清空串口数据

                printLog(sendData);                                                             //打印串口数据

                dataSize = buffer.Count;
                while (buffer.Count >= 4)                                                       //当buffer中的数据的个数大于等于4个时，即每一帧的数据长度所在位（第4位）出现时
                {
                    if (buffer[0] == 0x55 && buffer[1] == 0xAA)
                    {
                        int len = buffer[3];                                                    //长度位
                        if (len > 0 && len <= 250)
                        {
                            if (dataSize >= (len + 6))                                          //如果接收到的数据没有达到一帧数据的指定长度， 则执行下次循环
                            {
                                int num = 0;                                                    //数据帧为：55 AA 01 0D 50 0B 00 01 86 A0 00 01 86 AA 05 02 01 XOR F0
                                bytChk = Get_CheckXor(dataBuff, dataBuff.Length);               //计算校验位
                                bytTailByte = buffer[dataSize - 1];                             //结束位
                                if (bytChk == buffer[dataSize - 2] && bytTailByte == 0xF0)      //检查校验位和尾帧数据是否正确
                                {
                                    int dataLen = buffer[5];
                                    buffer.RemoveRange(0, 6);                                   //删去帧头，地址和帧长度，命令字
                                    while (dataLen > 0)                                         //读取命令段
                                    {

                                        //encoderPulse = buffer[0];
                                        //encoderPulse <<= 8;
                                        //encoderPulse += buffer[1];
                                        //encoderPulse <<= 8;
                                        //encoderPulse += buffer[2];
                                        //encoderPulse <<= 8;
                                        //encoderPulse += buffer[3];

                                        for (int i = 0; i < 4; i++)
                                        {
                                            encoderPulse += buffer[i];                          // 00 01 86 A0 00 01 86 AA       
                                            if (i == 3)
                                            {
                                                break;
                                            }
                                            encoderPulse <<= 8;
                                        }
                                        encoderPulse = (int)(encoderPulse & 0xFFFFFFFF);        // 第一个编码器脉冲数
                                        for (int j = 4; j < 8; j++)
                                        {
                                            otrEncoderPulse += buffer[j];                       // 00 01 86 A0 00 01 86 AA
                                            if (j == 7)
                                            {
                                                break;
                                            }
                                            otrEncoderPulse <<= 8;
                                        }
                                        otrEncoderPulse = (int)(otrEncoderPulse & 0xFFFFFFFF);  // 第二个编码器脉冲数
                                        buffer.RemoveRange(0, 8);                               // 删除存储过的命令段
                                        for(int k = 0;k < 3; k++)
                                        {
                                            cmdata[k] = buffer[k];                              // cmdata[0]:电机转动速度；cmdata[1]:电机转动时间；cmdata[2]:所有数据回传结束标志
                                        }
                                        dataLen = 0;
                                        dataSize = 0;
                                        buffer.Clear();
                                        int firEncoder = Convert.ToInt32(encoderPulse);
                                        int secEncoder = Convert.ToInt32(otrEncoderPulse);
                                        int dValue = Math.Abs(firEncoder - secEncoder);

                                        tbspeed.Text = cmdata[0].ToString();
                                      //  time = DateTime.Now.ToLocalTime().ToString("yyyy年MM月dd日HH:mm:ss");
                                        time = DateTime.Now.ToLocalTime().ToString("yyyy年MM月dd日HH时mm分ss秒");
                                        fileName = System.Environment.CurrentDirectory + "\\" + time + ".txt"; //"+ time + "
                                        if (cmdata[2] >0)                                       //回传数据结束cmdata[1]= 01
                                        {
                                            string outputStr = time + " 电机在转速为：" + cmdata[0] + "转每分钟下，工作时间了：" + cmdata[1] + "分钟,第一个编码器输出脉冲数为：" +
                                                                           Convert.ToString(firEncoder) + "个，第二个编码器输出脉冲数为：" + 
                                                                           Convert.ToString(secEncoder) + "个,两编码器输出脉冲数差为：" +
                                                                           Convert.ToString(dValue) + "；\r\n";
                                            rtbDspMsg.Text += outputStr;
                                            StringBuilder fileData = new StringBuilder();
                                            fileData.Append(outputStr);
                                            saveFileToTxt(fileData.ToString(), fileName);
                                            fileData.Clear();
                                        }
                                        else
                                        {
                                            //所有数据没回传完毕处理
                                            string outputStr = time + "当前电机转速为：" + cmdata[0]+"转每分钟，第一个编码器输出脉冲数为："+ 
                                                Convert.ToString(firEncoder)+"个,第二个编码器输出脉冲数为："+
                                                Convert.ToString(secEncoder) + "个,两编码器输出脉冲数差为：" +
                                                Convert.ToString(dValue) + "；\r\n";
                                            rtbDspMsg.Text += outputStr;
                                        }
                                    }
                                }
                                else
                                {
                                    rtbDspMsg.Text += "校验位验证失败！\n";
                                    buffer.Clear();
                                    errorNum++;            //错误数据个数
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            buffer.RemoveRange(0, 2);
                        }
                    }
                    else
                    {
                        buffer.RemoveRange(0, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "出错提示");
            }
        }
        //指定电机转动位置
        private void btnSendLoc_Click(object sender, EventArgs e)
        {
            try
            {
                string serialStringTemp = this.tbMotorSpeed.Text;
                this.serialPort1.WriteLine(serialStringTemp);
            }
            catch(Exception ex)
            {
                MessageBox.Show("串口被关闭请稍后再试！");
            }
        }

        private void tbMotorSpeed_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 获取从地址开始的异或校验
        /// </summary>
        /// <param name="temp">数据帧</param>
        /// <param name="len">数组长度</param>
        /// <returns></returns>
        private byte Get_CheckXor(byte[] temp, int len)
        {
            byte A = 0;
            for (int i = 2; i < len-2; i++)
            {
                A ^= temp[i];
            }
            return A;
        }
        //更新选项框数据到数据帧
        private void updataCheckBoxData()
        {

            try
            {
                string speed = tbMotorSpeed.Text;
                sendData[6] = byte.Parse(speed);     //电机转速赋值

                string motorTime = motorTiming.Text;
                sendData[7] = byte.Parse(motorTime); //电机转动定时赋值
                if (rbContinuity.Checked == true)
                {
                    sendData[8] = 0x01;             //设置测试模式为连续测试模式
                }
                else
                {
                    sendData[8] = 0x02;             //设置测试模式为单次测试模式
                }
                if (isMotorWork)
                {
                    sendData[9] = 0x01;                 //电机开始转动
                }
                else
                {
                    sendData[9] = 0x00;
                }
                sendData[10] = Get_CheckXor(sendData, 12); //异或校验

            }
            catch (Exception ee)
            {
                MessageBox.Show("输入的数据太大，不能超过255！请重新输入");
                sendData[9] = 0x00;
                return;
            }
           
        }
        //显示到软件界面
        private void rtbDspMsg_TextChanged(object sender, EventArgs e)
        {
            this.rtbDspMsg.Focus();
            this.rtbDspMsg.Select(rtbDspMsg.TextLength, 0);
            this.rtbDspMsg.ScrollToCaret();
        }
        //打印log
        private void printLog(byte[] byteArr)
        {
            string strrcv = null;
           // int[] a = new int[128];
            for (int i = 0; i < sendData.Length; i++)   //这是用以显示字符串
            {
               // a[i] = Convert.ToInt32(sendData[i]);
                //   strrcv += ((char)Convert.ToInt32(dataBuff[i]));
                strrcv += sendData[i].ToString("X2");
            }
            Console.WriteLine(strrcv); //log 打印
        }
        //滑块数值改变
        private void speedSlider_ValueChanged_1(object sender, EventArgs e)
        {
            Console.WriteLine(speedSlider.Value);
            tbMotorSpeed.Text = Convert.ToString(speedSlider.Value);
        }
        //保存文件为.txt
        private void saveFileToTxt(string textStr,string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename,true);
                sw.WriteLine(textStr.ToString());
                sw.Close();
            }
            catch (IOException ee)
            {
                MessageBox.Show(ee.Message,"txt文件保存失败！");
                return;
            }
        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }
    }


}
