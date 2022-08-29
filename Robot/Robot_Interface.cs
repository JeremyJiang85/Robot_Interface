using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automation.BDaq;

namespace Robot
{
    public partial class Robot_Interface : Form
    {
        //==============================變數宣告區==============================

        public Fanuc fanuc = new Fanuc();

        public string IP = "";
        public string AlarmContent = "";
        public string[][] PositionText;
        public Single[] xyzwpr = new Single[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public Single[] joint = new Single[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string[] VelocityText;
        public int VelocityRegister = 7;
        public int VelocityValue = 100;

        public bool ConnectStatus_fg = false;

        byte portData = 0;
        ErrorCode err = ErrorCode.Success;
        private Button[,] m_IObutton;
        private int IOInitializeCount = 0;
            

        public Robot_Interface()
        {
            InitializeComponent();
            Deinitialize();
        }

        public void Initialize()
        {
            Alarm_lbl.Text = "";
            Xyzwpr_lbl.Text = "卡式座標\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            XJ1Set_tb.Text = "";
            YJ2Set_tb.Text = "";
            ZJ3Set_tb.Text = "";
            WJ4Set_tb.Text = "";
            PJ5Set_tb.Text = "";
            RJ6Set_tb.Text = "";
            VelocitySet_tb.Text = "";
            Joint_lbl.Text = "軸座標\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            Override_lbl.Text = "";
            Register_lbl.Text = "R1   =\r\nR2   =";
            R1Set_tb.Text = "";
            R2Set_tb.Text = "";
            PositionSet_cb.SelectedItem = "卡式座標";
            XJ1Set_lbl.Text = "X :";
            YJ2Set_lbl.Text = "Y :";
            ZJ3Set_lbl.Text = "Z :";
            WJ4Set_lbl.Text = "W:";
            PJ5Set_lbl.Text = "P :";
            RJ6Set_lbl.Text = "R :";
            PositionMove_cb.SelectedItem = "卡式座標";
            XJ1Negative_btn.Text = "-X";
            YJ2Negative_btn.Text = "-Y";
            ZJ3Negative_btn.Text = "-Z";
            WJ4Negative_btn.Text = "-W";
            PJ5Negative_btn.Text = "-P";
            RJ6Negative_btn.Text = "-R";
            XJ1Positive_btn.Text = "+X";
            YJ2Positive_btn.Text = "+Y";
            ZJ3Positive_btn.Text = "+Z";
            WJ4Positive_btn.Text = "+W";
            PJ5Positive_btn.Text = "+P";
            RJ6Positive_btn.Text = "+R";
            Velocity_lbl.Text = "Velocity :";

            Alarm_gb.Enabled = true;
            CurrentPosition_gb.Enabled = true;
            Override_gb.Enabled = true;
            Register_gb.Enabled = true;
            PositionSet_gb.Enabled = true;
            PositionMove_gb.Enabled = true;
            timer1.Enabled = true;

            fanuc.Refresh();
        }

        public void Deinitialize()
        {
            timer1.Enabled = false;
            Alarm_gb.Enabled = false;
            CurrentPosition_gb.Enabled = false;
            Override_gb.Enabled = false;
            Register_gb.Enabled = false;
            PositionSet_gb.Enabled = false;
            PositionMove_gb.Enabled = false;
            Output_pnl.Enabled = false;


            Alarm_lbl.Text = "";
            Xyzwpr_lbl.Text = "卡式座標\r\nX : \r\nY : \r\nZ : \r\nW: \r\nP : \r\nR : ";
            XJ1Set_tb.Text = "";
            YJ2Set_tb.Text = "";
            ZJ3Set_tb.Text = "";
            WJ4Set_tb.Text = "";
            PJ5Set_tb.Text = "";
            RJ6Set_tb.Text = "";
            VelocitySet_tb.Text = "";
            Joint_lbl.Text = "軸座標\r\nJ1 : \r\nJ2 : \r\nJ3 : \r\nJ4 : \r\nJ5 : \r\nJ6 : ";
            Override_lbl.Text = "";
            Register_lbl.Text = "R1   =\r\nR2   =";
            R1Set_tb.Text = "";
            R2Set_tb.Text = "";
            PositionSet_cb.SelectedItem = null;
            XJ1Set_lbl.Text = "";
            YJ2Set_lbl.Text = "";
            ZJ3Set_lbl.Text = "";
            WJ4Set_lbl.Text = "";
            PJ5Set_lbl.Text = "";
            RJ6Set_lbl.Text = "";
            PositionMove_cb.SelectedItem = null;
            XJ1Negative_btn.Text = "";
            YJ2Negative_btn.Text = "";
            ZJ3Negative_btn.Text = "";
            WJ4Negative_btn.Text = "";
            PJ5Negative_btn.Text = "";
            RJ6Negative_btn.Text = "";
            XJ1Positive_btn.Text = "";
            YJ2Positive_btn.Text = "";
            ZJ3Positive_btn.Text = "";
            WJ4Positive_btn.Text = "";
            PJ5Positive_btn.Text = "";
            RJ6Positive_btn.Text = "";

            Velocity_lbl.Text = "Velocity : ";

            IOInitialize_lbl.Text = "Uninitialized";
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
                    
                    fanuc.CPositionSet();
                    fanuc.VelocitySet(VelocityRegister);
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
            VelocityText = fanuc.Velocity(VelocityRegister);
            Velocity_lbl.Text = VelocityText[0];
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
                MessageBox.Show("請輸入有效數字");
                R1Set_tb.Text = "";
                R2Set_tb.Text = "";
            }
        }

        private void R1Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegisterSetKeyPressCheck(e);
        }

        private void R2Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegisterSetKeyPressCheck(e);
        }

        private void Velocity_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegisterSetKeyPressCheck(e);
        }

        private void RegisterSetKeyPressCheck(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void GetNowPosition_btn_Click(object sender, EventArgs e)
        {
            if ((string)PositionSet_cb.SelectedItem == "卡式座標")
            {
                XJ1Set_tb.Text = PositionText[1][0];
                YJ2Set_tb.Text = PositionText[1][1];
                ZJ3Set_tb.Text = PositionText[1][2];
                WJ4Set_tb.Text = PositionText[1][3];
                PJ5Set_tb.Text = PositionText[1][4];
                RJ6Set_tb.Text = PositionText[1][5];
                VelocitySet_tb.Text = VelocityText[1];
            }
            if ((string)PositionSet_cb.SelectedItem == "軸座標")
            {
                XJ1Set_tb.Text = PositionText[2][0];
                YJ2Set_tb.Text = PositionText[2][1];
                ZJ3Set_tb.Text = PositionText[2][2];
                WJ4Set_tb.Text = PositionText[2][3];
                PJ5Set_tb.Text = PositionText[2][4];
                RJ6Set_tb.Text = PositionText[2][5];
                VelocitySet_tb.Text = VelocityText[1];
            }
        }

        private void SetPosition_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(XJ1Set_tb.Text) || string.IsNullOrEmpty(YJ2Set_tb.Text) ||
                    string.IsNullOrEmpty(ZJ3Set_tb.Text) || string.IsNullOrEmpty(WJ4Set_tb.Text) ||
                    string.IsNullOrEmpty(PJ5Set_tb.Text) || string.IsNullOrEmpty(RJ6Set_tb.Text) ||
                    string.IsNullOrEmpty(VelocitySet_tb.Text))
                {
                    MessageBox.Show("座標值和速度值不可有空白");
                }
                else
                {
                    if ((string)PositionSet_cb.SelectedItem == "卡式座標")
                    {
                        xyzwpr[0] = Convert.ToSingle(XJ1Set_tb.Text);
                        xyzwpr[1] = Convert.ToSingle(YJ2Set_tb.Text);
                        xyzwpr[2] = Convert.ToSingle(ZJ3Set_tb.Text);
                        xyzwpr[3] = Convert.ToSingle(WJ4Set_tb.Text);
                        xyzwpr[4] = Convert.ToSingle(PJ5Set_tb.Text);
                        xyzwpr[5] = Convert.ToSingle(RJ6Set_tb.Text);
                        VelocityValue = Convert.ToInt32(VelocitySet_tb.Text);

                        if (xyzwpr[0] >= 0 && xyzwpr[0] <= 700 && 
                            xyzwpr[1] >= -500 && xyzwpr[1] <= 600 && 
                            xyzwpr[2] >= -130 && xyzwpr[2] <= 500)
                        {
                            if (VelocityValue >= 100 && VelocityValue <= 500)
                            {
                                fanuc.VelocitySet(VelocityRegister, VelocityValue);
                                fanuc.CPositionSet(xyzwpr);
                            }
                            else
                            {
                                MessageBox.Show("速度超出安全範圍");
                            }
                        }
                        else
                        {
                            MessageBox.Show("座標超出安全範圍");
                        }
                    }

                    if ((string)PositionSet_cb.SelectedItem == "軸座標")
                    {
                        joint[0] = Convert.ToSingle(XJ1Set_tb.Text);
                        joint[1] = Convert.ToSingle(YJ2Set_tb.Text);
                        joint[2] = Convert.ToSingle(ZJ3Set_tb.Text);
                        joint[3] = Convert.ToSingle(WJ4Set_tb.Text);
                        joint[4] = Convert.ToSingle(PJ5Set_tb.Text);
                        joint[5] = Convert.ToSingle(RJ6Set_tb.Text);
                        VelocityValue = Convert.ToInt32(VelocitySet_tb.Text);

                        if (VelocityValue >= 100 && VelocityValue <= 500)
                        {
                            fanuc.JPositionSet(joint);
                            fanuc.VelocitySet(VelocityRegister, VelocityValue);
                        }
                        else
                        {
                            MessageBox.Show("速度超出安全範圍");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入有效數字");
            }
        }

        private void XJ1Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void YJ2Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void ZJ3Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void WJ4Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void PJ5Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void RJ6Set_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositionSetKeyPressCheck(e);
        }

        private void PositionSetKeyPressCheck(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == (Char)45 || e.KeyChar == (Char)46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PositionSet_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)PositionSet_cb.SelectedItem == "卡式座標")
            {
                XJ1Set_lbl.Text = "X :";
                YJ2Set_lbl.Text = "Y :";
                ZJ3Set_lbl.Text = "Z :";
                WJ4Set_lbl.Text = "W:";
                PJ5Set_lbl.Text = "P :";
                RJ6Set_lbl.Text = "R :";
            }

            if ((string)PositionSet_cb.SelectedItem == "軸座標")
            {
                XJ1Set_lbl.Text = "J1 :";
                YJ2Set_lbl.Text = "J2 :";
                ZJ3Set_lbl.Text = "J3 :";
                WJ4Set_lbl.Text = "J4 :";
                PJ5Set_lbl.Text = "J5 :";
                RJ6Set_lbl.Text = "J6 :";
            }
        }
        
        private void BackTotheInitialStatus_btn_Click(object sender, EventArgs e)
        {
            xyzwpr[0] = 180;
            xyzwpr[1] = 0;
            xyzwpr[2] = 280;
            xyzwpr[3] = 180;
            xyzwpr[4] = 0;
            xyzwpr[5] = 0;
            VelocityValue = 100;

            fanuc.VelocitySet(VelocityRegister, VelocityValue);
            fanuc.CPositionSet(xyzwpr);
        }

        private void PositionMove_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)PositionMove_cb.SelectedItem == "卡式座標")
            {
                XJ1Negative_btn.Text = "-X";
                YJ2Negative_btn.Text = "-Y";
                ZJ3Negative_btn.Text = "-Z";
                WJ4Negative_btn.Text = "-W";
                PJ5Negative_btn.Text = "-P";
                RJ6Negative_btn.Text = "-R";
                XJ1Positive_btn.Text = "+X";
                YJ2Positive_btn.Text = "+Y";
                ZJ3Positive_btn.Text = "+Z";
                WJ4Positive_btn.Text = "+W";
                PJ5Positive_btn.Text = "+P";
                RJ6Positive_btn.Text = "+R";
            }

            if ((string)PositionMove_cb.SelectedItem == "軸座標")
            {
                XJ1Negative_btn.Text = "-J1";
                YJ2Negative_btn.Text = "-J2";
                ZJ3Negative_btn.Text = "-J3";
                WJ4Negative_btn.Text = "-J4";
                PJ5Negative_btn.Text = "-J5";
                RJ6Negative_btn.Text = "-J6";
                XJ1Positive_btn.Text = "+J1";
                YJ2Positive_btn.Text = "+J2";
                ZJ3Positive_btn.Text = "+J3";
                WJ4Positive_btn.Text = "+J4";
                PJ5Positive_btn.Text = "+J5";
                RJ6Positive_btn.Text = "+J6";
            }
        }

        private void XJ1Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(XJ1Positive_btn.Text);
        }

        private void XJ1Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(XJ1Negative_btn.Text);
        }

        private void YJ2Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(YJ2Positive_btn.Text);
        }

        private void YJ2Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(YJ2Negative_btn.Text);
        }

        private void ZJ3Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(ZJ3Positive_btn.Text);
        }

        private void ZJ3Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(ZJ3Negative_btn.Text);
        }

        private void WJ4Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(WJ4Positive_btn.Text);
        }

        private void WJ4Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(WJ4Negative_btn.Text);
        }

        private void PJ5Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(PJ5Positive_btn.Text);
        }

        private void PJ5Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(PJ5Negative_btn.Text);
        }

        private void RJ6Positive_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(RJ6Positive_btn.Text);
        }

        private void RJ6Negative_btn_Click(object sender, EventArgs e)
        {
            fanuc.PositionMove(RJ6Negative_btn.Text);
        }

        private void IOInitialize_btn_Click(object sender, EventArgs e)
        {
            if (!instantDoCtrl1.Initialized)
            {
                MessageBox.Show("IO卡初始化失敗");
                return;
            }
            
            portData = 0;
            IOInitialize_lbl.Text = "Initialized";
            Output_pnl.Enabled = true;
            Console.WriteLine(IOInitializeCount);
            if (IOInitializeCount == 0)
            {
                m_IObutton = new Button[2, 8]{ { P00_btn, P01_btn, P02_btn, P03_btn, P04_btn, P05_btn, P06_btn, P07_btn},
                                               { P10_btn, P11_btn, P12_btn, P13_btn, P14_btn, P15_btn, P16_btn, P17_btn} };
            }
            
            for (int i = 0; i <= m_IObutton.GetLength(0)-1; i++)
            {
                err = instantDoCtrl1.Write(i, portData);
                if (err != ErrorCode.Success)
                {
                    HandleError(err);
                    return;
                }
                for (int j = 0; j <= m_IObutton.GetLength(1)-1; j++)
                {
                    if (IOInitializeCount == 0)
                    {
                        m_IObutton[i, j].Click += new EventHandler(Button_Click);
                        m_IObutton[i, j].Tag = new DoBitInformation(i, j, portData);
                    }
                    m_IObutton[i, j].BackColor = Color.Green;
                }
            }

            IOInitializeCount++;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            DoBitInformation buttonInformation = (DoBitInformation)button.Tag;
            byte temp;
            temp = (byte)(buttonInformation.BitValue ^ 0x01);
            err = instantDoCtrl1.WriteBit(buttonInformation.PortNum, buttonInformation.BitNum, temp);
            if (err != ErrorCode.Success)
            {
                HandleError(err);
                return;
            }
            buttonInformation.BitValue = temp;
            button.Tag = buttonInformation;
            if (buttonInformation.BitValue == 1)
            {
                button.BackColor = Color.Red;
            }
            else
            {
                button.BackColor = Color.Green;
            }
        }

        private void HandleError(ErrorCode err)
        {
            if ((err >= ErrorCode.ErrorHandleNotValid) && (err != ErrorCode.Success))
            {
                MessageBox.Show("Sorry ! Some errors happened, the error code is: " + err.ToString());
            }
        }

        
    }

    //==============================class Fanuc==============================
    public class Fanuc
    {
        private FRRJIf.Core mobjCore;
        private FRRJIf.DataTable mobjDataTable;
        private FRRJIf.DataCurPos mobjCurPos;
        private FRRJIf.DataTask mobjTask;
        private FRRJIf.DataPosReg mobjPosReg;
        private FRRJIf.DataSysVar mobjSysVarInt;
        private FRRJIf.DataNumReg mobjNumReg;
        private FRRJIf.DataAlarm mobjAlarmCurrent;
        
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
            if (!(mobjDataTable.Refresh()))
            {
                MessageBox.Show("Refresh失敗");
            }
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

            if (mobjAlarmCurrent.GetValue(Count, ref AlarmID, ref AlarmNumber, ref CauseAlarmID, ref CauseAlarmNumber, ref Severity,
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

            if (mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
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

            if (mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;

                if (!(mobjPosReg.SetValueXyzwpr(Index, xyzwpr, Config, UF, UT)))
                {
                    MessageBox.Show("卡式座標設定失敗");
                }
            }
            else
            {
                MessageBox.Show("取得目前卡式座標失敗");
            }

        }

        public void CPositionSet()
        {
            Array Xyzwpr = new Single[9];
            Array Config = new short[7];
            Array Joint = new Single[9];
            short UF = 0;
            short UT = 0;
            short ValidC = 0;
            short ValidJ = 0;

            if (mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;

                if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                {
                    MessageBox.Show("卡式座標設定失敗");
                }
            }
            else
            {
                MessageBox.Show("取得目前卡式座標失敗");
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

            if (mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;

                if (!(mobjPosReg.SetValueJoint(Index, joint, UF, UT)))
                {
                    MessageBox.Show("軸座標設定失敗");
                }
            }
            else
            {
                MessageBox.Show("取得目前軸座標失敗");
            }
        }

        public string Override()
        {
            string OverrideText = "";
            object Value = null;

            if (mobjSysVarInt.GetValue(ref Value))
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
            int Index = 1;
            object Value = null;

            for (Index = 1; Index <= 2; Index++)
            {
                if (mobjNumReg.GetValue(Index, ref Value))
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

        public string[] Velocity(int VelocityRegister)
        {
            string[] VelocityText = { "", "" };
            int index = VelocityRegister;
            object Value = null;

            if (mobjNumReg.GetValue(index, ref Value))
            {
                VelocityText[0] = "Velocity : " + Convert.ToString(Value);
                VelocityText[1] = Convert.ToString(Value);
            }
            else
            {
                VelocityText[0] = "Velocity : Error";
                VelocityText[1] = "Error";
            }
            return VelocityText;
        }

        public void RegisterSet(int Index, Single Value)
        {
            if (!(mobjNumReg.SetValue(Index, Value)))
            {
                MessageBox.Show("R" + Index.ToString() + "設定失敗");
            }
        }

        public void VelocitySet(int Index, Single Value)
        {
            if (!(mobjNumReg.SetValue(Index, Value)))
            {
                MessageBox.Show("R" + Index.ToString() + "(速度)設定失敗");
            }
        }

        public void VelocitySet(int Index)
        {
            object Value = null;

            if (mobjNumReg.GetValue(Index, ref Value))
            {
                if (!(mobjNumReg.SetValue(Index, Value)))
                {
                    MessageBox.Show("R" + Index.ToString() + "(速度)設定失敗");
                }
            }
            else
            {
                MessageBox.Show("R" + Index.ToString() + "(速度)取得失敗");
            }
        }
        
        public void PositionMove(string Axis)
        {
            Array Xyzwpr = new Single[9];
            Array Config = new short[7];
            Array Joint = new Single[9];
            short UF = 0;
            short UT = 0;
            short ValidC = 0;
            short ValidJ = 0;

            if (mobjCurPos.GetValue(ref Xyzwpr, ref Config, ref Joint, ref UF, ref UT, ref ValidC, ref ValidJ))
            {
                int Index = 1;


                switch (Axis)
                {
                    case "+X":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(0)) + 5, 0);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-X":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(0)) - 5, 0);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+Y":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(1)) + 5, 1);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-Y":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(1)) - 5, 1);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+Z":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(2)) + 5, 2);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-Z":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(2)) - 5, 2);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+W":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(3)) + 5, 3);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-W":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(3)) - 5, 3);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+P":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(4)) + 5, 4);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-P":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(4)) - 5, 4);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+R":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(5)) + 5, 5);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-R":
                        Xyzwpr.SetValue(Convert.ToSingle(Xyzwpr.GetValue(5)) - 5, 5);
                        if (!(mobjPosReg.SetValueXyzwpr(Index, Xyzwpr, Config, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J1":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(0)) + 5, 0);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J1":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(0)) - 5, 0);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J2":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(1)) + 5, 1);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J2":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(1)) - 5, 1);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J3":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(2)) + 5, 2);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J3":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(2)) - 5, 2);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J4":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(3)) + 5, 3);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J4":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(3)) - 5, 3);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J5":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(4)) + 5, 4);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J5":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(4)) - 5, 4);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "+J6":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(5)) + 5, 5);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;

                    case "-J6":
                        Joint.SetValue(Convert.ToSingle(Joint.GetValue(5)) - 5, 5);
                        if (!(mobjPosReg.SetValueJoint(Index, Joint, UF, UT)))
                        {
                            MessageBox.Show("軸座標設定失敗");
                        }
                        break;
                }


            }
            else
            {
                MessageBox.Show("取得目前軸座標失敗");
            }
        }
    }

    //==============================class IO==============================
    public class DoBitInformation
    {
        private int m_portNum;
        private int m_bitNum;
        private byte m_bitValue;

        public DoBitInformation(int portNum, int bitNum, byte bitvalue)
        {
            m_portNum = portNum;
            m_bitNum = bitNum;
            m_bitValue = bitvalue;
        }

        public int PortNum
        {
            get { return m_portNum; }
            set
            {
                if ((value - 0) >= 0
                   && (value - 0) <= (2 - 1))
                {
                    m_portNum = value;
                }
                else
                {
                    MessageBox.Show("超出Port範圍");
                }
            }
        }

        public int BitNum
        {
            get { return m_bitNum; }
            set
            {
                if (value >= 0 && value <= 7)
                {
                    m_bitNum = value;
                }
                else
                {
                    MessageBox.Show("超出Bit範圍");
                }
            }
        }

        public byte BitValue
        {
            get { return m_bitValue; }
            set
            {
                if (value == 0 || value == 1)
                {
                    m_bitValue = value;
                }
                else
                {
                    MessageBox.Show("超出BitValue範圍");
                }
            }
        }
    }
}
