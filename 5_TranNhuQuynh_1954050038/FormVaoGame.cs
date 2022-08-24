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
    public partial class formVaoGame : Form
    {
        public formVaoGame()
        {            
            InitializeComponent();            
        }

        private void btVaoNgay_MouseHover(object sender, EventArgs e)
        {
            btVaoNgay.BackColor = Color.CornflowerBlue;
        }
        private void btVaoNgay_MouseLeave(object sender, EventArgs e)
        {
            btVaoNgay.BackColor = Color.White;
        }
        private void btThoat_MouseHover(object sender, EventArgs e)
        {
            btThoat.BackColor = Color.CornflowerBlue;
        }
        private void btThoat_MouseLeave(object sender, EventArgs e)
        {
            btThoat.BackColor = Color.White;
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát game?", "Thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
               
        }

        #region Biến toàn cục
        string ingame = "Tên của bạn là...";
        #endregion
        
        
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            txtName.Text = "";
        }
       
        private void vaoNgay()
        {
            if (txtName.Text == ingame || txtName.Text == "")
                MessageBox.Show("Hãy nhập tên của bạn");
            else
            {
                FormChoi.PlayerName = txtName.Text;
                this.Close();
            }
        }

        private void btVaoNgay_Click(object sender, EventArgs e)
        {
            vaoNgay();
        }

        private void formVaoGame_Load(object sender, EventArgs e)
        {
            txtName.Text = ingame;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    vaoNgay();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }

    }
}
