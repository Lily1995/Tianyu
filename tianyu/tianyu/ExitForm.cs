using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tianyu
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdoExit1.Checked)
            {
                Application.Exit();//如果选择直接退出，关闭整个程序
            }

            else
            {
                this.Close();
                loginForm logionForm = new loginForm();//选择换班退出，打开登陆窗口
                logionForm.Show();
            }
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();//关闭此退出窗口
        }

        private void rdoExit1_Click(object sender, EventArgs e)
        {
            string Exit = ((RadioButton)sender).Text;//选择的按钮
        }

        private void rdoExit2_Click(object sender, EventArgs e)
        {
            string Exit = ((RadioButton)sender).Text;//选择的按钮
        }

        private void lblExit1_Click(object sender, EventArgs e)
        {

        }

        private void rdoExit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoExit2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picpicture_Click(object sender, EventArgs e)
        {

        }
    }
}
