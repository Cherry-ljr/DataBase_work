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
    public partial class ShoppingCar : Form
    {
        public ShoppingCar()
        {
            InitializeComponent();
            //select count(*) from ShoppingCar
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接

                    String sql = "select SC_no '编号',username'用户名',Book_no'书籍编号',Book_num'数量' from [ShoppingCar] where SC_status='N' and username ='" + common.GetName() + "'";//这个表名一定要加上[]; // 查询语句

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

            SqlConnection conn1 = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
            conn1.Open();
            //select sum(Book_num) from ShoppingCar  
            SqlCommand cmd = new SqlCommand("select sum(Book_num) from ShoppingCar  "+ "where SC_status ='N' and username = '" + common.GetName()+"'", conn1);//
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string num = String.Format("{0}", sdr[0]);
            booknums.Text = num;
            conn1.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CusView cusinfo_form = new CusView();
            cusinfo_form.ShowDialog(this);//
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{

                if (MessageBox.Show("确实要订购该书籍吗?", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string book_num = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//订购书籍数量
                    string book_no = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//书籍编号
                    string bb_no = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//购物车编号

                    SqlConnection conn1 = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                    conn1.Open();
                    // update ShoppingCar set Book_num=book_num where Book_no = book_no
                    //select book_num from Repository where book_no = 1
                    SqlCommand cmd = new SqlCommand("select book_num from Repository where book_no = '" + book_no + "'", conn1);//这个表名一定要加上[]
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    string res_num;
                    try
                    {
                        res_num = String.Format("{0}", sdr[0]);
                        if (int.Parse(res_num) < int.Parse(book_num))
                        {
                            MessageBox.Show("书籍库存不足");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("书籍库存不足");
                        return;
                    }
                    conn1.Close();

                    //更新库存
                    conn1 = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                    conn1.Open();
                    // update Repository set Book_num=1 where Book_no = 1
                    string now_num = (int.Parse(res_num) - int.Parse(book_num)).ToString();
                    //MessageBox.Show(now_num);
                    cmd = new SqlCommand("update Repository set Book_num= " + now_num + " where Book_no =" + book_no, conn1);//这个表名一定要加上[]
                    sdr = cmd.ExecuteReader();
                    conn1.Close();

                    //增加到订单表中
                    conn1 = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                    conn1.Open();
                    // update ShoppingCar set Book_num=book_num where Book_no = book_no
                    string datetime = DateTime.Now.ToLocalTime().ToString();
                    //insert into OrderInfo(username,SC_no,status,time)VALUES('cherry',20,)
                    cmd = new SqlCommand("INSERT INTO OrderInfo(username,SC_no,Book_no,Book_num,status,time)VALUES('" + common.GetName() + "'," 
                        + bb_no + ","+book_no+","+book_num+",'" + "N" + "','" + datetime + "')", conn1);//这个表名一定要加上[]
                    sdr = cmd.ExecuteReader();
                    conn1.Close();

                    conn1 = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                    conn1.Open();
                    // update ShoppingCar set Book_num=book_num where Book_no = book_no
                    //insert into OrderInfo(username,SC_no,status,time)VALUES('cherry',20,)
                    cmd = new SqlCommand("update ShoppingCar set SC_status='Y' where SC_no = '" + bb_no + "'", conn1);//这个表名一定要加上[]
                    sdr = cmd.ExecuteReader();
                    conn1.Close();

                    this.Hide();
                    ShoppingCar shoppingcar_form = new ShoppingCar();
                    shoppingcar_form.ShowDialog(this);//
                    this.Close();

                }
           // }
        /*
            catch
            {
                MessageBox.Show("所选数据无效");
            }
          */
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string bianhao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
            string book_num = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            book_num = (int.Parse(book_num) + 1).ToString();
            //MessageBox.Show(book_num);
            SqlConnection conn = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("update ShoppingCar set Book_num=" + book_num + "where SC_no = " + bianhao, conn);//
            SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();

            this.Hide();
            ShoppingCar shoppingcar_form = new ShoppingCar();
            shoppingcar_form.ShowDialog(this);//
            this.Close();
          //  MessageBox.Show("数量增加成功");
      

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string bianhao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取第一个单元格的值
            string book_num = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            book_num = (int.Parse(book_num) - 1).ToString();
            //MessageBox.Show(book_num);
            SqlConnection conn = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("update ShoppingCar set Book_num=" + book_num + "where SC_no = " + bianhao, conn);//
            SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();

            this.Hide();
            ShoppingCar shoppingcar_form = new ShoppingCar();
            shoppingcar_form.ShowDialog(this);//
            this.Close();
            //  MessageBox.Show("数量增加成功");
      
        }

        private void booknums_Click(object sender, EventArgs e)
        {

        }
    }
}
