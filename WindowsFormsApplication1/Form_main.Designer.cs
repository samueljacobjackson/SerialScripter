namespace WindowsFormsApplication1
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tBtn_new = new System.Windows.Forms.ToolStripButton();
            this.tBtn_open = new System.Windows.Forms.ToolStripButton();
            this.tBtn_save = new System.Windows.Forms.ToolStripButton();
            this.tBtn_save_con = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tBtn_cut = new System.Windows.Forms.ToolStripButton();
            this.tBtn_copy = new System.Windows.Forms.ToolStripButton();
            this.tBtn_paste = new System.Windows.Forms.ToolStripButton();
            this.tBtn_clearConsole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tBtn_echo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tBtn_receiveAsAscii = new System.Windows.Forms.ToolStripButton();
            this.tBtn_receiveAsHex = new System.Windows.Forms.ToolStripButton();
            this.tBtn_sendAsAscii = new System.Windows.Forms.ToolStripButton();
            this.tBtn_sendAsHex = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tBtn_connect = new System.Windows.Forms.ToolStripButton();
            this.tBtn_send = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_portName = new System.Windows.Forms.ToolStripComboBox();
            this.speedbaudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_speedBaud = new System.Windows.Forms.ToolStripComboBox();
            this.dataBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_dataBits = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_stopBits = new System.Windows.Forms.ToolStripComboBox();
            this.parityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_parity = new System.Windows.Forms.ToolStripComboBox();
            this.flowControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBox_flowControl = new System.Windows.Forms.ToolStripComboBox();
            this.readTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBox_readTimeout = new System.Windows.Forms.ToolStripTextBox();
            this.writeTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBox_writeTimeout = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.ss_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_TD = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_RD = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_RTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_CTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_DSR = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_DTR = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_CD = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl_scripts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1_rTxtBox = new System.Windows.Forms.RichTextBox();
            this.cMenu_script = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenu_scriptCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_scriptCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_scriptPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_scriptDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenu_scriptSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Console = new System.Windows.Forms.GroupBox();
            this.rTxt_console = new System.Windows.Forms.RichTextBox();
            this.cMenu_console = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cMenu_consoleCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_consoleCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_consolePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cMenu_consoleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenu_consoleSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeperator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cMenu_consoleClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.tabControl_scripts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.cMenu_script.SuspendLayout();
            this.Console.SuspendLayout();
            this.cMenu_console.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBtn_new,
            this.tBtn_open,
            this.tBtn_save,
            this.tBtn_save_con,
            this.toolStripSeparator1,
            this.tBtn_cut,
            this.tBtn_copy,
            this.tBtn_paste,
            this.tBtn_clearConsole,
            this.toolStripSeparator7,
            this.tBtn_echo,
            this.toolStripSeparator3,
            this.tBtn_receiveAsAscii,
            this.tBtn_receiveAsHex,
            this.tBtn_sendAsAscii,
            this.tBtn_sendAsHex,
            this.toolStripSeparator4,
            this.tBtn_connect,
            this.tBtn_send,
            this.toolStripSeparator5,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 25);
            this.toolStrip1.TabIndex = 27;
            // 
            // tBtn_new
            // 
            this.tBtn_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_new.Image = global::SerialScripter.Properties.Resources.ScriptNew;
            this.tBtn_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_new.Name = "tBtn_new";
            this.tBtn_new.Size = new System.Drawing.Size(23, 22);
            this.tBtn_new.Text = "New Script";
            this.tBtn_new.Click += new System.EventHandler(this.TBtn_new_Click);
            // 
            // tBtn_open
            // 
            this.tBtn_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_open.Image = global::SerialScripter.Properties.Resources.ScriptOpen;
            this.tBtn_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_open.Name = "tBtn_open";
            this.tBtn_open.Size = new System.Drawing.Size(23, 22);
            this.tBtn_open.Text = "Open Script";
            this.tBtn_open.Click += new System.EventHandler(this.TBtn_open_Click);
            // 
            // tBtn_save
            // 
            this.tBtn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_save.Image = global::SerialScripter.Properties.Resources.ScriptSave;
            this.tBtn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_save.Name = "tBtn_save";
            this.tBtn_save.Size = new System.Drawing.Size(23, 22);
            this.tBtn_save.Text = "Save Script";
            this.tBtn_save.Click += new System.EventHandler(this.TBtn_save_Click);
            // 
            // tBtn_save_con
            // 
            this.tBtn_save_con.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_save_con.Image = global::SerialScripter.Properties.Resources.SaveCon;
            this.tBtn_save_con.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_save_con.Name = "tBtn_save_con";
            this.tBtn_save_con.Size = new System.Drawing.Size(23, 22);
            this.tBtn_save_con.Text = "Save Console";
            this.tBtn_save_con.Click += new System.EventHandler(this.TBtn_save_con_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tBtn_cut
            // 
            this.tBtn_cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_cut.Image = global::SerialScripter.Properties.Resources.Cut;
            this.tBtn_cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_cut.Name = "tBtn_cut";
            this.tBtn_cut.Size = new System.Drawing.Size(23, 22);
            this.tBtn_cut.Text = "Cut";
            this.tBtn_cut.Click += new System.EventHandler(this.TBtn_cut_Click);
            // 
            // tBtn_copy
            // 
            this.tBtn_copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_copy.Image = global::SerialScripter.Properties.Resources.Copy;
            this.tBtn_copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_copy.Name = "tBtn_copy";
            this.tBtn_copy.Size = new System.Drawing.Size(23, 22);
            this.tBtn_copy.Text = "Copy";
            this.tBtn_copy.Click += new System.EventHandler(this.TBtn_copy_Click);
            // 
            // tBtn_paste
            // 
            this.tBtn_paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_paste.Image = global::SerialScripter.Properties.Resources.Paste;
            this.tBtn_paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_paste.Name = "tBtn_paste";
            this.tBtn_paste.Size = new System.Drawing.Size(23, 22);
            this.tBtn_paste.Text = "Paste";
            this.tBtn_paste.Click += new System.EventHandler(this.TBtn_paste_Click);
            // 
            // tBtn_clearConsole
            // 
            this.tBtn_clearConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_clearConsole.Image = global::SerialScripter.Properties.Resources.ClearConsole;
            this.tBtn_clearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_clearConsole.Name = "tBtn_clearConsole";
            this.tBtn_clearConsole.Size = new System.Drawing.Size(23, 22);
            this.tBtn_clearConsole.Text = "Clear Console";
            this.tBtn_clearConsole.Click += new System.EventHandler(this.TBtn_clearConsole_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tBtn_echo
            // 
            this.tBtn_echo.CheckOnClick = true;
            this.tBtn_echo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_echo.Image = global::SerialScripter.Properties.Resources.Echo;
            this.tBtn_echo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_echo.Name = "tBtn_echo";
            this.tBtn_echo.Size = new System.Drawing.Size(23, 22);
            this.tBtn_echo.Text = "Echo Console";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tBtn_receiveAsAscii
            // 
            this.tBtn_receiveAsAscii.Checked = true;
            this.tBtn_receiveAsAscii.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tBtn_receiveAsAscii.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_receiveAsAscii.Image = global::SerialScripter.Properties.Resources.ReceiveAsAscii;
            this.tBtn_receiveAsAscii.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_receiveAsAscii.Name = "tBtn_receiveAsAscii";
            this.tBtn_receiveAsAscii.Size = new System.Drawing.Size(23, 22);
            this.tBtn_receiveAsAscii.Text = "Receive Ascii";
            this.tBtn_receiveAsAscii.Click += new System.EventHandler(this.TBtn_receiveAsAscii_Click);
            // 
            // tBtn_receiveAsHex
            // 
            this.tBtn_receiveAsHex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_receiveAsHex.Image = global::SerialScripter.Properties.Resources.ReceiveAsHex;
            this.tBtn_receiveAsHex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_receiveAsHex.Name = "tBtn_receiveAsHex";
            this.tBtn_receiveAsHex.Size = new System.Drawing.Size(23, 22);
            this.tBtn_receiveAsHex.Text = "Receive Hex";
            this.tBtn_receiveAsHex.Click += new System.EventHandler(this.TBtn_receiveAsHex_Click);
            // 
            // tBtn_sendAsAscii
            // 
            this.tBtn_sendAsAscii.Checked = true;
            this.tBtn_sendAsAscii.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tBtn_sendAsAscii.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_sendAsAscii.Image = global::SerialScripter.Properties.Resources.SendAsAscii;
            this.tBtn_sendAsAscii.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_sendAsAscii.Name = "tBtn_sendAsAscii";
            this.tBtn_sendAsAscii.Size = new System.Drawing.Size(23, 22);
            this.tBtn_sendAsAscii.Text = "Send Ascii";
            this.tBtn_sendAsAscii.Click += new System.EventHandler(this.TBtn_sendAsAscii_Click);
            // 
            // tBtn_sendAsHex
            // 
            this.tBtn_sendAsHex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_sendAsHex.Image = global::SerialScripter.Properties.Resources.SendAsHex;
            this.tBtn_sendAsHex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_sendAsHex.Name = "tBtn_sendAsHex";
            this.tBtn_sendAsHex.Size = new System.Drawing.Size(23, 22);
            this.tBtn_sendAsHex.Text = "Send Hex";
            this.tBtn_sendAsHex.Click += new System.EventHandler(this.TBtn_sendAsHex_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tBtn_connect
            // 
            this.tBtn_connect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_connect.Image = global::SerialScripter.Properties.Resources.Connect;
            this.tBtn_connect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_connect.Name = "tBtn_connect";
            this.tBtn_connect.Size = new System.Drawing.Size(23, 22);
            this.tBtn_connect.Text = "Connect";
            this.tBtn_connect.Click += new System.EventHandler(this.TBtn_connect_Click);
            // 
            // tBtn_send
            // 
            this.tBtn_send.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBtn_send.Image = global::SerialScripter.Properties.Resources.Send;
            this.tBtn_send.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBtn_send.Name = "tBtn_send";
            this.tBtn_send.Size = new System.Drawing.Size(23, 22);
            this.tBtn_send.Text = "Transmit Script";
            this.tBtn_send.Click += new System.EventHandler(this.TBtn_send_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.speedbaudToolStripMenuItem,
            this.dataBitsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.parityToolStripMenuItem,
            this.flowControlToolStripMenuItem,
            this.readTimeoutToolStripMenuItem,
            this.writeTimeoutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::SerialScripter.Properties.Resources.Settings;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_portName});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem1.Text = "Port Name";
            // 
            // cBox_portName
            // 
            this.cBox_portName.Name = "cBox_portName";
            this.cBox_portName.Size = new System.Drawing.Size(121, 23);
            // 
            // speedbaudToolStripMenuItem
            // 
            this.speedbaudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_speedBaud});
            this.speedbaudToolStripMenuItem.Name = "speedbaudToolStripMenuItem";
            this.speedbaudToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.speedbaudToolStripMenuItem.Text = "Speed (baud)";
            // 
            // cBox_speedBaud
            // 
            this.cBox_speedBaud.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cBox_speedBaud.Name = "cBox_speedBaud";
            this.cBox_speedBaud.Size = new System.Drawing.Size(121, 23);
            this.cBox_speedBaud.Text = "9600";
            // 
            // dataBitsToolStripMenuItem
            // 
            this.dataBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_dataBits});
            this.dataBitsToolStripMenuItem.Name = "dataBitsToolStripMenuItem";
            this.dataBitsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dataBitsToolStripMenuItem.Text = "Data Bits";
            // 
            // cBox_dataBits
            // 
            this.cBox_dataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cBox_dataBits.Name = "cBox_dataBits";
            this.cBox_dataBits.Size = new System.Drawing.Size(121, 23);
            this.cBox_dataBits.Text = "8";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_stopBits});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Stop Bits";
            // 
            // cBox_stopBits
            // 
            this.cBox_stopBits.Items.AddRange(new object[] {
            "One",
            "Two",
            "1 1/2",
            "None"});
            this.cBox_stopBits.Name = "cBox_stopBits";
            this.cBox_stopBits.Size = new System.Drawing.Size(121, 23);
            this.cBox_stopBits.Text = "One";
            // 
            // parityToolStripMenuItem
            // 
            this.parityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_parity});
            this.parityToolStripMenuItem.Name = "parityToolStripMenuItem";
            this.parityToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.parityToolStripMenuItem.Text = "Parity";
            // 
            // cBox_parity
            // 
            this.cBox_parity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd",
            "Space"});
            this.cBox_parity.Name = "cBox_parity";
            this.cBox_parity.Size = new System.Drawing.Size(121, 23);
            this.cBox_parity.Text = "None";
            // 
            // flowControlToolStripMenuItem
            // 
            this.flowControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cBox_flowControl});
            this.flowControlToolStripMenuItem.Name = "flowControlToolStripMenuItem";
            this.flowControlToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.flowControlToolStripMenuItem.Text = "Flow Control";
            // 
            // cBox_flowControl
            // 
            this.cBox_flowControl.DropDownWidth = 161;
            this.cBox_flowControl.Items.AddRange(new object[] {
            "None",
            "Request To Send",
            "Request To Send XOn/XOff",
            "XOn/XOff"});
            this.cBox_flowControl.Name = "cBox_flowControl";
            this.cBox_flowControl.Size = new System.Drawing.Size(166, 23);
            this.cBox_flowControl.Text = "None";
            // 
            // readTimeoutToolStripMenuItem
            // 
            this.readTimeoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBox_readTimeout});
            this.readTimeoutToolStripMenuItem.Name = "readTimeoutToolStripMenuItem";
            this.readTimeoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.readTimeoutToolStripMenuItem.Text = "Read Timeout";
            // 
            // tBox_readTimeout
            // 
            this.tBox_readTimeout.Name = "tBox_readTimeout";
            this.tBox_readTimeout.Size = new System.Drawing.Size(100, 23);
            this.tBox_readTimeout.Text = "2000";
            // 
            // writeTimeoutToolStripMenuItem
            // 
            this.writeTimeoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBox_writeTimeout});
            this.writeTimeoutToolStripMenuItem.Name = "writeTimeoutToolStripMenuItem";
            this.writeTimeoutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.writeTimeoutToolStripMenuItem.Text = "Write Timeout";
            // 
            // tBox_writeTimeout
            // 
            this.tBox_writeTimeout.Name = "tBox_writeTimeout";
            this.tBox_writeTimeout.Size = new System.Drawing.Size(100, 23);
            this.tBox_writeTimeout.Text = "500";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ss_status,
            this.ss_TD,
            this.ss_RD,
            this.ss_RTS,
            this.ss_CTS,
            this.ss_DSR,
            this.ss_DTR,
            this.ss_CD});
            this.statusStrip2.Location = new System.Drawing.Point(0, 652);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(783, 25);
            this.statusStrip2.TabIndex = 32;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // ss_status
            // 
            this.ss_status.Name = "ss_status";
            this.ss_status.Size = new System.Drawing.Size(449, 20);
            this.ss_status.Spring = true;
            this.ss_status.Text = "Form Status";
            this.ss_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ss_TD
            // 
            this.ss_TD.AutoSize = false;
            this.ss_TD.BackColor = System.Drawing.SystemColors.Control;
            this.ss_TD.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_TD.Name = "ss_TD";
            this.ss_TD.Size = new System.Drawing.Size(42, 20);
            this.ss_TD.Text = "TD";
            this.ss_TD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_TD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_RD
            // 
            this.ss_RD.AutoSize = false;
            this.ss_RD.BackColor = System.Drawing.SystemColors.Control;
            this.ss_RD.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_RD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ss_RD.Name = "ss_RD";
            this.ss_RD.Size = new System.Drawing.Size(42, 20);
            this.ss_RD.Text = "RD";
            this.ss_RD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_RD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_RTS
            // 
            this.ss_RTS.AutoSize = false;
            this.ss_RTS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_RTS.Name = "ss_RTS";
            this.ss_RTS.Size = new System.Drawing.Size(47, 20);
            this.ss_RTS.Text = "RTS";
            this.ss_RTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_RTS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_CTS
            // 
            this.ss_CTS.AutoSize = false;
            this.ss_CTS.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_CTS.Name = "ss_CTS";
            this.ss_CTS.Size = new System.Drawing.Size(48, 20);
            this.ss_CTS.Text = "CTS";
            this.ss_CTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_CTS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_DSR
            // 
            this.ss_DSR.AutoSize = false;
            this.ss_DSR.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_DSR.Name = "ss_DSR";
            this.ss_DSR.Size = new System.Drawing.Size(48, 20);
            this.ss_DSR.Text = "DSR";
            this.ss_DSR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_DSR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_DTR
            // 
            this.ss_DTR.AutoSize = false;
            this.ss_DTR.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_DTR.Name = "ss_DTR";
            this.ss_DTR.Size = new System.Drawing.Size(49, 20);
            this.ss_DTR.Text = "DTR";
            this.ss_DTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_DTR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ss_CD
            // 
            this.ss_CD.AutoSize = false;
            this.ss_CD.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ss_CD.Name = "ss_CD";
            this.ss_CD.Size = new System.Drawing.Size(43, 20);
            this.ss_CD.Text = "CD";
            this.ss_CD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ss_CD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tabControl_scripts
            // 
            this.tabControl_scripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_scripts.Controls.Add(this.tabPage1);
            this.tabControl_scripts.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl_scripts.ItemSize = new System.Drawing.Size(80, 20);
            this.tabControl_scripts.Location = new System.Drawing.Point(12, 28);
            this.tabControl_scripts.Name = "tabControl_scripts";
            this.tabControl_scripts.SelectedIndex = 0;
            this.tabControl_scripts.Size = new System.Drawing.Size(756, 352);
            this.tabControl_scripts.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_scripts.TabIndex = 3;
            this.tabControl_scripts.Tag = "";
            this.tabControl_scripts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TabControl_scripts_drawItem);
            this.tabControl_scripts.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_scripts_selected);
            this.tabControl_scripts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabControl_scripts_mouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tabPage1_rTxtBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Script 1";
            // 
            // tabPage1_rTxtBox
            // 
            this.tabPage1_rTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabPage1_rTxtBox.ContextMenuStrip = this.cMenu_script;
            this.tabPage1_rTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1_rTxtBox.Location = new System.Drawing.Point(3, 3);
            this.tabPage1_rTxtBox.Name = "tabPage1_rTxtBox";
            this.tabPage1_rTxtBox.Size = new System.Drawing.Size(742, 318);
            this.tabPage1_rTxtBox.TabIndex = 0;
            this.tabPage1_rTxtBox.Text = "";
            // 
            // cMenu_script
            // 
            this.cMenu_script.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_scriptCut,
            this.cMenu_scriptCopy,
            this.cMenu_scriptPaste,
            this.cMenu_scriptDelete,
            this.toolStripSeparator2,
            this.cMenu_scriptSelectAll});
            this.cMenu_script.Name = "cMenu_script";
            this.cMenu_script.Size = new System.Drawing.Size(123, 120);
            // 
            // cMenu_scriptCut
            // 
            this.cMenu_scriptCut.Name = "cMenu_scriptCut";
            this.cMenu_scriptCut.Size = new System.Drawing.Size(122, 22);
            this.cMenu_scriptCut.Text = "Cut";
            this.cMenu_scriptCut.Click += new System.EventHandler(this.CMenu_scriptCut_Click);
            // 
            // cMenu_scriptCopy
            // 
            this.cMenu_scriptCopy.Name = "cMenu_scriptCopy";
            this.cMenu_scriptCopy.Size = new System.Drawing.Size(122, 22);
            this.cMenu_scriptCopy.Text = "Copy";
            this.cMenu_scriptCopy.Click += new System.EventHandler(this.CMenu_scriptCopy_Click);
            // 
            // cMenu_scriptPaste
            // 
            this.cMenu_scriptPaste.Name = "cMenu_scriptPaste";
            this.cMenu_scriptPaste.Size = new System.Drawing.Size(122, 22);
            this.cMenu_scriptPaste.Text = "Paste";
            this.cMenu_scriptPaste.Click += new System.EventHandler(this.CMenu_scriptPaste_Click);
            // 
            // cMenu_scriptDelete
            // 
            this.cMenu_scriptDelete.Name = "cMenu_scriptDelete";
            this.cMenu_scriptDelete.Size = new System.Drawing.Size(122, 22);
            this.cMenu_scriptDelete.Text = "Delete";
            this.cMenu_scriptDelete.Click += new System.EventHandler(this.CMenu_scriptDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // cMenu_scriptSelectAll
            // 
            this.cMenu_scriptSelectAll.Name = "cMenu_scriptSelectAll";
            this.cMenu_scriptSelectAll.Size = new System.Drawing.Size(122, 22);
            this.cMenu_scriptSelectAll.Text = "Select All";
            this.cMenu_scriptSelectAll.Click += new System.EventHandler(this.CMenu_scriptSelectAll_Click);
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.Controls.Add(this.rTxt_console);
            this.Console.Location = new System.Drawing.Point(12, 386);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(759, 263);
            this.Console.TabIndex = 5;
            this.Console.TabStop = false;
            this.Console.Text = "Console";
            // 
            // rTxt_console
            // 
            this.rTxt_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxt_console.ContextMenuStrip = this.cMenu_console;
            this.rTxt_console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxt_console.Location = new System.Drawing.Point(3, 16);
            this.rTxt_console.Name = "rTxt_console";
            this.rTxt_console.Size = new System.Drawing.Size(753, 244);
            this.rTxt_console.TabIndex = 2;
            this.rTxt_console.Text = "";
            this.rTxt_console.TextChanged += new System.EventHandler(this.RTxt_console_TextChanged);
            this.rTxt_console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RTxt_console_keyDown);
            this.rTxt_console.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RTxt_console_keyClick);
            // 
            // cMenu_console
            // 
            this.cMenu_console.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMenu_consoleCut,
            this.cMenu_consoleCopy,
            this.cMenu_consolePaste,
            this.cMenu_consoleDelete,
            this.toolStripSeparator6,
            this.cMenu_consoleSelectAll,
            this.toolStripSeperator7,
            this.cMenu_consoleClear});
            this.cMenu_console.Name = "cMenu_console";
            this.cMenu_console.Size = new System.Drawing.Size(148, 148);
            // 
            // cMenu_consoleCut
            // 
            this.cMenu_consoleCut.Name = "cMenu_consoleCut";
            this.cMenu_consoleCut.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consoleCut.Text = "Cut";
            this.cMenu_consoleCut.Click += new System.EventHandler(this.CMenu_consoleCut_Click);
            // 
            // cMenu_consoleCopy
            // 
            this.cMenu_consoleCopy.Name = "cMenu_consoleCopy";
            this.cMenu_consoleCopy.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consoleCopy.Text = "Copy";
            this.cMenu_consoleCopy.Click += new System.EventHandler(this.CMenu_consoleCopy_Click);
            // 
            // cMenu_consolePaste
            // 
            this.cMenu_consolePaste.Name = "cMenu_consolePaste";
            this.cMenu_consolePaste.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consolePaste.Text = "Paste";
            this.cMenu_consolePaste.Click += new System.EventHandler(this.CMenu_consolePaste_Click);
            // 
            // cMenu_consoleDelete
            // 
            this.cMenu_consoleDelete.Name = "cMenu_consoleDelete";
            this.cMenu_consoleDelete.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consoleDelete.Text = "Delete";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(144, 6);
            // 
            // cMenu_consoleSelectAll
            // 
            this.cMenu_consoleSelectAll.Name = "cMenu_consoleSelectAll";
            this.cMenu_consoleSelectAll.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consoleSelectAll.Text = "Select All";
            this.cMenu_consoleSelectAll.Click += new System.EventHandler(this.CMenu_consoleSelectAll_Click);
            // 
            // toolStripSeperator7
            // 
            this.toolStripSeperator7.Name = "toolStripSeperator7";
            this.toolStripSeperator7.Size = new System.Drawing.Size(144, 6);
            // 
            // cMenu_consoleClear
            // 
            this.cMenu_consoleClear.Name = "cMenu_consoleClear";
            this.cMenu_consoleClear.Size = new System.Drawing.Size(147, 22);
            this.cMenu_consoleClear.Text = "Clear Console";
            this.cMenu_consoleClear.Click += new System.EventHandler(this.CMenu_consoleClear_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 677);
            this.Controls.Add(this.tabControl_scripts);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_main";
            this.Text = "Serial Scripter";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.tabControl_scripts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.cMenu_script.ResumeLayout(false);
            this.Console.ResumeLayout(false);
            this.cMenu_console.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tBtn_new;
        private System.Windows.Forms.ToolStripButton tBtn_open;
        private System.Windows.Forms.ToolStripButton tBtn_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tBtn_echo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tBtn_receiveAsAscii;
        private System.Windows.Forms.ToolStripButton tBtn_receiveAsHex;
        private System.Windows.Forms.ToolStripButton tBtn_sendAsAscii;
        private System.Windows.Forms.ToolStripButton tBtn_sendAsHex;
        private System.Windows.Forms.ToolStripButton tBtn_connect;
        private System.Windows.Forms.ToolStripButton tBtn_send;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox cBox_portName;
        private System.Windows.Forms.ToolStripMenuItem speedbaudToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBox_speedBaud;
        private System.Windows.Forms.ToolStripMenuItem dataBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBox_dataBits;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox cBox_stopBits;
        private System.Windows.Forms.ToolStripMenuItem parityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBox_parity;
        private System.Windows.Forms.ToolStripMenuItem flowControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cBox_flowControl;
        private System.Windows.Forms.ToolStripMenuItem readTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tBox_readTimeout;
        private System.Windows.Forms.ToolStripMenuItem writeTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tBox_writeTimeout;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel ss_status;
        private System.Windows.Forms.ToolStripStatusLabel ss_TD;
        private System.Windows.Forms.ToolStripStatusLabel ss_RD;
        private System.Windows.Forms.ToolStripStatusLabel ss_RTS;
        private System.Windows.Forms.ToolStripStatusLabel ss_CTS;
        private System.Windows.Forms.ToolStripStatusLabel ss_DSR;
        private System.Windows.Forms.ToolStripStatusLabel ss_DTR;
        private System.Windows.Forms.ToolStripStatusLabel ss_CD;
        private System.Windows.Forms.ToolStripButton tBtn_save_con;
        private System.Windows.Forms.TabControl tabControl_scripts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox tabPage1_rTxtBox;
        private System.Windows.Forms.GroupBox Console;
        private System.Windows.Forms.RichTextBox rTxt_console;
        private System.Windows.Forms.ToolStripButton tBtn_clearConsole;
        private System.Windows.Forms.ContextMenuStrip cMenu_console;
        private System.Windows.Forms.ContextMenuStrip cMenu_script;
        private System.Windows.Forms.ToolStripMenuItem cMenu_scriptCut;
        private System.Windows.Forms.ToolStripMenuItem cMenu_scriptCopy;
        private System.Windows.Forms.ToolStripMenuItem cMenu_scriptPaste;
        private System.Windows.Forms.ToolStripMenuItem cMenu_scriptDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cMenu_scriptSelectAll;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consoleCut;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consoleCopy;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consolePaste;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consoleDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consoleSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeperator7;
        private System.Windows.Forms.ToolStripMenuItem cMenu_consoleClear;
        private System.Windows.Forms.ToolStripButton tBtn_cut;
        private System.Windows.Forms.ToolStripButton tBtn_copy;
        private System.Windows.Forms.ToolStripButton tBtn_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    }
}

