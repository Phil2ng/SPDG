namespace SPDG
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单数据维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单数据查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.客户数据维护ToolStripMenuItem,
            this.商品数据维护ToolStripMenuItem,
            this.订单数据ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户登录ToolStripMenuItem,
            this.密码修改ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户登录ToolStripMenuItem.Text = "用户登录";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // 客户数据维护ToolStripMenuItem
            // 
            this.客户数据维护ToolStripMenuItem.Name = "客户数据维护ToolStripMenuItem";
            this.客户数据维护ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.客户数据维护ToolStripMenuItem.Text = "客户数据维护";
            this.客户数据维护ToolStripMenuItem.Click += new System.EventHandler(this.客户数据维护ToolStripMenuItem_Click);
            // 
            // 商品数据维护ToolStripMenuItem
            // 
            this.商品数据维护ToolStripMenuItem.Name = "商品数据维护ToolStripMenuItem";
            this.商品数据维护ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.商品数据维护ToolStripMenuItem.Text = "商品数据维护";
            this.商品数据维护ToolStripMenuItem.Click += new System.EventHandler(this.商品数据维护ToolStripMenuItem_Click);
            // 
            // 订单数据ToolStripMenuItem
            // 
            this.订单数据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.订单数据维护ToolStripMenuItem,
            this.订单数据查询ToolStripMenuItem});
            this.订单数据ToolStripMenuItem.Name = "订单数据ToolStripMenuItem";
            this.订单数据ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.订单数据ToolStripMenuItem.Text = "订单数据";
            // 
            // 订单数据维护ToolStripMenuItem
            // 
            this.订单数据维护ToolStripMenuItem.Name = "订单数据维护ToolStripMenuItem";
            this.订单数据维护ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.订单数据维护ToolStripMenuItem.Text = "订单数据维护";
            this.订单数据维护ToolStripMenuItem.Click += new System.EventHandler(this.订单数据维护ToolStripMenuItem_Click);
            // 
            // 订单数据查询ToolStripMenuItem
            // 
            this.订单数据查询ToolStripMenuItem.Name = "订单数据查询ToolStripMenuItem";
            this.订单数据查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.订单数据查询ToolStripMenuItem.Text = "订单数据查询";
            this.订单数据查询ToolStripMenuItem.Click += new System.EventHandler(this.订单数据查询ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 764);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "商品订购管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户数据维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品数据维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单数据查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单数据维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}