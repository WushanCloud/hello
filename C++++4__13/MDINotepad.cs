using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C____4_13;
namespace C____4__13
{
    public partial class MDINotepad : Form
    {
        public MDINotepad()
        {
            InitializeComponent();
        }

        private void MDINotepad_Load(object sender, EventArgs e)
        {

        }

        private void 打开oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad MDIChild = new Notepad();
            MDIChild.MdiParent = this;
            MDIChild.Show();
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 层叠CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平平铺HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 全部关闭LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
