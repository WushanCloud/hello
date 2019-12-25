namespace C____4__13
{
    partial class MDINotepad
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部关闭LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开oToolStripMenuItem,
            this.窗口wToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.窗口wToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 打开oToolStripMenuItem
            // 
            this.打开oToolStripMenuItem.Name = "打开oToolStripMenuItem";
            this.打开oToolStripMenuItem.Size = new System.Drawing.Size(89, 28);
            this.打开oToolStripMenuItem.Text = "打开(&O)";
            this.打开oToolStripMenuItem.Click += new System.EventHandler(this.打开oToolStripMenuItem_Click);
            // 
            // 窗口wToolStripMenuItem
            // 
            this.窗口wToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.垂直平铺ToolStripMenuItem,
            this.层叠CToolStripMenuItem,
            this.水平平铺HToolStripMenuItem,
            this.全部关闭LToolStripMenuItem});
            this.窗口wToolStripMenuItem.Name = "窗口wToolStripMenuItem";
            this.窗口wToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.窗口wToolStripMenuItem.Text = "窗口(&W)";
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺(&V)";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // 层叠CToolStripMenuItem
            // 
            this.层叠CToolStripMenuItem.Name = "层叠CToolStripMenuItem";
            this.层叠CToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.层叠CToolStripMenuItem.Text = "层叠(&C)";
            this.层叠CToolStripMenuItem.Click += new System.EventHandler(this.层叠CToolStripMenuItem_Click);
            // 
            // 水平平铺HToolStripMenuItem
            // 
            this.水平平铺HToolStripMenuItem.Name = "水平平铺HToolStripMenuItem";
            this.水平平铺HToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.水平平铺HToolStripMenuItem.Text = "水平平铺(&H)";
            this.水平平铺HToolStripMenuItem.Click += new System.EventHandler(this.水平平铺HToolStripMenuItem_Click);
            // 
            // 全部关闭LToolStripMenuItem
            // 
            this.全部关闭LToolStripMenuItem.Name = "全部关闭LToolStripMenuItem";
            this.全部关闭LToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.全部关闭LToolStripMenuItem.Text = "全部关闭(&L)";
            this.全部关闭LToolStripMenuItem.Click += new System.EventHandler(this.全部关闭LToolStripMenuItem_Click);
            // 
            // MDINotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDINotepad";
            this.Text = "多文档记事本";
            this.Load += new System.EventHandler(this.MDINotepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口wToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部关闭LToolStripMenuItem;
    }
}

