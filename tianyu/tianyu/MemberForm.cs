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
    public partial class MemberForm : Form
    {
       
        DataSet da = new DataSet();
      
        SqlDataAdapter adapter;
        public MemberForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String sql = (@"SELECT MID, MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            switch (cboStyle.Text)
            {     
                //case"全部":
                //    sql += "where MType like '%会员'";
                //    break;
                case "钻石会员":
                    sql += " WHERE MType='钻石会员'";
                    break;
                case "金卡会员":
                    sql += " WHERE MType='金卡会员'";
                    break;
                case "银卡会员":
                    sql += " WHERE MType='银卡会员'";
                    break;
                default:
                    break;
            }
            da.Tables["Member"].Clear();
            adapter.SelectCommand.CommandText = sql;
            adapter.Fill(da, "Member");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            da.Tables["Member"].Clear();
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
        }

        private void dgvMemberInformation_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.SeaShell;
            }
        }

        private void dgvMemberInformation_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvMemberInformation.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        //删除
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            //得到主键ID
            string id = dgvMemberInformation.SelectedRows[0].Cells["MID"].Value.ToString();
            try
            {
                //打开数据库
                DBHelper.conn.Open();
                string sql = string.Format("DELETE FROM Member WHERE MID={0} ", Convert.ToInt32(id));
                SqlCommand comm = new SqlCommand(sql, DBHelper.conn);

                if (comm.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                da.Tables["Member"].Clear();
                adapter.Fill(da, "Member");


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

        private void MemberForm_Load(object sender, EventArgs e)
        {
            if (UserHelper.loginType == "售票员")
                //不能进行删除
                tsmiDelete.Enabled = false;


            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.Items.Add("钻石会员");
            cboStyle.Items.Add("金卡会员");
            cboStyle.Items.Add("银卡会员");

            String sql = ("SELECT MID,MName,MIDcard,MPhone,MDiscount,MType FROM Member");
            adapter = new SqlDataAdapter(sql, DBHelper.conn);
            adapter.Fill(da, "Member");
            dgvMemberInformation.DataSource = da.Tables["Member"];
            //更改列名
            dgvMemberInformation.Columns["MName"].HeaderText = "姓名";
            dgvMemberInformation.Columns["MIDcard"].HeaderText = "证件号";
            dgvMemberInformation.Columns["MPhone"].HeaderText = "电话号码";
            dgvMemberInformation.Columns["MDiscount"].HeaderText = "折扣类型";
            dgvMemberInformation.Columns["MType"].HeaderText = "会员类型";
            //隐藏“MID”列
            dgvMemberInformation.Columns["MID"].Visible = false;
            //设置“MType”为只读
            dgvMemberInformation.Columns["MType"].ReadOnly = true;
        }
        //注册
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistForm re = new RegistForm();
            re.ShowDialog();

        }
        //取消
        private void btnExit_Click(object sender, EventArgs e) // 单击"btnCancel"查询事件
        {
            //点击"取消"关闭窗口
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void 冻结ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string users = this.tb_frost.Text;
            //string sqlStr = string.Format("select*from Member where MIDcard='{0}'", MIDcard);
            //DataTable dt_demand = DBHelper.ExecuteDataset(sqlStr);

        }
    }
}
