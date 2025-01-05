namespace EdgeCount
{
    partial class EdgeCount
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
            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
            this.label_ErrorDetail = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_ErrorDetail = new System.Windows.Forms.TextBox();
            this.button_DaqProperty = new System.Windows.Forms.Button();
            this.textBox_direction3 = new System.Windows.Forms.TextBox();
            this.textBox_direction2 = new System.Windows.Forms.TextBox();
            this.textBox_direction1 = new System.Windows.Forms.TextBox();
            this.textBox_direction0 = new System.Windows.Forms.TextBox();
            this.textBox_Count3 = new System.Windows.Forms.TextBox();
            this.textBox_Count2 = new System.Windows.Forms.TextBox();
            this.textBox_Count1 = new System.Windows.Forms.TextBox();
            this.label_bit3 = new System.Windows.Forms.Label();
            this.label_bit2 = new System.Windows.Forms.Label();
            this.label_bit1 = new System.Windows.Forms.Label();
            this.label_bit0 = new System.Windows.Forms.Label();
            this.textBox_Count0 = new System.Windows.Forms.TextBox();
            this.label_EdgeDirection = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            this.groupBox_Edge = new System.Windows.Forms.GroupBox();
            this.dioEdge1 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge2 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge3 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge4 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge5 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge6 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge7 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge8 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge9 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge10 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge11 = new dnc.daq.task.DioEdge(this.components);
            this.dioEdge12 = new dnc.daq.task.DioEdge(this.components);
            this.daqDevice1 = new dnc.daq.task.DaqDevice(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
            this.groupBox_Edge.SuspendLayout();
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
            dncDaqProperty1.TaskMode = dnc.daq.DaqTaskMode.AdvancedMode;
            this.dncDaq1.DaqProperty = dncDaqProperty1;
            this.dncDaq1.DncName = "dncDaq1";
            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
            this.dncDaq1.OnEdge += new dnc.daq.EdgeEventHandler(this.dncDaq1_OnEdge);
            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
            // 
            // label_ErrorDetail
            // 
            this.label_ErrorDetail.AutoSize = true;
            this.label_ErrorDetail.Location = new System.Drawing.Point(13, 159);
            this.label_ErrorDetail.Name = "label_ErrorDetail";
            this.label_ErrorDetail.Size = new System.Drawing.Size(64, 13);
            this.label_ErrorDetail.TabIndex = 9;
            this.label_ErrorDetail.Text = "Error Details";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(438, 184);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(101, 25);
            this.button_Exit.TabIndex = 8;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_ErrorDetail
            // 
            this.textBox_ErrorDetail.Location = new System.Drawing.Point(15, 184);
            this.textBox_ErrorDetail.Multiline = true;
            this.textBox_ErrorDetail.Name = "textBox_ErrorDetail";
            this.textBox_ErrorDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ErrorDetail.Size = new System.Drawing.Size(407, 90);
            this.textBox_ErrorDetail.TabIndex = 7;
            this.textBox_ErrorDetail.WordWrap = false;
            // 
            // button_DaqProperty
            // 
            this.button_DaqProperty.Location = new System.Drawing.Point(438, 16);
            this.button_DaqProperty.Name = "button_DaqProperty";
            this.button_DaqProperty.Size = new System.Drawing.Size(101, 25);
            this.button_DaqProperty.TabIndex = 6;
            this.button_DaqProperty.Text = "DncDaq Setting";
            this.button_DaqProperty.UseVisualStyleBackColor = true;
            this.button_DaqProperty.Click += new System.EventHandler(this.button_DaqProperty_Click);
            // 
            // textBox_direction3
            // 
            this.textBox_direction3.Location = new System.Drawing.Point(99, 76);
            this.textBox_direction3.Name = "textBox_direction3";
            this.textBox_direction3.Size = new System.Drawing.Size(60, 20);
            this.textBox_direction3.TabIndex = 18;
            // 
            // textBox_direction2
            // 
            this.textBox_direction2.Location = new System.Drawing.Point(179, 76);
            this.textBox_direction2.Name = "textBox_direction2";
            this.textBox_direction2.Size = new System.Drawing.Size(60, 20);
            this.textBox_direction2.TabIndex = 17;
            // 
            // textBox_direction1
            // 
            this.textBox_direction1.Location = new System.Drawing.Point(253, 76);
            this.textBox_direction1.Name = "textBox_direction1";
            this.textBox_direction1.Size = new System.Drawing.Size(60, 20);
            this.textBox_direction1.TabIndex = 16;
            // 
            // textBox_direction0
            // 
            this.textBox_direction0.Location = new System.Drawing.Point(327, 76);
            this.textBox_direction0.Name = "textBox_direction0";
            this.textBox_direction0.Size = new System.Drawing.Size(60, 20);
            this.textBox_direction0.TabIndex = 15;
            // 
            // textBox_Count3
            // 
            this.textBox_Count3.Location = new System.Drawing.Point(99, 39);
            this.textBox_Count3.Name = "textBox_Count3";
            this.textBox_Count3.Size = new System.Drawing.Size(60, 20);
            this.textBox_Count3.TabIndex = 14;
            this.textBox_Count3.Text = "0";
            this.textBox_Count3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Count2
            // 
            this.textBox_Count2.Location = new System.Drawing.Point(179, 39);
            this.textBox_Count2.Name = "textBox_Count2";
            this.textBox_Count2.Size = new System.Drawing.Size(60, 20);
            this.textBox_Count2.TabIndex = 13;
            this.textBox_Count2.Text = "0";
            this.textBox_Count2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_Count1
            // 
            this.textBox_Count1.Location = new System.Drawing.Point(253, 39);
            this.textBox_Count1.Name = "textBox_Count1";
            this.textBox_Count1.Size = new System.Drawing.Size(60, 20);
            this.textBox_Count1.TabIndex = 12;
            this.textBox_Count1.Text = "0";
            this.textBox_Count1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_bit3
            // 
            this.label_bit3.AutoSize = true;
            this.label_bit3.Location = new System.Drawing.Point(135, 21);
            this.label_bit3.Name = "label_bit3";
            this.label_bit3.Size = new System.Drawing.Size(24, 13);
            this.label_bit3.TabIndex = 11;
            this.label_bit3.Text = "bit3";
            // 
            // label_bit2
            // 
            this.label_bit2.AutoSize = true;
            this.label_bit2.Location = new System.Drawing.Point(215, 21);
            this.label_bit2.Name = "label_bit2";
            this.label_bit2.Size = new System.Drawing.Size(24, 13);
            this.label_bit2.TabIndex = 10;
            this.label_bit2.Text = "bit2";
            // 
            // label_bit1
            // 
            this.label_bit1.AutoSize = true;
            this.label_bit1.Location = new System.Drawing.Point(289, 21);
            this.label_bit1.Name = "label_bit1";
            this.label_bit1.Size = new System.Drawing.Size(24, 13);
            this.label_bit1.TabIndex = 9;
            this.label_bit1.Text = "bit1";
            // 
            // label_bit0
            // 
            this.label_bit0.AutoSize = true;
            this.label_bit0.Location = new System.Drawing.Point(363, 21);
            this.label_bit0.Name = "label_bit0";
            this.label_bit0.Size = new System.Drawing.Size(24, 13);
            this.label_bit0.TabIndex = 8;
            this.label_bit0.Text = "bit0";
            // 
            // textBox_Count0
            // 
            this.textBox_Count0.Location = new System.Drawing.Point(327, 39);
            this.textBox_Count0.Name = "textBox_Count0";
            this.textBox_Count0.Size = new System.Drawing.Size(60, 20);
            this.textBox_Count0.TabIndex = 7;
            this.textBox_Count0.Text = "0";
            this.textBox_Count0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_EdgeDirection
            // 
            this.label_EdgeDirection.AutoSize = true;
            this.label_EdgeDirection.Location = new System.Drawing.Point(18, 79);
            this.label_EdgeDirection.Name = "label_EdgeDirection";
            this.label_EdgeDirection.Size = new System.Drawing.Size(77, 13);
            this.label_EdgeDirection.TabIndex = 6;
            this.label_EdgeDirection.Text = "Edge Direction";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(31, 42);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(64, 13);
            this.label_Count.TabIndex = 5;
            this.label_Count.Text = "Count value";
            // 
            // groupBox_Edge
            // 
            this.groupBox_Edge.Controls.Add(this.textBox_direction3);
            this.groupBox_Edge.Controls.Add(this.textBox_direction2);
            this.groupBox_Edge.Controls.Add(this.textBox_direction1);
            this.groupBox_Edge.Controls.Add(this.textBox_direction0);
            this.groupBox_Edge.Controls.Add(this.textBox_Count3);
            this.groupBox_Edge.Controls.Add(this.textBox_Count2);
            this.groupBox_Edge.Controls.Add(this.textBox_Count1);
            this.groupBox_Edge.Controls.Add(this.label_bit3);
            this.groupBox_Edge.Controls.Add(this.label_bit2);
            this.groupBox_Edge.Controls.Add(this.label_bit1);
            this.groupBox_Edge.Controls.Add(this.label_bit0);
            this.groupBox_Edge.Controls.Add(this.textBox_Count0);
            this.groupBox_Edge.Controls.Add(this.label_EdgeDirection);
            this.groupBox_Edge.Controls.Add(this.label_Count);
            this.groupBox_Edge.Location = new System.Drawing.Point(15, 25);
            this.groupBox_Edge.Name = "groupBox_Edge";
            this.groupBox_Edge.Size = new System.Drawing.Size(407, 117);
            this.groupBox_Edge.TabIndex = 5;
            this.groupBox_Edge.TabStop = false;
            this.groupBox_Edge.Text = "Edge Monitoring";
            // 
            // dioEdge1
            // 
            this.dioEdge1.EdgeNo = 0;
            // 
            // dioEdge2
            // 
            this.dioEdge2.EdgeBitString = "1";
            this.dioEdge2.EdgeNo = 1;
            // 
            // dioEdge3
            // 
            this.dioEdge3.EdgeBitString = "2";
            this.dioEdge3.EdgeNo = 2;
            // 
            // dioEdge4
            // 
            this.dioEdge4.EdgeBitString = "3";
            this.dioEdge4.EdgeNo = 3;
            // 
            // dioEdge5
            // 
            this.dioEdge5.EdgeNo = 0;
            // 
            // dioEdge6
            // 
            this.dioEdge6.EdgeBitString = "1";
            this.dioEdge6.EdgeNo = 1;
            // 
            // dioEdge7
            // 
            this.dioEdge7.EdgeBitString = "2";
            this.dioEdge7.EdgeNo = 2;
            // 
            // dioEdge8
            // 
            this.dioEdge8.EdgeBitString = "3";
            this.dioEdge8.EdgeNo = 3;
            // 
            // dioEdge9
            // 
            this.dioEdge9.EdgeNo = 0;
            // 
            // dioEdge10
            // 
            this.dioEdge10.EdgeBitString = "1";
            this.dioEdge10.EdgeNo = 1;
            // 
            // dioEdge11
            // 
            this.dioEdge11.EdgeBitString = "2";
            this.dioEdge11.EdgeNo = 2;
            // 
            // dioEdge12
            // 
            this.dioEdge12.EdgeBitString = "3";
            this.dioEdge12.EdgeNo = 3;
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
            this.daqDevice1.Edge.Add(this.dioEdge9);
            this.daqDevice1.Edge.Add(this.dioEdge10);
            this.daqDevice1.Edge.Add(this.dioEdge11);
            this.daqDevice1.Edge.Add(this.dioEdge12);
            this.daqDevice1.ModelName = "DIO-32DM-PE";
            this.daqDevice1.TabName = "Device00";
            // 
            // EdgeCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 291);
            this.Controls.Add(this.label_ErrorDetail);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.textBox_ErrorDetail);
            this.Controls.Add(this.button_DaqProperty);
            this.Controls.Add(this.groupBox_Edge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdgeCount";
            this.Text = "Edge Detection Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
            this.groupBox_Edge.ResumeLayout(false);
            this.groupBox_Edge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dnc.daq.DncDaq dncDaq1;
        private System.Windows.Forms.Label label_ErrorDetail;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_ErrorDetail;
        private System.Windows.Forms.Button button_DaqProperty;
        private System.Windows.Forms.TextBox textBox_direction3;
        private System.Windows.Forms.TextBox textBox_direction2;
        private System.Windows.Forms.TextBox textBox_direction1;
        private System.Windows.Forms.TextBox textBox_direction0;
        private System.Windows.Forms.TextBox textBox_Count3;
        private System.Windows.Forms.TextBox textBox_Count2;
        private System.Windows.Forms.TextBox textBox_Count1;
        private System.Windows.Forms.Label label_bit3;
        private System.Windows.Forms.Label label_bit2;
        private System.Windows.Forms.Label label_bit1;
        private System.Windows.Forms.Label label_bit0;
        private System.Windows.Forms.TextBox textBox_Count0;
        private System.Windows.Forms.Label label_EdgeDirection;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.GroupBox groupBox_Edge;
        private dnc.daq.task.DioEdge dioEdge1;
        private dnc.daq.task.DioEdge dioEdge2;
        private dnc.daq.task.DioEdge dioEdge3;
        private dnc.daq.task.DioEdge dioEdge4;
        private dnc.daq.task.DioEdge dioEdge5;
        private dnc.daq.task.DioEdge dioEdge6;
        private dnc.daq.task.DioEdge dioEdge7;
        private dnc.daq.task.DioEdge dioEdge8;
        private dnc.daq.task.DaqDevice daqDevice1;
        private dnc.daq.task.DioEdge dioEdge9;
        private dnc.daq.task.DioEdge dioEdge10;
        private dnc.daq.task.DioEdge dioEdge11;
        private dnc.daq.task.DioEdge dioEdge12;
    }
}

