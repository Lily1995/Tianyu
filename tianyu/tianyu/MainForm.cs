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
    public partial class MainForm : Form
    {
        private List<Image> lst = new List<Image>();
        private int ImageIndex = 0;
        private Timer timer4 = new Timer();
        public MainForm()
        {
            InitializeComponent();
            lst.Add(Image.FromFile(@"G:\TY\天娱\tianyu\tianyu\images\我.jpg"));
            lst.Add(Image.FromFile(@"G:\TY\天娱\tianyu\tianyu\images\YA.jpg"));
            lst.Add(Image.FromFile(@"G:\TY\天娱\tianyu\tianyu\images\是.jpg"));

            timer3.Interval = 2500;
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Enabled = true;

            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.timer5.Start();
            if (UserHelper.loginType == "售票员")
            {                
                tsbtnUptade.Enabled = false;//如果是售票员登陆，更新及修改影片功能不能使用
                tsmiAdd.Enabled = false;//如果是售票员登陆，菜单中增加影片功能不能使用
                tsmiUpdate.Enabled = false;//如果是售票员登陆，菜单中修改影片功能不能使用
                tsmiDelete.Enabled = false;//如果是售票员登陆，菜单中删除影片功能不能使用
            }
            //设置标签文本框，显示当前登录的类型
            this.tsmiLogin.Text = UserHelper.loginId + "  " + UserHelper.loginType + "  欢迎您！";
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            ExitForm exit = new ExitForm();
            exit.ShowDialog();//显示模式窗口
            this.Close();


        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            //AddForm add = new AddForm();
            //add.ShowDialog();
            Film film = new Film();
            film.Show();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.ShowDialog();
        }

        private void tsmiFilms_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.ShowDialog();
        }

        private void tsmiOrder_Click(object sender, EventArgs e)
        {
            SelectForm selectfrom = new SelectForm();
            selectfrom.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SearchOrderForm searchorder = new SearchOrderForm();
            searchorder.ShowDialog();
        }

        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            SearchOrderForm searchorder = new SearchOrderForm();
            searchorder.ShowDialog();
        }

        private void tsmiMemberInfor_Click(object sender, EventArgs e)
        {
            MemberForm member = new MemberForm();
            member.ShowDialog();
        }

        private void tsmiRegister_Click(object sender, EventArgs e)
        {
            RegistForm regist = new RegistForm();
            regist.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.lbtime.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //this.pictureBox2.Controls.Add(this.pictureBox2);
            //this.Close();
        }

        private void lbtime_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = lst[ImageIndex];
            ImageIndex++;
            if (ImageIndex > lst.Count - 1)
                ImageIndex = 0;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            pictureBox2.Image = lst[ImageIndex];
            ImageIndex++;
            if (ImageIndex > lst.Count - 1)
                ImageIndex = 0;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label3.Left = label3.Left - 3;
            if(label3.Right<0)
            {
                label3.Left = this.Width;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label3.Controls.Add(this.label3);
        }
    }
}
