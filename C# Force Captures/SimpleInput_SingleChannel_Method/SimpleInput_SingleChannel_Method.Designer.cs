namespace SimpleInput_SingleChannel_Method
{
    partial class SimpleInput_SingleChannel_Method
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
            dnc.daq.DncDaqProperty dncDaqProperty1 = new dnc.daq.DncDaqProperty();
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_ErrorDetail = new System.Windows.Forms.TextBox();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.button_InputChannel = new System.Windows.Forms.Button();
            this.textBox_ChannelNo = new System.Windows.Forms.TextBox();
            this.textBox_DeviceNo = new System.Windows.Forms.TextBox();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ChannelNo = new System.Windows.Forms.Label();
            this.label_DeviceNo = new System.Windows.Forms.Label();
            this.daqInputTask1 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(17, 213);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(67, 13);
            this.label_ErrorDetail.TabIndex = 16;
            this.label_ErrorDetail.Text = "Error Details ";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(301, 201);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(101, 25);
            this.button_Exit.TabIndex = 15;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_ErrorDetail
            // 
            this.textBox_ErrorDetail.Location = new System.Drawing.Point(14, 234);
            this.textBox_ErrorDetail.Multiline = true;
            this.textBox_ErrorDetail.Name = "textBox_ErrorDetail";
            this.textBox_ErrorDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ErrorDetail.Size = new System.Drawing.Size(388, 90);
            this.textBox_ErrorDetail.TabIndex = 14;
            this.textBox_ErrorDetail.WordWrap = false;
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(301, 17);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(101, 25);
            this.button_DaqProperty.TabIndex = 13;
            this.button_DaqProperty.Text = "DncDaq Setting";
            this.button_DaqProperty.UseVisualStyleBackColor = true;
            this.button_DaqProperty.Click += new System.EventHandler(this.button_DaqProperty_Click);
            // 
            // dncDaq1
            // 
            dncDaqProperty1.DebugLogFileName = "DncDaqDebugLog.log";
            dncDaqProperty1.DebugLogTarget.ERROR = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EVENT = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EXEPTION = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.INFO = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.Device.Add(this.daqDevice1);
            dncDaqProperty1.InputTask.Add(this.daqInputTask1);
            this.dncDaq1.DaqProperty = dncDaqProperty1;
            this.dncDaq1.DncName = "dncDaq1";
            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
            // 
            // button_InputChannel
            // 
            this.button_InputChannel.Location = new System.Drawing.Point(301, 50);
            this.button_InputChannel.Name = "button_InputChannel";
            this.button_InputChannel.Size = new System.Drawing.Size(101, 25);
            this.button_InputChannel.TabIndex = 24;
            this.button_InputChannel.Text = "AiInputChannel";
            this.button_InputChannel.UseVisualStyleBackColor = true;
            this.button_InputChannel.Click += new System.EventHandler(this.button_InputChannel_Click);
            // 
            // textBox_ChannelNo
            // 
            this.textBox_ChannelNo.Location = new System.Drawing.Point(117, 52);
            this.textBox_ChannelNo.Name = "textBox_ChannelNo";
            this.textBox_ChannelNo.Size = new System.Drawing.Size(36, 20);
            this.textBox_ChannelNo.TabIndex = 23;
            this.textBox_ChannelNo.Text = "0";
            // 
            // textBox_DeviceNo
            // 
            this.textBox_DeviceNo.Location = new System.Drawing.Point(117, 20);
            this.textBox_DeviceNo.Name = "textBox_DeviceNo";
            this.textBox_DeviceNo.Size = new System.Drawing.Size(36, 20);
            this.textBox_DeviceNo.TabIndex = 22;
            this.textBox_DeviceNo.Text = "0";
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(20, 104);
            this.textBox_Data.Multiline = true;
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Data.Size = new System.Drawing.Size(199, 90);
            this.textBox_Data.TabIndex = 21;
            this.textBox_Data.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Voltage[V]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Channel";
            // 
            // label_ChannelNo
            // 
            this.label_ChannelNo.AutoSize = true;
            this.label_ChannelNo.Location = new System.Drawing.Point(17, 56);
            this.label_ChannelNo.Name = "label_ChannelNo";
            this.label_ChannelNo.Size = new System.Drawing.Size(96, 13);
            this.label_ChannelNo.TabIndex = 18;
            this.label_ChannelNo.Text = "Specified Channel:";
            // 
            // label_DeviceNo
            // 
            this.label_DeviceNo.AutoSize = true;
            this.label_DeviceNo.Location = new System.Drawing.Point(17, 25);
            this.label_DeviceNo.Name = "label_DeviceNo";
            this.label_DeviceNo.Size = new System.Drawing.Size(67, 13);
            this.label_DeviceNo.TabIndex = 17;
            this.label_DeviceNo.Text = "Device No.: ";
            // 
            // daqInputTask1
            // 
            this.daqInputTask1.AccessType = dnc.daq.DaqInputAccessType.Analog;
            this.daqInputTask1.DeviceName = "AIO000";
            this.daqInputTask1.InputNo = 0;
            this.daqInputTask1.Target = "dncLabel_InputValue";
            this.daqInputTask1.TaskValueByte = null;
            this.daqInputTask1.TaskValueFloat = null;
            this.daqInputTask1.TaskValueInt = null;
            this.daqInputTask1.Timing = "Timer";
            // 
            // daqDevice1
            // 
            this.daqDevice1.AiInputMethod = ((short)(0));
            this.daqDevice1.AiRange = new short[0];
            this.daqDevice1.AiScanClock = 2F;
            this.daqDevice1.AoDefaultOutData = new float[] {
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F,
        0F, 0F, 0F, 0F, 0F, 0F, 0F, 0F};
            this.daqDevice1.AoRange = new short[0];
            this.daqDevice1.BufferOverOperation = dnc.daq.DaqAioSamplingBufferOver.All;
            this.daqDevice1.DeviceName = "AIO000";
            this.daqDevice1.DeviceNo = ((short)(0));
            this.daqDevice1.DoDefaultOutData = new byte[] {
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)),
        ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0))};
            this.daqDevice1.ModelName = "AIO-163202F-PE";
            this.daqDevice1.TabName = "Device00";
            // 
            // SimpleInput_SingleChannel_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 337);
            this.Controls.Add(this.label_ErrorDetail);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_ErrorDetail);
            this.Controls.Add(this.button_DaqProperty);
            this.Controls.Add(this.button_InputChannel);
            this.Controls.Add(this.textBox_ChannelNo);
            this.Controls.Add(this.textBox_DeviceNo);
            this.Controls.Add(this.textBox_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ChannelNo);
            this.Controls.Add(this.label_DeviceNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleInput_SingleChannel_Method";
            this.Text = "Specified Channel Simple Input Sample (Method Linkage) ";
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_ErrorDetail;
        private System.Windows.Forms.Button button_DaqProperty;
        private dnc.daq.DncDaq dncDaq1;
        private System.Windows.Forms.Button button_InputChannel;
        private System.Windows.Forms.TextBox textBox_ChannelNo;
        private System.Windows.Forms.TextBox textBox_DeviceNo;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ChannelNo;
        private System.Windows.Forms.Label label_DeviceNo;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DaqInputTask daqInputTask1;
    }
}

