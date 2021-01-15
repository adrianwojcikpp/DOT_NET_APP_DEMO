namespace SerialPortApp
{
    partial class MainForm
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
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDataReceive = new System.Windows.Forms.TextBox();
            this.groupBox_receive = new System.Windows.Forms.GroupBox();
            this.rxEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox_transmit = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbDataTransmit = new System.Windows.Forms.TextBox();
            this.groupBox_exceptions = new System.Windows.Forms.GroupBox();
            this.error_label = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSerialPort = new System.Windows.Forms.TabPage();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_receive.SuspendLayout();
            this.groupBox_transmit.SuspendLayout();
            this.groupBox_exceptions.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSerialPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(13, 73);
            this.baudRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(79, 17);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(13, 106);
            this.dataBitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(69, 17);
            this.dataBitsLabel.TabIndex = 3;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(13, 139);
            this.parityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(48, 17);
            this.parityLabel.TabIndex = 5;
            this.parityLabel.Text = "Parity:";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(13, 39);
            this.portNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(79, 17);
            this.portNameLabel.TabIndex = 7;
            this.portNameLabel.Text = "Port Name:";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(13, 172);
            this.stopBitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(68, 17);
            this.stopBitsLabel.TabIndex = 9;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(103, 69);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(203, 24);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(103, 102);
            this.dataBitsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(203, 24);
            this.dataBitsComboBox.TabIndex = 4;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(103, 135);
            this.parityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(203, 24);
            this.parityComboBox.TabIndex = 6;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(103, 36);
            this.portNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(203, 24);
            this.portNameComboBox.TabIndex = 8;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(103, 169);
            this.stopBitsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(203, 24);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_settings.Controls.Add(this.baudRateComboBox);
            this.groupBox_settings.Controls.Add(this.btnStop);
            this.groupBox_settings.Controls.Add(this.baudRateLabel);
            this.groupBox_settings.Controls.Add(this.btnStart);
            this.groupBox_settings.Controls.Add(this.stopBitsComboBox);
            this.groupBox_settings.Controls.Add(this.stopBitsLabel);
            this.groupBox_settings.Controls.Add(this.dataBitsLabel);
            this.groupBox_settings.Controls.Add(this.portNameComboBox);
            this.groupBox_settings.Controls.Add(this.dataBitsComboBox);
            this.groupBox_settings.Controls.Add(this.portNameLabel);
            this.groupBox_settings.Controls.Add(this.parityLabel);
            this.groupBox_settings.Controls.Add(this.parityComboBox);
            this.groupBox_settings.Location = new System.Drawing.Point(11, 7);
            this.groupBox_settings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_settings.Size = new System.Drawing.Size(325, 246);
            this.groupBox_settings.TabIndex = 11;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Serial Port Settings";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(209, 202);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 28);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Disconnect";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 202);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 28);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDataReceive
            // 
            this.tbDataReceive.Location = new System.Drawing.Point(15, 23);
            this.tbDataReceive.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataReceive.Multiline = true;
            this.tbDataReceive.Name = "tbDataReceive";
            this.tbDataReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReceive.Size = new System.Drawing.Size(658, 118);
            this.tbDataReceive.TabIndex = 13;
            // 
            // groupBox_receive
            // 
            this.groupBox_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_receive.Controls.Add(this.rxEnableCheckBox);
            this.groupBox_receive.Controls.Add(this.btnClear);
            this.groupBox_receive.Controls.Add(this.tbDataReceive);
            this.groupBox_receive.Location = new System.Drawing.Point(12, 261);
            this.groupBox_receive.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_receive.Name = "groupBox_receive";
            this.groupBox_receive.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_receive.Size = new System.Drawing.Size(681, 185);
            this.groupBox_receive.TabIndex = 14;
            this.groupBox_receive.TabStop = false;
            this.groupBox_receive.Text = "Receive";
            // 
            // rxEnableCheckBox
            // 
            this.rxEnableCheckBox.AutoSize = true;
            this.rxEnableCheckBox.Checked = true;
            this.rxEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rxEnableCheckBox.Location = new System.Drawing.Point(15, 149);
            this.rxEnableCheckBox.Name = "rxEnableCheckBox";
            this.rxEnableCheckBox.Size = new System.Drawing.Size(94, 21);
            this.rxEnableCheckBox.TabIndex = 15;
            this.rxEnableCheckBox.Text = "Rx Enable";
            this.rxEnableCheckBox.UseVisualStyleBackColor = true;
            this.rxEnableCheckBox.CheckedChanged += new System.EventHandler(this.rxEnableCheckBox_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(560, 149);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 28);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox_transmit
            // 
            this.groupBox_transmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transmit.Controls.Add(this.btnSend);
            this.groupBox_transmit.Controls.Add(this.tbDataTransmit);
            this.groupBox_transmit.Location = new System.Drawing.Point(11, 454);
            this.groupBox_transmit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_transmit.Name = "groupBox_transmit";
            this.groupBox_transmit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_transmit.Size = new System.Drawing.Size(681, 89);
            this.groupBox_transmit.TabIndex = 15;
            this.groupBox_transmit.TabStop = false;
            this.groupBox_transmit.Text = "Transmit";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(560, 53);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(113, 28);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbDataTransmit
            // 
            this.tbDataTransmit.Location = new System.Drawing.Point(16, 23);
            this.tbDataTransmit.Margin = new System.Windows.Forms.Padding(4);
            this.tbDataTransmit.Name = "tbDataTransmit";
            this.tbDataTransmit.Size = new System.Drawing.Size(657, 22);
            this.tbDataTransmit.TabIndex = 0;
            // 
            // groupBox_exceptions
            // 
            this.groupBox_exceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_exceptions.Controls.Add(this.error_label);
            this.groupBox_exceptions.Location = new System.Drawing.Point(344, 7);
            this.groupBox_exceptions.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_exceptions.Name = "groupBox_exceptions";
            this.groupBox_exceptions.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_exceptions.Size = new System.Drawing.Size(348, 246);
            this.groupBox_exceptions.TabIndex = 16;
            this.groupBox_exceptions.TabStop = false;
            this.groupBox_exceptions.Text = "Exceptions";
            // 
            // error_label
            // 
            this.error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(4, 19);
            this.error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(340, 223);
            this.error_label.TabIndex = 0;
            this.error_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSerialPort);
            this.tabMain.Controls.Add(this.tabInput);
            this.tabMain.Controls.Add(this.tabControl);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(709, 581);
            this.tabMain.TabIndex = 17;
            // 
            // tabSerialPort
            // 
            this.tabSerialPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabSerialPort.Controls.Add(this.groupBox_settings);
            this.tabSerialPort.Controls.Add(this.groupBox_exceptions);
            this.tabSerialPort.Controls.Add(this.groupBox_transmit);
            this.tabSerialPort.Controls.Add(this.groupBox_receive);
            this.tabSerialPort.Location = new System.Drawing.Point(4, 25);
            this.tabSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.tabSerialPort.Name = "tabSerialPort";
            this.tabSerialPort.Padding = new System.Windows.Forms.Padding(4);
            this.tabSerialPort.Size = new System.Drawing.Size(701, 552);
            this.tabSerialPort.TabIndex = 0;
            this.tabSerialPort.Text = "Serial Port";
            // 
            // tabInput
            // 
            this.tabInput.Location = new System.Drawing.Point(4, 25);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(701, 552);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Input plot";
            this.tabInput.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(4, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabControl.Size = new System.Drawing.Size(701, 552);
            this.tabControl.TabIndex = 2;
            this.tabControl.Text = "Output control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(709, 581);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "C# Serial Port App";
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_receive.ResumeLayout(false);
            this.groupBox_receive.PerformLayout();
            this.groupBox_transmit.ResumeLayout(false);
            this.groupBox_transmit.PerformLayout();
            this.groupBox_exceptions.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSerialPort.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbDataReceive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.GroupBox groupBox_receive;
        private System.Windows.Forms.GroupBox groupBox_transmit;
        private System.Windows.Forms.TextBox tbDataTransmit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox_exceptions;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSerialPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.CheckBox rxEnableCheckBox;
    }
}

