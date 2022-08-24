using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_TranNhuQuynh_1954050038
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void txtTenB_MouseClick(object sender, MouseEventArgs e)
        {
            txtTenB.Text = "";
        }

        private void btnVGame_Click(object sender, EventArgs e)
        {
            if (txtTenB.Text == "")
            {

                MessageBox.Show("Hãy nhập tên của bạn");
            }
            else
            {
                FormChoi.PlayerName = txtTenB.Text;
                this.Close();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
