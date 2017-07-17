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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainForm mainfrom = new MainForm();
            //mainfrom.ShowDialog();
            //判断是否是合法用户
             bool isValidUser = false;  

            string message = "";
            //判断用户的输入是否完整方法
            if (ValidateInput())         
            {
             
                isValidUser = ValidateUser(txtID.Text, txtPwd.Text, cb.Text, ref message);

            
                if (isValidUser)
                {
                    UserHelper.loginId = txtID.Text;        
                    UserHelper.loginType = cb.Text;   

                    if (cb.Text == "管理员")
                    {
                       //管理员
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;

                    }
                    else if (cb.Text == "售票员")
                    {
                        //售票员
                        MainForm main = new MainForm();
                        main.ShowDialog();
                        this.Visible = false;
                    }
                }
                else 
                {
                    MessageBox.Show(message, "操作提示");
                }
            }
            
        }
        private bool ValidateInput()
        {
            bool isValidate = false;
            string ID = txtID.Text.Trim();
            string Pwd = txtPwd.Text.Trim();
            string Type = cb.Text;
            if (ID == "")
            {
                MessageBox.Show("请输入用户名");
                txtID.Focus();    
                isValidate = false;
            }
            else if (Pwd == "")
            {
                MessageBox.Show("请输入密码");
                txtPwd.Focus();   
                isValidate = false;
            }
            else if (Type == "")
            {
                MessageBox.Show("请输入用户类型");
                cb.Focus();   
                isValidate = false;
            }
            else
            {
                isValidate = true;
            }
            return isValidate;
        }
        private bool ValidateUser(string LoginId, string LoginPwd, string LoginType, ref string message)
        {
            bool isCorrect = false;  

            if (LoginType == "管理员")
            {
              
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='管理员'", LoginId, LoginPwd);
                
               
                try
                {
                    //创建Command对象
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                    //打开数据库连接
                    DBHelper.conn.Open();

               
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "用户名或密码不存在";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "操作数据库出错";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                  
                    DBHelper.conn.Close();
                }
            }
            else if (LoginType == "售票员")
            {
                string sql = string.Format(@"select count(*) from Types where TLgionId='{0}' 
                                            and TLgionPwd='{1}'and TLgoinType='售票员'", LoginId, LoginPwd);


                
                try
                {
                  
                    SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                 
                    DBHelper.conn.Open();

               
                    int count = (int)comm.ExecuteScalar();
                    if (count != 1)
                    {
                        message = "用户名或密码不存在";
                        isCorrect = false;
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }
                catch (Exception ex)
                {
                    message = "操作数据库出错";
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.conn.Close();
                }
            }
            return isCorrect;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            cb.Items.Add("管理员");
            cb.Items.Add("售票员");
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
