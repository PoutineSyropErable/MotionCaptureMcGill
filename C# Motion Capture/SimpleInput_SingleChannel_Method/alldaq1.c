./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            // dncDaq1
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            this.dncDaq1.DaqProperty = dncDaqProperty1;
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            this.dncDaq1.DncName = "dncDaq1";
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
./default/SimpleInput_SingleChannel_Method.Designer_default.cs:        private dnc.daq.DncDaq dncDaq1;
./default/SimpleInput_SingleChannel_Method_default.cs:            dncDaq1.ShowProperty();
./default/SimpleInput_SingleChannel_Method_default.cs:        private void dncDaq1_OnInit(object sender, EventArgs e)
./default/SimpleInput_SingleChannel_Method_default.cs:            if (dncDaq1.DaqProperty.Device.Count <= 0)
./default/SimpleInput_SingleChannel_Method_default.cs:            if (dncDaq1.DaqProperty.InputTask.Count <= 0)
./default/SimpleInput_SingleChannel_Method_default.cs:        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
./default/SimpleInput_SingleChannel_Method_default.cs:            ret = dncDaq1.DaqErrorString(DeviceNo, e.Error, out error_string);
./default/SimpleInput_SingleChannel_Method_default.cs:            ret1 = dncDaq1.AiInputChannel(device_no, channel, out aidata);
./default/SimpleInput_SingleChannel_Method_default.cs:                ret2 = dncDaq1.DaqErrorString(device_no, ret1, out error_string);
./SimpleInput_SingleChannel_Method.cs:            dncDaq1.ShowProperty();
./SimpleInput_SingleChannel_Method.cs:        private void dncDaq1_OnInit(object sender, EventArgs e)
./SimpleInput_SingleChannel_Method.cs:            if (dncDaq1.DaqProperty.Device.Count <= 0)
./SimpleInput_SingleChannel_Method.cs:            if (dncDaq1.DaqProperty.InputTask.Count <= 0)
./SimpleInput_SingleChannel_Method.cs:        private void dncDaq1_OnError(object sender, short DeviceNo, dnc.common.DncErrorEventArgs e)
./SimpleInput_SingleChannel_Method.cs:            ret = dncDaq1.DaqErrorString(DeviceNo, e.Error, out error_string);
./SimpleInput_SingleChannel_Method.cs:            ret1 = dncDaq1.AiInputChannel(device_no, channel, out aidata);
./SimpleInput_SingleChannel_Method.cs:                ret2 = dncDaq1.DaqErrorString(device_no, ret1, out error_string);
./SimpleInput_SingleChannel_Method.Designer.cs:            this.dncDaq1 = new dnc.daq.DncDaq(this.components);
./SimpleInput_SingleChannel_Method.Designer.cs:            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).BeginInit();
./SimpleInput_SingleChannel_Method.Designer.cs:            // dncDaq1
./SimpleInput_SingleChannel_Method.Designer.cs:            this.dncDaq1.DaqProperty = dncDaqProperty1;
./SimpleInput_SingleChannel_Method.Designer.cs:            this.dncDaq1.DncName = "dncDaq1";
./SimpleInput_SingleChannel_Method.Designer.cs:            this.dncDaq1.OnError += new dnc.common.DncDaqErrorEventHandler(this.dncDaq1_OnError);
./SimpleInput_SingleChannel_Method.Designer.cs:            this.dncDaq1.OnInit += new System.EventHandler(this.dncDaq1_OnInit);
./SimpleInput_SingleChannel_Method.Designer.cs:            ((System.ComponentModel.ISupportInitialize)(this.dncDaq1)).EndInit();
./SimpleInput_SingleChannel_Method.Designer.cs:        private dnc.daq.DncDaq dncDaq1;
./SimpleInput_SingleChannel_Method.resx:  <metadata name="dncDaq1.TrayLocation" type="System.Drawing.Point, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
