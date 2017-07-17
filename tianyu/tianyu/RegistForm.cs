using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tianyu
{
    public partial class RegistForm : Form
    {
        public RegistForm()
        {
            InitializeComponent();
        }

        private void RegistForm_Load(object sender, EventArgs e)
        {
            //隐藏提示语
            labClew.Visible = false;
            labNumber.Visible = false;
            //cboType.Items.Add("钻石会员");
            //cboType.Items.Add("金卡会员");
            //cboType.Items.Add("银卡会员");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //折扣
            int discount = 0;
            //if(cboType.Text=="全部")
            //{
            //    discount = 0;
            //}
            if (cboType.Text == "钻石会员")
            {
                discount = 60;
            }
            else if (cboType.Text == "金卡会员")
            {
                discount = 65;
            }
            else if (cboType.Text == "银卡会员")
            {
                discount = 70;
            }

            try
            {

                if (ValidateInput())
                {
                    //打开数据库
                    DBHelper.conn.Open(); 
                    string sql = string.Format(@"insert into Member( MName,MIDcard,Mphone,MDiscount,MType)
                                               values ('{0}','{1}','{2}',{3},'{4}')", txtName.Text, txtPeopleId.Text, txtPhone.Text, discount, cboType.Text);  
                    SqlCommand command = new SqlCommand(sql, DBHelper.conn);
                    int row = command.ExecuteNonQuery();
                    if (row == 1)
                    {
                        //存储输入的身份证
                        UserHelper.MemberID = txtPeopleId.Text.Trim();
                        //存储输入的会员类型
                        UserHelper.type = cboType.Text.Trim();       
                        DialogResult results = MessageBox.Show("注册成功！");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库
                DBHelper.conn.Close();  
            }


        }
        //调用
        private bool ValidateInput()
        {
            return Input();
        }
        //方法
        private bool Input()
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名");
                txtName.Focus(); //获得焦点
                return false;
            }
            else if (cboType.Text.Trim() == "")
            {
                MessageBox.Show("请选择会员类型");
                cboType.Focus(); 
                return false;
            }
            else if (txtPeopleId.Text.Trim() == "")
            {
                MessageBox.Show("请输入有效证件");
                txtPeopleId.Focus();  
                return false;
            }
            else if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系方式");
                txtPhone.Focus(); 
                return false;
            }
            else
            {
                return true;
            }
        }
        //取消
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
        }

        private void txtPeopleId_TextChanged(object sender, EventArgs e) 
        {

            if (txtPeopleId.Text.Length == 18) 
            {
                //隐藏
                labClew.Visible = false;
            }
            else
            {
                //显示
                labClew.Visible = true;
            }
        }

        private void txtPeopleId_KeyPress(object sender, KeyPressEventArgs e) 
        {
            //证件只能输入数字
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)18)
            {
                e.Handled = true;
                MessageBox.Show("请输入数字");
            }
        }

        private void txtPeopleId_Leave(object sender, EventArgs e) 
        {
            if (txtPeopleId.Text.Length != 18)   
            {
                MessageBox.Show("您输入的证件必须为18位，请重新输入！");
                //清除先前输入的
                txtPeopleId.Clear();  
                //获得焦点
                txtPeopleId.Focus(); 
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e) 
        {
            if (txtPhone.Text.Length != 11)  
            {
                MessageBox.Show("您输入的联系方式必须为11位，请重新输入！");
                txtPhone.Clear(); 
                txtPhone.Focus(); 
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)11)
            {
                e.Handled = true;
                MessageBox.Show("请输入数字");
            }
        }
        //更改时触发事件
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if(txtPhone.Text.Length==11)
            {
                //隐藏
                labNumber.Visible = false;
            }
            else
            {
                //显示
                labNumber.Visible = true;
            }
        }
    }
}
