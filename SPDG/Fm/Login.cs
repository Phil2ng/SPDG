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

namespace SPDG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            TxtPass.Text = "";

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //string str = "server=LEFY\\SQLEXPRESS;uid=sa;pwd=123;database=SPDG;";
            //string str = "Data Source=.;Initial Catalog=SPDG;Integrated Security=True";
            //SqlConnection con = new SqlConnection(str);
            //con.Open();
            SqlConnection con = DBConnect.con();
            con.Open();
            string sql = "select Name,Passwd from USERS where Name='" + TxtUser.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.Read())
            {
                MessageBox.Show("没有此账号,请先注册!");
                Login_Load(sender, e);
                con.Close();
                return;
            }
            con.Close();
            con.Open();
            sql = "select Name,Passwd from USERS where Name='" + TxtUser.Text + "'and Passwd='" + TxtPass.Text + "'";
            cmd = new SqlCommand(sql,con);
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                MainForm mForm = new MainForm();
                mForm.Show();
                con.Close();
                this.Visible = false ;   //窗体隐藏
            }
            else
            {
                MessageBox.Show("请输入正确的账号和密码!");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            FmRegister rg = new FmRegister();
            rg.Show();
        }
    }
}
