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
    public partial class ManagerInfo : Form
    {
        public ManagerInfo()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
            conn.Open();
            SqlDataAdapter daAuthors = new SqlDataAdapter("select * From Manager", conn);
            DataSet dsPubs = new DataSet("Pubs");

            daAuthors.FillSchema(dsPubs, SchemaType.Source, "Manager");
            //FillSchema加载表的架构和数据,有了架构，表就知道哪个列是它的主键，同时 Rows 集合的 Find 方法也就可用了。


            daAuthors.Fill(dsPubs, "Manager");
            DataTable tblAuthors;
            tblAuthors = dsPubs.Tables["Manager"];
            DataRow drCurrent;
          //  MessageBox.Show(common.GetName());
            drCurrent = tblAuthors.Rows.Find(common.GetName());
            nickname.Text = drCurrent[0].ToString();
            username.Text = drCurrent[1].ToString();
            tel.Text = drCurrent[3].ToString();
            address.Text = drCurrent[4].ToString();
            myinfo.Text = drCurrent[5].ToString();

        }

        private void Manager_OK_Click(object sender, EventArgs e)
        {
            String connsql = "Data Source=PC-20170513IEDS\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connsql;
                    conn.Open(); // 打开数据库连接
                    //update Customer set nickname = 'lijiarui',cus_age='17'where username = cherry
                    string strcomm = "update Manager set " + "nickname='" + nickname.Text.Trim() + "'," + "tel='" + tel.Text.Trim() + "'," + "address='" + address.Text.Trim() + "'," + "myinfo='" + myinfo.Text.Trim() + "'where username = '" + common.GetName() + "'";
                    //update FilTer set 列名 = value where id = 3
                    SqlCommand comm = new SqlCommand(strcomm, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("信息修改成功！");
                    Manager manager_form = new Manager();
                    manager_form.ShowDialog(this);//
                    this.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }

        private void ManagerInfo_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager manager_form = new Manager();
            manager_form.ShowDialog(this);//
            this.Close();
        }
    }
}
