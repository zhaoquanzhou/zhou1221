using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用
{
    public partial class Form1 : Form
    {
        IniFile IniFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender,EventArgs e)
        {
            MessageBox.Show("点击了");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbx_user.Text=="admin"&&tbx_pwd.Text=="123")
            {
                if (true)
                {

                }
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }
    }
}
