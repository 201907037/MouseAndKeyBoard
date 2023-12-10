using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseAndKey
{
    public partial class Form2 : Form
    {

        private string currentTextBoxValue = "";

        const int WM_KEYDOWN = 0x100;

        public static string mousestart = "F1";
        public static string mouseend = "F2";
        public static string keystart = "F3";
        public static string keyend = "F4";
        public Form2()
        {
            InitializeComponent();
            textBox1.KeyDown += textBox1_KeyDown;
            textBox2.KeyDown += textBox2_KeyDown;
            textBox3.KeyDown += textBox3_KeyDown;
            textBox4.KeyDown += textBox4_KeyDown;
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender;
            currentTextBoxValue = e.KeyCode.ToString();
            textBox1.Text = currentTextBoxValue;
            e.SuppressKeyPress = true; // 키 이벤트 전파 방지
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox2 = (TextBox)sender;
            currentTextBoxValue = e.KeyCode.ToString();
            textBox2.Text = currentTextBoxValue;
            e.SuppressKeyPress = true; // 키 이벤트 전파 방지
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox3 = (TextBox)sender;
            currentTextBoxValue = e.KeyCode.ToString();
            textBox3.Text = currentTextBoxValue;
            e.SuppressKeyPress = true; // 키 이벤트 전파 방지
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox4 = (TextBox)sender;
            currentTextBoxValue = e.KeyCode.ToString();
            textBox4.Text = currentTextBoxValue;
            e.SuppressKeyPress = true; // 키 이벤트 전파 방지
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1= new Form1();
            f1.setKey = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text;

            mousestart = textBox1.Text;
            mouseend  = textBox2.Text;
            keystart = textBox3.Text;
            keyend = textBox4.Text;

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = mousestart;
            textBox2.Text = mouseend;
            textBox3.Text = keystart;
            textBox4.Text = keyend;
        }
    }
}
