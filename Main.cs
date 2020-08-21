using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MedicSimsCheatmenu
{
    public partial class MedicsCheatmenu : Form
    {
        [DllImport("user32")]
        private static extern bool SetForegroundWindow(IntPtr hwnd);
        public bool bool_button1, bool_button2, bool_button3, bool_button4, bool_button5, bool_button6, bool_button7, bool_button8;
        public MedicsCheatmenu()
        {
            InitializeComponent();
        }

        private void bt_cas_unlockbytag_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("cas.unlockbytag{enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button8 == false)
                {
                    bt_cas_unlockbytag.BackColor = SystemColors.GradientActiveCaption;
                    bool_button8 = true;
                }
                else if (bool_button8 == true)
                {
                    bt_cas_unlockbytag.BackColor = SystemColors.ControlLight;
                    bool_button8 = false;
                }
            }
        }

        private void bt_moveobjects_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("bb.moveobjects {enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button1 == false)
                {
                    bt_moveobjects.BackColor = SystemColors.GradientActiveCaption;
                    bool_button1 = true;
                }
                else if (bool_button1 == true)
                {
                    bt_moveobjects.BackColor = SystemColors.ControlLight;
                    bool_button1 = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                if (bool_button7 == false)
                {
                    bt_money.BackColor = SystemColors.GradientActiveCaption;
                    SendKeys.SendWait("money 500000{enter}");
                    bool_button7 = true;
                }
                else if (bool_button7 == true)
                {
                    bt_money.BackColor = SystemColors.ControlLight;
                    SendKeys.SendWait("money 5000{enter}");
                    bool_button7 = false;
                }
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
            }
        }

        private void bt_testingcheats_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                if (bool_button6 == false)
                {
                    SendKeys.SendWait("testingcheats true{enter}");
                    bt_testingcheats.BackColor = SystemColors.GradientActiveCaption;
                    bool_button6 = true;
                }
                else if (bool_button6 == true)
                {
                    SendKeys.SendWait("testingcheats false{enter}");
                    bt_testingcheats.BackColor = SystemColors.ControlLight;
                    bool_button6 = false;
                }
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
            }
        }

        private void bt_showhiddenobjects_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("bb.showhiddenobjects{enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button2 == false)
                {
                    bt_showhiddenobjects.BackColor = SystemColors.GradientActiveCaption;
                    bool_button2 = true;
                }
                else if (bool_button2 == true)
                {
                    bt_showhiddenobjects.BackColor = SystemColors.ControlLight;
                    bool_button2 = false;
                }
            }
        }

        private void bt_showliveeditobjects_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("bb.showliveeditobjects{enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button3 == false)
                {
                    bt_showliveeditobjects.BackColor = SystemColors.GradientActiveCaption;
                    bool_button3 = true;
                }
                else if (bool_button3 == true)
                {
                    bt_showliveeditobjects.BackColor = SystemColors.ControlLight;
                    bool_button3 = false;
                }
            }
        }

        private void bt_ignoregameplayunlocksentitlement_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("bb.ignoregameplayunlocksentitlement{enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button4 == false)
                {
                    bt_ignoregameplayunlocksentitlement.BackColor = SystemColors.GradientActiveCaption;
                    bool_button4 = true;
                }
                else if (bool_button4 == true)
                {
                    bt_ignoregameplayunlocksentitlement.BackColor = SystemColors.ControlLight;
                    bool_button4 = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("TS4_x64").FirstOrDefault();
            SetForegroundWindow(proc.MainWindowHandle);
            if (proc != null && proc.MainWindowHandle != IntPtr.Zero)
            {
                Thread.Sleep(500);
                Console.Beep(500, 250);
                SendKeys.SendWait("^(+c)");
                Thread.Sleep(50);
                SendKeys.SendWait("cas.fulleditmode{enter}");
                Thread.Sleep(200);
                SendKeys.SendWait("^(+c)");
                if (bool_button5 == false)
                {
                    cas_fulleditmode.BackColor = SystemColors.GradientActiveCaption;
                    bool_button5 = true;
                }
                else if (bool_button5 == true)
                {
                    cas_fulleditmode.BackColor = SystemColors.ControlLight;
                    bool_button5 = false;
                }
            }
        }
    }
}
