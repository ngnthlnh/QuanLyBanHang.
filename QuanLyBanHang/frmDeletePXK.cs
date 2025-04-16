using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDeletePXK : Form
    {
        private string soPXK;

        public frmDeletePXK()
        {
            InitializeComponent();
        }

        public frmDeletePXK(string soPXK)
        {
            this.soPXK = soPXK;
        }

        private void frmDeletePXK_Load(object sender, EventArgs e)
        {

        }
    }
}
