namespace SimpleIO
{
    partial class SimpleIO
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
            dnc.button.DncButtonProperty dncButtonProperty1 = new dnc.button.DncButtonProperty();
            dnc.textbox.DncTextBoxProperty dncTextBoxProperty1 = new dnc.textbox.DncTextBoxProperty();
            dnc.button.DncButtonProperty dncButtonProperty2 = new dnc.button.DncButtonProperty();
            dnc.textbox.DncTextBoxProperty dncTextBoxProperty2 = new dnc.textbox.DncTextBoxProperty();
            dnc.lamp.DncLampProperty dncLampProperty1 = new dnc.lamp.DncLampProperty();
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.dncButton_output = new dnc.button.DncButton(this.components);
            this.dncTextBox_OutputValue = new dnc.textbox.DncTextBox(this.components);
            this.groupBox_DO = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dncButton_input = new dnc.button.DncButton(this.components);
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_ErrorDetail = new System.Windows.Forms.TextBox();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.dncTextBox_InputValue = new dnc.textbox.DncTextBox(this.components);
            this.dncLamp_Input = new dnc.lamp.DncLamp(this.components);
            this.label_Channel = new System.Windows.Forms.Label();
            this.groupBox_DI = new System.Windows.Forms.GroupBox();
            this.daqInputTask1 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqInputTask2 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqOutputTask1 = new dnc.daq.task.DaqOutputTask(this.components);
            this.daqInputTask3 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqInputTask4 = new dnc.daq.task.DaqInputTask(this.components);
            this.daqOutputTask2 = new dnc.daq.task.DaqOutputTask(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncTextBox_OutputValue)).BeginInit();
            this.groupBox_DO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncTextBox_InputValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncLamp_Input)).BeginInit();
            this.groupBox_DI.SuspendLayout();
            this.SuspendLayout();
            // 
            // dncDaq1
            // 
            dncDaqProperty1.DebugLogFileName = "DncDaqDebugLog.log";
            dncDaqProperty1.DebugLogTarget.ERROR = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EVENT = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.EXEPTION = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.DebugLogTarget.INFO = dnc.daq.DaqDebugLog.On;
            dncDaqProperty1.Device.Add(this.daqDevice1);
            dncDaqProperty1.InputTask.Add(this.daqInputTask3);
            dncDaqProperty1.InputTask.Add(this.daqInputTask4);
            dncDaqProperty1.OutputTask.Add(this.daqOutputTask2);
            this.dncDaq1.DaqProperty = dncDaqProperty1;
            this.dncDaq1.DncName = "dncDaq1";
            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
            // 
            // dncButton_output
            // 
            dncButtonProperty1.OffLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.OnLedColor = System.Drawing.Color.Empty;
            dncButtonProperty1.TextOff = "Data Output";
            dncButtonProperty1.TextOn = "Data Output";
            this.dncButton_output.ButtonProperty = dncButtonProperty1;
            this.dncButton_output.Location = new System.Drawing.Point(362, 176);
            this.dncButton_output.Name = "dncButton_output";
            this.dncButton_output.Size = new System.Drawing.Size(101, 25);
            this.dncButton_output.TabIndex = 14;
            this.dncButton_output.UseVisualStyleBackColor = true;
            // 
            // dncTextBox_OutputValue
            // 
            this.dncTextBox_OutputValue.Location = new System.Drawing.Point(111, 26);
            this.dncTextBox_OutputValue.Name = "dncTextBox_OutputValue";
            this.dncTextBox_OutputValue.Size = new System.Drawing.Size(45, 20);
            this.dncTextBox_OutputValue.TabIndex = 1;
            dncTextBoxProperty1.DataType = dnc.textbox.TextBoxDataType.Hexadecimal;
            dncTextBoxProperty1.FocusedBackColor = System.Drawing.Color.Empty;
            dncTextBoxProperty1.HexadecimalSymbol = dnc.textbox.TextBoxHexadecimalSymbol.Prefix0x;
            dncTextBoxProperty1.MaxValue = ((long)(10000));
            dncTextBoxProperty1.MaxValueR = 10000D;
            dncTextBoxProperty1.MinValue = ((long)(0));
            dncTextBoxProperty1.MinValueR = 0D;
            dncTextBoxProperty1.Text = "0";
            dncTextBoxProperty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dncTextBox_OutputValue.TextBoxProperty = dncTextBoxProperty1;
            // 
            // groupBox_DO
            // 
            this.groupBox_DO.Controls.Add(this.dncTextBox_OutputValue);
            this.groupBox_DO.Controls.Add(this.label1);
            this.groupBox_DO.Location = new System.Drawing.Point(12, 171);
            this.groupBox_DO.Name = "groupBox_DO";
            this.groupBox_DO.Size = new System.Drawing.Size(334, 67);
            this.groupBox_DO.TabIndex = 12;
            this.groupBox_DO.TabStop = false;
            this.groupBox_DO.Text = "Digital Output";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Output Data(Hex)";
            // 
            // dncButton_input
            // 
            dncButtonProperty2.OffLedColor = System.Drawing.Color.Empty;
            dncButtonProperty2.OnLedColor = System.Drawing.Color.Empty;
            dncButtonProperty2.TextOff = "Data Input";
            dncButtonProperty2.TextOn = "Data Input";
            this.dncButton_input.ButtonProperty = dncButtonProperty2;
            this.dncButton_input.Location = new System.Drawing.Point(362, 49);
            this.dncButton_input.Name = "dncButton_input";
            this.dncButton_input.Size = new System.Drawing.Size(101, 25);
            this.dncButton_input.TabIndex = 13;
            this.dncButton_input.UseVisualStyleBackColor = true;
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(15, 247);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(64, 13);
            this.label_ErrorDetail.TabIndex = 11;
            this.label_ErrorDetail.Text = "Error Details";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(362, 272);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(101, 25);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_ErrorDetail
            // 
            this.textBox_ErrorDetail.Location = new System.Drawing.Point(17, 272);
            this.textBox_ErrorDetail.Multiline = true;
            this.textBox_ErrorDetail.Name = "textBox_ErrorDetail";
            this.textBox_ErrorDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ErrorDetail.Size = new System.Drawing.Size(329, 90);
            this.textBox_ErrorDetail.TabIndex = 9;
            this.textBox_ErrorDetail.WordWrap = false;
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(362, 16);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(101, 25);
            this.button_DaqProperty.TabIndex = 8;
            this.button_DaqProperty.Text = "DncDaq Setting";
            this.button_DaqProperty.UseVisualStyleBackColor = true;
            this.button_DaqProperty.Click += new System.EventHandler(this.button_DaqProperty_Click);
            // 
            // dncTextBox_InputValue
            // 
            this.dncTextBox_InputValue.Location = new System.Drawing.Point(111, 22);
            this.dncTextBox_InputValue.Name = "dncTextBox_InputValue";
            this.dncTextBox_InputValue.ReadOnly = true;
            this.dncTextBox_InputValue.Size = new System.Drawing.Size(45, 20);
            this.dncTextBox_InputValue.TabIndex = 2;
            dncTextBoxProperty2.DataType = dnc.textbox.TextBoxDataType.Hexadecimal;
            dncTextBoxProperty2.FocusedBackColor = System.Drawing.Color.Empty;
            dncTextBoxProperty2.HexadecimalSymbol = dnc.textbox.TextBoxHexadecimalSymbol.Prefix0x;
            dncTextBoxProperty2.MaxValue = ((long)(10000));
            dncTextBoxProperty2.MaxValueR = 10000D;
            dncTextBoxProperty2.MinValue = ((long)(0));
            dncTextBoxProperty2.MinValueR = 0D;
            dncTextBoxProperty2.Text = "0";
            dncTextBoxProperty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dncTextBox_InputValue.TextBoxProperty = dncTextBoxProperty2;
            // 
            // dncLamp_Input
            // 
            dncLampProperty1.ColorOff = System.Drawing.Color.Empty;
            dncLampProperty1.ColorOn = System.Drawing.Color.Lime;
            dncLampProperty1.NumOfLamp = ((short)(8));
            dncLampProperty1.TextCoordinateY = ((short)(-5));
            dncLampProperty1.TextLocation = dnc.lamp.LampTextLocation.BottomRight;
            dncLampProperty1.TextOffColor = System.Drawing.Color.Empty;
            dncLampProperty1.TextOnColor = System.Drawing.Color.Empty;
            dncLampProperty1.TextType = dnc.lamp.LampTextType.BitNo;
            dncLampProperty1.Value = ((uint)(0u));
            this.dncLamp_Input.LampProperty = dncLampProperty1;
            this.dncLamp_Input.Location = new System.Drawing.Point(16, 48);
            this.dncLamp_Input.Name = "dncLamp_Input";
            this.dncLamp_Input.Size = new System.Drawing.Size(304, 44);
            this.dncLamp_Input.TabIndex = 4;
            // 
            // label_Channel
            // 
            this.label_Channel.AutoSize = true;
            this.label_Channel.Location = new System.Drawing.Point(16, 25);
            this.label_Channel.Name = "label_Channel";
            this.label_Channel.Size = new System.Drawing.Size(82, 13);
            this.label_Channel.TabIndex = 0;
            this.label_Channel.Text = "Input Data(Hex)";
            // 
            // groupBox_DI
            // 
            this.groupBox_DI.Controls.Add(this.dncTextBox_InputValue);
            this.groupBox_DI.Controls.Add(this.dncLamp_Input);
            this.groupBox_DI.Controls.Add(this.label_Channel);
            this.groupBox_DI.Location = new System.Drawing.Point(12, 26);
            this.groupBox_DI.Name = "groupBox_DI";
            this.groupBox_DI.Size = new System.Drawing.Size(334, 129);
            this.groupBox_DI.TabIndex = 7;
            this.groupBox_DI.TabStop = false;
            this.groupBox_DI.Text = "Digital Input";
            // 
            // daqInputTask1
            // 
            this.daqInputTask1.AccessType = dnc.daq.DaqInputAccessType.DigitalPort;
            this.daqInputTask1.DeviceName = "DIO000";
            this.daqInputTask1.InputNo = 0;
            this.daqInputTask1.Target = "dncTextBox_InputValue";
            this.daqInputTask1.TaskValueByte = null;
            this.daqInputTask1.TaskValueFloat = null;
            this.daqInputTask1.TaskValueInt = null;
            this.daqInputTask1.Timing = "dncButton_input";
            // 
            // daqInputTask2
            // 
            this.daqInputTask2.AccessType = dnc.daq.DaqInputAccessType.DigitalPort;
            this.daqInputTask2.DeviceName = "DIO000";
            this.daqInputTask2.InputNo = 1;
            this.daqInputTask2.Target = "dncLamp_Input";
            this.daqInputTask2.TaskValueByte = null;
            this.daqInputTask2.TaskValueFloat = null;
            this.daqInputTask2.TaskValueInt = null;
            this.daqInputTask2.Timing = "dncButton_input";
            // 
            // daqOutputTask1
            // 
            this.daqOutputTask1.AccessType = dnc.daq.DaqOutputAccessType.DigitalPort;
            this.daqOutputTask1.DeviceName = "DIO000";
            this.daqOutputTask1.OutputNo = 0;
            this.daqOutputTask1.Source = "dncTextBox_OutputValue";
            this.daqOutputTask1.TaskValueByte = null;
            this.daqOutputTask1.TaskValueFloat = null;
            this.daqOutputTask1.TaskValueInt = null;
            this.daqOutputTask1.Timing = "dncButton_output";
            // 
            // daqInputTask3
            // 
            this.daqInputTask3.AccessType = dnc.daq.DaqInputAccessType.DigitalPort;
            this.daqInputTask3.DeviceName = "DIO000";
            this.daqInputTask3.InputNo = 0;
            this.daqInputTask3.Target = "dncTextBox_InputValue";
            this.daqInputTask3.TaskValueByte = null;
            this.daqInputTask3.TaskValueFloat = null;
            this.daqInputTask3.TaskValueInt = null;
            this.daqInputTask3.Timing = "dncButton_input";
            // 
            // daqInputTask4
            // 
            this.daqInputTask4.AccessType = dnc.daq.DaqInputAccessType.DigitalPort;
            this.daqInputTask4.DeviceName = "DIO000";
            this.daqInputTask4.InputNo = 1;
            this.daqInputTask4.Target = "dncLamp_Input";
            this.daqInputTask4.TaskValueByte = null;
            this.daqInputTask4.TaskValueFloat = null;
            this.daqInputTask4.TaskValueInt = null;
            this.daqInputTask4.Timing = "dncButton_input";
            // 
            // daqOutputTask2
            // 
            this.daqOutputTask2.AccessType = dnc.daq.DaqOutputAccessType.DigitalPort;
            this.daqOutputTask2.DeviceName = "DIO000";
            this.daqOutputTask2.OutputNo = 0;
            this.daqOutputTask2.Source = "dncTextBox_OutputValue";
            this.daqOutputTask2.TaskValueByte = null;
            this.daqOutputTask2.TaskValueFloat = null;
            this.daqOutputTask2.TaskValueInt = null;
            this.daqOutputTask2.Timing = "dncButton_output";
            // 
            // daqDevice1
            // 
            this.daqDevice1.AiInputMethod = ((short)(0));
            this.daqDevice1.AiRange = new short[0];
            this.daqDevice1.AiScanClock = 0F;
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
            this.daqDevice1.DeviceName = "DIO000";
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
            this.daqDevice1.ModelName = "DIO-32DM-PE";
            this.daqDevice1.TabName = "Device00";
            // 
            // SimpleIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 379);
            this.Controls.Add(this.dncButton_output);
            this.Controls.Add(this.groupBox_DO);
            this.Controls.Add(this.dncButton_input);
            this.Controls.Add(this.label_ErrorDetail);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_ErrorDetail);
            this.Controls.Add(this.button_DaqProperty);
            this.Controls.Add(this.groupBox_DI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleIO";
            this.Text = "Digital I/O Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncTextBox_OutputValue)).EndInit();
            this.groupBox_DO.ResumeLayout(false);
            this.groupBox_DO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dncButton_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncTextBox_InputValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dncLamp_Input)).EndInit();
            this.groupBox_DI.ResumeLayout(false);
            this.groupBox_DI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dnc.daq.DncDaq dncDaq1;
        private dnc.button.DncButton dncButton_output;
        private dnc.textbox.DncTextBox dncTextBox_OutputValue;
        private System.Windows.Forms.GroupBox groupBox_DO;
        private System.Windows.Forms.Label label1;
        private dnc.button.DncButton dncButton_input;
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_ErrorDetail;
        private System.Windows.Forms.Button button_DaqProperty;
        private dnc.textbox.DncTextBox dncTextBox_InputValue;
        private dnc.lamp.DncLamp dncLamp_Input;
        private System.Windows.Forms.Label label_Channel;
        private System.Windows.Forms.GroupBox groupBox_DI;
        private dnc.daq.task.DaqInputTask daqInputTask1;
        private dnc.daq.task.DaqInputTask daqInputTask2;
        private dnc.daq.task.DaqOutputTask daqOutputTask1;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DaqInputTask daqInputTask3;
        private dnc.daq.task.DaqInputTask daqInputTask4;
        private dnc.daq.task.DaqOutputTask daqOutputTask2;
    }
}

