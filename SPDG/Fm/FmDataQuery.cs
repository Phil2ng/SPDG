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
    public partial class FmDataQuery : Form
    {
        public FmDataQuery()
        {
            InitializeComponent();
        }

        private void FmDataQuery_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConnect.con();
                string sql = "select * from SPDGB";
                SqlDataAdapter Adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                Adpt.Fill(ds, "SPDGB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "GetKHBH";
                cmd.CommandType = CommandType.StoredProcedure;
                Adpt.SelectCommand = cmd;
                Adpt.Fill(ds, "KHBH");
                int n = ds.Tables["KHBH"].Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    comboKHBH.Items.Add(ds.Tables["KHBH"].Rows[i]["客户编号"]);
                }
                cmd.CommandText = "GetSPBH";
                Adpt.SelectCommand = cmd;
                Adpt.Fill(ds, "SPBH");
                n = ds.Tables["SPBH"].Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    comboSPBH.Items.Add(ds.Tables["SPBH"].Rows[i]["商品编号"]);
                }
                con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (comboKHBH.Text == "" && comboSPBH.Text == "")
            {
                MessageBox.Show("客户编号或商品编号不能全为空!");
                return;
            }
            try
            {
                SqlConnection con = DBConnect.con();
                //con.Open();
                //SqlCommand cmd = new SqlCommand();
                string sql = "select * from SPDGB ";
                if (comboKHBH.Text != ""&&comboSPBH.Text!="")
                {
                    sql = sql + "where 客户编号='" + comboKHBH.Text + "'"+ " and 商品编号='" + comboSPBH.Text + "'";
                }
                else if(comboKHBH.Text!="")
                {
                    sql = sql + "where 客户编号='" + comboKHBH.Text + "'";
                }
                else
                {
                    sql = sql + "where 商品编号='" + comboSPBH.Text + "'";
                }
                //string str = "insert into SPDGB values ('" + comboKHBH.Text + "','" + comboSPBH.Text + "','" + txtDGSJ.Text + "','" + txtSL.Text + "','" + txtXYRQ.Text + "','" + txtFKFS.Text + "','" + txtSHFS.Text + "')";
                //cmd.CommandText = str;
                //cmd.Connection = con;
                //cmd.ExecuteNonQuery();
                SqlDataAdapter Adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                Adpt.Fill(ds, "SPDGB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                //con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
