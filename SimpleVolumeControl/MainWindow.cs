using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVolumeControl
{
    public partial class MainWindow : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        private const int StepSize = 100;
        private Timer VolDownTimer;
        private Timer VolUpTimer;

        public MainWindow()
        {
            InitializeComponent();

            VolDownTimer = new Timer();
            VolDownTimer.Interval = StepSize;
            VolDownTimer.Enabled = false;
            VolDownTimer.Tick += VolDownTimer_Tick;

            VolUpTimer = new Timer();
            VolUpTimer.Interval = StepSize;
            VolUpTimer.Enabled = false;
            VolUpTimer.Tick += VolUpTimer_Tick;
        }

        private void VolDownTimer_Tick(object sender, EventArgs e)
        {
            VolDown();
        }

        private void VolUpTimer_Tick(object sender, EventArgs e)
        {
            VolUp();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int msg,IntPtr wParam, IntPtr lParam);

        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void BtnDec_MouseDown(object sender, MouseEventArgs e)
        {
            VolDownTimer.Enabled = true;
        }

        private void BtnDec_MouseUp(object sender, MouseEventArgs e)
        {
            VolDownTimer.Enabled = false;
        }

        private void BtnInc_MouseDown(object sender, MouseEventArgs e)
        {
            VolUpTimer.Enabled = true;
        }

        private void BtnInc_MouseUp(object sender, MouseEventArgs e)
        {
            VolUpTimer.Enabled = false;
        }

        private void BtnMute_Click(object sender, EventArgs e)
        {
            Mute();
        }
    }
}
