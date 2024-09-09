namespace MultiChannel_Button
{
    partial class SimpleInput_MultiChannel_Button
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
            dnc.label.DncLabelProperty dncLabelProperty1 = new dnc.label.DncLabelProperty();
            dnc.daq.DncDaqProperty dncDaqProperty1 = new dnc.daq.DncDaqProperty();
            dnc.button.DncButtonProperty dncButtonProperty1 = new dnc.button.DncButtonProperty();
            this.groupBox_singleChannelInput = new System.Windows.Forms.GroupBox();
            this.dncLabel_InputValue = new dnc.label.DncLabel(this.components);
            this.label_Unit = new System.Windows.Forms.Label();
            this.label_Channel = new System.Windows.Forms.Label();
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_ErrorDetail = new System.Windows.Forms.TextBox();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.dncButton1 = new dnc.button.DncButton(this.components);
            this.daqInputTask1 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            this.groupBox_singleChannelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncLabel_InputValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_singleChannelInput
            // 
            this.groupBox_singleChannelInput.Controls.Add(this.dncLabel_InputValue);
            this.groupBox_singleChannelInput.Controls.Add(this.label_Unit);
            this.groupBox_singleChannelInput.Controls.Add(this.label_Channel);
            this.groupBox_singleChannelInput.Location = new System.Drawing.Point(13, 21);
            this.groupBox_singleChannelInput.Name = "groupBox_singleChannelInput";
            this.groupBox_singleChannelInput.Size = new System.Drawing.Size(380, 69);
            this.groupBox_singleChannelInput.TabIndex = 6;
            this.groupBox_singleChannelInput.TabStop = false;
            this.groupBox_singleChannelInput.Text = "Input from Multi-Channels";
            // 
            // dncLabel_InputValue
            // 
            this.dncLabel_InputValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dncLabelProperty1.Text = "0";
            dncLabelProperty1.TextAlign = dnc.common.ContentAlignmentEx.MiddleRight;
            this.dncLabel_InputValue.LabelProperty = dncLabelProperty1;
            this.dncLabel_InputValue.Location = new System.Drawing.Point(69, 26);
            this.dncLabel_InputValue.Name = "dncLabel_InputValue";
            this.dncLabel_InputValue.Size = new System.Drawing.Size(268, 25);
            this.dncLabel_InputValue.TabIndex = 3;
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Location = new System.Drawing.Point(343, 31);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(20, 13);
            this.label_Unit.TabIndex = 2;
            this.label_Unit.Text = "[V]";
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Location = new System.Drawing.Point(13, 31);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(37, 13);
            this.label_Channel.TabIndex = 0;
            this.label_Channel.Text = "ch.0-3";
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(17, 108);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(67, 13);
            this.label_ErrorDetail.TabIndex = 10;
            this.label_ErrorDetail.Text = "Error Details ";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(418, 95);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(104, 25);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_ErrorDetail
            // 
            this.textBox_ErrorDetail.Location = new System.Drawing.Point(13, 129);
            this.textBox_ErrorDetail.Multiline = true;
            this.textBox_ErrorDetail.Name = "textBox_ErrorDetail";
            this.textBox_ErrorDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ErrorDetail.Size = new System.Drawing.Size(380, 90);
            this.textBox_ErrorDetail.TabIndex = 8;
            this.textBox_ErrorDetail.WordWrap = false;
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(418, 10);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(104, 25);
            this.button_DaqProperty.TabIndex = 7;
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
            // dncButton1
            // 
            dncButtonProperty1.OffLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.OnLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.TextOff = "Simple Input";
            dncButtonProperty1.TextOn = "Simple Input";
            this.dncButton1.ButtonProperty = dncButtonProperty1;
            this.dncButton1.Location = new System.Drawing.Point(418, 43);
            this.dncButton1.Name = "dncButton1";
            this.dncButton1.Size = new System.Drawing.Size(103, 25);
            this.dncButton1.TabIndex = 11;
            this.dncButton1.UseVisualStyleBackColor = true;
            // 
            // daqInputTask1
            // 
            this.daqInputTask1.AccessType = dnc.daq.DaqInputAccessType.Analog;
            this.daqInputTask1.AccessTypeInputValue = "0-3";
            this.daqInputTask1.DeviceName = "AIO000";
            this.daqInputTask1.InputNo = 0;
            this.daqInputTask1.Target = "dncLabel_InputValue";
            this.daqInputTask1.TaskValueByte = null;
            this.daqInputTask1.TaskValueFloat = null;
            this.daqInputTask1.TaskValueInt = null;
            this.daqInputTask1.Timing = "dncButton1";
            // 
            // daqDevice1
            // 
            this.daqDevice1.AiInputMethod = ((short)(0));
            this.daqDevice1.AiRange = new short[0];
            this.daqDevice1.AiScanClock = 2F;
            this.daqDevice1.AoDefaultOutData = new float[] {
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F,
        0F};
            this.daqDevice1.AoRange = new short[0];
            this.daqDevice1.BufferOverOperation = dnc.daq.DaqAioSamplingBufferOver.All;
            this.daqDevice1.DeviceName = "AIO000";
            this.daqDevice1.DeviceNo = ((short)(0));
            this.daqDevice1.DoDefaultOutData = new byte[] {
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0)),
        ((byte)(0))};
            this.daqDevice1.ModelName = "AIO-163202F-PE";
            this.daqDevice1.TabName = "Device00";
            // 
            // SimpleInput_MultiChannel_Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 229);
            this.Controls.Add(this.groupBox_singleChannelInput);
            this.Controls.Add(this.label_ErrorDetail);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_ErrorDetail);
            this.Controls.Add(this.button_DaqProperty);
            this.Controls.Add(this.dncButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleInput_MultiChannel_Button";
            this.Text = "Multi-Channels Simple Input Sample (Button Linkage) ";
            this.groupBox_singleChannelInput.ResumeLayout(false);
            this.groupBox_singleChannelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncLabel_InputValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_singleChannelInput;
        private dnc.label.DncLabel dncLabel_InputValue;
        private System.Windows.Forms.Label label_Unit;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_ErrorDetail;
        private System.Windows.Forms.Button button_DaqProperty;
        private dnc.daq.DncDaq dncDaq1;
        private dnc.button.DncButton dncButton1;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DaqInputTask daqInputTask1;
    }
}

