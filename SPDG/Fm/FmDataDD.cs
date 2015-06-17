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
    public partial class FmDataDD : Form
    {
        public FmDataDD()
        {
            InitializeComponent();
        }

        private void FmDataInput_Load(object sender, EventArgs e)
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
        public void binding()
        {
            try
            {
                comboKHBH.Text = dataGridView1.SelectedCells[0].Value.ToString();
                comboSPBH.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtDGSJ.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txtSL.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txtXYRQ.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txtFKFS.Text = dataGridView1.SelectedCells[5].Value.ToString();
                txtSHFS.Text = dataGridView1.SelectedCells[6].Value.ToString();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            binding();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboKHBH.Text == "" || comboSPBH.Text == "")
            {
                MessageBox.Show("客户编号或商品编号不能为空!");
                return;
            }
            try
            {
                SqlConnection con = DBConnect.con();
                SqlCommand cmd = new SqlCommand();
                string str = "insert into SPDGB values ('" + comboKHBH.Text + "','" + comboSPBH.Text + "','" + txtDGSJ.Text + "','" + txtSL.Text + "','" + txtXYRQ.Text + "','" + txtFKFS.Text + "','" + txtSHFS.Text + "')";
                cmd.CommandText = str;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter Adpt = new SqlDataAdapter("select * from SPDGB", con);
                DataSet ds = new DataSet();
                Adpt.Fill(ds, "SPDGB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboKHBH.Text == "" || comboSPBH.Text == "")
            {
                MessageBox.Show("客户编号或商品编号不能为空!");
                return;
            }
            try
            {
                SqlConnection con = DBConnect.con();
                SqlCommand cmd = new SqlCommand();
                string str = "update SPDGB set 客户编号='" + comboKHBH.Text + "',商品编号='" + comboSPBH.Text + "',订购时间='" + txtDGSJ.Text + "',数量='" + txtSL.Text + "',需要日期='" + txtXYRQ.Text + "',付款方式='" + txtFKFS.Text + "',送货方式='" + txtSHFS.Text + "'" + " where 客户编号='" + comboKHBH.Text + "' and 商品编号='" + comboSPBH.Text + "' and 订购时间='" + txtDGSJ.Text + "'" ;
                cmd.CommandText = str;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter Adpt = new SqlDataAdapter("select * from SPDGB", con);
                DataSet ds = new DataSet();
                Adpt.Fill(ds, "SPDGB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboKHBH.Text == "" || comboSPBH.Text == "")
            {
                MessageBox.Show("客户编号或商品编号不能为空!");
                return;
            }
            try
            {
                SqlConnection con = DBConnect.con();
                SqlCommand cmd = new SqlCommand();
                string str = "delete from SPDGB " + " where 客户编号='" + comboKHBH.Text + "' and 商品编号='" + comboSPBH.Text + "' and 订购时间='" + txtDGSJ.Text + "'";
                cmd.CommandText = str;
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter Adpt = new SqlDataAdapter("select * from SPDGB", con);
                DataSet ds = new DataSet();
                Adpt.Fill(ds, "SPDGB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }


    }
}
