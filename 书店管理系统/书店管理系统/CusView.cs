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
    public partial class CusView : Form
    {
        public CusView()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Book_Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)//书名
            {
                String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connsql;
                        conn.Open(); // 打开数据库连接

                        String sql = "select * from [cus_bookSerch] where 书名 like '%" + textBox1.Text.Trim() + "%'";//这个表名一定要加上[]; // 查询语句

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
            else if (comboBox1.SelectedIndex == 1)//作者
            {
                String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connsql;
                        conn.Open(); // 打开数据库连接

                        String sql = "select * from [cus_bookSerch] where 作者 like '%" + textBox1.Text.Trim() + "%'";//这个表名一定要加上[]; // 查询语句

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
            else//出版社
            {
                String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
                try
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = connsql;
                        conn.Open(); // 打开数据库连接

                        String sql = "select * from [cus_bookSerch] where 出版社 like '%" + textBox1.Text.Trim() + "%'";//这个表名一定要加上[]; // 查询语句

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

        private void Shehuikexue_Btn_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select * from [cus_bookSerch] where 书籍类别 like '%社会科学%'";//这个表名一定要加上[]; // 查询语句

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

        private void Kexuejishu_Btn_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select * from [cus_bookSerch] where 书籍类别 like '%科学技术%'";//这个表名一定要加上[]; // 查询语句

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

        private void Wenxue_Btn_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select * from [cus_bookSerch] where 书籍类别 like '%文学%'";//这个表名一定要加上[]; // 查询语句

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

        private void Yishu_Btn_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select *  from [cus_bookSerch] where 书籍类别 like '%艺术%'";//这个表名一定要加上[]; // 查询语句

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

        private void Home_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_form = new Main();
            main_form.ShowDialog(this);//
            this.Close();
        }

        private void ShopCar_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShoppingCar shoppingcar_form = new ShoppingCar();
            shoppingcar_form.ShowDialog(this);//
            this.Close();
        }

        private void Person_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusInfo cusinfo_form = new CusInfo();
            cusinfo_form.ShowDialog(this);//
            this.Close();
        }

        private void OrderSearch_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusOrder cusorder_form = new CusOrder();
            cusorder_form.ShowDialog(this);//
            this.Close();
        }

        private void Add_ShopCar_Click(object sender, EventArgs e)
        {
            string bianhao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值

            SqlConnection conn = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [ShoppingCar] where SC_status='N' and username='" + common.GetName() + "' and Book_no='" + bianhao + "'", conn);//这个表名一定要加上[]
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                string num = String.Format("{0}", sdr[3]);
                int book_num = int.Parse(num) + 1;
                //MessageBox.Show(book_num.ToString());
                conn.Close();
                conn.Open();
                // update ShoppingCar set Book_num=book_num where Book_no = book_no
                cmd = new SqlCommand("update ShoppingCar set Book_num=" + book_num + "where Book_no = " + bianhao, conn);//这个表名一定要加上[]
                sdr = cmd.ExecuteReader();
                conn.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO ShoppingCar(username,Book_no,Book_num,SC_status)VALUES('" + common.GetName() + "','" + bianhao + "','" + "1" + "','" + "N" + "')", conn);//这个表名一定要加上[]
                sdr = cmd.ExecuteReader();
                conn.Close();
            }
            MessageBox.Show("添加成功");
        }
    }
}
