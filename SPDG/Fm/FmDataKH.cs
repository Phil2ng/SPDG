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
    public partial class FmDataKH : Form
    {
        public FmDataKH()
        {
            InitializeComponent();
        }

        
        private void FmDataKH_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = DBConnect.con();
                string sql = "select * from KHB";
                SqlDataAdapter adpt = new SqlDataAdapter(sql,con);
                DataSet ds = new DataSet();
                adpt.Fill(ds,"KHB");
                dataGridView1.DataSource=ds.Tables[0].DefaultView;
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
                txtKHBH.Text = dataGridView1.SelectedCells[0].Value.ToString();
                txtKHXM.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtCSRQ.Text = dataGridView1.SelectedCells[2].Value.ToString();
                comboXB.Text = dataGridView1.SelectedCells[3].Value.ToString();
                txtSZSS.Text = dataGridView1.SelectedCells[4].Value.ToString();
                txtLXDH.Text = dataGridView1.SelectedCells[5].Value.ToString();
                txtBZ.Text = dataGridView1.SelectedCells[6].Value.ToString();
                
            }
            catch (Exception cw)
            {
                MessageBox.Show(cw.Message);
            }
        }
        private void dataGridView1_Click(object sender, DataGridViewCellEventArgs e)
        {
            binding();

        }
        
        private Boolean Check(string KHid)
        {
            SqlConnection con = DBConnect.con();
            con.Open();
            string sql = "select * from KHB where 客户编号='" + KHid + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        private void btnEvent(int n)
        {
            try
            {
                SqlConnection con = DBConnect.con();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                string str0 = "'" + txtKHBH.Text + "','" + txtKHXM.Text + "','" + txtCSRQ.Text + "','" + comboXB.Text + "','" + txtSZSS.Text + "','" + txtLXDH.Text + "','" + txtBZ.Text + "','" + cbVIP.Checked + "'";
                string str1 = "客户编号='" + txtKHBH.Text + "',客户姓名='" + txtKHXM.Text + "',出生日期='" + txtCSRQ.Text + "',性别='" + comboXB.Text + "',所在省市='" + txtSZSS.Text + "',联系电话='" + txtLXDH.Text + "',备注='" + txtBZ.Text + "',是否VIP='" + cbVIP.Checked + "'";
                if (n == 0)
                {
                    cmd.CommandText = "insert into KHB values (" + str0 + ")";
                }
                else if (n == 1)
                {
                    cmd.CommandText = "update KHB set " + str1 + " where 客户编号='" + txtKHBH.Text + "'";
                }
                else
                {
                    cmd.CommandText = "delete from KHB where 客户编号='" + txtKHBH.Text + "'";
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
                string sql = "select * from KHB";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                adpt.Fill(ds, "KHB");
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
            if (txtKHBH.Text == "")
            {
                MessageBox.Show("客户编号不能为空");
            }
            else if (Check(txtKHBH.Text))
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
            if (!Check(txtKHBH.Text))
            {
                MessageBox.Show("客户不存在");
            }
            else if(MessageBox.Show("你确定要修改数据吗?","消息框",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                btnEvent(1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Check(txtKHBH.Text))
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
