using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace tianyu
{
    public partial class OrderFrom : Form
    {
        public OrderFrom()
        {
            InitializeComponent();
        }

        private void OrderFrom_Load(object sender, EventArgs e)
        {
            lblnum.Visible = false;
            GetAdd();//<电影的基本默认信息>和<类型> ====================================调用方法
            for (int i = 1; i <= 150; i++) //添加150张影票
            {
                dudnum.Items.Add(i);
            }
        }
        private void GetAdd()
        {
            //添加下拉框内的座位类型
            cboSeat.Items.Add("情侣座");
            cboSeat.Items.Add("硬座");
            cboSeat.Items.Add("软座");


            //=====================================从数据库中读出折扣类型==============================

            string sql = "select AType,ARebate from Agio";
            try
            {
                DBHelper.conn.Open();            //打开数据库连接
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);  //创建Command对象
                SqlDataReader reader = comm.ExecuteReader();           //执行命令(ExecuteReader用来读取数据的)
                while (reader.Read())                                  //循环读出座位类型（用read()方法读取一行数据）
                {
                    cboAgio.Items.Add(reader["AType"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }

            #region（电影的信息读出来放在对应的文本框里）
            //将数据库中的电影的信息读出来放在所对应的文本框里===============================================添数据
            sql = string.Format(@"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                F.FNumber as '票数',F.FNum as '座位号',S.SSort as '类型',T.TTime as '放映时间',
                                H.HHall as '大厅'
                                from Film as F ,Sort as S ,Time as T ,Hall as H
                                where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID and   F.FID ={0}", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader["片名"].ToString();
                    txtName.ReadOnly = true;
                    txtMain.Text = reader["主演"].ToString();
                    txtMain.ReadOnly = true;
                    txtType.Text = reader["类型"].ToString();
                    txtType.ReadOnly = true;
                    txtDirect.Text = reader["导演"].ToString();
                    txtDirect.ReadOnly = true;
                    txtTime.Text = reader["放映日期"].ToString();
                    txtTime.ReadOnly = true;
                    txtlanguage.Text = reader["语言"].ToString();
                    txtlanguage.ReadOnly = true;
                    txtDays.Text = reader["放映时间"].ToString();
                    txtDays.ReadOnly = true;
                    txtPrice.Text = reader["票价"].ToString();
                    txtPrice.ReadOnly = true;
                    txtHour.Text = reader["片长"].ToString();
                    txtHour.ReadOnly = true;
                    txtHall.Text = reader["大厅"].ToString();
                    txtHall.ReadOnly = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            #endregion

        }

        private void txtCert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//经判断为数字，可以输入
                MessageBox.Show("请输入数字！");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;//经判断为数字，可以输入
                MessageBox.Show("请输入数字！");
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void txtCert_Leave(object sender, EventArgs e)
        {
            int num = txtCert.Text.Trim().Length;

            if (num != 18)           //判断长度
            {
                MessageBox.Show("请输入合法的证件号<18>位！", "操作提示");
                txtCert.Focus();          //将焦点切回到原来的地方
            }
        }

        private void txtCert_TextChanged(object sender, EventArgs e)
        {
            if (txtCert.Text.Trim().Length != 18)
            {
                lblnum.Visible = true;  //如果长度不是18位 显示文字
            }
            else
            {
                lblnum.Visible = false; //是18位 不显示
            }
        }
        private bool GetCardnum(String cert, String agio)
        {
            bool no = false;
            int no1 = 0;
            try
            {
                DBHelper.conn.Open();
                string sql = string.Format(@"select count(*) from Member
                                             where MIDcard='{0}'and MType='{1}'", cert, agio);  //将会员信息(Member) 和 会员类型(MemberTypes)两表相连
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                no1 = Convert.ToInt32(comm.ExecuteScalar());
                if (no1 != 1)                                                          //（如果会员信息(Member) 和 会员类型(MemberTypes)不匹配
                {                                                                       //说明不是会员） 
                    DialogResult result = MessageBox.Show("对不起，你不是会员！请注册！", "提示！",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DBHelper.conn.Close();
                        MemberForm member = new MemberForm();
                        member.ShowDialog();
                    }
                    no = false;
                }
                else
                {
                    no = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return no;
        }
        private bool ValidateInput()
        {
            bool Conect = false;
            if (cboSeat.Text.Trim() == "")
            {
                MessageBox.Show("请输入座位类型");
                cboSeat.Focus();
                Conect = false;
            }
            else if (cboAgio.Text.Trim() == "")
            {


                MessageBox.Show("请输入打折类型");
                cboAgio.Focus();

                Conect = false;
            }

            else if (txtNum1.Text.Trim() == "")
            {
                MessageBox.Show("请计算总价格");
                txtNum1.Focus();
                Conect = false;
            }
            else if (txtNum2.Text.Trim() == "")
            {
                MessageBox.Show("请输入付款");
                txtNum2.Focus();
                Conect = false;
            }
            else if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))
            {
                txtNum1.Text = "";
                MessageBox.Show("没有票票啦！");
            }
            else if (txtSum.Text.Trim() == "")
            {
                MessageBox.Show("请找零！");
                txtNum2.Focus();

                Conect = false;
            }
            else if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
            {
                MessageBox.Show("付款金额不足！");
                txtNum2.Focus();
                txtNum2.Text = "";
                Conect = false;
            }
            else if (Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()) != Convert.ToInt32(txtSum.Text.Trim()))
            {
                MessageBox.Show("请找零！");
                txtSum.Focus();
                Conect = false;
            }
            else if (txtCert.Text.Trim() == "")
            {
                MessageBox.Show("请输入会员证件号");
                txtCert.Focus();
                Conect = false;
            }
            else
            {
                Conect = true;
            }
            return Conect;
        }
        private int GetDiscountByType(String type)
        {
            int discount = 0;
            try
            {
                DBHelper.conn.Open();
                String sql = String.Format("SELECT ARebate FROM Agio WHERE AType='{0}'", type);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                discount = Convert.ToInt32(comm.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return discount;
        }
        /// <summary>
        /// 得到选择座位类型后所加的钱
        /// </summary>
        /// <param name="seat">座位类型</param>
        /// <returns>钱数</returns>
        private int GetIncreaseMoneyBySeet(String seat)
        {
            int money = 0;
            try
            {
                DBHelper.conn.Open();
                String sql = String.Format("SELECT SMoney FROM Seat WHERE SType='{0}'", seat);
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                money = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
            return money;
        }
         private void GetNumber(String type)
        {
            string sql = string.Format(@"SELECT FPew AS 硬座,FComPew AS 软座,FLove AS 情侣座
                                         FROM Film
                                         WHERE FID='{0}'", UserHelper.Id);
            try
            {
                DBHelper.conn.Open();
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    //根据选择的座位类型得到相应得票数
                    if (type == "情侣座")
                    {
                        txtNumber.Text = reader["情侣座"].ToString();
                    }
                    else if (type == "硬座")
                    {
                        txtNumber.Text = reader["硬座"].ToString();
                    }
                    else if (type == "软座")
                    {
                        txtNumber.Text = reader["软座"].ToString();
                    }

                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.conn.Close();
            }
        }
         private int HallGet()
         {
             String hallText = txtHall.Text.Trim();
             int hallId = 0;
             //根据大厅得到所选的座位类============================判断在哪个大厅
             switch (hallText)
             {
                 case "一号大厅":
                     hallId = 1;
                     break;
                 case "二号大厅":
                     hallId = 2;
                     break;
                 case "三号大厅":
                     hallId = 3;
                     break;
                 default:
                     break;
             }
             return hallId;
         }

         private void cboSeat_SelectedIndexChanged(object sender, EventArgs e)
         {
             GetNumber(cboSeat.Text.Trim()); //得到剩余票数=调用方法 
            if (cboAgio.Text.Trim() == "")//当 打折类型  为空时
            {
                int hallId = HallGet();//得到大厅的ID的方法

                int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法
                if (cboSeat.Text.Trim() == "情侣座")
                {
                    txtMoney.Text = (Convert.ToInt32(txtPrice.Text.Trim()) * 2 + money).ToString();
                }
                else
                {
                    txtMoney.Text = (Convert.ToInt32(txtPrice.Text.Trim()) + money).ToString();
                }
            }
            else
            {
                if (cboSeat.Text.Trim() == "情侣座")
                {
                    int hallId = HallGet();//得到大厅的ID方法

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)

                    //得到选择座位类型和打折类型后的=价格（情侣是两张）
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                }
                else
                {
                    int hallId = HallGet();//得到大厅的ID方法

                    int money = Convert.ToInt32(GetIncreaseMoneyBySeet(cboSeat.Text.Trim()));  //得到选择座位类型后所加的钱的 方法

                    // 根据选择折扣类型得到折率的 方法
                    double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)

                    //得到选择座位类型和打折类型后的=价格
                    txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                }
            }
         }

         private void cboAgio_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cboSeat.Text.Trim() == "")//座位类型为空
             {
                 // 根据选择折扣类型得到折率的 方法
                 double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                 txtMoney.Text = Convert.ToInt32((Convert.ToDouble(txtPrice.Text.Trim()) * discount)).ToString();

             }
             else
             {
                 if (cboSeat.Text.Trim() == "情侣座")
                 {

                     //得到选择座位类型后所加的钱的 方法
                     int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                     // 根据选择折扣类型得到折率的 方法
                     double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                     //得到选择座位类型和打折类型后的=价格
                     txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) * 2 + Convert.ToDouble(money)) * discount));
                 }
                 else
                 {

                     //得到选择座位类型后所加的钱的 方法
                     int money = GetIncreaseMoneyBySeet(cboSeat.Text);

                     // 根据选择折扣类型得到折率的 方法
                     double discount = Convert.ToDouble(GetDiscountByType(cboAgio.Text)) / 100; //(将它除以100得到打折后的折扣)
                     //得到选择座位类型和打折类型后的=价格
                     txtMoney.Text = Convert.ToString(Convert.ToInt32((Convert.ToDouble(txtPrice.Text) + Convert.ToDouble(money)) * discount));
                 }
             }
         }
         private void dudnum_TextChanged(object sender, EventArgs e)
         {
             //计算价格
             if (txtMoney.Text.Trim() != "")//价格不为空时
             {
                 txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
             }
         }

         private void txtNum1_Click(object sender, EventArgs e)
         {
             if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//价格不为空时或者票数为空时
             {
                 if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//剩余的票数小于订购的票数
                 {
                     //清空文本框
                     txtNum1.Text = "";
                     txtNum2.Text = "";
                     txtSum.Text = "";

                     MessageBox.Show("没有票票啦！");
                 }
                 else
                 {
                     txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                 }
             }
         }

         private void lblNum1_Click(object sender, EventArgs e)
         {
             if (txtMoney.Text.Trim() != "" && txtNumber.Text.Trim() != "")//价格不为空时或者票数为空时
             {
                 if (Convert.ToInt32(txtNumber.Text.Trim()) < Convert.ToInt32(dudnum.Text.Trim()))//剩余的票数小于订购的票数
                 {
                     txtNum1.Text = "";
                     MessageBox.Show("没有票票啦！");
                 }
                 else
                 {
                     txtNum1.Text = Convert.ToString(Convert.ToInt32(txtMoney.Text.Trim()) * Convert.ToInt32(dudnum.Text.Trim()));
                 }
             }
         }

         private void txtSum_Click(object sender, EventArgs e)
         {
             if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
             {
                 txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
             }
         }

         private void lblSum_Click(object sender, EventArgs e)
         {
             if (txtNum2.Text.Trim() != "" && txtNum1.Text.Trim() != "" && Payment() == true)
             {
                 if (txtCert.Text.Trim() == "")//如果证件输入为空时提示
                 {
                     MessageBox.Show("请输入证件！");
                     txtCert.Focus();
                 }
                 else
                 {
                     txtSum.Text = Convert.ToString(Convert.ToInt32(txtNum2.Text.Trim()) - Convert.ToInt32(txtNum1.Text.Trim()));
                 }
             }
         }
         private bool Payment()
         {
             if (Convert.ToInt32(txtNum1.Text.Trim()) > Convert.ToInt32(txtNum2.Text.Trim()))
             {
                 MessageBox.Show("付款金额不足！");
                 txtNum2.Text = "";
                 txtNum2.Focus();
                 return false;
             }
             else
             {
                 return true;
             }
         }
         private void Clear()
         {
             cboSeat.Text = "";//清空座位类型
             txtMoney.Text = "";//清空价格
             cboAgio.Text = "";//清空折扣类型
             dudnum.Text = "1";//恢复票数
             txtCert.Text = "";//清空证件号
             txtPhone.Text = "";
             txtNum1.Text = "";//清空合计
             txtNum2.Text = "";//清空付款值
             txtSum.Text = "";//清空找零
             GetNumber(cboSeat.Text.Trim());//更新票数
         }
         private bool subtract(String type)
         {

             //用相应座位的（总票数）减去（用户订的票数）得到（剩余的票数）
             String sql = "";
             try
             {
                 switch (cboSeat.Text.Trim())//座位类型
                 {
                     case "硬座":
                         sql = String.Format(@"UPDATE Film SET FPew=FPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                         break;
                     case "软座":
                         sql = String.Format(@"UPDATE Film SET FComPew=FComPew-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                         break;
                     case "情侣座":
                         sql = String.Format(@"UPDATE Film SET FLove=FLove-{0}
                                           WHERE FID={1}", Convert.ToInt32(dudnum.Text.Trim()), UserHelper.Id);
                         break;
                     default:
                         break;
                 }
                 DBHelper.conn.Open();
                 SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                 int rows = comm.ExecuteNonQuery();//返回多行
                 if (rows == 1)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 DBHelper.conn.Close();
             }
             return false;

         }
         private void GetAddTicket()
         {
             //将订票信息全部插入到Ticket表中
             string sql = string.Format(@"insert into Ticket(TFName,TPhone,TCard,TDate,TTime,THall,TTicketPrice,TPayMoney,TCount,TMoney,TAgio)
                                            values ('{0}','{1}','{2}','{3}','{4} ','{5}',{6},{7},{8},{9},'{10}')",
                                             txtName.Text, txtPhone.Text, txtCert.Text, txtTime.Text, txtDays.Text, txtHall.Text,
                                             txtPrice.Text, txtMoney.Text, dudnum.Text, txtNum1.Text, cboAgio.Text);

             if (subtract(cboSeat.Text.Trim()))
             {
                 try
                 {

                     DBHelper.conn.Open();
                     SqlCommand comm = new SqlCommand(sql, DBHelper.conn);
                     int rows = comm.ExecuteNonQuery();
                     if (rows == 1)
                     {
                         DialogResult result = MessageBox.Show("订票成功！是否继续！");
                         if (result == DialogResult.OK)
                         {
                             DBHelper.conn.Close();
                             this.Clear();//清空数据
                         }
                         else
                         {
                             this.Close();
                         }
                     }
                     else
                     {
                         MessageBox.Show("订票失败！");
                     }
                 }
                 catch (Exception ex)
                 {

                     MessageBox.Show(ex.Message);
                 }
                 finally
                 {
                     DBHelper.conn.Close();
                 }

             }
         }

         private void btnCancel_Click(object sender, EventArgs e)
         {

             if (ValidateInput())//调用方法 （输入不为空）
             {

                 if (cboAgio.Text.Trim() == "钻石会员" || cboAgio.Text.Trim() == "金卡会员" || cboAgio.Text.Trim() == "银卡会员")
                 {

                     if (GetCardnum(txtCert.Text.Trim(), cboAgio.Text.Trim()))   //==调用GetNumber()方法（证件号，折扣类型）
                     {

                         GetAddTicket();
                     }
                     else
                     {
                         txtCert.Text = UserHelper.MemberID;
                         cboAgio.Text = UserHelper.type;
                     }
                 }
                 else
                 {

                     if (cboAgio.Text.Trim() == "团体购票" && Convert.ToInt32(dudnum.Text.Trim()) < 20)
                     {
                         MessageBox.Show("您的票数不足20张，不能团购！！");
                         dudnum.Focus();

                     }
                     else
                     {
                         GetAddTicket();
                     }
                 }
             }
         }

         private void btnCorrect_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void button1_Click(object sender, EventArgs e)
         {

         }

    }

}
