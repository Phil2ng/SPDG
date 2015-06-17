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
    public partial class FmRegister : Form
    {
        public FmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = DBConnect.con();
            con.Open();
            string sql = "select Name from USERS where Name='" + TxtUser.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                con.Close();
                MessageBox.Show("用户名已经存在!");
            }
            else
            {
                con.Close();
                if (TxtUser.Text == "" || TxtPass.Text == "")
                {
                    MessageBox.Show("用户名或密码不能为空!");
                    return;
                }
                try
                {
                    string str = "insert into USERS values ('" + TxtUser.Text + "','" + TxtPass.Text + "')";
                    cmd.CommandText = str;
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("恭喜你,注册成功!");
                    this.Close();
                }
                catch (Exception cw)
                {
                    MessageBox.Show(cw.Message);
                }
            }
        }
    }
}
