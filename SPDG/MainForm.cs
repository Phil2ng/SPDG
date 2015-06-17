using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPDG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmChangPass ChgPass = new FmChangPass();
            ChgPass.Show();
        }

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Fmlongin = new Login();
            Fmlongin.Show();
        }

        private void 客户数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDataKH KH = new FmDataKH();
            KH.Show();
        }

        private void 商品数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDataSP SP = new FmDataSP();
            SP.Show();
        }

        private void 订单数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDataQuery DDCX = new FmDataQuery();
            DDCX.Show();
        }

        private void 订单数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDataDD DDWH = new FmDataDD();
            DDWH.Show();
        }
    }
}
