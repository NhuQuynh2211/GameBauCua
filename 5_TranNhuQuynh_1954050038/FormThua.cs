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
    public partial class FormThua : Form
    {
        public FormThua()
        {          
            InitializeComponent();
        }
        private void bttThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát game?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void bttChoiTiep_Click(object sender, EventArgs e)
        {
            FormChoi.show = 0;
            FormChoi form = new FormChoi();
            form.ShowDialog();
           
        }
    }
}
