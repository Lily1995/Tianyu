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

using System.IO;
using System.Data.SqlClient;


namespace tianyu
{
    public partial class SelectForm : Form
    {
        private DataSet dataset = new DataSet();
        private SqlDataAdapter dataAdapter; 
        public SelectForm()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dateTime = (dateTimePicker.Value).ToString();
            String date = dateTime.Substring(0, dateTime.Length - 8).Trim();

            string sql = string.Format(@"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                F.FNumber as '票数',F.FNum as '座位号',S.SSort as '类型',T.TTime as '放映时间',
                                H.HHall as '大厅'
                                from Film as F ,Sort as S ,Time as T ,Hall as H
                                where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID and F.FDate='{0}'", date);
            dataset.Tables["Films"].Clear();
            dataAdapter.SelectCommand.CommandText = sql;

            dataAdapter.Fill(dataset, "Films");
        }

        private void 修改影片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateForm update = new UpdateForm();
            //update.ShowDialog();
        }

        private void 订票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderFrom orderfrom = new OrderFrom();
            orderfrom.ShowDialog();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            GetSelect();
        }
        public void GetSelect()
        {
            try
            {
                string sql = @"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                            F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                            F.FNumber as '票数',F.FNum as '座位号' ,S.SSort as '类型',T.TTime as '放映时间',
                                            H.HHall as '大厅'
                                            from Film as F ,Sort as S ,Time as T ,Hall as H
                                            where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID";

                dataAdapter = new SqlDataAdapter(sql, DBHelper.conn);

                dataAdapter.Fill(dataset, "Films");
                dgvSerch.DataSource = dataset.Tables["Films"];
                dgvSerch.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void 订票_Click(object sender, EventArgs e)
        {
            string name = this.dgvSerch.CurrentRow.Cells[1].Value.ToString();
            string zhuyan = this.dgvSerch.CurrentRow.Cells[2].Value.ToString();
            string leixing = this.dgvSerch.CurrentRow.Cells[3].Value.ToString();
            string daoyan = this.dgvSerch.CurrentRow.Cells[4].Value.ToString();
            string riqi = this.dgvSerch.CurrentRow.Cells[5].Value.ToString();
            string yuyan = this.dgvSerch.CurrentRow.Cells[6].Value.ToString();
            string shijian = this.dgvSerch.CurrentRow.Cells[7].Value.ToString();
            string piaojia = this.dgvSerch.CurrentRow.Cells[8].Value.ToString();
            string pianc = this.dgvSerch.CurrentRow.Cells[9].Value.ToString();
            string dat = this.dgvSerch.CurrentRow.Cells[10].Value.ToString();
            Order.name = name;
            Order.zhuyan = zhuyan;
            Order.leixing = leixing;
            Order.daoyan = daoyan;
            Order.riqi = riqi;
            Order.yuyan = yuyan;
            Order.shijian = shijian;
            Order.piaojia = piaojia;
            Order.pianc = pianc;
            Order.dat = dat;
            OrderFrom orderfrom = new OrderFrom();
            orderfrom.Show();
        }

        private void 刷新_Click(object sender, EventArgs e)
        {
            string sql = @"select F.FID as Id, F.FFilmName as '片名',F.FDirector as '导演',F.FPlay as '主演',F.FIntro as '简介',
                                            F.FLanguage as '语言',F.FLong as '片长',F.FDate as '放映日期',F.FMoney as '票价',
                                            F.FNumber as '票数',F.FNum as '座位号',S.SSort as '类型',T.TTime as '放映时间',
                                            H.HHall as '大厅'
                                            from Film as F ,Sort as S ,Time as T ,Hall as H
                                            where F.FSortID=S.SOID and F.FTimeID = T.TID and H.HID=T.THallID";
            try
            {
                dataset.Tables["Films"].Clear();
                dataAdapter.SelectCommand.CommandText = sql;
                dataAdapter.Fill(dataset, "Films");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSerch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //得到所选择得当行得Id得值，并赋予UserHelper中的Id变量（当鼠标点击某个单元格时得到里面的内容）
            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
                //UserHelper.Id = Convert.ToInt32(dgvSerch.Rows[e.RowIndex].Cells["Id"].Value);
                //使相对路径合法
                //Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                //得到图片的相对路径
                //String path = Convert.ToString(dgvSerch.Rows[e.RowIndex].Cells["图片路径"].Value);
                //if (path != "")
                //{   //使相对路径合法
                   // Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                    //在数据库和查询表绑定时已经将路径读出 现将路径拿到这边作为相对路径
                    //picPic.Image = Image.FromFile(path);
                //}
                //else
                //{
                    //使相对路径合法
                    //Directory.SetCurrentDirectory(PathHelper.currentDirectory);
                    //picPic.Image = Image.FromFile("Images\\空.bmp");
                //}
            }
        }
    }

