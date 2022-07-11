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
            this.卡式座標Set_gb = new System.Windows.Forms.GroupBox();
            this.InitialPoint_btn = new System.Windows.Forms.Button();
            this.SafeRange_lbl = new System.Windows.Forms.Label();
            this.GetNowCPosition_btn = new System.Windows.Forms.Button();
            this.SetCPosition_btn = new System.Windows.Forms.Button();
            this.RSet_tb = new System.Windows.Forms.TextBox();
            this.PSet_tb = new System.Windows.Forms.TextBox();
            this.WSet_tb = new System.Windows.Forms.TextBox();
            this.ZSet_tb = new System.Windows.Forms.TextBox();
            this.YSet_tb = new System.Windows.Forms.TextBox();
            this.XSet_tb = new System.Windows.Forms.TextBox();
            this.RSet_lbl = new System.Windows.Forms.Label();
            this.PSet_lbl = new System.Windows.Forms.Label();
            this.WSet_lbl = new System.Windows.Forms.Label();
            this.ZSet_lbl = new System.Windows.Forms.Label();
            this.YSet_lbl = new System.Windows.Forms.Label();
            this.XSet_lbl = new System.Windows.Forms.Label();
            this.軸座標Set_gb = new System.Windows.Forms.GroupBox();
            this.SetJPosition_btn = new System.Windows.Forms.Button();
            this.J6Set_tb = new System.Windows.Forms.TextBox();
            this.GetNowJPosition_btn = new System.Windows.Forms.Button();
            this.J5Set_tb = new System.Windows.Forms.TextBox();
            this.J4Set_tb = new System.Windows.Forms.TextBox();
            this.J3Set_tb = new System.Windows.Forms.TextBox();
            this.J2Set_tb = new System.Windows.Forms.TextBox();
            this.J1Set_tb = new System.Windows.Forms.TextBox();
            this.J6Set_lbl = new System.Windows.Forms.Label();
            this.J5Set_lbl = new System.Windows.Forms.Label();
            this.J4Set_lbl = new System.Windows.Forms.Label();
            this.J3Set_lbl = new System.Windows.Forms.Label();
            this.J2Set_lbl = new System.Windows.Forms.Label();
            this.J1Set_lbl = new System.Windows.Forms.Label();
            this.Move_gb = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect_gb.SuspendLayout();
            this.Alarm_gb.SuspendLayout();
            this.CurrentPosition_gb.SuspendLayout();
            this.Register_gb.SuspendLayout();
            this.Override_gb.SuspendLayout();
            this.卡式座標Set_gb.SuspendLayout();
            this.軸座標Set_gb.SuspendLayout();
            this.Move_gb.SuspendLayout();
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
            this.Connect_lbl.Size = new System.Drawing.Size(123, 21);
            this.Connect_lbl.TabIndex = 5;
            this.Connect_lbl.Text = "Disconnected ";
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
            this.CurrentPosition_gb.Location = new System.Drawing.Point(12, 159);
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
            this.Register_gb.Location = new System.Drawing.Point(777, 159);
            this.Register_gb.Name = "Register_gb";
            this.Register_gb.Size = new System.Drawing.Size(126, 189);
            this.Register_gb.TabIndex = 6;
            this.Register_gb.TabStop = false;
            this.Register_gb.Text = "Register";
            // 
            // RegisterSet_btn
            // 
            this.RegisterSet_btn.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RegisterSet_btn.Location = new System.Drawing.Point(11, 143);
            this.RegisterSet_btn.Name = "RegisterSet_btn";
            this.RegisterSet_btn.Size = new System.Drawing.Size(101, 35);
            this.RegisterSet_btn.TabIndex = 5;
            this.RegisterSet_btn.Text = "REG SET";
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
            // 
            // R1Set_tb
            // 
            this.R1Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R1Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.R1Set_tb.Location = new System.Drawing.Point(75, 85);
            this.R1Set_tb.Name = "R1Set_tb";
            this.R1Set_tb.Size = new System.Drawing.Size(37, 23);
            this.R1Set_tb.TabIndex = 2;
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
            this.Override_gb.Location = new System.Drawing.Point(703, 12);
            this.Override_gb.Name = "Override_gb";
            this.Override_gb.Size = new System.Drawing.Size(100, 76);
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
            // 卡式座標Set_gb
            // 
            this.卡式座標Set_gb.Controls.Add(this.InitialPoint_btn);
            this.卡式座標Set_gb.Controls.Add(this.SafeRange_lbl);
            this.卡式座標Set_gb.Controls.Add(this.GetNowCPosition_btn);
            this.卡式座標Set_gb.Controls.Add(this.SetCPosition_btn);
            this.卡式座標Set_gb.Controls.Add(this.RSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.PSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.WSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.ZSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.YSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.XSet_tb);
            this.卡式座標Set_gb.Controls.Add(this.RSet_lbl);
            this.卡式座標Set_gb.Controls.Add(this.PSet_lbl);
            this.卡式座標Set_gb.Controls.Add(this.WSet_lbl);
            this.卡式座標Set_gb.Controls.Add(this.ZSet_lbl);
            this.卡式座標Set_gb.Controls.Add(this.YSet_lbl);
            this.卡式座標Set_gb.Controls.Add(this.XSet_lbl);
            this.卡式座標Set_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.卡式座標Set_gb.Location = new System.Drawing.Point(320, 159);
            this.卡式座標Set_gb.Name = "卡式座標Set_gb";
            this.卡式座標Set_gb.Size = new System.Drawing.Size(284, 252);
            this.卡式座標Set_gb.TabIndex = 8;
            this.卡式座標Set_gb.TabStop = false;
            this.卡式座標Set_gb.Text = "卡式座標Set";
            // 
            // InitialPoint_btn
            // 
            this.InitialPoint_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InitialPoint_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.InitialPoint_btn.Location = new System.Drawing.Point(160, 203);
            this.InitialPoint_btn.Name = "InitialPoint_btn";
            this.InitialPoint_btn.Size = new System.Drawing.Size(117, 40);
            this.InitialPoint_btn.TabIndex = 10;
            this.InitialPoint_btn.Text = "Initial Point";
            this.InitialPoint_btn.UseVisualStyleBackColor = true;
            this.InitialPoint_btn.Click += new System.EventHandler(this.InitialPoint_btn_Click);
            // 
            // SafeRange_lbl
            // 
            this.SafeRange_lbl.AutoSize = true;
            this.SafeRange_lbl.Location = new System.Drawing.Point(160, 29);
            this.SafeRange_lbl.Name = "SafeRange_lbl";
            this.SafeRange_lbl.Size = new System.Drawing.Size(117, 84);
            this.SafeRange_lbl.TabIndex = 14;
            this.SafeRange_lbl.Text = "SafeRange\r\nX : 0~700\r\nY : -500~600\r\nZ : -130~500";
            // 
            // GetNowCPosition_btn
            // 
            this.GetNowCPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GetNowCPosition_btn.Location = new System.Drawing.Point(6, 203);
            this.GetNowCPosition_btn.Name = "GetNowCPosition_btn";
            this.GetNowCPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.GetNowCPosition_btn.TabIndex = 12;
            this.GetNowCPosition_btn.Text = "Get Now Position";
            this.GetNowCPosition_btn.UseVisualStyleBackColor = true;
            this.GetNowCPosition_btn.Click += new System.EventHandler(this.GetNowCPosition_btn_Click);
            // 
            // SetCPosition_btn
            // 
            this.SetCPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetCPosition_btn.Location = new System.Drawing.Point(82, 203);
            this.SetCPosition_btn.Name = "SetCPosition_btn";
            this.SetCPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.SetCPosition_btn.TabIndex = 13;
            this.SetCPosition_btn.Text = "Set Position";
            this.SetCPosition_btn.UseVisualStyleBackColor = true;
            this.SetCPosition_btn.Click += new System.EventHandler(this.SetCPosition_btn_Click);
            // 
            // RSet_tb
            // 
            this.RSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RSet_tb.Location = new System.Drawing.Point(46, 174);
            this.RSet_tb.Name = "RSet_tb";
            this.RSet_tb.Size = new System.Drawing.Size(108, 23);
            this.RSet_tb.TabIndex = 11;
            this.RSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PSet_tb
            // 
            this.PSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PSet_tb.Location = new System.Drawing.Point(46, 145);
            this.PSet_tb.Name = "PSet_tb";
            this.PSet_tb.Size = new System.Drawing.Size(108, 23);
            this.PSet_tb.TabIndex = 10;
            this.PSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WSet_tb
            // 
            this.WSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.WSet_tb.Location = new System.Drawing.Point(46, 116);
            this.WSet_tb.Name = "WSet_tb";
            this.WSet_tb.Size = new System.Drawing.Size(108, 23);
            this.WSet_tb.TabIndex = 9;
            this.WSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ZSet_tb
            // 
            this.ZSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZSet_tb.Location = new System.Drawing.Point(46, 87);
            this.ZSet_tb.Name = "ZSet_tb";
            this.ZSet_tb.Size = new System.Drawing.Size(108, 23);
            this.ZSet_tb.TabIndex = 8;
            this.ZSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YSet_tb
            // 
            this.YSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YSet_tb.Location = new System.Drawing.Point(46, 58);
            this.YSet_tb.Name = "YSet_tb";
            this.YSet_tb.Size = new System.Drawing.Size(108, 23);
            this.YSet_tb.TabIndex = 7;
            this.YSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XSet_tb
            // 
            this.XSet_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XSet_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XSet_tb.Location = new System.Drawing.Point(46, 29);
            this.XSet_tb.Name = "XSet_tb";
            this.XSet_tb.Size = new System.Drawing.Size(108, 23);
            this.XSet_tb.TabIndex = 6;
            this.XSet_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RSet_lbl
            // 
            this.RSet_lbl.AutoSize = true;
            this.RSet_lbl.Location = new System.Drawing.Point(7, 174);
            this.RSet_lbl.Name = "RSet_lbl";
            this.RSet_lbl.Size = new System.Drawing.Size(33, 21);
            this.RSet_lbl.TabIndex = 5;
            this.RSet_lbl.Text = "R :";
            // 
            // PSet_lbl
            // 
            this.PSet_lbl.AutoSize = true;
            this.PSet_lbl.Location = new System.Drawing.Point(9, 145);
            this.PSet_lbl.Name = "PSet_lbl";
            this.PSet_lbl.Size = new System.Drawing.Size(31, 21);
            this.PSet_lbl.TabIndex = 4;
            this.PSet_lbl.Text = "P :";
            // 
            // WSet_lbl
            // 
            this.WSet_lbl.AutoSize = true;
            this.WSet_lbl.Location = new System.Drawing.Point(6, 116);
            this.WSet_lbl.Name = "WSet_lbl";
            this.WSet_lbl.Size = new System.Drawing.Size(34, 21);
            this.WSet_lbl.TabIndex = 3;
            this.WSet_lbl.Text = "W:";
            // 
            // ZSet_lbl
            // 
            this.ZSet_lbl.AutoSize = true;
            this.ZSet_lbl.Location = new System.Drawing.Point(8, 87);
            this.ZSet_lbl.Name = "ZSet_lbl";
            this.ZSet_lbl.Size = new System.Drawing.Size(32, 21);
            this.ZSet_lbl.TabIndex = 2;
            this.ZSet_lbl.Text = "Z :";
            // 
            // YSet_lbl
            // 
            this.YSet_lbl.AutoSize = true;
            this.YSet_lbl.Location = new System.Drawing.Point(6, 58);
            this.YSet_lbl.Name = "YSet_lbl";
            this.YSet_lbl.Size = new System.Drawing.Size(34, 21);
            this.YSet_lbl.TabIndex = 1;
            this.YSet_lbl.Text = "Y :";
            // 
            // XSet_lbl
            // 
            this.XSet_lbl.AutoSize = true;
            this.XSet_lbl.Location = new System.Drawing.Point(6, 29);
            this.XSet_lbl.Name = "XSet_lbl";
            this.XSet_lbl.Size = new System.Drawing.Size(34, 21);
            this.XSet_lbl.TabIndex = 0;
            this.XSet_lbl.Text = "X :";
            // 
            // 軸座標Set_gb
            // 
            this.軸座標Set_gb.Controls.Add(this.SetJPosition_btn);
            this.軸座標Set_gb.Controls.Add(this.J6Set_tb);
            this.軸座標Set_gb.Controls.Add(this.GetNowJPosition_btn);
            this.軸座標Set_gb.Controls.Add(this.J5Set_tb);
            this.軸座標Set_gb.Controls.Add(this.J4Set_tb);
            this.軸座標Set_gb.Controls.Add(this.J3Set_tb);
            this.軸座標Set_gb.Controls.Add(this.J2Set_tb);
            this.軸座標Set_gb.Controls.Add(this.J1Set_tb);
            this.軸座標Set_gb.Controls.Add(this.J6Set_lbl);
            this.軸座標Set_gb.Controls.Add(this.J5Set_lbl);
            this.軸座標Set_gb.Controls.Add(this.J4Set_lbl);
            this.軸座標Set_gb.Controls.Add(this.J3Set_lbl);
            this.軸座標Set_gb.Controls.Add(this.J2Set_lbl);
            this.軸座標Set_gb.Controls.Add(this.J1Set_lbl);
            this.軸座標Set_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.軸座標Set_gb.Location = new System.Drawing.Point(610, 159);
            this.軸座標Set_gb.Name = "軸座標Set_gb";
            this.軸座標Set_gb.Size = new System.Drawing.Size(161, 252);
            this.軸座標Set_gb.TabIndex = 9;
            this.軸座標Set_gb.TabStop = false;
            this.軸座標Set_gb.Text = "軸座標Set";
            // 
            // SetJPosition_btn
            // 
            this.SetJPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SetJPosition_btn.Location = new System.Drawing.Point(82, 203);
            this.SetJPosition_btn.Name = "SetJPosition_btn";
            this.SetJPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.SetJPosition_btn.TabIndex = 13;
            this.SetJPosition_btn.Text = "Set Position";
            this.SetJPosition_btn.UseVisualStyleBackColor = true;
            this.SetJPosition_btn.Click += new System.EventHandler(this.SetJPosition_btn_Click);
            // 
            // J6Set_tb
            // 
            this.J6Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J6Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J6Set_tb.Location = new System.Drawing.Point(46, 174);
            this.J6Set_tb.Name = "J6Set_tb";
            this.J6Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J6Set_tb.TabIndex = 11;
            this.J6Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetNowJPosition_btn
            // 
            this.GetNowJPosition_btn.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GetNowJPosition_btn.Location = new System.Drawing.Point(6, 203);
            this.GetNowJPosition_btn.Name = "GetNowJPosition_btn";
            this.GetNowJPosition_btn.Size = new System.Drawing.Size(72, 40);
            this.GetNowJPosition_btn.TabIndex = 12;
            this.GetNowJPosition_btn.Text = "Get Now Position";
            this.GetNowJPosition_btn.UseVisualStyleBackColor = true;
            this.GetNowJPosition_btn.Click += new System.EventHandler(this.GetNowJPosition_btn_Click);
            // 
            // J5Set_tb
            // 
            this.J5Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J5Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J5Set_tb.Location = new System.Drawing.Point(46, 145);
            this.J5Set_tb.Name = "J5Set_tb";
            this.J5Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J5Set_tb.TabIndex = 10;
            this.J5Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J4Set_tb
            // 
            this.J4Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J4Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J4Set_tb.Location = new System.Drawing.Point(46, 116);
            this.J4Set_tb.Name = "J4Set_tb";
            this.J4Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J4Set_tb.TabIndex = 9;
            this.J4Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J3Set_tb
            // 
            this.J3Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J3Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J3Set_tb.Location = new System.Drawing.Point(46, 87);
            this.J3Set_tb.Name = "J3Set_tb";
            this.J3Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J3Set_tb.TabIndex = 8;
            this.J3Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J2Set_tb
            // 
            this.J2Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J2Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J2Set_tb.Location = new System.Drawing.Point(46, 58);
            this.J2Set_tb.Name = "J2Set_tb";
            this.J2Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J2Set_tb.TabIndex = 7;
            this.J2Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J1Set_tb
            // 
            this.J1Set_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.J1Set_tb.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.J1Set_tb.Location = new System.Drawing.Point(46, 29);
            this.J1Set_tb.Name = "J1Set_tb";
            this.J1Set_tb.Size = new System.Drawing.Size(108, 23);
            this.J1Set_tb.TabIndex = 6;
            this.J1Set_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // J6Set_lbl
            // 
            this.J6Set_lbl.AutoSize = true;
            this.J6Set_lbl.Location = new System.Drawing.Point(6, 174);
            this.J6Set_lbl.Name = "J6Set_lbl";
            this.J6Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J6Set_lbl.TabIndex = 5;
            this.J6Set_lbl.Text = "J6:";
            // 
            // J5Set_lbl
            // 
            this.J5Set_lbl.AutoSize = true;
            this.J5Set_lbl.Location = new System.Drawing.Point(6, 145);
            this.J5Set_lbl.Name = "J5Set_lbl";
            this.J5Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J5Set_lbl.TabIndex = 4;
            this.J5Set_lbl.Text = "J5:";
            // 
            // J4Set_lbl
            // 
            this.J4Set_lbl.AutoSize = true;
            this.J4Set_lbl.Location = new System.Drawing.Point(6, 116);
            this.J4Set_lbl.Name = "J4Set_lbl";
            this.J4Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J4Set_lbl.TabIndex = 3;
            this.J4Set_lbl.Text = "J4:";
            // 
            // J3Set_lbl
            // 
            this.J3Set_lbl.AutoSize = true;
            this.J3Set_lbl.Location = new System.Drawing.Point(6, 87);
            this.J3Set_lbl.Name = "J3Set_lbl";
            this.J3Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J3Set_lbl.TabIndex = 2;
            this.J3Set_lbl.Text = "J3:";
            // 
            // J2Set_lbl
            // 
            this.J2Set_lbl.AutoSize = true;
            this.J2Set_lbl.Location = new System.Drawing.Point(6, 58);
            this.J2Set_lbl.Name = "J2Set_lbl";
            this.J2Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J2Set_lbl.TabIndex = 1;
            this.J2Set_lbl.Text = "J2:";
            // 
            // J1Set_lbl
            // 
            this.J1Set_lbl.AutoSize = true;
            this.J1Set_lbl.Location = new System.Drawing.Point(6, 29);
            this.J1Set_lbl.Name = "J1Set_lbl";
            this.J1Set_lbl.Size = new System.Drawing.Size(33, 21);
            this.J1Set_lbl.TabIndex = 0;
            this.J1Set_lbl.Text = "J1:";
            // 
            // Move_gb
            // 
            this.Move_gb.Controls.Add(this.label1);
            this.Move_gb.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Move_gb.Location = new System.Drawing.Point(12, 350);
            this.Move_gb.Name = "Move_gb";
            this.Move_gb.Size = new System.Drawing.Size(302, 220);
            this.Move_gb.TabIndex = 10;
            this.Move_gb.TabStop = false;
            this.Move_gb.Text = "Move";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Robot_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.Move_gb);
            this.Controls.Add(this.軸座標Set_gb);
            this.Controls.Add(this.卡式座標Set_gb);
            this.Controls.Add(this.Override_gb);
            this.Controls.Add(this.Register_gb);
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
            this.卡式座標Set_gb.ResumeLayout(false);
            this.卡式座標Set_gb.PerformLayout();
            this.軸座標Set_gb.ResumeLayout(false);
            this.軸座標Set_gb.PerformLayout();
            this.Move_gb.ResumeLayout(false);
            this.Move_gb.PerformLayout();
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
        private System.Windows.Forms.GroupBox 卡式座標Set_gb;
        private System.Windows.Forms.TextBox XSet_tb;
        private System.Windows.Forms.Label RSet_lbl;
        private System.Windows.Forms.Label PSet_lbl;
        private System.Windows.Forms.Label WSet_lbl;
        private System.Windows.Forms.Label ZSet_lbl;
        private System.Windows.Forms.Label YSet_lbl;
        private System.Windows.Forms.Label XSet_lbl;
        private System.Windows.Forms.Button SetCPosition_btn;
        private System.Windows.Forms.Button GetNowCPosition_btn;
        private System.Windows.Forms.TextBox RSet_tb;
        private System.Windows.Forms.TextBox PSet_tb;
        private System.Windows.Forms.TextBox WSet_tb;
        private System.Windows.Forms.TextBox ZSet_tb;
        private System.Windows.Forms.TextBox YSet_tb;
        private System.Windows.Forms.GroupBox 軸座標Set_gb;
        private System.Windows.Forms.Button SetJPosition_btn;
        private System.Windows.Forms.Button GetNowJPosition_btn;
        private System.Windows.Forms.TextBox J6Set_tb;
        private System.Windows.Forms.TextBox J5Set_tb;
        private System.Windows.Forms.TextBox J4Set_tb;
        private System.Windows.Forms.TextBox J3Set_tb;
        private System.Windows.Forms.TextBox J2Set_tb;
        private System.Windows.Forms.TextBox J1Set_tb;
        private System.Windows.Forms.Label J6Set_lbl;
        private System.Windows.Forms.Label J5Set_lbl;
        private System.Windows.Forms.Label J4Set_lbl;
        private System.Windows.Forms.Label J3Set_lbl;
        private System.Windows.Forms.Label J2Set_lbl;
        private System.Windows.Forms.Label J1Set_lbl;
        private System.Windows.Forms.Label SafeRange_lbl;
        private System.Windows.Forms.Button InitialPoint_btn;
        private System.Windows.Forms.GroupBox Move_gb;
        private System.Windows.Forms.Label label1;
    }
}

