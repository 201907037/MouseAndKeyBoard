using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
        private static int Loop_cun; //마우스 반복 횟수
        private static int Loop_cun2; //키보드 반복 횟수
        private static int Delay; //마우스 시간지연
        private static int Delay2; //키보드 시간지연

        private const uint L_down = 0x0002;
        private const uint L_up = 0x0004;

        public static string setKeyList="F1,F2,F3,F4"; //단축키 초기값
        public static string mousestart="F1";
        public static string mouseend="F2";
        public static string keystart="F3";
        public static string keyend="F4";

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

        public string setKey //Form2에 있는 데이터 가져오는 속성
        {
            set
            {
                setKeyList = value;
            }
        }
        private void mButton_Click(object sender, EventArgs e)
        {
            clstart = new Thread(click_start);
            clstart.Start();
            hook = new Hook(clstart);
            hook.SetHook();
        }
        private void kButton_Click(object sender, EventArgs e)
        {
           String message = this.txtKeyboard.Text;

           
            Loop_cun2 = Convert.ToInt32(txtKeyRepeat.Text);
            Delay2 = int.Parse(txtKdelay.Text);
            hook = new Hook();
            hook.SetHook();
            Thread.Sleep(3000); // 매크로가 3초 뒤에 실행
            if (Loop_cun2 == 0)
            {
                while (true)
                {
                    SendKeys.Send(message);
                    Thread.Sleep(Delay2);
                   
                }
            }
            else
            {
                for (int i = 0; i < Loop_cun2; i++)
                {
                    SendKeys.Send(message);
                    Thread.Sleep(Delay2);
                }
            }
        }
        private void click_start()
        {
            int flag = 0;
            Delay = int.Parse(txtMdelay.Text);
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
                if (Loop_cun == 0)
                {
                    while (true)
                    { 
                        mouse_event(L_down, 0, 0, 0, 0);
                        mouse_event(L_up, 0, 0, 0, 0);
                        Thread.Sleep(Delay);
                    }
                }
                else
                {
                    for (int i = 0; i < Loop_cun; i++)
                    {
                        mouse_event(L_down, 0, 0, 0, 0);
                        mouse_event(L_up, 0, 0, 0, 0);
                        Thread.Sleep(Delay);
                    }
                    flag = 1;
                }
            }
            else { clstart.Abort(); hook.UnHook(); }

        }
        private void MyThreadFunctionWithParameter(Object txt)
        {
            try
            {
               
            }
            finally
            {
                // 쓰레드 종료 전에 필요한 정리 작업 수행
                hook.UnHook();
            }
        }

        private void key_start(String txt)
        {
           
        }

        private void btn_E_Click(object sender, EventArgs e)
        {
            //clstart.Abort();hook.UnHook();
            SendKeys.Flush();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ////form1에 포커스가 정확하게 맞춰졌을때만 실행됨
            //if (e.KeyCode == Keys.F1)
            //{
            //    mButton_Click(sender, e);
            //}
            //if (e.KeyCode == Keys.F3)
            //{
            //    kButton_Click(sender, e);
            //}
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 매크로단축키설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            positionlbl = mPosition.Text;
            timer.Start();
        }


        private void exp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("반복 횟수가 0이면 무한 반복됩니다. 마우스 종료단축키 F2\n" +
            "시간 지연은 ms단위입니다 1초=1000", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //여기에서 form2에 가져온 단축키 값이 저장되있나 임시로 체크
            string[] KeyList = setKeyList.Split(',');
            mousestart = KeyList[0];
            mouseend = KeyList[1];
            keystart = KeyList[2];
            keyend = KeyList[3];

            //MessageBox.Show($"4개 값: {mousestart},{mouseend},{keystart},{keyend}\n" +
            //    $"setKeyList 값 : {setKeyList}", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
