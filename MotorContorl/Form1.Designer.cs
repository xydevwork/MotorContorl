namespace MotorContorl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.cmbComports = new DevComponents.DotNetBar.ComboBoxItem();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.cmbCmbBaurate = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.swtButton = new DevComponents.DotNetBar.SwitchButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSaveData = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.SetMotor = new DevComponents.DotNetBar.RibbonTabItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.rbLocMode = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSpeedMode = new System.Windows.Forms.RadioButton();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.tbMotorSpeed = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tbspeed = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbNumOfPulse = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tbNumOfCircle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSendLoc = new DevComponents.DotNetBar.ButtonX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.btnClnMsg = new DevComponents.DotNetBar.ButtonX();
            this.cbSplit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.motorTiming = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSigle = new System.Windows.Forms.RadioButton();
            this.rbContinuity = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rtbDspMsg = new System.Windows.Forms.RichTextBox();
            this.speedSlider = new DevComponents.DotNetBar.Controls.Slider();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sliderKi = new DevComponents.DotNetBar.Controls.Slider();
            this.sliderKd = new DevComponents.DotNetBar.Controls.Slider();
            this.nudkpflt = new System.Windows.Forms.NumericUpDown();
            this.nudkiflt = new System.Windows.Forms.NumericUpDown();
            this.nudkdflt = new System.Windows.Forms.NumericUpDown();
            this.sliderKp = new DevComponents.DotNetBar.Controls.Slider();
            this.swBtnPID = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkpflt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkiflt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkdflt)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ribbonControl1
            // 
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.ribbonTabItem1,
            this.SetMotor});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(5, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(683, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar2);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(683, 98);
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer5});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(148, 95);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 2;
            this.ribbonBar2.Text = "连接设置";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6,
            this.itemContainer7,
            this.itemContainer8});
            // 
            // 
            // 
            this.itemContainer5.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1,
            this.cmbComports});
            // 
            // 
            // 
            this.itemContainer6.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "端口号：";
            // 
            // cmbComports
            // 
            this.cmbComports.ComboWidth = 80;
            this.cmbComports.DropDownHeight = 106;
            this.cmbComports.DropDownWidth = 120;
            this.cmbComports.ItemHeight = 16;
            this.cmbComports.Name = "cmbComports";
            this.cmbComports.Text = "comboBoxItem1";
            this.cmbComports.Click += new System.EventHandler(this.cmbComports_Click);
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2,
            this.cmbCmbBaurate});
            // 
            // 
            // 
            this.itemContainer7.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "波特率：";
            // 
            // cmbCmbBaurate
            // 
            this.cmbCmbBaurate.ComboWidth = 80;
            this.cmbCmbBaurate.DropDownHeight = 106;
            this.cmbCmbBaurate.DropDownWidth = 80;
            this.cmbCmbBaurate.ItemHeight = 16;
            this.cmbCmbBaurate.Items.AddRange(new object[] {
            this.comboItem7,
            this.comboItem8,
            this.comboItem9});
            this.cmbCmbBaurate.Name = "cmbCmbBaurate";
            this.cmbCmbBaurate.Text = "comboBoxItem1";
            this.cmbCmbBaurate.Click += new System.EventHandler(this.cmbCmbBaurate_Click);
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "9600";
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "19200";
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "115200";
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.swtButton});
            // 
            // 
            // 
            this.itemContainer8.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // swtButton
            // 
            this.swtButton.Name = "swtButton";
            this.swtButton.Text = "连接     ";
            this.swtButton.ValueChanged += new System.EventHandler(this.swtButton_ValueChanged);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBar1);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 53);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(687, 98);
            // 
            // 
            // 
            this.ribbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveData});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(106, 95);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 0;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.Image")));
            this.btnSaveData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.SplitButton = true;
            this.btnSaveData.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem15,
            this.buttonItem16});
            this.btnSaveData.SubItemsExpandWidth = 14;
            this.btnSaveData.Text = "打开存储数据文件夹";
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // buttonItem15
            // 
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.Text = "New Item";
            // 
            // buttonItem16
            // 
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.Text = "New Item";
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.Image = ((System.Drawing.Image)(resources.GetObject("applicationButton1.Image")));
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 0;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.applicationButton1.Text = "&File";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2,
            this.itemContainer4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.galleryContainer1});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem5,
            this.buttonItem6,
            this.buttonItem7});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "&New";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem3.Image")));
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 24;
            this.buttonItem3.Text = "&Open...";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem4.Image")));
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 24;
            this.buttonItem4.Text = "&Save...";
            // 
            // buttonItem5
            // 
            this.buttonItem5.BeginGroup = true;
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem5.Image")));
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 24;
            this.buttonItem5.Text = "S&hare...";
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem6.Image")));
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "&Print...";
            // 
            // buttonItem7
            // 
            this.buttonItem7.BeginGroup = true;
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem7.Image")));
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "&Close";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            // 
            // 
            // 
            this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem8
            // 
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem11
            // 
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "&4. example.rtf";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem12.Image")));
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem13.Image")));
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "串口设置";
            this.ribbonTabItem1.Click += new System.EventHandler(this.ribbonTabItem1_Click);
            // 
            // SetMotor
            // 
            this.SetMotor.Name = "SetMotor";
            this.SetMotor.Panel = this.ribbonPanel2;
            this.SetMotor.Text = "数据保存";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "by欣杨科技有限公司";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // rbLocMode
            // 
            this.rbLocMode.AutoSize = true;
            this.rbLocMode.Location = new System.Drawing.Point(14, 20);
            this.rbLocMode.Name = "rbLocMode";
            this.rbLocMode.Size = new System.Drawing.Size(71, 16);
            this.rbLocMode.TabIndex = 24;
            this.rbLocMode.Text = "位置模式";
            this.rbLocMode.UseVisualStyleBackColor = true;
            this.rbLocMode.CheckedChanged += new System.EventHandler(this.rbLocMode_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSpeedMode);
            this.groupBox1.Controls.Add(this.rbLocMode);
            this.groupBox1.Location = new System.Drawing.Point(5, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 49);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "步进电机转动模式";
            // 
            // rbSpeedMode
            // 
            this.rbSpeedMode.AutoSize = true;
            this.rbSpeedMode.Checked = true;
            this.rbSpeedMode.Location = new System.Drawing.Point(349, 20);
            this.rbSpeedMode.Name = "rbSpeedMode";
            this.rbSpeedMode.Size = new System.Drawing.Size(71, 16);
            this.rbSpeedMode.TabIndex = 25;
            this.rbSpeedMode.TabStop = true;
            this.rbSpeedMode.Text = "速度模式";
            this.rbSpeedMode.UseVisualStyleBackColor = true;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(5, 214);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(683, 10);
            this.line1.TabIndex = 26;
            this.line1.Text = "line1";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 83);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(99, 21);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "电机转速(rpm)：";
            // 
            // tbMotorSpeed
            // 
            // 
            // 
            // 
            this.tbMotorSpeed.Border.Class = "TextBoxBorder";
            this.tbMotorSpeed.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbMotorSpeed.Location = new System.Drawing.Point(117, 83);
            this.tbMotorSpeed.Name = "tbMotorSpeed";
            this.tbMotorSpeed.PreventEnterBeep = true;
            this.tbMotorSpeed.Size = new System.Drawing.Size(47, 21);
            this.tbMotorSpeed.TabIndex = 5;
            this.tbMotorSpeed.Text = "5";
            this.tbMotorSpeed.TextChanged += new System.EventHandler(this.tbMotorSpeed_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Location = new System.Drawing.Point(114, 154);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(6, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(8, 32);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(66, 21);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "当前转速：";
            // 
            // tbspeed
            // 
            // 
            // 
            // 
            this.tbspeed.Border.Class = "TextBoxBorder";
            this.tbspeed.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbspeed.Enabled = false;
            this.tbspeed.Location = new System.Drawing.Point(89, 32);
            this.tbspeed.Name = "tbspeed";
            this.tbspeed.PreventEnterBeep = true;
            this.tbspeed.Size = new System.Drawing.Size(100, 21);
            this.tbspeed.TabIndex = 10;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(30, 74);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 21);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "细分：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(19, 122);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(55, 21);
            this.labelX4.TabIndex = 13;
            this.labelX4.Text = "脉冲数：";
            // 
            // tbNumOfPulse
            // 
            // 
            // 
            // 
            this.tbNumOfPulse.Border.Class = "TextBoxBorder";
            this.tbNumOfPulse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNumOfPulse.Location = new System.Drawing.Point(89, 122);
            this.tbNumOfPulse.Name = "tbNumOfPulse";
            this.tbNumOfPulse.PreventEnterBeep = true;
            this.tbNumOfPulse.Size = new System.Drawing.Size(100, 21);
            this.tbNumOfPulse.TabIndex = 14;
            this.tbNumOfPulse.Text = "0";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(30, 170);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 21);
            this.labelX5.TabIndex = 15;
            this.labelX5.Text = "圈数：";
            // 
            // tbNumOfCircle
            // 
            // 
            // 
            // 
            this.tbNumOfCircle.Border.Class = "TextBoxBorder";
            this.tbNumOfCircle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbNumOfCircle.Location = new System.Drawing.Point(89, 170);
            this.tbNumOfCircle.Name = "tbNumOfCircle";
            this.tbNumOfCircle.PreventEnterBeep = true;
            this.tbNumOfCircle.Size = new System.Drawing.Size(100, 21);
            this.tbNumOfCircle.TabIndex = 16;
            this.tbNumOfCircle.Text = "0";
            // 
            // btnSendLoc
            // 
            this.btnSendLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSendLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSendLoc.Location = new System.Drawing.Point(6, 192);
            this.btnSendLoc.Name = "btnSendLoc";
            this.btnSendLoc.Size = new System.Drawing.Size(75, 23);
            this.btnSendLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSendLoc.TabIndex = 17;
            this.btnSendLoc.Text = "发送位置";
            this.btnSendLoc.Click += new System.EventHandler(this.btnSendLoc_Click);
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(5, 451);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(681, 23);
            this.line2.TabIndex = 19;
            this.line2.Text = "line2";
            // 
            // btnClnMsg
            // 
            this.btnClnMsg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClnMsg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClnMsg.Location = new System.Drawing.Point(117, 192);
            this.btnClnMsg.Name = "btnClnMsg";
            this.btnClnMsg.Size = new System.Drawing.Size(75, 23);
            this.btnClnMsg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClnMsg.TabIndex = 21;
            this.btnClnMsg.Text = "清空消息";
            this.btnClnMsg.Click += new System.EventHandler(this.btnClnMsg_Click);
            // 
            // cbSplit
            // 
            this.cbSplit.DisplayMember = "Text";
            this.cbSplit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSplit.FormattingEnabled = true;
            this.cbSplit.ItemHeight = 15;
            this.cbSplit.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cbSplit.Location = new System.Drawing.Point(89, 74);
            this.cbSplit.Name = "cbSplit";
            this.cbSplit.Size = new System.Drawing.Size(100, 21);
            this.cbSplit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSplit.TabIndex = 3;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "1";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "2";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "4";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "8";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "16";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "32";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // motorTiming
            // 
            // 
            // 
            // 
            this.motorTiming.Border.Class = "TextBoxBorder";
            this.motorTiming.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.motorTiming.Location = new System.Drawing.Point(117, 110);
            this.motorTiming.Name = "motorTiming";
            this.motorTiming.PreventEnterBeep = true;
            this.motorTiming.Size = new System.Drawing.Size(47, 21);
            this.motorTiming.TabIndex = 28;
            this.motorTiming.Text = "2";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(36, 110);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 21);
            this.labelX6.TabIndex = 27;
            this.labelX6.Text = "定时(min)：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSigle);
            this.groupBox2.Controls.Add(this.rbContinuity);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.tbMotorSpeed);
            this.groupBox2.Controls.Add(this.motorTiming);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnClnMsg);
            this.groupBox2.Controls.Add(this.btnSendLoc);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Location = new System.Drawing.Point(224, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 221);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "速度模式";
            // 
            // rbSigle
            // 
            this.rbSigle.AutoSize = true;
            this.rbSigle.Location = new System.Drawing.Point(118, 19);
            this.rbSigle.Name = "rbSigle";
            this.rbSigle.Size = new System.Drawing.Size(71, 16);
            this.rbSigle.TabIndex = 1;
            this.rbSigle.Text = "单次测试";
            this.rbSigle.UseVisualStyleBackColor = true;
            // 
            // rbContinuity
            // 
            this.rbContinuity.AutoSize = true;
            this.rbContinuity.Checked = true;
            this.rbContinuity.Location = new System.Drawing.Point(6, 20);
            this.rbContinuity.Name = "rbContinuity";
            this.rbContinuity.Size = new System.Drawing.Size(71, 16);
            this.rbContinuity.TabIndex = 0;
            this.rbContinuity.TabStop = true;
            this.rbContinuity.Text = "连续测试";
            this.rbContinuity.UseVisualStyleBackColor = true;
            // 
            // rtbDspMsg
            // 
            this.rtbDspMsg.Location = new System.Drawing.Point(5, 470);
            this.rtbDspMsg.Name = "rtbDspMsg";
            this.rtbDspMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDspMsg.Size = new System.Drawing.Size(681, 205);
            this.rtbDspMsg.TabIndex = 31;
            this.rtbDspMsg.Text = "";
            this.rtbDspMsg.TextChanged += new System.EventHandler(this.rtbDspMsg_TextChanged);
            // 
            // speedSlider
            // 
            // 
            // 
            // 
            this.speedSlider.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.speedSlider.Location = new System.Drawing.Point(236, 284);
            this.speedSlider.Maximum = 255;
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(150, 23);
            this.speedSlider.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.speedSlider.TabIndex = 3;
            this.speedSlider.Text = "调速";
            this.speedSlider.Value = 0;
            this.speedSlider.ValueChanged += new System.EventHandler(this.speedSlider_ValueChanged_1);
            // 
            // sliderKi
            // 
            // 
            // 
            // 
            this.sliderKi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sliderKi.Location = new System.Drawing.Point(6, 108);
            this.sliderKi.Maximum = 500;
            this.sliderKi.Minimum = -500;
            this.sliderKi.Name = "sliderKi";
            this.sliderKi.Size = new System.Drawing.Size(150, 23);
            this.sliderKi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sliderKi.TabIndex = 33;
            this.sliderKi.Text = "Ki:";
            this.sliderKi.Value = 0;
            this.sliderKi.ValueChanged += new System.EventHandler(this.sliderKi_ValueChanged);
            // 
            // sliderKd
            // 
            // 
            // 
            // 
            this.sliderKd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sliderKd.Location = new System.Drawing.Point(6, 168);
            this.sliderKd.Maximum = 500;
            this.sliderKd.Minimum = -500;
            this.sliderKd.Name = "sliderKd";
            this.sliderKd.Size = new System.Drawing.Size(150, 23);
            this.sliderKd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sliderKd.TabIndex = 34;
            this.sliderKd.Text = "Kd:";
            this.sliderKd.Value = 0;
            this.sliderKd.ValueChanged += new System.EventHandler(this.sliderKd_ValueChanged);
            // 
            // nudkpflt
            // 
            this.nudkpflt.DecimalPlaces = 2;
            this.nudkpflt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudkpflt.Location = new System.Drawing.Point(170, 56);
            this.nudkpflt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudkpflt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudkpflt.Name = "nudkpflt";
            this.nudkpflt.Size = new System.Drawing.Size(55, 21);
            this.nudkpflt.TabIndex = 38;
            this.nudkpflt.ValueChanged += new System.EventHandler(this.nudkpflt_ValueChanged);
            // 
            // nudkiflt
            // 
            this.nudkiflt.DecimalPlaces = 2;
            this.nudkiflt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudkiflt.Location = new System.Drawing.Point(170, 108);
            this.nudkiflt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudkiflt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudkiflt.Name = "nudkiflt";
            this.nudkiflt.Size = new System.Drawing.Size(55, 21);
            this.nudkiflt.TabIndex = 39;
            this.nudkiflt.ValueChanged += new System.EventHandler(this.nudkiflt_ValueChanged);
            // 
            // nudkdflt
            // 
            this.nudkdflt.DecimalPlaces = 2;
            this.nudkdflt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudkdflt.Location = new System.Drawing.Point(170, 170);
            this.nudkdflt.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudkdflt.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudkdflt.Name = "nudkdflt";
            this.nudkdflt.Size = new System.Drawing.Size(55, 21);
            this.nudkdflt.TabIndex = 40;
            this.nudkdflt.ValueChanged += new System.EventHandler(this.nudkdflt_ValueChanged);
            // 
            // sliderKp
            // 
            // 
            // 
            // 
            this.sliderKp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sliderKp.Location = new System.Drawing.Point(6, 54);
            this.sliderKp.Maximum = 500;
            this.sliderKp.Minimum = -500;
            this.sliderKp.Name = "sliderKp";
            this.sliderKp.Size = new System.Drawing.Size(150, 23);
            this.sliderKp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.sliderKp.TabIndex = 41;
            this.sliderKp.Text = "Kp:";
            this.sliderKp.Value = 0;
            this.sliderKp.ValueChanged += new System.EventHandler(this.sliderKp_ValueChanged);
            // 
            // swBtnPID
            // 
            // 
            // 
            // 
            this.swBtnPID.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swBtnPID.Location = new System.Drawing.Point(111, 19);
            this.swBtnPID.Name = "swBtnPID";
            this.swBtnPID.Size = new System.Drawing.Size(66, 22);
            this.swBtnPID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swBtnPID.TabIndex = 42;
            this.swBtnPID.ValueChanged += new System.EventHandler(this.swBtnPID_ValueChanged);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(6, 20);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(99, 21);
            this.labelX7.TabIndex = 43;
            this.labelX7.Text = "PID控制开关：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelX7);
            this.groupBox3.Controls.Add(this.nudkdflt);
            this.groupBox3.Controls.Add(this.sliderKp);
            this.groupBox3.Controls.Add(this.sliderKd);
            this.groupBox3.Controls.Add(this.nudkiflt);
            this.groupBox3.Controls.Add(this.swBtnPID);
            this.groupBox3.Controls.Add(this.nudkpflt);
            this.groupBox3.Controls.Add(this.sliderKi);
            this.groupBox3.Location = new System.Drawing.Point(452, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(234, 221);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID控制";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbspeed);
            this.groupBox4.Controls.Add(this.labelX2);
            this.groupBox4.Controls.Add(this.cbSplit);
            this.groupBox4.Controls.Add(this.labelX3);
            this.groupBox4.Controls.Add(this.labelX4);
            this.groupBox4.Controls.Add(this.tbNumOfPulse);
            this.groupBox4.Controls.Add(this.labelX5);
            this.groupBox4.Controls.Add(this.tbNumOfCircle);
            this.groupBox4.Location = new System.Drawing.Point(5, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 221);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置模式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 676);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.speedSlider);
            this.Controls.Add(this.rtbDspMsg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "转台控制系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudkpflt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkiflt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudkdflt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.IO.Ports.SerialPort serialPort1;
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ComboBoxItem cmbComports;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ComboBoxItem cmbCmbBaurate;
        private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.DotNetBar.SwitchButtonItem swtButton;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem SetMotor;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private System.Windows.Forms.RadioButton rbLocMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSpeedMode;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX tbMotorSpeed;
        private DevComponents.DotNetBar.ButtonX btnStop;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX tbspeed;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNumOfPulse;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX tbNumOfCircle;
        private DevComponents.DotNetBar.ButtonX btnSendLoc;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.ButtonX btnClnMsg;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSplit;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.ButtonItem btnSaveData;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.Editors.ComboItem comboItem7;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.TextBoxX motorTiming;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSigle;
        private System.Windows.Forms.RadioButton rbContinuity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rtbDspMsg;
        private DevComponents.DotNetBar.Controls.Slider speedSlider;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevComponents.DotNetBar.Controls.Slider sliderKi;
        private DevComponents.DotNetBar.Controls.Slider sliderKd;
        private System.Windows.Forms.NumericUpDown nudkpflt;
        private System.Windows.Forms.NumericUpDown nudkiflt;
        private System.Windows.Forms.NumericUpDown nudkdflt;
        private DevComponents.DotNetBar.Controls.Slider sliderKp;
        private DevComponents.DotNetBar.Controls.SwitchButton swBtnPID;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

