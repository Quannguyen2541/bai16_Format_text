using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai16_Format_text
{
    public partial class Mainform: Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formatext formatext = new Formatext();
            formatext.MdiParent = this;
            formatext.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            string ten = "Nguyễn Phước Minh Quân";
            lblInfo.Text = "Họ và tên thí sinh: " + ten + Environment.NewLine;
            lblInfo.Text += "Ngày viết chương trình: " + System.DateTime.Now;
        }
    }
}
