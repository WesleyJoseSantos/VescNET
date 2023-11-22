namespace Sample
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGridMcconf = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConnection = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirmware = new System.Windows.Forms.TextBox();
            this.tbHardware = new System.Windows.Forms.TextBox();
            this.tbUUID = new System.Windows.Forms.TextBox();
            this.tabPageMcconf = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendMcconf = new System.Windows.Forms.Button();
            this.buttonReadMcconf = new System.Windows.Forms.Button();
            this.tabPageAppconf = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.propertyGridAppconf = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendAppconf = new System.Windows.Forms.Button();
            this.buttonReadAppconf = new System.Windows.Forms.Button();
            this.tabPageCommands = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btGetFwInfo = new System.Windows.Forms.Button();
            this.btDetectEncoder = new System.Windows.Forms.Button();
            this.btGetValues = new System.Windows.Forms.Button();
            this.btSetDutyCycle = new System.Windows.Forms.Button();
            this.btSetCurrent = new System.Windows.Forms.Button();
            this.btSetCurrentBrake = new System.Windows.Forms.Button();
            this.btSetRPM = new System.Windows.Forms.Button();
            this.btSetPos = new System.Windows.Forms.Button();
            this.btSetHandbrake = new System.Windows.Forms.Button();
            this.btSetServoPos = new System.Windows.Forms.Button();
            this.tbDutyCycle = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.tbCurrentBrake = new System.Windows.Forms.TextBox();
            this.tbRpm = new System.Windows.Forms.TextBox();
            this.tbPos = new System.Windows.Forms.TextBox();
            this.tbHandbrake = new System.Windows.Forms.TextBox();
            this.tbServoPos = new System.Windows.Forms.TextBox();
            this.tbDetectEncoder = new System.Windows.Forms.TextBox();
            this.btReboot = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageMcconf.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageAppconf.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPageCommands.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGridMcconf
            // 
            this.propertyGridMcconf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMcconf.Location = new System.Drawing.Point(4, 4);
            this.propertyGridMcconf.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGridMcconf.Name = "propertyGridMcconf";
            this.propertyGridMcconf.Size = new System.Drawing.Size(636, 381);
            this.propertyGridMcconf.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConnection);
            this.tabControl1.Controls.Add(this.tabPageMcconf);
            this.tabControl1.Controls.Add(this.tabPageAppconf);
            this.tabControl1.Controls.Add(this.tabPageCommands);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 491);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.tableLayoutPanel1);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 25);
            this.tabPageConnection.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageConnection.Size = new System.Drawing.Size(652, 462);
            this.tabPageConnection.TabIndex = 2;
            this.tabPageConnection.Text = "Connection";
            this.tabPageConnection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.07407F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.92593F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btConnect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFirmware, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbHardware, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbUUID, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmware Version:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hardware Version:";
            // 
            // btConnect
            // 
            this.btConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnect.Location = new System.Drawing.Point(238, 382);
            this.btConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(323, 28);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "UUID:";
            // 
            // tbFirmware
            // 
            this.tbFirmware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFirmware.Location = new System.Drawing.Point(209, 45);
            this.tbFirmware.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirmware.Name = "tbFirmware";
            this.tbFirmware.ReadOnly = true;
            this.tbFirmware.Size = new System.Drawing.Size(380, 22);
            this.tbFirmware.TabIndex = 3;
            // 
            // tbHardware
            // 
            this.tbHardware.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHardware.Location = new System.Drawing.Point(209, 158);
            this.tbHardware.Margin = new System.Windows.Forms.Padding(4);
            this.tbHardware.Name = "tbHardware";
            this.tbHardware.ReadOnly = true;
            this.tbHardware.Size = new System.Drawing.Size(380, 22);
            this.tbHardware.TabIndex = 3;
            // 
            // tbUUID
            // 
            this.tbUUID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUUID.Location = new System.Drawing.Point(209, 271);
            this.tbUUID.Margin = new System.Windows.Forms.Padding(4);
            this.tbUUID.Name = "tbUUID";
            this.tbUUID.ReadOnly = true;
            this.tbUUID.Size = new System.Drawing.Size(380, 22);
            this.tbUUID.TabIndex = 3;
            // 
            // tabPageMcconf
            // 
            this.tabPageMcconf.Controls.Add(this.tableLayoutPanel4);
            this.tabPageMcconf.Location = new System.Drawing.Point(4, 25);
            this.tabPageMcconf.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMcconf.Name = "tabPageMcconf";
            this.tabPageMcconf.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageMcconf.Size = new System.Drawing.Size(652, 462);
            this.tabPageMcconf.TabIndex = 0;
            this.tabPageMcconf.Text = "Motor";
            this.tabPageMcconf.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.propertyGridMcconf, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.81081F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18919F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(644, 454);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonSendMcconf, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonReadMcconf, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 393);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(636, 57);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // buttonSendMcconf
            // 
            this.buttonSendMcconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendMcconf.Location = new System.Drawing.Point(15, 14);
            this.buttonSendMcconf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendMcconf.Name = "buttonSendMcconf";
            this.buttonSendMcconf.Size = new System.Drawing.Size(288, 28);
            this.buttonSendMcconf.TabIndex = 0;
            this.buttonSendMcconf.Text = "Send";
            this.buttonSendMcconf.UseVisualStyleBackColor = true;
            this.buttonSendMcconf.Click += new System.EventHandler(this.BtSendMcconf_Click);
            // 
            // buttonReadMcconf
            // 
            this.buttonReadMcconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReadMcconf.Location = new System.Drawing.Point(333, 14);
            this.buttonReadMcconf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadMcconf.Name = "buttonReadMcconf";
            this.buttonReadMcconf.Size = new System.Drawing.Size(288, 28);
            this.buttonReadMcconf.TabIndex = 0;
            this.buttonReadMcconf.Text = "Read";
            this.buttonReadMcconf.UseVisualStyleBackColor = true;
            this.buttonReadMcconf.Click += new System.EventHandler(this.BtReadMcconf_Click);
            // 
            // tabPageAppconf
            // 
            this.tabPageAppconf.Controls.Add(this.tableLayoutPanel6);
            this.tabPageAppconf.Location = new System.Drawing.Point(4, 25);
            this.tabPageAppconf.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAppconf.Name = "tabPageAppconf";
            this.tabPageAppconf.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAppconf.Size = new System.Drawing.Size(652, 462);
            this.tabPageAppconf.TabIndex = 1;
            this.tabPageAppconf.Text = "App";
            this.tabPageAppconf.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.propertyGridAppconf, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.81081F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18919F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(644, 454);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // propertyGridAppconf
            // 
            this.propertyGridAppconf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridAppconf.Location = new System.Drawing.Point(4, 4);
            this.propertyGridAppconf.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGridAppconf.Name = "propertyGridAppconf";
            this.propertyGridAppconf.Size = new System.Drawing.Size(636, 381);
            this.propertyGridAppconf.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.buttonSendAppconf, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonReadAppconf, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 393);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(636, 57);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // buttonSendAppconf
            // 
            this.buttonSendAppconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendAppconf.Location = new System.Drawing.Point(15, 14);
            this.buttonSendAppconf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendAppconf.Name = "buttonSendAppconf";
            this.buttonSendAppconf.Size = new System.Drawing.Size(288, 28);
            this.buttonSendAppconf.TabIndex = 0;
            this.buttonSendAppconf.Text = "Send";
            this.buttonSendAppconf.UseVisualStyleBackColor = true;
            this.buttonSendAppconf.Click += new System.EventHandler(this.BtSendAppconf_Click);
            // 
            // buttonReadAppconf
            // 
            this.buttonReadAppconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReadAppconf.Location = new System.Drawing.Point(333, 14);
            this.buttonReadAppconf.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadAppconf.Name = "buttonReadAppconf";
            this.buttonReadAppconf.Size = new System.Drawing.Size(288, 28);
            this.buttonReadAppconf.TabIndex = 0;
            this.buttonReadAppconf.Text = "Read";
            this.buttonReadAppconf.UseVisualStyleBackColor = true;
            this.buttonReadAppconf.Click += new System.EventHandler(this.BtReadAppconf_Click);
            // 
            // tabPageCommands
            // 
            this.tabPageCommands.Controls.Add(this.tableLayoutPanel3);
            this.tabPageCommands.Location = new System.Drawing.Point(4, 25);
            this.tabPageCommands.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCommands.Name = "tabPageCommands";
            this.tabPageCommands.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCommands.Size = new System.Drawing.Size(652, 462);
            this.tabPageCommands.TabIndex = 3;
            this.tabPageCommands.Text = "Commands";
            this.tabPageCommands.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btGetFwInfo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btDetectEncoder, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.btGetValues, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btSetDutyCycle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btSetCurrent, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btSetCurrentBrake, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btSetRPM, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btSetPos, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.btSetHandbrake, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.btSetServoPos, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.tbDutyCycle, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbCurrent, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbCurrentBrake, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.tbRpm, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tbPos, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tbHandbrake, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.tbServoPos, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.tbDetectEncoder, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.btReboot, 0, 10);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(644, 454);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btGetFwInfo
            // 
            this.btGetFwInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGetFwInfo.Location = new System.Drawing.Point(66, 7);
            this.btGetFwInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btGetFwInfo.Name = "btGetFwInfo";
            this.btGetFwInfo.Size = new System.Drawing.Size(189, 26);
            this.btGetFwInfo.TabIndex = 0;
            this.btGetFwInfo.Text = "Get Firmware Info";
            this.btGetFwInfo.UseVisualStyleBackColor = true;
            // 
            // btDetectEncoder
            // 
            this.btDetectEncoder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDetectEncoder.Location = new System.Drawing.Point(66, 376);
            this.btDetectEncoder.Margin = new System.Windows.Forms.Padding(4);
            this.btDetectEncoder.Name = "btDetectEncoder";
            this.btDetectEncoder.Size = new System.Drawing.Size(189, 26);
            this.btDetectEncoder.TabIndex = 0;
            this.btDetectEncoder.Text = "Detect Encoder";
            this.btDetectEncoder.UseVisualStyleBackColor = true;
            this.btDetectEncoder.Click += new System.EventHandler(this.BtDetectEncoder_Click);
            // 
            // btGetValues
            // 
            this.btGetValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGetValues.Location = new System.Drawing.Point(66, 48);
            this.btGetValues.Margin = new System.Windows.Forms.Padding(4);
            this.btGetValues.Name = "btGetValues";
            this.btGetValues.Size = new System.Drawing.Size(189, 26);
            this.btGetValues.TabIndex = 0;
            this.btGetValues.Text = "Get Values";
            this.btGetValues.UseVisualStyleBackColor = true;
            // 
            // btSetDutyCycle
            // 
            this.btSetDutyCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetDutyCycle.Location = new System.Drawing.Point(66, 89);
            this.btSetDutyCycle.Margin = new System.Windows.Forms.Padding(4);
            this.btSetDutyCycle.Name = "btSetDutyCycle";
            this.btSetDutyCycle.Size = new System.Drawing.Size(189, 26);
            this.btSetDutyCycle.TabIndex = 0;
            this.btSetDutyCycle.Text = "Set Duty Cycle";
            this.btSetDutyCycle.UseVisualStyleBackColor = true;
            this.btSetDutyCycle.Click += new System.EventHandler(this.BtSetDutyCycle_Click);
            // 
            // btSetCurrent
            // 
            this.btSetCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetCurrent.Location = new System.Drawing.Point(66, 130);
            this.btSetCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.btSetCurrent.Name = "btSetCurrent";
            this.btSetCurrent.Size = new System.Drawing.Size(189, 26);
            this.btSetCurrent.TabIndex = 0;
            this.btSetCurrent.Text = "Set Current";
            this.btSetCurrent.UseVisualStyleBackColor = true;
            this.btSetCurrent.Click += new System.EventHandler(this.BtSetCurrent_Click);
            // 
            // btSetCurrentBrake
            // 
            this.btSetCurrentBrake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetCurrentBrake.Location = new System.Drawing.Point(66, 171);
            this.btSetCurrentBrake.Margin = new System.Windows.Forms.Padding(4);
            this.btSetCurrentBrake.Name = "btSetCurrentBrake";
            this.btSetCurrentBrake.Size = new System.Drawing.Size(189, 26);
            this.btSetCurrentBrake.TabIndex = 0;
            this.btSetCurrentBrake.Text = "Set Current Brake";
            this.btSetCurrentBrake.UseVisualStyleBackColor = true;
            this.btSetCurrentBrake.Click += new System.EventHandler(this.BtSetCurrentBrake_Click);
            // 
            // btSetRPM
            // 
            this.btSetRPM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetRPM.Location = new System.Drawing.Point(66, 212);
            this.btSetRPM.Margin = new System.Windows.Forms.Padding(4);
            this.btSetRPM.Name = "btSetRPM";
            this.btSetRPM.Size = new System.Drawing.Size(189, 26);
            this.btSetRPM.TabIndex = 0;
            this.btSetRPM.Text = "Set RPM";
            this.btSetRPM.UseVisualStyleBackColor = true;
            this.btSetRPM.Click += new System.EventHandler(this.BtSetRPM_Click);
            // 
            // btSetPos
            // 
            this.btSetPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetPos.Location = new System.Drawing.Point(66, 253);
            this.btSetPos.Margin = new System.Windows.Forms.Padding(4);
            this.btSetPos.Name = "btSetPos";
            this.btSetPos.Size = new System.Drawing.Size(189, 26);
            this.btSetPos.TabIndex = 0;
            this.btSetPos.Text = "Set Position";
            this.btSetPos.UseVisualStyleBackColor = true;
            this.btSetPos.Click += new System.EventHandler(this.BtSetPos_Click);
            // 
            // btSetHandbrake
            // 
            this.btSetHandbrake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetHandbrake.Location = new System.Drawing.Point(66, 294);
            this.btSetHandbrake.Margin = new System.Windows.Forms.Padding(4);
            this.btSetHandbrake.Name = "btSetHandbrake";
            this.btSetHandbrake.Size = new System.Drawing.Size(189, 26);
            this.btSetHandbrake.TabIndex = 0;
            this.btSetHandbrake.Text = "Set Handbrake";
            this.btSetHandbrake.UseVisualStyleBackColor = true;
            this.btSetHandbrake.Click += new System.EventHandler(this.BtSetHandbrake_Click);
            // 
            // btSetServoPos
            // 
            this.btSetServoPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSetServoPos.Location = new System.Drawing.Point(66, 335);
            this.btSetServoPos.Margin = new System.Windows.Forms.Padding(4);
            this.btSetServoPos.Name = "btSetServoPos";
            this.btSetServoPos.Size = new System.Drawing.Size(189, 26);
            this.btSetServoPos.TabIndex = 0;
            this.btSetServoPos.Text = "Set Servo Pos";
            this.btSetServoPos.UseVisualStyleBackColor = true;
            this.btSetServoPos.Click += new System.EventHandler(this.BtSetServoPos_Click);
            // 
            // tbDutyCycle
            // 
            this.tbDutyCycle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDutyCycle.Location = new System.Drawing.Point(335, 91);
            this.tbDutyCycle.Margin = new System.Windows.Forms.Padding(4);
            this.tbDutyCycle.Name = "tbDutyCycle";
            this.tbDutyCycle.Size = new System.Drawing.Size(296, 22);
            this.tbDutyCycle.TabIndex = 1;
            this.tbDutyCycle.Text = "0,2";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCurrent.Location = new System.Drawing.Point(335, 132);
            this.tbCurrent.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(296, 22);
            this.tbCurrent.TabIndex = 1;
            this.tbCurrent.Text = "1,0";
            // 
            // tbCurrentBrake
            // 
            this.tbCurrentBrake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCurrentBrake.Location = new System.Drawing.Point(335, 173);
            this.tbCurrentBrake.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurrentBrake.Name = "tbCurrentBrake";
            this.tbCurrentBrake.Size = new System.Drawing.Size(296, 22);
            this.tbCurrentBrake.TabIndex = 1;
            this.tbCurrentBrake.Text = "3,0";
            // 
            // tbRpm
            // 
            this.tbRpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRpm.Location = new System.Drawing.Point(335, 214);
            this.tbRpm.Margin = new System.Windows.Forms.Padding(4);
            this.tbRpm.Name = "tbRpm";
            this.tbRpm.Size = new System.Drawing.Size(296, 22);
            this.tbRpm.TabIndex = 1;
            this.tbRpm.Text = "15";
            // 
            // tbPos
            // 
            this.tbPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPos.Location = new System.Drawing.Point(335, 255);
            this.tbPos.Margin = new System.Windows.Forms.Padding(4);
            this.tbPos.Name = "tbPos";
            this.tbPos.Size = new System.Drawing.Size(296, 22);
            this.tbPos.TabIndex = 1;
            this.tbPos.Text = "0";
            // 
            // tbHandbrake
            // 
            this.tbHandbrake.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHandbrake.Location = new System.Drawing.Point(335, 296);
            this.tbHandbrake.Margin = new System.Windows.Forms.Padding(4);
            this.tbHandbrake.Name = "tbHandbrake";
            this.tbHandbrake.Size = new System.Drawing.Size(296, 22);
            this.tbHandbrake.TabIndex = 1;
            this.tbHandbrake.Text = "3,0";
            // 
            // tbServoPos
            // 
            this.tbServoPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbServoPos.Location = new System.Drawing.Point(335, 337);
            this.tbServoPos.Margin = new System.Windows.Forms.Padding(4);
            this.tbServoPos.Name = "tbServoPos";
            this.tbServoPos.Size = new System.Drawing.Size(296, 22);
            this.tbServoPos.TabIndex = 1;
            this.tbServoPos.Text = "0";
            // 
            // tbDetectEncoder
            // 
            this.tbDetectEncoder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDetectEncoder.Location = new System.Drawing.Point(335, 378);
            this.tbDetectEncoder.Margin = new System.Windows.Forms.Padding(4);
            this.tbDetectEncoder.Name = "tbDetectEncoder";
            this.tbDetectEncoder.Size = new System.Drawing.Size(296, 22);
            this.tbDetectEncoder.TabIndex = 1;
            this.tbDetectEncoder.Text = "10,0";
            // 
            // btReboot
            // 
            this.btReboot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReboot.Location = new System.Drawing.Point(66, 419);
            this.btReboot.Margin = new System.Windows.Forms.Padding(4);
            this.btReboot.Name = "btReboot";
            this.btReboot.Size = new System.Drawing.Size(189, 26);
            this.btReboot.TabIndex = 0;
            this.btReboot.Text = "Reboot";
            this.btReboot.UseVisualStyleBackColor = true;
            this.btReboot.Click += new System.EventHandler(this.btReboot_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLog, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 491);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.86364F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.13636F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(660, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log:";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(4, 29);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(652, 75);
            this.textBoxLog.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 599);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VESC Sample";
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageMcconf.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tabPageAppconf.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tabPageCommands.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGridMcconf;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMcconf;
        private System.Windows.Forms.TabPage tabPageAppconf;
        private System.Windows.Forms.TabPage tabPageConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageCommands;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonSendMcconf;
        private System.Windows.Forms.Button buttonReadMcconf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PropertyGrid propertyGridAppconf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button buttonSendAppconf;
        private System.Windows.Forms.Button buttonReadAppconf;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btGetFwInfo;
        private System.Windows.Forms.Button btDetectEncoder;
        private System.Windows.Forms.Button btGetValues;
        private System.Windows.Forms.Button btSetDutyCycle;
        private System.Windows.Forms.Button btSetCurrent;
        private System.Windows.Forms.Button btSetCurrentBrake;
        private System.Windows.Forms.Button btSetRPM;
        private System.Windows.Forms.Button btSetPos;
        private System.Windows.Forms.Button btSetHandbrake;
        private System.Windows.Forms.Button btSetServoPos;
        private System.Windows.Forms.TextBox tbDutyCycle;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.TextBox tbCurrentBrake;
        private System.Windows.Forms.TextBox tbRpm;
        private System.Windows.Forms.TextBox tbPos;
        private System.Windows.Forms.TextBox tbHandbrake;
        private System.Windows.Forms.TextBox tbServoPos;
        private System.Windows.Forms.TextBox tbDetectEncoder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirmware;
        private System.Windows.Forms.TextBox tbHardware;
        private System.Windows.Forms.TextBox tbUUID;
        private System.Windows.Forms.Button btReboot;
    }
}

