using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;//新建引用
using System.Data.SqlClient;//新建引用

namespace 书店管理系统
{
    public partial class CusOrder : Form
    {
        public CusOrder()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusView cusinfo_form = new CusView();
            cusinfo_form.ShowDialog(this);//
            this.Close();
        }

        private void CusOrder_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)//未处理订单
            {
                String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connsql;
                        conn.Open(); // 打开数据库连接
                        //select name'书名',time'下单时间' from cus_orderSerch where status='N' and username = 
                        String sql = "select name'书名',time'下单时间' from cus_orderSerch where status='N' and username = '"+common.GetName() +"'";//这个表名一定要加上[]; // 查询语句

                        SqlDataAdapter myda = new SqlDataAdapter(sql, conn); // 实例化适配器

                        DataTable dt = new DataTable(); // 实例化数据表
                        myda.Fill(dt); // 保存数据 

                        dataGridView1.DataSource = dt; // 设置到DataGridView中

                        conn.Close(); // 关闭数据库连接
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误信息：" + ex.Message, "出现错误");
                }

            }
            else//已处理订单
            {
                String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connsql;
                        conn.Open(); // 打开数据库连接
                        //select name'书名',time'下单时间' from cus_orderSerch where status='N' and username = 
                        String sql = "select name'书名',time'下单时间' from cus_orderSerch where status='Y' and username = '" + common.GetName() + "'";//这个表名一定要加上[]; // 查询语句

                        SqlDataAdapter myda = new SqlDataAdapter(sql, conn); // 实例化适配器

                        DataTable dt = new DataTable(); // 实例化数据表
                        myda.Fill(dt); // 保存数据 

                        dataGridView1.DataSource = dt; // 设置到DataGridView中

                        conn.Close(); // 关闭数据库连接
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误信息：" + ex.Message, "出现错误");
                }
            }
        }
    }
}
