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
    public partial class FmChangPass : Form
    {
        public FmChangPass()
        {
            InitializeComponent();
        }
        private void FmChangPass_Load(object sender, EventArgs e)
        {
            TxtUser.Text = "";
            TxtPass.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = DBConnect.con();
            con.Open();
            string sql = "select Name,Passwd from USERS where Name='" + TxtUser.Text + "'and Passwd='" + TxtPass.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                if (txtPass1.Text != txtPass2.Text)
                {
                    MessageBox.Show("两次输入的密码不一致!");
                    return;
                }
                try
                {
                    con.Close();
                    con.Open();
                    string str = "update USERS set Passwd='" + txtPass1.Text + "'";
                    cmd.CommandText = str;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("密码更改成功!");
                    this.Close();
                }
                catch (Exception cw)
                {
                    MessageBox.Show(cw.Message);
                }
            }
            else
            {
                MessageBox.Show("请输入正确的账号和密码!");
            }
        }

    }
}
