namespace Tester
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
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabPageMcconf = new System.Windows.Forms.TabPage();
            this.tabPageAppconf = new System.Windows.Forms.TabPage();
            this.tabPageCommands = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendMcconf = new System.Windows.Forms.Button();
            this.buttonReadMcconf = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.propertyGridAppconf = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendAppconf = new System.Windows.Forms.Button();
            this.buttonReadAppconf = new System.Windows.Forms.Button();
            this.buttonDetectEncoder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageConnection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageMcconf.SuspendLayout();
            this.tabPageAppconf.SuspendLayout();
            this.tabPageCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGridMcconf
            // 
            this.propertyGridMcconf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridMcconf.Location = new System.Drawing.Point(3, 3);
            this.propertyGridMcconf.Name = "propertyGridMcconf";
            this.propertyGridMcconf.Size = new System.Drawing.Size(480, 248);
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 328);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageConnection
            // 
            this.tabPageConnection.Controls.Add(this.tableLayoutPanel1);
            this.tabPageConnection.Location = new System.Drawing.Point(4, 22);
            this.tabPageConnection.Name = "tabPageConnection";
            this.tabPageConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConnection.Size = new System.Drawing.Size(492, 302);
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
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxBaud, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonConnect, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "BaudRate:";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(175, 38);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(252, 21);
            this.comboBoxPort.TabIndex = 1;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBoxBaud.Location = new System.Drawing.Point(175, 136);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(252, 21);
            this.comboBoxBaud.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConnect.Location = new System.Drawing.Point(180, 234);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(242, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tabPageMcconf
            // 
            this.tabPageMcconf.Controls.Add(this.tableLayoutPanel4);
            this.tabPageMcconf.Location = new System.Drawing.Point(4, 22);
            this.tabPageMcconf.Name = "tabPageMcconf";
            this.tabPageMcconf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMcconf.Size = new System.Drawing.Size(492, 302);
            this.tabPageMcconf.TabIndex = 0;
            this.tabPageMcconf.Text = "Motor";
            this.tabPageMcconf.UseVisualStyleBackColor = true;
            // 
            // tabPageAppconf
            // 
            this.tabPageAppconf.Controls.Add(this.tableLayoutPanel6);
            this.tabPageAppconf.Location = new System.Drawing.Point(4, 22);
            this.tabPageAppconf.Name = "tabPageAppconf";
            this.tabPageAppconf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppconf.Size = new System.Drawing.Size(492, 302);
            this.tabPageAppconf.TabIndex = 1;
            this.tabPageAppconf.Text = "App";
            this.tabPageAppconf.UseVisualStyleBackColor = true;
            // 
            // tabPageCommands
            // 
            this.tabPageCommands.Controls.Add(this.splitContainer1);
            this.tabPageCommands.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommands.Name = "tabPageCommands";
            this.tabPageCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommands.Size = new System.Drawing.Size(492, 302);
            this.tabPageCommands.TabIndex = 3;
            this.tabPageCommands.Text = "Commands";
            this.tabPageCommands.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(486, 296);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLog, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.74359F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.25641F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 126);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Log:";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 21);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(480, 102);
            this.textBoxLog.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonDetectEncoder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(486, 166);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.propertyGridMcconf, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.81081F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18919F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(486, 296);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 257);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(480, 36);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // buttonSendMcconf
            // 
            this.buttonSendMcconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendMcconf.Location = new System.Drawing.Point(12, 6);
            this.buttonSendMcconf.Name = "buttonSendMcconf";
            this.buttonSendMcconf.Size = new System.Drawing.Size(216, 23);
            this.buttonSendMcconf.TabIndex = 0;
            this.buttonSendMcconf.Text = "Send";
            this.buttonSendMcconf.UseVisualStyleBackColor = true;
            this.buttonSendMcconf.Click += new System.EventHandler(this.buttonSendMcconf_Click);
            // 
            // buttonReadMcconf
            // 
            this.buttonReadMcconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReadMcconf.Location = new System.Drawing.Point(252, 6);
            this.buttonReadMcconf.Name = "buttonReadMcconf";
            this.buttonReadMcconf.Size = new System.Drawing.Size(216, 23);
            this.buttonReadMcconf.TabIndex = 0;
            this.buttonReadMcconf.Text = "Read";
            this.buttonReadMcconf.UseVisualStyleBackColor = true;
            this.buttonReadMcconf.Click += new System.EventHandler(this.buttonReadMcconf_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.propertyGridAppconf, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.81081F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.18919F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(486, 296);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // propertyGridAppconf
            // 
            this.propertyGridAppconf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridAppconf.Location = new System.Drawing.Point(3, 3);
            this.propertyGridAppconf.Name = "propertyGridAppconf";
            this.propertyGridAppconf.Size = new System.Drawing.Size(480, 248);
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
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 257);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(480, 36);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // buttonSendAppconf
            // 
            this.buttonSendAppconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendAppconf.Location = new System.Drawing.Point(12, 6);
            this.buttonSendAppconf.Name = "buttonSendAppconf";
            this.buttonSendAppconf.Size = new System.Drawing.Size(216, 23);
            this.buttonSendAppconf.TabIndex = 0;
            this.buttonSendAppconf.Text = "Send";
            this.buttonSendAppconf.UseVisualStyleBackColor = true;
            this.buttonSendAppconf.Click += new System.EventHandler(this.buttonSendAppconf_Click);
            // 
            // buttonReadAppconf
            // 
            this.buttonReadAppconf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReadAppconf.Location = new System.Drawing.Point(252, 6);
            this.buttonReadAppconf.Name = "buttonReadAppconf";
            this.buttonReadAppconf.Size = new System.Drawing.Size(216, 23);
            this.buttonReadAppconf.TabIndex = 0;
            this.buttonReadAppconf.Text = "Read";
            this.buttonReadAppconf.UseVisualStyleBackColor = true;
            this.buttonReadAppconf.Click += new System.EventHandler(this.buttonReadAppconf_Click);
            // 
            // buttonDetectEncoder
            // 
            this.buttonDetectEncoder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDetectEncoder.Location = new System.Drawing.Point(50, 30);
            this.buttonDetectEncoder.Name = "buttonDetectEncoder";
            this.buttonDetectEncoder.Size = new System.Drawing.Size(142, 23);
            this.buttonDetectEncoder.TabIndex = 0;
            this.buttonDetectEncoder.Text = "Detect Encoder";
            this.buttonDetectEncoder.UseVisualStyleBackColor = true;
            this.buttonDetectEncoder.Click += new System.EventHandler(this.buttonDetectEncoder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VESC Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConnection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageMcconf.ResumeLayout(false);
            this.tabPageAppconf.ResumeLayout(false);
            this.tabPageCommands.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TabPage tabPageCommands;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonSendMcconf;
        private System.Windows.Forms.Button buttonReadMcconf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PropertyGrid propertyGridAppconf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button buttonSendAppconf;
        private System.Windows.Forms.Button buttonReadAppconf;
        private System.Windows.Forms.Button buttonDetectEncoder;
    }
}

