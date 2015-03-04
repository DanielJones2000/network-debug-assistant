using network_debug_assistant.Properties;
namespace network_debug_assistant
{
    partial class Index
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._code = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._clearSendValue = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._clearBackValues = new System.Windows.Forms.LinkLabel();
            this._connect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._type = new System.Windows.Forms.ComboBox();
            this._send = new System.Windows.Forms.Button();
            this._sendValue = new System.Windows.Forms.TextBox();
            this._backValues = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._toolMessage = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._code);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this._connect);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this._port);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this._ip);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this._type);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._send);
            this.splitContainer1.Panel2.Controls.Add(this._sendValue);
            this.splitContainer1.Panel2.Controls.Add(this._backValues);
            this.splitContainer1.Size = new System.Drawing.Size(600, 421);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 0;
            // 
            // _code
            // 
            this._code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._code.FormattingEnabled = true;
            this._code.Location = new System.Drawing.Point(14, 165);
            this._code.Name = "_code";
            this._code.Size = new System.Drawing.Size(121, 20);
            this._code.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._clearSendValue);
            this.groupBox2.Location = new System.Drawing.Point(3, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送区域";
            // 
            // _clearSendValue
            // 
            this._clearSendValue.AutoSize = true;
            this._clearSendValue.Location = new System.Drawing.Point(47, 28);
            this._clearSendValue.Name = "_clearSendValue";
            this._clearSendValue.Size = new System.Drawing.Size(53, 12);
            this._clearSendValue.TabIndex = 0;
            this._clearSendValue.TabStop = true;
            this._clearSendValue.Text = "清空文本";
            this._clearSendValue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._clearSendValue_LinkClicked);
            this._clearSendValue.MouseHover += new System.EventHandler(this._mouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._clearBackValues);
            this.groupBox1.Location = new System.Drawing.Point(3, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收区域";
            // 
            // _clearBackValues
            // 
            this._clearBackValues.AutoSize = true;
            this._clearBackValues.Location = new System.Drawing.Point(47, 26);
            this._clearBackValues.Name = "_clearBackValues";
            this._clearBackValues.Size = new System.Drawing.Size(53, 12);
            this._clearBackValues.TabIndex = 1;
            this._clearBackValues.TabStop = true;
            this._clearBackValues.Text = "清空文本";
            this._clearBackValues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._clearBackValues_LinkClicked);
            this._clearBackValues.MouseHover += new System.EventHandler(this._mouseHover);
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(16, 201);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(119, 38);
            this._connect.TabIndex = 8;
            this._connect.Text = "链接";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this._connect_Click);
            this._connect.MouseHover += new System.EventHandler(this._mouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "(4)编码";
            // 
            // _port
            // 
            this._port.Location = new System.Drawing.Point(14, 115);
            this._port.Name = "_port";
            this._port.Size = new System.Drawing.Size(121, 21);
            this._port.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "(3)端口：";
            // 
            // _ip
            // 
            this._ip.Location = new System.Drawing.Point(14, 72);
            this._ip.Name = "_ip";
            this._ip.Size = new System.Drawing.Size(121, 21);
            this._ip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "(2)链接IP地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "(1)协议类型：";
            // 
            // _type
            // 
            this._type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._type.FormattingEnabled = true;
            this._type.Location = new System.Drawing.Point(16, 24);
            this._type.Name = "_type";
            this._type.Size = new System.Drawing.Size(119, 20);
            this._type.TabIndex = 0;
            // 
            // _send
            // 
            this._send.Location = new System.Drawing.Point(360, 327);
            this._send.Name = "_send";
            this._send.Size = new System.Drawing.Size(67, 60);
            this._send.TabIndex = 3;
            this._send.Text = "发送";
            this._send.UseVisualStyleBackColor = true;
            this._send.Click += new System.EventHandler(this._send_Click);
            this._send.MouseHover += new System.EventHandler(this._mouseHover);
            // 
            // _sendValue
            // 
            this._sendValue.Location = new System.Drawing.Point(3, 324);
            this._sendValue.Multiline = true;
            this._sendValue.Name = "_sendValue";
            this._sendValue.Size = new System.Drawing.Size(351, 71);
            this._sendValue.TabIndex = 2;
            this._sendValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // _backValues
            // 
            this._backValues.Location = new System.Drawing.Point(3, -1);
            this._backValues.Multiline = true;
            this._backValues.Name = "_backValues";
            this._backValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._backValues.Size = new System.Drawing.Size(425, 319);
            this._backValues.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _toolMessage
            // 
            this._toolMessage.Name = "_toolMessage";
            this._toolMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = Resources.ApplictionName;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _connect;
        private System.Windows.Forms.TextBox _backValues;
        private System.Windows.Forms.LinkLabel _clearBackValues;
        private System.Windows.Forms.TextBox _sendValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel _clearSendValue;
        private System.Windows.Forms.Button _send;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _toolMessage;
        private System.Windows.Forms.ComboBox _code;
    }
}