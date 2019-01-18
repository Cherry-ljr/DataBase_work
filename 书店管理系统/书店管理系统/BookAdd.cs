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
    public partial class BookAdd : Form
    {
        public BookAdd()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");//建立连接
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Book(name,author,publish,origin_price,price,Sup_no,Book_category )VALUES('"
                + name.Text.Trim() + "','" + author.Text.Trim() + "','"+ publish.Text.Trim()+"',"+ oPrice.Text.Trim() +","
               + price.Text.Trim() + ",'" + supporter.Text.Trim() + "','" + comboBox1.SelectedItem + "')", conn);//这个表名一定要加上[]
            SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();
            MessageBox.Show("书籍添加成功");


            //conn.Open();
            //cmd = new SqlCommand("SELECT TOP 1 * FROM Book order by Book_no desc", conn);//最后插入的一行数据
            //sdr = cmd.ExecuteReader();
            //sdr.Read();
            //string BooKNO;
            //BooKNO = String.Format("{0}", sdr[0]);
            //int book_no = int.Parse(BooKNO);
            //conn.Close();
            //conn.Open();
            //cmd = new SqlCommand("INSERT INTO Repository(Book_no,BooK_num )VALUES(" + book_no + "," + 10 + ")", conn);//这个
            //sdr = cmd.ExecuteReader();
            //conn.Close();

            //MessageBox.Show("库存添加成功");

            this.Hide();
            Manager manager_form = new Manager();
            manager_form.ShowDialog(this);//
            this.Close();

            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager_form = new Manager();
            manager_form.ShowDialog(this);//
        }
    }
}
