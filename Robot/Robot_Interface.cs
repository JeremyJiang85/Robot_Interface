


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * git test
 */ 

namespace Robot
{
    public partial class Robot_Interface : Form
    {
        //==============================變數宣告區==============================

        public Fanuc fanuc = new Fanuc();

        public string IP = "";
        public string AlarmContent = "";
        public string[][] PositionText;
        public Single[] xyzwpr = new Single[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Single[] joint = new Single[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public bool ConnectStatus_fg = false;


        public Robot_Interface()
        {
            InitializeComponent();
            Deinitialize();
        }

        public void Initialize()
        {
            Alarm_lbl.Text = "";
            Xyzwpr_lbl.Text = "卡式座標\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            Joint_lbl.Text = "軸座標\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            Override_lbl.Text = "";
            Register_lbl.Text = "R1   =\r\nR2   =";
            R1Set_tb.Text = "";
            R2Set_tb.Text = "";
            Alarm_gb.Enabled = true;
            CurrentPosition_gb.Enabled = true;
            Override_gb.Enabled = true;
            Register_gb.Enabled = true;
            卡式座標Set_gb.Enabled = true;
            軸座標Set_gb.Enabled = true;
            timer1.Enabled = true;
        }

        public void Deinitialize()
        {
            timer1.Enabled = false;
            Alarm_gb.Enabled = false;
            CurrentPosition_gb.Enabled = false;
            Override_gb.Enabled = false;
            Register_gb.Enabled = false;
            卡式座標Set_gb.Enabled = false;
            軸座標Set_gb.Enabled = false;
            Alarm_lbl.Text = "";
            Xyzwpr_lbl.Text = "卡式座標\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            Joint_lbl.Text = "軸座標\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            Override_lbl.Text = "";
            Register_lbl.Text = "R1   =\r\nR2   =";
            R1Set_tb.Text = "";
            R2Set_tb.Text = "";
        }

        private void Connect_btn_Click(object sender, EventArgs e)
        {
            if (!ConnectStatus_fg)
            {
                fanuc.Initalize();
                IP = Convert.ToString(HostName_tb.Text);
                if (fanuc.Connect(IP))
                {
                    Initialize();
                    ConnectStatus_fg = true;
                    Connect_btn.Text = "Disconnect";
                    Connect_lbl.Text = "Connecting";
                }
                else
                {
                    MessageBox.Show("連線錯誤");
                }
            }
            else
            {
                if (fanuc.Disconnect())
                {
                    Deinitialize();
                    ConnectStatus_fg = false;
                    Connect_btn.Text = "Connect";
                    Connect_lbl.Text = "Disconnected";
                }
                else
                {
                    MessageBox.Show("離線錯誤");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fanuc.Refresh();
            Alarm_lbl.Text = fanuc.Alarm();
            PositionText = fanuc.CurrentPosition();
            Xyzwpr_lbl.Text = PositionText[0][0];
            Joint_lbl.Text = PositionText[0][1];
            Override_lbl.Text = fanuc.Override();
            Register_lbl.Text = fanuc.Register();
        }

        private void RegisterSet_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(R1Set_tb.Text))
                {
                    fanuc.RegisterSet(1, Convert.ToSingle(R1Set_tb.Text));
                }
                if (!string.IsNullOrEmpty(R2Set_tb.Text))
                {
                    fanuc.RegisterSet(2, Convert.ToSingle(R2Set_tb.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入整數");
                R1Set_tb.Text = "";
                R2Set_tb.Text = "";
            }
        }

        private void GetNowCPosition_btn_Click(object sender, EventArgs e)
        {
            XSet_tb.Text = PositionText[1][0];
            YSet_tb.Text = PositionText[1][1];
            ZSet_tb.Text = PositionText[1][2];
            WSet_tb.Text = PositionText[1][3];
            PSet_tb.Text = PositionText[1][4];
            RSet_tb.Text = PositionText[1][5];
        }

        private void SetCPosition_btn_Click(object sender, EventArgs e)
        {
            xyzwpr[0] = Convert.ToSingle(XSet_tb.Text);
            xyzwpr[1] = Convert.ToSingle(YSet_tb.Text);
            xyzwpr[2] = Convert.ToSingle(ZSet_tb.Text);
            xyzwpr[3] = Convert.ToSingle(WSet_tb.Text);
            xyzwpr[4] = Convert.ToSingle(PSet_tb.Text);
            xyzwpr[5] = Convert.ToSingle(RSet_tb.Text);

            fanuc.CPositionSet(xyzwpr);
        }

        private void GetNowJPosition_btn_Click(object sender, EventArgs e)
        {
            J1Set_tb.Text = PositionText[2][0];
            J2Set_tb.Text = PositionText[2][1];
            J3Set_tb.Text = PositionText[2][2];
            J4Set_tb.Text = PositionText[2][3];
            J5Set_tb.Text = PositionText[2][4];
            J6Set_tb.Text = PositionText[2][5];
        }

        private void SetJPosition_btn_Click(object sender, EventArgs e)
        {
            joint[0] = Convert.ToSingle(J1Set_tb.Text);
            joint[1] = Convert.ToSingle(J2Set_tb.Text);
            joint[2] = Convert.ToSingle(J3Set_tb.Text);
            joint[3] = Convert.ToSingle(J4Set_tb.Text);
            joint[4] = Convert.ToSingle(J5Set_tb.Text);
            joint[5] = Convert.ToSingle(J6Set_tb.Text);

            fanuc.JPositionSet(joint);
        }
        
    }

    //==============================class Fanuc==============================
    public class Fanuc
    {
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;
        private FRRJIf.DataTable mobjDataTable2;
        private FRRJIf.DataCurPos mobjCurPos;
        private FRRJIf.DataCurPos mobjCurPosUF;
        private FRRJIf.DataCurPos mobjCurPos2;
        private FRRJIf.DataTask mobjTask;
        private FRRJIf.DataTask mobjTaskIgnoreMacro;
        private FRRJIf.DataTask mobjTaskIgnoreKarel;
        private FRRJIf.DataTask mobjTaskIgnoreMacroKarel;
        private FRRJIf.DataPosReg mobjPosReg;
        private FRRJIf.DataPosReg mobjPosReg2;
        private FRRJIf.DataPosRegXyzwpr mobjPosRegXyzwpr;
        private FRRJIf.DataPosRegMG mobjPosRegMG;
        private FRRJIf.DataSysVar mobjSysVarInt;
        private FRRJIf.DataSysVar mobjSysVarInt2;
        private FRRJIf.DataSysVar mobjSysVarReal;
        private FRRJIf.DataSysVar mobjSysVarReal2;
        private FRRJIf.DataSysVar mobjSysVarString;
        private FRRJIf.DataSysVarPos mobjSysVarPos;
        private FRRJIf.DataSysVar[] mobjSysVarIntArray;
        private FRRJIf.DataNumReg mobjNumReg;
        private FRRJIf.DataNumReg mobjNumReg2;
        private FRRJIf.DataNumReg mobjNumReg3;
        private FRRJIf.DataAlarm mobjAlarm;
        private FRRJIf.DataAlarm mobjAlarmCurrent;
        private FRRJIf.DataSysVar mobjVarString;
        private FRRJIf.DataString mobjStrReg;
        private FRRJIf.DataString mobjStrRegComment;

        public bool Alarm_fg { get => alarm_fg; }
        private bool alarm_fg = false;
        public bool Refresh_fg { get => refresh_fg; }
        private bool refresh_fg = false;
        public bool CurrentPosition_fg { get => currentPosition_fg; }
        private bool currentPosition_fg = false;
        public bool Overrider_fg { get => override_fg; }
        private bool override_fg = false;
        public bool Register_fg { get => register_fg; }
        private bool register_fg = false;
        public bool RegisterSet_fg { get => registerSet_fg; }
        private bool registerSet_fg = false;
        public bool SetCPosition_fg { get => setCPosition_fg; }
        private bool setCPosition_fg = false;
        public bool SetJPosition_fg { get => setJPosition_fg; }
        private bool setJPosition_fg = false;



        public void Initalize()
        {
            mobjCore = new FRRJIf.Core();
            mobjDataTable = mobjCore.DataTable;
            mobjAlarmCurrent = mobjDataTable.AddAlarm(FRRJIf.FRIF_DATA_TYPE.ALARM_CURRENT, 1, 0);
            mobjCurPos = mobjDataTable.AddCurPos(FRRJIf.FRIF_DATA_TYPE.CURPOS, 1);
            mobjTask = mobjDataTable.AddTask(FRRJIf.FRIF_DATA_TYPE.TASK, 1);
            mobjPosReg = mobjDataTable.AddPosReg(FRRJIf.FRIF_DATA_TYPE.POSREG, 1, 1, 10);
            mobjSysVarInt = mobjDataTable.AddSysVar(FRRJIf.FRIF_DATA_TYPE.SYSVAR_INT, "$MCR.$GENOVERRIDE");
            mobjNumReg = mobjDataTable.AddNumReg(FRRJIf.FRIF_DATA_TYPE.NUMREG_REAL, 1, 10);
        }

        public bool Connect(string IP)
        {
            return mobjCore.Connect(IP);
        }

        public bool Disconnect()
        {
            return mobjCore.Disconnect();
        }

        public void Refresh()
        {
            refresh_fg = mobjDataTable.Refresh();
        }

        public string Alarm()
        {
            string AlarmText = "";
            const int Count = 1;
            short AlarmID = 0;
            short AlarmNumber = 0;
            short CauseAlarmID = 0;
            short CauseAlarmNumber = 0;
            short Severity = 0;
            short Year = 0;
            short Month = 0;
            short Day = 0;
            short Hour = 0;
            short Minute = 0;
            short Second = 0;
            string AlarmMessage = "";
            string CauseAlarmMessage = "";
            string SeverityMessage = "";

            if (alarm_fg = mobjAlarmCurrent.GetValue(Count, ref AlarmID, ref AlarmNumber, ref CauseAlarmID, ref CauseAlarmNumber, ref Severity,
                ref Year, ref Month, ref Day, ref Hour, ref Minute, ref Second, ref AlarmMessage, ref CauseAlarmMessage, ref SeverityMessage))
            {
                AlarmText = AlarmID + ", " + AlarmNumber + ", " + CauseAlarmID + ", " + CauseAlarmNumber + ", " + Severity + "\r\n" +
                    Year + "/" + Month + "/" + Day + ", " + Hour + ":" + Minute + ":" + Second + "\r\n";
                if (!string.IsNullOrEmpty(AlarmMessage))
                {
                    AlarmText = AlarmText + AlarmMessage + "\r\n";
                }
                if (!string.IsNullOrEmpty(CauseAlarmMessage))
                {
                    AlarmText = AlarmText + CauseAlarmMessage + "\r\n";
                }
                if (!string.IsNullOrEmpty(SeverityMessage))
                {
                    AlarmText = AlarmText + SeverityMessage;
                }
            }
            else
            {
                AlarmText = "Error";
            }
            return AlarmText;
        }

        public string[][] CurrentPosition()
        {
            string[] CurrentPositionText = { "", "" };
            string[] GetNowCPositionText = { "", "", "", "", "", "" };
            string[] GetNowJPositionText = { "", "", "", "", "", "" };
            string[][] ReturnText = new string[3][];

            Array Xyzwpr = new Single[9];
            Array Config = new short[7];
            Array Joint = new Single[9];
            short UF = 0;
            short UT = 0;
            short ValidC = 0;
            short ValidJ = 0;

            if (currentPosition_fg = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                CurrentPositionText[0] = "卡式座標\r\n" +
                    "X : " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(0)).ToString("###0.000")) + "\r\n" +
                    "Y : " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(1)).ToString("###0.000")) + "\r\n" +
                    "Z : " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(2)).ToString("###0.000")) + "\r\n" +
                    "W: " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(3)).ToString("###0.000")) + "\r\n" +
                    "P : " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(4)).ToString("###0.000")) + "\r\n" +
                    "R : " + String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(5)).ToString("###0.000"));

                CurrentPositionText[1] = "軸座標\r\n" +
                    "J1 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(0)).ToString("###0.000")) + "\r\n" +
                    "J2 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(1)).ToString("###0.000")) + "\r\n" +
                    "J3 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(2)).ToString("###0.000")) + "\r\n" +
                    "J4 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(3)).ToString("###0.000")) + "\r\n" +
                    "J5 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(4)).ToString("###0.000")) + "\r\n" +
                    "J6 : " + String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(5)).ToString("###0.000"));

                GetNowCPositionText[0] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(0)).ToString("###0.000"));
                GetNowCPositionText[1] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(1)).ToString("###0.000"));
                GetNowCPositionText[2] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(2)).ToString("###0.000"));
                GetNowCPositionText[3] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(3)).ToString("###0.000"));
                GetNowCPositionText[4] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(4)).ToString("###0.000"));
                GetNowCPositionText[5] = String.Format("{0,10}", Convert.ToSingle(Xyzwpr.GetValue(5)).ToString("###0.000"));

                GetNowJPositionText[0] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(0)).ToString("###0.000"));
                GetNowJPositionText[1] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(1)).ToString("###0.000"));
                GetNowJPositionText[2] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(2)).ToString("###0.000"));
                GetNowJPositionText[3] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(3)).ToString("###0.000"));
                GetNowJPositionText[4] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(4)).ToString("###0.000"));
                GetNowJPositionText[5] = String.Format("{0,10}", Convert.ToSingle(Joint.GetValue(5)).ToString("###0.000"));
            }
            else
            {
                CurrentPositionText[0] = "卡式座標\r\nError";
                CurrentPositionText[1] = "軸座標\r\nError";

                GetNowCPositionText[0] = "Error";
                GetNowCPositionText[1] = "Error";
                GetNowCPositionText[2] = "Error";
                GetNowCPositionText[3] = "Error";
                GetNowCPositionText[4] = "Error";
                GetNowCPositionText[5] = "Error";

                GetNowJPositionText[0] = "Error";
                GetNowJPositionText[1] = "Error";
                GetNowJPositionText[2] = "Error";
                GetNowJPositionText[3] = "Error";
                GetNowJPositionText[4] = "Error";
                GetNowJPositionText[5] = "Error";
            }
            ReturnText[0] = CurrentPositionText;
            ReturnText[1] = GetNowCPositionText;
            ReturnText[2] = GetNowJPositionText;
            return ReturnText;
        }

        public void CPositionSet(Single[] xyzwpr)
        {
            Array Xyzwpr = new Single[9];
            Array Config = new short[7];
            Array Joint = new Single[9];
            short UF = 0;
            short UT = 0;
            short ValidC = 0;
            short ValidJ = 0;

            if (currentPosition_fg = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;

                if (!(setCPosition_fg = mobjPosReg.SetValueXyzwpr(Index, xyzwpr, Config, UF, UT)))
                {
                    MessageBox.Show("卡式座標設定失敗");
                }
            }
            else
            {
                MessageBox.Show("卡式座標設定失敗");
            }
        }

        public void JPositionSet(Single[] joint)
        {
            Array Xyzwpr = new Single[9];
            Array Config = new short[7];
            Array Joint = new Single[9];
            short UF = 0;
            short UT = 0;
            short ValidC = 0;
            short ValidJ = 0;

            if (currentPosition_fg = mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;

                if (!(setCPosition_fg = mobjPosReg.SetValueJoint(Index, joint, UF, UT)))
                {
                    MessageBox.Show("軸座標設定失敗");
                }
            }
            else
            {
                MessageBox.Show("軸座標設定失敗");
            }
        }

        public string Override()
        {
            string OverrideText = "";
            object Value = null;

            if (override_fg = mobjSysVarInt.GetValue(ref Value))
            {
                OverrideText = Convert.ToString(Value) + "%";
            }
            else
            {
                OverrideText = "Error";
            }
            return OverrideText;
        }

        public string Register()
        {
            string RegisterText = "";
            int Index = 0;
            object Value = null;

            for (Index = 1; Index <= 2; Index++)
            {
                if (register_fg = mobjNumReg.GetValue(Index, ref Value))
                {
                    if (Index == 1)
                    {
                        RegisterText = "R" + Index + "   =   " + Convert.ToString(Value);
                    }
                    else
                    {
                        RegisterText = RegisterText + "\r\nR" + Index + "   =   " + Convert.ToString(Value);
                    }
                }
                else
                {
                    RegisterText = "Error";
                    break;
                }
            }
            return RegisterText;
        }

        public void RegisterSet(int Index, Single Value)
        {
            if (!(registerSet_fg = mobjNumReg.SetValue(Index, Value)))
            {
                MessageBox.Show("R{0}設定失敗", Index.ToString());
            }
        }
        
    }
}
