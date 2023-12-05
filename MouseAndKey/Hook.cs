using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseAndKey
{
    internal class Hook
    {
        [DllImport("User32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        Thread hth;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);



        const int WH_KEYBOARD_LL = 13;

        const int WM_KEYDOWN = 0x100;



        private IntPtr hook = IntPtr.Zero;

        public void SetHook()

        {

            IntPtr hInstance = LoadLibrary("User32");



            hook = SetWindowsHookEx(WH_KEYBOARD_LL, HookProc, hInstance, 0);
            //MessageBox.Show("set 눌림", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        public void UnHook()

        {

            UnhookWindowsHookEx(hook);

        }

        private IntPtr HookProc(int code,  IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)

            {
                int vkCode = Marshal.ReadInt32(lParam);

                if (vkCode.ToString() == "162")
                {
                    hth.Abort();
                    //MessageBox.Show("컨트롤 눌림", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return CallNextHookEx(hook, code, (int)wParam, lParam); // 키입력을 정상적으로 동작하게 합니다.
            }
            else

            {

                return CallNextHookEx(hook, code, (int)wParam, lParam);

            }
        }

        public Hook(Thread th)
        {
            hth = th;
            //MessageBox.Show("컨트롤 눌림", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
