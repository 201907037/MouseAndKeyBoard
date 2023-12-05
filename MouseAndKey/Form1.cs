using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseAndKey
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private static int Cur_x, Cur_y; //text박스에서 가져올 x,y
        private static int Loop_cun; //반복 횟수

        private const uint L_down = 0x0002;
        private const uint L_up = 0x0004;

        Thread clstart;
        Hook hook;

        public Form1()
        {
            InitializeComponent();
        }

        private string positionlbl;

        private void timer_Tick(object sender, EventArgs e)
        {
            mPosition.Text = positionlbl + " X : " + Cursor.Position.X + ", " + "Y : " + Cursor.Position.Y;

        }

        private void mButton_Click(object sender, EventArgs e)
        {
            clstart = new Thread(click_start);
            clstart.Start();
            hook = new Hook(clstart);
            hook.SetHook();
        }

        private void click_start()
        {
            int flag = 0;
            if (flag == 0)
            {
                if (!String.IsNullOrEmpty(xPtxt.Text) && !String.IsNullOrEmpty(yPtxt.Text))
                {
                    Cur_x = Convert.ToInt32(xPtxt.Text);
                    Cur_y = Convert.ToInt32(yPtxt.Text);
                    Cursor.Position = new Point(Cur_x, Cur_y);
                }
                Loop_cun = Convert.ToInt32(cnt.Text);
                KeyPreview = true;
                for (int i = 0; i < Loop_cun; i++)
                {
                    mouse_event(L_down, 0, 0, 0, 0);
                    mouse_event(L_up, 0, 0, 0, 0);
                    Thread.Sleep(100);
                }
                flag = 1;
            }
            else { clstart.Abort(); hook.UnHook(); }

        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            clstart.Abort(); hook.UnHook();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Space)
            {
                //Thread.Sleep(1000);
                MessageBox.Show("키 눌림", "test", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ctrl을 누르면 마우스 매크로가 중단됩니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            positionlbl = mPosition.Text;
            timer.Start();

        }

    }
}
