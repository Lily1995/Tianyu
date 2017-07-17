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
    public partial class SearchOrderForm : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataSet dataset = new DataSet();
        public SearchOrderForm()
        {
            InitializeComponent();
        }

        private void btnRearch_Click(object sender, EventArgs e)
        {
            String datatime = (dateTimePicker.Value).ToString();
            String data = datatime.Substring(0, datatime.Length - 8).Trim();

            String sql = string.Format(@"SELECT TId,TFName AS 电影名称 ,
             TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket 
                        where TDate='{0}'", data);

            dataset.Tables["Ticket"].Clear();
            dataAdapter.SelectCommand.CommandText = sql;
            dataAdapter.Fill(dataset, "Ticket");
        }

        private void SearchOrderForm_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT TId,TFName AS 电影名称 ,
                          TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket";
            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);
            dataset = new DataSet("Ticket");
            dataAdapter.Fill(dataset, "Ticket");
            dgvTicket.DataSource = dataset.Tables["Ticket"];

            dgvTicket.Columns["TId"].Visible = false;
        }

        private void dgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvTicket.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
       

        //private void btnReturn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT TId,TFName AS 电影名称 ,
                          TCard AS 身份证件 ,TDate AS 放映日期,TTime AS 放映时间 ,THall AS 放映大厅,TCount AS 购票数量 FROM Ticket";

            dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);

            dataset = new DataSet("Ticket");
            dataAdapter.Fill(dataset, "Ticket");

            dgvTicket.DataSource = dataset.Tables["Ticket"];

            dgvTicket.Columns["TId"].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //编写 SQL 语句
//            String sqlFilm = String.Format(@"DELETE FROM Ticket
//                                         WHERE TId={0}", UserHelper.ID);
//            //            String sqlMoney = String.Format(@"DELETE FROM Money
//            //                                         WHERE MFilmID={0}", UserHelper.ID);
//            DialogResult result = MessageBox.Show("是否删除！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
//            if (result == DialogResult.OK)
//            {
//                if (Delete(sqlFilm))
//                {
//                    MessageBox.Show("删除成功！");
                   
//                }
//            }
        }

        
    }
}
