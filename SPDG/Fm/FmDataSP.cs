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
    public partial class FmDataSP : Form
    {
        public FmDataSP()
        {
            InitializeComponent();
        }

        private void FmDataSP_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConnect.con();
                string sql = "select * from SPB";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adpt.Fill(ds, "SPB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
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
                txtSPBH.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtSPLB.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtSPMC.Text = dataGridView1.SelectedCells[2].Value.ToString();
                txtDJ.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txtSCCS.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txtBZQ.Text = dataGridView1.SelectedCells[5].Value.ToString();
                txtKCL.Text = dataGridView1.SelectedCells[6].Value.ToString();
                txtBZ.Text = dataGridView1.SelectedCells[7].Value.ToString();
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
        private Boolean Check(string SPid)
        {
            SqlConnection con = DBConnect.con();
            con.Open();
            string sql = "select * from SPB where 商品编号='" + SPid + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int x = 0;
            while (rd.Read())
            {
                x++;
            }
            con.Close();
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnEvent(int n)
        {
            try
            {
                SqlConnection con = DBConnect.con();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string str0 = "'" + txtSPBH.Text + "','" + txtSPLB.Text + "','" + txtSPMC.Text + "','" + txtDJ.Text + "','" + txtSCCS.Text + "','" + txtBZQ.Text + "','" + txtKCL.Text + "','" + txtBZ.Text + "'";
                string str1 = "商品编号='" + txtSPBH.Text + "',商品类别='" + txtSPLB.Text + "',商品名称='" + txtSPMC.Text + "',单价='" + txtDJ.Text + "',生产商='" + txtSCCS.Text + "',保质期='" + txtBZQ.Text + "',库存量='" + txtKCL.Text + "',备注='" + txtBZ.Text + "'";
                if (n == 0)
                {
                    cmd.CommandText = "insert into SPB values (" + str0 + ")";
                }
                else if (n == 1)
                {
                    cmd.CommandText = "update SPB set " + str1 + " where 商品编号='" + txtSPBH.Text + "'";
                }
                else
                {
                    cmd.CommandText = "delete from SPB where 商品编号='" + txtSPBH.Text + "'";
                }
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("增加数据成功!");
                }
                else if (n == 1)
                {
                    MessageBox.Show("修改数据成功!");
                }
                else
                {
                    MessageBox.Show("删除数据成功!");
                }
                string sql = "select * from SPB";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adpt.Fill(ds, "SPB");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSPBH.Text == "")
            {
                MessageBox.Show("客户编号不能为空");
            }
            else if (Check(txtSPBH.Text))
            {
                MessageBox.Show("客户编号不能重复");
            }
            else if (MessageBox.Show("你确定要增加数据吗?", "消息框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnEvent(0);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Check(txtSPBH.Text))
            {
                MessageBox.Show("客户不存在");
            }
            else if (MessageBox.Show("你确定要修改数据吗?", "消息框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnEvent(1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Check(txtSPBH.Text))
            {
                MessageBox.Show("客户不存在");
            }
            else if (MessageBox.Show("你确定要删除数据吗?", "消息框", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnEvent(2);
            }
        }

    }
}
