namespace Robot
{
    partial class Robot_Interface
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot_Interface));
            this.HostName_tb = new System.Windows.Forms.TextBox();
            this.Connect_btn = new System.Windows.Forms.Button();
            this.Connect_gb = new System.Windows.Forms.GroupBox();
            this.Connect_lbl = new System.Windows.Forms.Label();
            this.Alarm_gb = new System.Windows.Forms.GroupBox();
            this.Alarm_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CurrentPosition_gb = new System.Windows.Forms.GroupBox();
            this.Joint_lbl = new System.Windows.Forms.Label();
            this.Xyzwpr_lbl = new System.Windows.Forms.Label();
            this.Register_gb = new System.Windows.Forms.GroupBox();
            this.RegisterSet_btn = new System.Windows.Forms.Button();
            this.R2Set_lbl = new System.Windows.Forms.Label();
            this.R2Set_tb = new System.Windows.Forms.TextBox();
            this.R1Set_tb = new System.Windows.Forms.TextBox();
            this.R1Set_lbl = new System.Windows.Forms.Label();
            this.Register_lbl = new System.Windows.Forms.Label();
            this.Override_gb = new System.Windows.Forms.GroupBox();
            this.Override_lbl = new System.Windows.Forms.Label();
            this.PositionSet_gb = new System.Windows.Forms.GroupBox();
            this.VelocityRange_lbl = new System.Windows.Forms.Label();
            this.VelocitySet_tb = new System.Windows.Forms.TextBox();
            this.Velocity_lbl = new System.Windows.Forms.Label();
            this.PositionSet_cb = new System.Windows.Forms.ComboBox();
            this.BackTotheInitialStatus_btn = new System.Windows.Forms.Button();
            this.SafeRange_lbl = new System.Windows.Forms.Label();
            this.GetNowPosition_btn = new System.Windows.Forms.Button();
            this.SetPosition_btn = new System.Windows.Forms.Button();
            this.RJ6Set_tb = new System.Windows.Forms.TextBox();
            this.PJ5Set_tb = new System.Windows.Forms.TextBox();
            this.WJ4Set_tb = new System.Windows.Forms.TextBox();
            this.ZJ3Set_tb = new System.Windows.Forms.TextBox();
            this.YJ2Set_tb = new System.Windows.Forms.TextBox();
            this.XJ1Set_tb = new System.Windows.Forms.TextBox();
            this.RJ6Set_lbl = new System.Windows.Forms.Label();
            this.PJ5Set_lbl = new System.Windows.Forms.Label();
            this.WJ4Set_lbl = new System.Windows.Forms.Label();
            this.ZJ3Set_lbl = new System.Windows.Forms.Label();
            this.YJ2Set_lbl = new System.Windows.Forms.Label();
            this.XJ1Set_lbl = new System.Windows.Forms.Label();
            this.PositionMove_gb = new System.Windows.Forms.GroupBox();
            this.RJ6Positive_btn = new System.Windows.Forms.Button();
            this.RJ6Negative_btn = new System.Windows.Forms.Button();
            this.PJ5Positive_btn = new System.Windows.Forms.Button();
            this.PJ5Negative_btn = new System.Windows.Forms.Button();
            this.WJ4Positive_btn = new System.Windows.Forms.Button();
            this.WJ4Negative_btn = new System.Windows.Forms.Button();
            this.ZJ3Positive_btn = new System.Windows.Forms.Button();
            this.ZJ3Negative_btn = new System.Windows.Forms.Button();
            this.YJ2Positive_btn = new System.Windows.Forms.Button();
            this.YJ2Negative_btn = new System.Windows.Forms.Button();
            this.PositionMove_cb = new System.Windows.Forms.ComboBox();
            this.XJ1Positive_btn = new System.Windows.Forms.Button();
            this.XJ1Negative_btn = new System.Windows.Forms.Button();
            this.IO_gb = new System.Windows.Forms.GroupBox();
            this.Output_pnl = new System.Windows.Forms.Panel();
            this.P07_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Bit_lbl = new System.Windows.Forms.Label();
            this.P06_btn = new System.Windows.Forms.Button();
            this.Bit0_lbl = new System.Windows.Forms.Label();
            this.P05_btn = new System.Windows.Forms.Button();
            this.Bit1_lbl = new System.Windows.Forms.Label();
            this.P04_btn = new System.Windows.Forms.Button();
            this.Bit2_lbl = new System.Windows.Forms.Label();
            this.P03_btn = new System.Windows.Forms.Button();
            this.Bit3_lbl = new System.Windows.Forms.Label();
            this.P02_btn = new System.Windows.Forms.Button();
            this.Bit4_lbl = new System.Windows.Forms.Label();
            this.P01_btn = new System.Windows.Forms.Button();
            this.Bit5_lbl = new System.Windows.Forms.Label();
            this.P00_btn = new System.Windows.Forms.Button();
            this.P17_btn = new System.Windows.Forms.Button();
            this.Bit6_lbl = new System.Windows.Forms.Label();
            this.P16_btn = new System.Windows.Forms.Button();
            this.Bit7_lbl = new System.Windows.Forms.Label();
            this.P15_btn = new System.Windows.Forms.Button();
            this.Port1_lbl = new System.Windows.Forms.Label();
            this.P14_btn = new System.Windows.Forms.Button();
            this.Port0_lbl = new System.Windows.Forms.Label();
            this.P13_btn = new System.Windows.Forms.Button();
            this.P12_btn = new System.Windows.Forms.Button();
            this.P10_btn = new System.Windows.Forms.Button();
            this.P11_btn = new System.Windows.Forms.Button();
            this.IOInitialize_lbl = new System.Windows.Forms.Label();
            this.IOInitialize_btn = new System.Windows.Forms.Button();
            this.instantDoCtrl1 = new Automation.BDaq.InstantDoCtrl(this.components);
            this.Connect_gb.SuspendLayout();
            this.Alarm_gb.SuspendLayout();
            this.CurrentPosition_gb.SuspendLayout();
            this.Register_gb.SuspendLayout();
            this.Override_gb.SuspendLayout();
            this.PositionSet_gb.SuspendLayout();
            this.PositionMove_gb.SuspendLayout();
            this.IO_gb.SuspendLayout();
            this.Output_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostName_tb
            // 
            this.HostName_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HostName_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HostName_tb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HostName_tb.Location = new System.Drawing.Point(10, 63);
            this.HostName_tb.Name = "HostName_tb";
            this.HostName_tb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HostName_tb.Size = new System.Drawing.Size(110, 27);
            this.HostName_tb.TabIndex = 0;
            this.HostName_tb.Text = "127.0.0.1";
            this.HostName_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Connect_btn
            // 
            this.Connect_btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Connect_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Connect_btn.Location = new System.Drawing.Point(10, 96);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(110, 27);
            this.Connect_btn.TabIndex = 1;
            this.Connect_btn.Text = "Connect";
            this.Connect_btn.UseVisualStyleBackColor = true;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // Connect_gb
            // 
            this.Connect_gb.Controls.Add(this.Connect_lbl);
            this.Connect_gb.Controls.Add(this.HostName_tb);
            this.Connect_gb.Controls.Add(this.Connect_btn);
            this.Connect_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Connect_gb.Location = new System.Drawing.Point(12, 12);
            this.Connect_gb.Name = "Connect_gb";
            this.Connect_gb.Size = new System.Drawing.Size(141, 141);
            this.Connect_gb.TabIndex = 3;
            this.Connect_gb.TabStop = false;
            this.Connect_gb.Text = "ConnectStatus";
            // 
            // Connect_lbl
            // 
            this.Connect_lbl.AutoSize = true;
            this.Connect_lbl.Location = new System.Drawing.Point(6, 29);
            this.Connect_lbl.Name = "Connect_lbl";
            this.Connect_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Connect_lbl.Size = new System.Drawing.Size(118, 21);
            this.Connect_lbl.TabIndex = 5;
            this.Connect_lbl.Text = "Disconnected";
            // 
            // Alarm_gb
            // 
            this.Alarm_gb.Controls.Add(this.Alarm_lbl);
            this.Alarm_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Alarm_gb.Location = new System.Drawing.Point(159, 12);
            this.Alarm_gb.Name = "Alarm_gb";
            this.Alarm_gb.Size = new System.Drawing.Size(538, 141);
            this.Alarm_gb.TabIndex = 4;
            this.Alarm_gb.TabStop = false;
            this.Alarm_gb.Text = "AlarmStatus";
            // 
            // Alarm_lbl
            // 
            this.Alarm_lbl.AutoSize = true;
            this.Alarm_lbl.Location = new System.Drawing.Point(6, 29);
            this.Alarm_lbl.Name = "Alarm_lbl";
            this.Alarm_lbl.Size = new System.Drawing.Size(0, 21);
            this.Alarm_lbl.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CurrentPosition_gb
            // 
            this.CurrentPosition_gb.Controls.Add(this.Joint_lbl);
            this.CurrentPosition_gb.Controls.Add(this.Xyzwpr_lbl);
            this.CurrentPosition_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CurrentPosition_gb.Location = new System.Drawing.Point(548, 253);
            this.CurrentPosition_gb.Name = "CurrentPosition_gb";
            this.CurrentPosition_gb.Size = new System.Drawing.Size(302, 184);
            this.CurrentPosition_gb.TabIndex = 5;
            this.CurrentPosition_gb.TabStop = false;
            this.CurrentPosition_gb.Text = "CurrentPosition";
            // 
            // Joint_lbl
            // 
            this.Joint_lbl.AutoSize = true;
            this.Joint_lbl.Location = new System.Drawing.Point(153, 29);
            this.Joint_lbl.Name = "Joint_lbl";
            this.Joint_lbl.Size = new System.Drawing.Size(73, 147);
            this.Joint_lbl.TabIndex = 19;
            this.Joint_lbl.Text = "軸座標\r\nJ1 :\r\nJ2 :\r\nJ3 :\r\nJ4 :\r\nJ5 :\r\nJ6 :";
            // 
            // Xyzwpr_lbl
            // 
            this.Xyzwpr_lbl.AutoSize = true;
            this.Xyzwpr_lbl.Location = new System.Drawing.Point(6, 29);
            this.Xyzwpr_lbl.Name = "Xyzwpr_lbl";
            this.Xyzwpr_lbl.Size = new System.Drawing.Size(94, 147);
            this.Xyzwpr_lbl.TabIndex = 18;
            this.Xyzwpr_lbl.Text = "卡式座標\r\nX :\r\nY :\r\nZ :\r\nW:\r\nP :\r\nR :";
            // 
            // Register_gb
            // 
            this.Register_gb.Controls.Add(this.RegisterSet_btn);
            this.Register_gb.Controls.Add(this.R2Set_lbl);
            this.Register_gb.Controls.Add(this.R2Set_tb);
            this.Register_gb.Controls.Add(this.R1Set_tb);
            this.Register_gb.Controls.Add(this.R1Set_lbl);
            this.Register_gb.Controls.Add(this.Register_lbl);
            this.Register_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Register_gb.Location = new System.Drawing.Point(703, 12);
            this.Register_gb.Name = "Register_gb";
            this.Register_gb.Size = new System.Drawing.Size(147, 238);
            this.Register_gb.TabIndex = 6;
            this.Register_gb.TabStop = false;
            this.Register_gb.Text = "Register";
            // 
            // RegisterSet_btn
            // 
            this.RegisterSet_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RegisterSet_btn.Location = new System.Drawing.Point(11, 143);
            this.RegisterSet_btn.Name = "RegisterSet_btn";
            this.RegisterSet_btn.Size = new System.Drawing.Size(101, 38);
            this.RegisterSet_btn.TabIndex = 5;
            this.RegisterSet_btn.Text = "Register Set";
            this.RegisterSet_btn.UseVisualStyleBackColor = true;
            this.RegisterSet_btn.Click += new System.EventHandler(this.RegisterSet_btn_Click);
            // 
            // R2Set_lbl
            // 
            this.R2Set_lbl.AutoSize = true;
            this.R2Set_lbl.Location = new System.Drawing.Point(7, 114);
            this.R2Set_lbl.Name = "R2Set_lbl";
            this.R2Set_lbl.Size = new System.Drawing.Size(59, 21);
            this.R2Set_lbl.TabIndex = 4;
            this.R2Set_lbl.Text = "R2   =";
            // 
            // R2Set_tb
            // 
            this.R2Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R2Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.R2Set_tb.Location = new System.Drawing.Point(75, 114);
            this.R2Set_tb.Name = "R2Set_tb";
            this.R2Set_tb.Size = new System.Drawing.Size(37, 23);
            this.R2Set_tb.TabIndex = 3;
            this.R2Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R2Set_tb_KeyPress);
            // 
            // R1Set_tb
            // 
            this.R1Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R1Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.R1Set_tb.Location = new System.Drawing.Point(75, 85);
            this.R1Set_tb.Name = "R1Set_tb";
            this.R1Set_tb.Size = new System.Drawing.Size(37, 23);
            this.R1Set_tb.TabIndex = 2;
            this.R1Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.R1Set_tb_KeyPress);
            // 
            // R1Set_lbl
            // 
            this.R1Set_lbl.AutoSize = true;
            this.R1Set_lbl.Location = new System.Drawing.Point(7, 85);
            this.R1Set_lbl.Name = "R1Set_lbl";
            this.R1Set_lbl.Size = new System.Drawing.Size(59, 21);
            this.R1Set_lbl.TabIndex = 1;
            this.R1Set_lbl.Text = "R1   =";
            // 
            // Register_lbl
            // 
            this.Register_lbl.AutoSize = true;
            this.Register_lbl.Location = new System.Drawing.Point(7, 29);
            this.Register_lbl.Name = "Register_lbl";
            this.Register_lbl.Size = new System.Drawing.Size(59, 42);
            this.Register_lbl.TabIndex = 0;
            this.Register_lbl.Text = "R1   =\r\nR2   =";
            // 
            // Override_gb
            // 
            this.Override_gb.Controls.Add(this.Override_lbl);
            this.Override_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Override_gb.Location = new System.Drawing.Point(548, 159);
            this.Override_gb.Name = "Override_gb";
            this.Override_gb.Size = new System.Drawing.Size(149, 91);
            this.Override_gb.TabIndex = 7;
            this.Override_gb.TabStop = false;
            this.Override_gb.Text = "Override";
            // 
            // Override_lbl
            // 
            this.Override_lbl.AutoSize = true;
            this.Override_lbl.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Override_lbl.Location = new System.Drawing.Point(7, 33);
            this.Override_lbl.Name = "Override_lbl";
            this.Override_lbl.Size = new System.Drawing.Size(0, 32);
            this.Override_lbl.TabIndex = 0;
            // 
            // PositionSet_gb
            // 
            this.PositionSet_gb.Controls.Add(this.VelocityRange_lbl);
            this.PositionSet_gb.Controls.Add(this.VelocitySet_tb);
            this.PositionSet_gb.Controls.Add(this.Velocity_lbl);
            this.PositionSet_gb.Controls.Add(this.PositionSet_cb);
            this.PositionSet_gb.Controls.Add(this.BackTotheInitialStatus_btn);
            this.PositionSet_gb.Controls.Add(this.SafeRange_lbl);
            this.PositionSet_gb.Controls.Add(this.GetNowPosition_btn);
            this.PositionSet_gb.Controls.Add(this.SetPosition_btn);
            this.PositionSet_gb.Controls.Add(this.RJ6Set_tb);
            this.PositionSet_gb.Controls.Add(this.PJ5Set_tb);
            this.PositionSet_gb.Controls.Add(this.WJ4Set_tb);
            this.PositionSet_gb.Controls.Add(this.ZJ3Set_tb);
            this.PositionSet_gb.Controls.Add(this.YJ2Set_tb);
            this.PositionSet_gb.Controls.Add(this.XJ1Set_tb);
            this.PositionSet_gb.Controls.Add(this.RJ6Set_lbl);
            this.PositionSet_gb.Controls.Add(this.PJ5Set_lbl);
            this.PositionSet_gb.Controls.Add(this.WJ4Set_lbl);
            this.PositionSet_gb.Controls.Add(this.ZJ3Set_lbl);
            this.PositionSet_gb.Controls.Add(this.YJ2Set_lbl);
            this.PositionSet_gb.Controls.Add(this.XJ1Set_lbl);
            this.PositionSet_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PositionSet_gb.Location = new System.Drawing.Point(249, 159);
            this.PositionSet_gb.Name = "PositionSet_gb";
            this.PositionSet_gb.Size = new System.Drawing.Size(293, 278);
            this.PositionSet_gb.TabIndex = 8;
            this.PositionSet_gb.TabStop = false;
            this.PositionSet_gb.Text = "Position Set";
            // 
            // VelocityRange_lbl
            // 
            this.VelocityRange_lbl.AutoSize = true;
            this.VelocityRange_lbl.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VelocityRange_lbl.Location = new System.Drawing.Point(163, 142);
            this.VelocityRange_lbl.Name = "VelocityRange_lbl";
            this.VelocityRange_lbl.Size = new System.Drawing.Size(124, 57);
            this.VelocityRange_lbl.TabIndex = 17;
            this.VelocityRange_lbl.Text = "輸入100~500\r\n(預設值為100)\r\n   (mm/sec)↓";
            // 
            // VelocitySet_tb
            // 
            this.VelocitySet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocitySet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.VelocitySet_tb.Location = new System.Drawing.Point(163, 204);
            this.VelocitySet_tb.Name = "VelocitySet_tb";
            this.VelocitySet_tb.Size = new System.Drawing.Size(123, 23);
            this.VelocitySet_tb.TabIndex = 16;
            this.VelocitySet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VelocitySet_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Velocity_tb_KeyPress);
            // 
            // Velocity_lbl
            // 
            this.Velocity_lbl.AutoSize = true;
            this.Velocity_lbl.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Velocity_lbl.Location = new System.Drawing.Point(163, 119);
            this.Velocity_lbl.Name = "Velocity_lbl";
            this.Velocity_lbl.Size = new System.Drawing.Size(81, 19);
            this.Velocity_lbl.TabIndex = 15;
            this.Velocity_lbl.Text = "Velocity :";
            // 
            // PositionSet_cb
            // 
            this.PositionSet_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionSet_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PositionSet_cb.FormattingEnabled = true;
            this.PositionSet_cb.Items.AddRange(new object[] {
            "卡式座標",
            "軸座標"});
            this.PositionSet_cb.Location = new System.Drawing.Point(13, 29);
            this.PositionSet_cb.Name = "PositionSet_cb";
            this.PositionSet_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PositionSet_cb.Size = new System.Drawing.Size(144, 24);
            this.PositionSet_cb.TabIndex = 11;
            this.PositionSet_cb.SelectedIndexChanged += new System.EventHandler(this.PositionSet_cb_SelectedIndexChanged);
            // 
            // BackTotheInitialStatus_btn
            // 
            this.BackTotheInitialStatus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackTotheInitialStatus_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BackTotheInitialStatus_btn.Location = new System.Drawing.Point(163, 233);
            this.BackTotheInitialStatus_btn.Name = "BackTotheInitialStatus_btn";
            this.BackTotheInitialStatus_btn.Size = new System.Drawing.Size(123, 40);
            this.BackTotheInitialStatus_btn.TabIndex = 10;
            this.BackTotheInitialStatus_btn.Text = "Back To The Initial Status";
            this.BackTotheInitialStatus_btn.UseVisualStyleBackColor = true;
            this.BackTotheInitialStatus_btn.Click += new System.EventHandler(this.BackTotheInitialStatus_btn_Click);
            // 
            // SafeRange_lbl
            // 
            this.SafeRange_lbl.AutoSize = true;
            this.SafeRange_lbl.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SafeRange_lbl.Location = new System.Drawing.Point(163, 29);
            this.SafeRange_lbl.Name = "SafeRange_lbl";
            this.SafeRange_lbl.Size = new System.Drawing.Size(117, 84);
            this.SafeRange_lbl.TabIndex = 14;
            this.SafeRange_lbl.Text = "SafeRange\r\nX : 0~700\r\nY : -500~600\r\nZ : -130~500";
            // 
            // GetNowPosition_btn
            // 
            this.GetNowPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GetNowPosition_btn.Location = new System.Drawing.Point(6, 233);
            this.GetNowPosition_btn.Name = "GetNowPosition_btn";
            this.GetNowPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.GetNowPosition_btn.TabIndex = 12;
            this.GetNowPosition_btn.Text = "Get Now Position";
            this.GetNowPosition_btn.UseVisualStyleBackColor = true;
            this.GetNowPosition_btn.Click += new System.EventHandler(this.GetNowPosition_btn_Click);
            // 
            // SetPosition_btn
            // 
            this.SetPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetPosition_btn.Location = new System.Drawing.Point(85, 233);
            this.SetPosition_btn.Name = "SetPosition_btn";
            this.SetPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.SetPosition_btn.TabIndex = 13;
            this.SetPosition_btn.Text = "Set Position";
            this.SetPosition_btn.UseVisualStyleBackColor = true;
            this.SetPosition_btn.Click += new System.EventHandler(this.SetPosition_btn_Click);
            // 
            // RJ6Set_tb
            // 
            this.RJ6Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RJ6Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RJ6Set_tb.Location = new System.Drawing.Point(49, 204);
            this.RJ6Set_tb.Name = "RJ6Set_tb";
            this.RJ6Set_tb.Size = new System.Drawing.Size(108, 23);
            this.RJ6Set_tb.TabIndex = 11;
            this.RJ6Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RJ6Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RJ6Set_tb_KeyPress);
            // 
            // PJ5Set_tb
            // 
            this.PJ5Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PJ5Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PJ5Set_tb.Location = new System.Drawing.Point(49, 175);
            this.PJ5Set_tb.Name = "PJ5Set_tb";
            this.PJ5Set_tb.Size = new System.Drawing.Size(108, 23);
            this.PJ5Set_tb.TabIndex = 10;
            this.PJ5Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PJ5Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PJ5Set_tb_KeyPress);
            // 
            // WJ4Set_tb
            // 
            this.WJ4Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WJ4Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WJ4Set_tb.Location = new System.Drawing.Point(49, 146);
            this.WJ4Set_tb.Name = "WJ4Set_tb";
            this.WJ4Set_tb.Size = new System.Drawing.Size(108, 23);
            this.WJ4Set_tb.TabIndex = 9;
            this.WJ4Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WJ4Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WJ4Set_tb_KeyPress);
            // 
            // ZJ3Set_tb
            // 
            this.ZJ3Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZJ3Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZJ3Set_tb.Location = new System.Drawing.Point(49, 117);
            this.ZJ3Set_tb.Name = "ZJ3Set_tb";
            this.ZJ3Set_tb.Size = new System.Drawing.Size(108, 23);
            this.ZJ3Set_tb.TabIndex = 8;
            this.ZJ3Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZJ3Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZJ3Set_tb_KeyPress);
            // 
            // YJ2Set_tb
            // 
            this.YJ2Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YJ2Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YJ2Set_tb.Location = new System.Drawing.Point(49, 88);
            this.YJ2Set_tb.Name = "YJ2Set_tb";
            this.YJ2Set_tb.Size = new System.Drawing.Size(108, 23);
            this.YJ2Set_tb.TabIndex = 7;
            this.YJ2Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YJ2Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YJ2Set_tb_KeyPress);
            // 
            // XJ1Set_tb
            // 
            this.XJ1Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XJ1Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XJ1Set_tb.Location = new System.Drawing.Point(49, 59);
            this.XJ1Set_tb.Name = "XJ1Set_tb";
            this.XJ1Set_tb.Size = new System.Drawing.Size(108, 23);
            this.XJ1Set_tb.TabIndex = 6;
            this.XJ1Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XJ1Set_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XJ1Set_tb_KeyPress);
            // 
            // RJ6Set_lbl
            // 
            this.RJ6Set_lbl.AutoSize = true;
            this.RJ6Set_lbl.Location = new System.Drawing.Point(9, 204);
            this.RJ6Set_lbl.Name = "RJ6Set_lbl";
            this.RJ6Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.RJ6Set_lbl.TabIndex = 5;
            this.RJ6Set_lbl.Text = "R :";
            // 
            // PJ5Set_lbl
            // 
            this.PJ5Set_lbl.AutoSize = true;
            this.PJ5Set_lbl.Location = new System.Drawing.Point(9, 175);
            this.PJ5Set_lbl.Name = "PJ5Set_lbl";
            this.PJ5Set_lbl.Size = new System.Drawing.Size(31, 21);
            this.PJ5Set_lbl.TabIndex = 4;
            this.PJ5Set_lbl.Text = "P :";
            // 
            // WJ4Set_lbl
            // 
            this.WJ4Set_lbl.AutoSize = true;
            this.WJ4Set_lbl.Location = new System.Drawing.Point(9, 146);
            this.WJ4Set_lbl.Name = "WJ4Set_lbl";
            this.WJ4Set_lbl.Size = new System.Drawing.Size(34, 21);
            this.WJ4Set_lbl.TabIndex = 3;
            this.WJ4Set_lbl.Text = "W:";
            // 
            // ZJ3Set_lbl
            // 
            this.ZJ3Set_lbl.AutoSize = true;
            this.ZJ3Set_lbl.Location = new System.Drawing.Point(9, 117);
            this.ZJ3Set_lbl.Name = "ZJ3Set_lbl";
            this.ZJ3Set_lbl.Size = new System.Drawing.Size(32, 21);
            this.ZJ3Set_lbl.TabIndex = 2;
            this.ZJ3Set_lbl.Text = "Z :";
            // 
            // YJ2Set_lbl
            // 
            this.YJ2Set_lbl.AutoSize = true;
            this.YJ2Set_lbl.Location = new System.Drawing.Point(9, 88);
            this.YJ2Set_lbl.Name = "YJ2Set_lbl";
            this.YJ2Set_lbl.Size = new System.Drawing.Size(34, 21);
            this.YJ2Set_lbl.TabIndex = 1;
            this.YJ2Set_lbl.Text = "Y :";
            // 
            // XJ1Set_lbl
            // 
            this.XJ1Set_lbl.AutoSize = true;
            this.XJ1Set_lbl.Location = new System.Drawing.Point(9, 59);
            this.XJ1Set_lbl.Name = "XJ1Set_lbl";
            this.XJ1Set_lbl.Size = new System.Drawing.Size(34, 21);
            this.XJ1Set_lbl.TabIndex = 0;
            this.XJ1Set_lbl.Text = "X :";
            // 
            // PositionMove_gb
            // 
            this.PositionMove_gb.Controls.Add(this.RJ6Positive_btn);
            this.PositionMove_gb.Controls.Add(this.RJ6Negative_btn);
            this.PositionMove_gb.Controls.Add(this.PJ5Positive_btn);
            this.PositionMove_gb.Controls.Add(this.PJ5Negative_btn);
            this.PositionMove_gb.Controls.Add(this.WJ4Positive_btn);
            this.PositionMove_gb.Controls.Add(this.WJ4Negative_btn);
            this.PositionMove_gb.Controls.Add(this.ZJ3Positive_btn);
            this.PositionMove_gb.Controls.Add(this.ZJ3Negative_btn);
            this.PositionMove_gb.Controls.Add(this.YJ2Positive_btn);
            this.PositionMove_gb.Controls.Add(this.YJ2Negative_btn);
            this.PositionMove_gb.Controls.Add(this.PositionMove_cb);
            this.PositionMove_gb.Controls.Add(this.XJ1Positive_btn);
            this.PositionMove_gb.Controls.Add(this.XJ1Negative_btn);
            this.PositionMove_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PositionMove_gb.Location = new System.Drawing.Point(12, 159);
            this.PositionMove_gb.Name = "PositionMove_gb";
            this.PositionMove_gb.Size = new System.Drawing.Size(231, 278);
            this.PositionMove_gb.TabIndex = 10;
            this.PositionMove_gb.TabStop = false;
            this.PositionMove_gb.Text = "Position Move";
            // 
            // RJ6Positive_btn
            // 
            this.RJ6Positive_btn.Location = new System.Drawing.Point(119, 236);
            this.RJ6Positive_btn.Name = "RJ6Positive_btn";
            this.RJ6Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.RJ6Positive_btn.TabIndex = 18;
            this.RJ6Positive_btn.Text = "+R";
            this.RJ6Positive_btn.UseVisualStyleBackColor = true;
            this.RJ6Positive_btn.Click += new System.EventHandler(this.RJ6Positive_btn_Click);
            // 
            // RJ6Negative_btn
            // 
            this.RJ6Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RJ6Negative_btn.Location = new System.Drawing.Point(6, 236);
            this.RJ6Negative_btn.Name = "RJ6Negative_btn";
            this.RJ6Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.RJ6Negative_btn.TabIndex = 17;
            this.RJ6Negative_btn.Text = "-R";
            this.RJ6Negative_btn.UseVisualStyleBackColor = true;
            this.RJ6Negative_btn.Click += new System.EventHandler(this.RJ6Negative_btn_Click);
            // 
            // PJ5Positive_btn
            // 
            this.PJ5Positive_btn.Location = new System.Drawing.Point(119, 201);
            this.PJ5Positive_btn.Name = "PJ5Positive_btn";
            this.PJ5Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.PJ5Positive_btn.TabIndex = 16;
            this.PJ5Positive_btn.Text = "+P";
            this.PJ5Positive_btn.UseVisualStyleBackColor = true;
            this.PJ5Positive_btn.Click += new System.EventHandler(this.PJ5Positive_btn_Click);
            // 
            // PJ5Negative_btn
            // 
            this.PJ5Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PJ5Negative_btn.Location = new System.Drawing.Point(6, 201);
            this.PJ5Negative_btn.Name = "PJ5Negative_btn";
            this.PJ5Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.PJ5Negative_btn.TabIndex = 15;
            this.PJ5Negative_btn.Text = "-P";
            this.PJ5Negative_btn.UseVisualStyleBackColor = true;
            this.PJ5Negative_btn.Click += new System.EventHandler(this.PJ5Negative_btn_Click);
            // 
            // WJ4Positive_btn
            // 
            this.WJ4Positive_btn.Location = new System.Drawing.Point(119, 166);
            this.WJ4Positive_btn.Name = "WJ4Positive_btn";
            this.WJ4Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.WJ4Positive_btn.TabIndex = 14;
            this.WJ4Positive_btn.Text = "+W";
            this.WJ4Positive_btn.UseVisualStyleBackColor = true;
            this.WJ4Positive_btn.Click += new System.EventHandler(this.WJ4Positive_btn_Click);
            // 
            // WJ4Negative_btn
            // 
            this.WJ4Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WJ4Negative_btn.Location = new System.Drawing.Point(6, 166);
            this.WJ4Negative_btn.Name = "WJ4Negative_btn";
            this.WJ4Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.WJ4Negative_btn.TabIndex = 13;
            this.WJ4Negative_btn.Text = "-W";
            this.WJ4Negative_btn.UseVisualStyleBackColor = true;
            this.WJ4Negative_btn.Click += new System.EventHandler(this.WJ4Negative_btn_Click);
            // 
            // ZJ3Positive_btn
            // 
            this.ZJ3Positive_btn.Location = new System.Drawing.Point(119, 132);
            this.ZJ3Positive_btn.Name = "ZJ3Positive_btn";
            this.ZJ3Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.ZJ3Positive_btn.TabIndex = 12;
            this.ZJ3Positive_btn.Text = "+Z";
            this.ZJ3Positive_btn.UseVisualStyleBackColor = true;
            this.ZJ3Positive_btn.Click += new System.EventHandler(this.ZJ3Positive_btn_Click);
            // 
            // ZJ3Negative_btn
            // 
            this.ZJ3Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZJ3Negative_btn.Location = new System.Drawing.Point(6, 132);
            this.ZJ3Negative_btn.Name = "ZJ3Negative_btn";
            this.ZJ3Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.ZJ3Negative_btn.TabIndex = 11;
            this.ZJ3Negative_btn.Text = "-Z";
            this.ZJ3Negative_btn.UseVisualStyleBackColor = true;
            this.ZJ3Negative_btn.Click += new System.EventHandler(this.ZJ3Negative_btn_Click);
            // 
            // YJ2Positive_btn
            // 
            this.YJ2Positive_btn.Location = new System.Drawing.Point(119, 97);
            this.YJ2Positive_btn.Name = "YJ2Positive_btn";
            this.YJ2Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.YJ2Positive_btn.TabIndex = 4;
            this.YJ2Positive_btn.Text = "+Y";
            this.YJ2Positive_btn.UseVisualStyleBackColor = true;
            this.YJ2Positive_btn.Click += new System.EventHandler(this.YJ2Positive_btn_Click);
            // 
            // YJ2Negative_btn
            // 
            this.YJ2Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YJ2Negative_btn.Location = new System.Drawing.Point(6, 97);
            this.YJ2Negative_btn.Name = "YJ2Negative_btn";
            this.YJ2Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.YJ2Negative_btn.TabIndex = 3;
            this.YJ2Negative_btn.Text = "-Y";
            this.YJ2Negative_btn.UseVisualStyleBackColor = true;
            this.YJ2Negative_btn.Click += new System.EventHandler(this.YJ2Negative_btn_Click);
            // 
            // PositionMove_cb
            // 
            this.PositionMove_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionMove_cb.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PositionMove_cb.FormattingEnabled = true;
            this.PositionMove_cb.Items.AddRange(new object[] {
            "卡式座標",
            "軸座標"});
            this.PositionMove_cb.Location = new System.Drawing.Point(6, 32);
            this.PositionMove_cb.Name = "PositionMove_cb";
            this.PositionMove_cb.Size = new System.Drawing.Size(219, 24);
            this.PositionMove_cb.TabIndex = 2;
            this.PositionMove_cb.SelectedIndexChanged += new System.EventHandler(this.PositionMove_cb_SelectedIndexChanged);
            // 
            // XJ1Positive_btn
            // 
            this.XJ1Positive_btn.Location = new System.Drawing.Point(119, 62);
            this.XJ1Positive_btn.Name = "XJ1Positive_btn";
            this.XJ1Positive_btn.Size = new System.Drawing.Size(106, 29);
            this.XJ1Positive_btn.TabIndex = 1;
            this.XJ1Positive_btn.Text = "+X";
            this.XJ1Positive_btn.UseVisualStyleBackColor = true;
            this.XJ1Positive_btn.Click += new System.EventHandler(this.XJ1Positive_btn_Click);
            // 
            // XJ1Negative_btn
            // 
            this.XJ1Negative_btn.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XJ1Negative_btn.Location = new System.Drawing.Point(6, 62);
            this.XJ1Negative_btn.Name = "XJ1Negative_btn";
            this.XJ1Negative_btn.Size = new System.Drawing.Size(106, 29);
            this.XJ1Negative_btn.TabIndex = 0;
            this.XJ1Negative_btn.Text = "-X";
            this.XJ1Negative_btn.UseVisualStyleBackColor = true;
            this.XJ1Negative_btn.Click += new System.EventHandler(this.XJ1Negative_btn_Click);
            // 
            // IO_gb
            // 
            this.IO_gb.Controls.Add(this.Output_pnl);
            this.IO_gb.Controls.Add(this.IOInitialize_lbl);
            this.IO_gb.Controls.Add(this.IOInitialize_btn);
            this.IO_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IO_gb.Location = new System.Drawing.Point(12, 443);
            this.IO_gb.Name = "IO_gb";
            this.IO_gb.Size = new System.Drawing.Size(339, 191);
            this.IO_gb.TabIndex = 11;
            this.IO_gb.TabStop = false;
            this.IO_gb.Text = "I/O";
            // 
            // Output_pnl
            // 
            this.Output_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output_pnl.Controls.Add(this.P07_btn);
            this.Output_pnl.Controls.Add(this.label10);
            this.Output_pnl.Controls.Add(this.Bit_lbl);
            this.Output_pnl.Controls.Add(this.P06_btn);
            this.Output_pnl.Controls.Add(this.Bit0_lbl);
            this.Output_pnl.Controls.Add(this.P05_btn);
            this.Output_pnl.Controls.Add(this.Bit1_lbl);
            this.Output_pnl.Controls.Add(this.P04_btn);
            this.Output_pnl.Controls.Add(this.Bit2_lbl);
            this.Output_pnl.Controls.Add(this.P03_btn);
            this.Output_pnl.Controls.Add(this.Bit3_lbl);
            this.Output_pnl.Controls.Add(this.P02_btn);
            this.Output_pnl.Controls.Add(this.Bit4_lbl);
            this.Output_pnl.Controls.Add(this.P01_btn);
            this.Output_pnl.Controls.Add(this.Bit5_lbl);
            this.Output_pnl.Controls.Add(this.P00_btn);
            this.Output_pnl.Controls.Add(this.P17_btn);
            this.Output_pnl.Controls.Add(this.Bit6_lbl);
            this.Output_pnl.Controls.Add(this.P16_btn);
            this.Output_pnl.Controls.Add(this.Bit7_lbl);
            this.Output_pnl.Controls.Add(this.P15_btn);
            this.Output_pnl.Controls.Add(this.Port1_lbl);
            this.Output_pnl.Controls.Add(this.P14_btn);
            this.Output_pnl.Controls.Add(this.Port0_lbl);
            this.Output_pnl.Controls.Add(this.P13_btn);
            this.Output_pnl.Controls.Add(this.P12_btn);
            this.Output_pnl.Controls.Add(this.P10_btn);
            this.Output_pnl.Controls.Add(this.P11_btn);
            this.Output_pnl.Location = new System.Drawing.Point(6, 65);
            this.Output_pnl.Name = "Output_pnl";
            this.Output_pnl.Size = new System.Drawing.Size(327, 120);
            this.Output_pnl.TabIndex = 12;
            // 
            // P07_btn
            // 
            this.P07_btn.BackColor = System.Drawing.Color.White;
            this.P07_btn.Location = new System.Drawing.Point(63, 50);
            this.P07_btn.Name = "P07_btn";
            this.P07_btn.Size = new System.Drawing.Size(27, 27);
            this.P07_btn.TabIndex = 2;
            this.P07_btn.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Output";
            // 
            // Bit_lbl
            // 
            this.Bit_lbl.AutoSize = true;
            this.Bit_lbl.Location = new System.Drawing.Point(-1, 29);
            this.Bit_lbl.Name = "Bit_lbl";
            this.Bit_lbl.Size = new System.Drawing.Size(33, 21);
            this.Bit_lbl.TabIndex = 27;
            this.Bit_lbl.Text = "Bit";
            // 
            // P06_btn
            // 
            this.P06_btn.BackColor = System.Drawing.Color.White;
            this.P06_btn.Location = new System.Drawing.Point(96, 50);
            this.P06_btn.Name = "P06_btn";
            this.P06_btn.Size = new System.Drawing.Size(27, 27);
            this.P06_btn.TabIndex = 3;
            this.P06_btn.UseVisualStyleBackColor = false;
            // 
            // Bit0_lbl
            // 
            this.Bit0_lbl.AutoSize = true;
            this.Bit0_lbl.Location = new System.Drawing.Point(301, 29);
            this.Bit0_lbl.Name = "Bit0_lbl";
            this.Bit0_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit0_lbl.TabIndex = 26;
            this.Bit0_lbl.Text = "0";
            // 
            // P05_btn
            // 
            this.P05_btn.BackColor = System.Drawing.Color.White;
            this.P05_btn.Location = new System.Drawing.Point(129, 50);
            this.P05_btn.Name = "P05_btn";
            this.P05_btn.Size = new System.Drawing.Size(27, 27);
            this.P05_btn.TabIndex = 4;
            this.P05_btn.UseVisualStyleBackColor = false;
            // 
            // Bit1_lbl
            // 
            this.Bit1_lbl.AutoSize = true;
            this.Bit1_lbl.Location = new System.Drawing.Point(268, 29);
            this.Bit1_lbl.Name = "Bit1_lbl";
            this.Bit1_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit1_lbl.TabIndex = 25;
            this.Bit1_lbl.Text = "1";
            // 
            // P04_btn
            // 
            this.P04_btn.BackColor = System.Drawing.Color.White;
            this.P04_btn.Location = new System.Drawing.Point(162, 50);
            this.P04_btn.Name = "P04_btn";
            this.P04_btn.Size = new System.Drawing.Size(27, 27);
            this.P04_btn.TabIndex = 5;
            this.P04_btn.UseVisualStyleBackColor = false;
            // 
            // Bit2_lbl
            // 
            this.Bit2_lbl.AutoSize = true;
            this.Bit2_lbl.Location = new System.Drawing.Point(235, 29);
            this.Bit2_lbl.Name = "Bit2_lbl";
            this.Bit2_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit2_lbl.TabIndex = 24;
            this.Bit2_lbl.Text = "2";
            // 
            // P03_btn
            // 
            this.P03_btn.BackColor = System.Drawing.Color.White;
            this.P03_btn.Location = new System.Drawing.Point(195, 50);
            this.P03_btn.Name = "P03_btn";
            this.P03_btn.Size = new System.Drawing.Size(27, 27);
            this.P03_btn.TabIndex = 6;
            this.P03_btn.UseVisualStyleBackColor = false;
            // 
            // Bit3_lbl
            // 
            this.Bit3_lbl.AutoSize = true;
            this.Bit3_lbl.Location = new System.Drawing.Point(202, 29);
            this.Bit3_lbl.Name = "Bit3_lbl";
            this.Bit3_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit3_lbl.TabIndex = 23;
            this.Bit3_lbl.Text = "3";
            // 
            // P02_btn
            // 
            this.P02_btn.BackColor = System.Drawing.Color.White;
            this.P02_btn.Location = new System.Drawing.Point(228, 50);
            this.P02_btn.Name = "P02_btn";
            this.P02_btn.Size = new System.Drawing.Size(27, 27);
            this.P02_btn.TabIndex = 7;
            this.P02_btn.UseVisualStyleBackColor = false;
            // 
            // Bit4_lbl
            // 
            this.Bit4_lbl.AutoSize = true;
            this.Bit4_lbl.Location = new System.Drawing.Point(169, 29);
            this.Bit4_lbl.Name = "Bit4_lbl";
            this.Bit4_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit4_lbl.TabIndex = 22;
            this.Bit4_lbl.Text = "4";
            // 
            // P01_btn
            // 
            this.P01_btn.BackColor = System.Drawing.Color.White;
            this.P01_btn.Location = new System.Drawing.Point(261, 50);
            this.P01_btn.Name = "P01_btn";
            this.P01_btn.Size = new System.Drawing.Size(27, 27);
            this.P01_btn.TabIndex = 8;
            this.P01_btn.UseVisualStyleBackColor = false;
            // 
            // Bit5_lbl
            // 
            this.Bit5_lbl.AutoSize = true;
            this.Bit5_lbl.Location = new System.Drawing.Point(136, 29);
            this.Bit5_lbl.Name = "Bit5_lbl";
            this.Bit5_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit5_lbl.TabIndex = 21;
            this.Bit5_lbl.Text = "5";
            // 
            // P00_btn
            // 
            this.P00_btn.BackColor = System.Drawing.Color.White;
            this.P00_btn.Location = new System.Drawing.Point(294, 50);
            this.P00_btn.Name = "P00_btn";
            this.P00_btn.Size = new System.Drawing.Size(27, 27);
            this.P00_btn.TabIndex = 0;
            this.P00_btn.UseVisualStyleBackColor = false;
            // 
            // P17_btn
            // 
            this.P17_btn.BackColor = System.Drawing.Color.White;
            this.P17_btn.Location = new System.Drawing.Point(63, 83);
            this.P17_btn.Name = "P17_btn";
            this.P17_btn.Size = new System.Drawing.Size(27, 27);
            this.P17_btn.TabIndex = 10;
            this.P17_btn.UseVisualStyleBackColor = false;
            // 
            // Bit6_lbl
            // 
            this.Bit6_lbl.AutoSize = true;
            this.Bit6_lbl.Location = new System.Drawing.Point(103, 29);
            this.Bit6_lbl.Name = "Bit6_lbl";
            this.Bit6_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit6_lbl.TabIndex = 20;
            this.Bit6_lbl.Text = "6";
            // 
            // P16_btn
            // 
            this.P16_btn.BackColor = System.Drawing.Color.White;
            this.P16_btn.Location = new System.Drawing.Point(96, 83);
            this.P16_btn.Name = "P16_btn";
            this.P16_btn.Size = new System.Drawing.Size(27, 27);
            this.P16_btn.TabIndex = 11;
            this.P16_btn.UseVisualStyleBackColor = false;
            // 
            // Bit7_lbl
            // 
            this.Bit7_lbl.AutoSize = true;
            this.Bit7_lbl.Location = new System.Drawing.Point(70, 29);
            this.Bit7_lbl.Name = "Bit7_lbl";
            this.Bit7_lbl.Size = new System.Drawing.Size(20, 21);
            this.Bit7_lbl.TabIndex = 19;
            this.Bit7_lbl.Text = "7";
            // 
            // P15_btn
            // 
            this.P15_btn.BackColor = System.Drawing.Color.White;
            this.P15_btn.Location = new System.Drawing.Point(129, 83);
            this.P15_btn.Name = "P15_btn";
            this.P15_btn.Size = new System.Drawing.Size(27, 27);
            this.P15_btn.TabIndex = 12;
            this.P15_btn.UseVisualStyleBackColor = false;
            // 
            // Port1_lbl
            // 
            this.Port1_lbl.AutoSize = true;
            this.Port1_lbl.Location = new System.Drawing.Point(-1, 89);
            this.Port1_lbl.Name = "Port1_lbl";
            this.Port1_lbl.Size = new System.Drawing.Size(58, 21);
            this.Port1_lbl.TabIndex = 18;
            this.Port1_lbl.Text = "Port 1";
            // 
            // P14_btn
            // 
            this.P14_btn.BackColor = System.Drawing.Color.White;
            this.P14_btn.Location = new System.Drawing.Point(162, 83);
            this.P14_btn.Name = "P14_btn";
            this.P14_btn.Size = new System.Drawing.Size(27, 27);
            this.P14_btn.TabIndex = 13;
            this.P14_btn.UseVisualStyleBackColor = false;
            // 
            // Port0_lbl
            // 
            this.Port0_lbl.AutoSize = true;
            this.Port0_lbl.Location = new System.Drawing.Point(-1, 56);
            this.Port0_lbl.Name = "Port0_lbl";
            this.Port0_lbl.Size = new System.Drawing.Size(58, 21);
            this.Port0_lbl.TabIndex = 17;
            this.Port0_lbl.Text = "Port 0";
            // 
            // P13_btn
            // 
            this.P13_btn.BackColor = System.Drawing.Color.White;
            this.P13_btn.Location = new System.Drawing.Point(195, 83);
            this.P13_btn.Name = "P13_btn";
            this.P13_btn.Size = new System.Drawing.Size(27, 27);
            this.P13_btn.TabIndex = 14;
            this.P13_btn.UseVisualStyleBackColor = false;
            // 
            // P12_btn
            // 
            this.P12_btn.BackColor = System.Drawing.Color.White;
            this.P12_btn.Location = new System.Drawing.Point(228, 83);
            this.P12_btn.Name = "P12_btn";
            this.P12_btn.Size = new System.Drawing.Size(27, 27);
            this.P12_btn.TabIndex = 15;
            this.P12_btn.UseVisualStyleBackColor = false;
            // 
            // P10_btn
            // 
            this.P10_btn.BackColor = System.Drawing.Color.White;
            this.P10_btn.Location = new System.Drawing.Point(294, 83);
            this.P10_btn.Name = "P10_btn";
            this.P10_btn.Size = new System.Drawing.Size(27, 27);
            this.P10_btn.TabIndex = 9;
            this.P10_btn.UseVisualStyleBackColor = false;
            // 
            // P11_btn
            // 
            this.P11_btn.BackColor = System.Drawing.Color.White;
            this.P11_btn.Location = new System.Drawing.Point(261, 83);
            this.P11_btn.Name = "P11_btn";
            this.P11_btn.Size = new System.Drawing.Size(27, 27);
            this.P11_btn.TabIndex = 16;
            this.P11_btn.UseVisualStyleBackColor = false;
            // 
            // IOInitialize_lbl
            // 
            this.IOInitialize_lbl.AutoSize = true;
            this.IOInitialize_lbl.Location = new System.Drawing.Point(122, 34);
            this.IOInitialize_lbl.Name = "IOInitialize_lbl";
            this.IOInitialize_lbl.Size = new System.Drawing.Size(111, 21);
            this.IOInitialize_lbl.TabIndex = 29;
            this.IOInitialize_lbl.Text = "Uninitialized";
            // 
            // IOInitialize_btn
            // 
            this.IOInitialize_btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IOInitialize_btn.Location = new System.Drawing.Point(6, 32);
            this.IOInitialize_btn.Name = "IOInitialize_btn";
            this.IOInitialize_btn.Size = new System.Drawing.Size(110, 27);
            this.IOInitialize_btn.TabIndex = 1;
            this.IOInitialize_btn.Text = "Initialize";
            this.IOInitialize_btn.UseVisualStyleBackColor = true;
            this.IOInitialize_btn.Click += new System.EventHandler(this.IOInitialize_btn_Click);
            // 
            // instantDoCtrl1
            // 
            this.instantDoCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("instantDoCtrl1._StateStream")));
            // 
            // Robot_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 687);
            this.Controls.Add(this.IO_gb);
            this.Controls.Add(this.PositionMove_gb);
            this.Controls.Add(this.PositionSet_gb);
            this.Controls.Add(this.Register_gb);
            this.Controls.Add(this.Override_gb);
            this.Controls.Add(this.CurrentPosition_gb);
            this.Controls.Add(this.Alarm_gb);
            this.Controls.Add(this.Connect_gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Robot_Interface";
            this.Text = "Robot_Interface";
            this.Connect_gb.ResumeLayout(false);
            this.Connect_gb.PerformLayout();
            this.Alarm_gb.ResumeLayout(false);
            this.Alarm_gb.PerformLayout();
            this.CurrentPosition_gb.ResumeLayout(false);
            this.CurrentPosition_gb.PerformLayout();
            this.Register_gb.ResumeLayout(false);
            this.Register_gb.PerformLayout();
            this.Override_gb.ResumeLayout(false);
            this.Override_gb.PerformLayout();
            this.PositionSet_gb.ResumeLayout(false);
            this.PositionSet_gb.PerformLayout();
            this.PositionMove_gb.ResumeLayout(false);
            this.IO_gb.ResumeLayout(false);
            this.IO_gb.PerformLayout();
            this.Output_pnl.ResumeLayout(false);
            this.Output_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HostName_tb;
        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.GroupBox Connect_gb;
        private System.Windows.Forms.GroupBox Alarm_gb;
        private System.Windows.Forms.Label Connect_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Alarm_lbl;
        private System.Windows.Forms.GroupBox CurrentPosition_gb;
        private System.Windows.Forms.Label Xyzwpr_lbl;
        private System.Windows.Forms.Label Joint_lbl;
        private System.Windows.Forms.GroupBox Register_gb;
        private System.Windows.Forms.Label Register_lbl;
        private System.Windows.Forms.GroupBox Override_gb;
        private System.Windows.Forms.Label Override_lbl;
        private System.Windows.Forms.TextBox R2Set_tb;
        private System.Windows.Forms.TextBox R1Set_tb;
        private System.Windows.Forms.Label R1Set_lbl;
        private System.Windows.Forms.Label R2Set_lbl;
        private System.Windows.Forms.Button RegisterSet_btn;
        private System.Windows.Forms.GroupBox PositionSet_gb;
        private System.Windows.Forms.TextBox XJ1Set_tb;
        private System.Windows.Forms.Label RJ6Set_lbl;
        private System.Windows.Forms.Label PJ5Set_lbl;
        private System.Windows.Forms.Label WJ4Set_lbl;
        private System.Windows.Forms.Label ZJ3Set_lbl;
        private System.Windows.Forms.Label YJ2Set_lbl;
        private System.Windows.Forms.Label XJ1Set_lbl;
        private System.Windows.Forms.Button SetPosition_btn;
        private System.Windows.Forms.Button GetNowPosition_btn;
        private System.Windows.Forms.TextBox RJ6Set_tb;
        private System.Windows.Forms.TextBox PJ5Set_tb;
        private System.Windows.Forms.TextBox WJ4Set_tb;
        private System.Windows.Forms.TextBox ZJ3Set_tb;
        private System.Windows.Forms.TextBox YJ2Set_tb;
        private System.Windows.Forms.Label SafeRange_lbl;
        private System.Windows.Forms.Button BackTotheInitialStatus_btn;
        private System.Windows.Forms.GroupBox PositionMove_gb;
        private System.Windows.Forms.ComboBox PositionSet_cb;
        private System.Windows.Forms.ComboBox PositionMove_cb;
        private System.Windows.Forms.Button XJ1Positive_btn;
        private System.Windows.Forms.Button XJ1Negative_btn;
        private System.Windows.Forms.Button RJ6Positive_btn;
        private System.Windows.Forms.Button RJ6Negative_btn;
        private System.Windows.Forms.Button PJ5Positive_btn;
        private System.Windows.Forms.Button PJ5Negative_btn;
        private System.Windows.Forms.Button WJ4Positive_btn;
        private System.Windows.Forms.Button WJ4Negative_btn;
        private System.Windows.Forms.Button ZJ3Positive_btn;
        private System.Windows.Forms.Button ZJ3Negative_btn;
        private System.Windows.Forms.Button YJ2Positive_btn;
        private System.Windows.Forms.Button YJ2Negative_btn;
        private System.Windows.Forms.Label Velocity_lbl;
        private System.Windows.Forms.TextBox VelocitySet_tb;
        private System.Windows.Forms.Label VelocityRange_lbl;
        private System.Windows.Forms.GroupBox IO_gb;
        private System.Windows.Forms.Button P00_btn;
        private System.Windows.Forms.Button IOInitialize_btn;
        private Automation.BDaq.InstantDoCtrl instantDoCtrl1;
        private System.Windows.Forms.Label IOInitialize_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Bit_lbl;
        private System.Windows.Forms.Label Bit0_lbl;
        private System.Windows.Forms.Label Bit1_lbl;
        private System.Windows.Forms.Label Bit2_lbl;
        private System.Windows.Forms.Label Bit3_lbl;
        private System.Windows.Forms.Label Bit4_lbl;
        private System.Windows.Forms.Label Bit5_lbl;
        private System.Windows.Forms.Label Bit6_lbl;
        private System.Windows.Forms.Label Bit7_lbl;
        private System.Windows.Forms.Label Port1_lbl;
        private System.Windows.Forms.Label Port0_lbl;
        private System.Windows.Forms.Button P11_btn;
        private System.Windows.Forms.Button P12_btn;
        private System.Windows.Forms.Button P13_btn;
        private System.Windows.Forms.Button P14_btn;
        private System.Windows.Forms.Button P15_btn;
        private System.Windows.Forms.Button P16_btn;
        private System.Windows.Forms.Button P17_btn;
        private System.Windows.Forms.Button P10_btn;
        private System.Windows.Forms.Button P01_btn;
        private System.Windows.Forms.Button P02_btn;
        private System.Windows.Forms.Button P03_btn;
        private System.Windows.Forms.Button P04_btn;
        private System.Windows.Forms.Button P05_btn;
        private System.Windows.Forms.Button P06_btn;
        private System.Windows.Forms.Button P07_btn;
        private System.Windows.Forms.Panel Output_pnl;
    }
}

