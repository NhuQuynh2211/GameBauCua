using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5_TranNhuQuynh_1954050038
{
    public partial class FormChoi : Form
    {
        //tạo một list choose thay vì một biến choose
        public List<int> choose = new List<int>();
        public static string PlayerName = "";
        public static int show = 1; //Biến show duyệt xem có mở form vào game không

        #region Biến cục bộ
        string path = Application.StartupPath + @"\Image\";
        int rand1, rand2, rand3;
        int mucCuoc;
        public static int tien;
        #endregion

        public FormChoi()
        {
            if (show == 1)
            {

                formVaoGame formChinh = new formVaoGame();
                formChinh.ShowDialog();
                InitializeComponent();
            }
            else
            {
                FormNew formNhapTen = new FormNew();
                formNhapTen.ShowDialog();              
                InitializeComponent();                
            }
        }
        public void GiaTri()
        {       
            cbbCuoc.Items.Add("10");
            cbbCuoc.Items.Add("50");
            cbbCuoc.Items.Add("100");
            cbbCuoc.Items.Add("200");
            cbbCuoc.Items.Add("500");
            cbbCuoc.Items.Add("1000");
        }
        private void FormChoi_Load(object sender, EventArgs e)
        {
            lbName.Text = PlayerName;
            GiaTri();
            lbGameName.Text = "      CHÀO MỪNG BẠN ĐẾN VỚI GAME BẦU CUA TÔM CÁ      ";
            Khoa();
            tien = 200;           
            lbTuiTien.Text = tien.ToString();
            listLichSuCuoc.Items.Add("");
            listLichSuCuoc.Items.Add("[ +200 vào túi tiền. ]");
            duyet = 1;
            timerDemNguoc2.Enabled = false;
            timerDemNguoc2.Stop();

        }
        private void timerTenGame_Tick(object sender, EventArgs e)
        {
            {
                lbGameName.Text = lbGameName.Text.Substring(1) +
                                  lbGameName.Text.Substring(0, 1);
            }
        }

        private void thoatGame()
        {
            if (MessageBox.Show("Bạn muốn thoát game?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            thoatGame();
        }
        public void MoKhoa()
        {
            pic1.Enabled = true;
            pic2.Enabled = true;
            pic3.Enabled = true;
            pic4.Enabled = true;
            pic5.Enabled = true;
            pic6.Enabled = true;
        }
        public void Khoa()
        {
            pic1.Enabled = false;
            pic2.Enabled = false;
            pic3.Enabled = false;
            pic4.Enabled = false;
            pic5.Enabled = false;
            pic6.Enabled = false;
        }
        public void LacBauCua()
        {
            Random random = new Random();
            rand1 = random.Next(1, 7);
            picKQ1.Image = Image.FromFile(path + rand1 + @".png");
           
            rand2 = random.Next(1, 7);
            picKQ2.Image = Image.FromFile(path + rand2 + @".png");
            
            rand3 = random.Next(1, 7);
            picKQ3.Image = Image.FromFile(path + rand3 + @".png");

        }

       
        private void lacLac()
        {
            if (duyet != 1) MessageBox.Show("Bạn cần ấn mũi tên để quay lượt tiếp theo !",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                if (cbbCuoc.SelectedItem == null || choose.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mức cược hoặc chưa chọn linh vật !",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    timerDemNguoc.Stop();
                    timerDemNguoc2.Stop();
                    timerDemNguoc3.Stop();
                    LacBauCua();
                    XuLyTuiTien();
                    Khoa();
                    sec1 = sec2 = sec3 = 30;
                    duyet = 0;
                    
                }              
            }
        }
        private void btLac_Click(object sender, EventArgs e)
        {
            lacLac();        
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    lacLac();
                    return true;
                case Keys.Escape:
                    thoatGame();
                    return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        private void pic1_Click(object sender, EventArgs e)
        {
            int count = 0; //Kiểm tra số lần click lên ô
            choose.Add(1); //Gán biến để đổi ô được chọn sang màu đỏ
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
            {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic1.Image = Image.FromFile(path + 1 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic1.Enabled = false;
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            int count = 0;
            choose.Add(2);
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
                {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic2.Image = Image.FromFile(path + 2 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic2.Enabled = false;             
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            int count = 0;
            choose.Add(3);
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
            {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic3.Image = Image.FromFile(path + 3 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic3.Enabled = false;
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            int count = 0;
            choose.Add(4);
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
            {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic4.Image = Image.FromFile(path + 4 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic4.Enabled = false;
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            int count = 0;
            choose.Add(5);
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
            {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic5.Image = Image.FromFile(path + 5 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic5.Enabled = false;
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            int count = 0;
            choose.Add(6);
            count++;
            if (count > 1) Khoa();

            if (Convert.ToInt32(lbTuiTien.Text) - mucCuoc < 0)
            {
                MessageBox.Show("Oops, không đủ tiền rồi :(");
            }
            else
            {
                pic6.Image = Image.FromFile(path + 6 + @".png");
                lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) - mucCuoc).ToString();
                pic6.Enabled = false;
            }
        }

        private void cbbCuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            mucCuoc = Convert.ToInt32(cbbCuoc.SelectedItem);
            MoKhoa();
        }


        private void Init()
        {
            picKQ1.Image = Image.FromFile(path + @"question.jpg");
            picKQ2.Image = Image.FromFile(path + @"question.jpg");
            picKQ3.Image = Image.FromFile(path + @"question.jpg");
        }
        private void KhoiTao()
        {
            pic1.Image = Image.FromFile(path + @"Nai.png");
            pic2.Image = Image.FromFile(path + @"Bau.png");
            pic3.Image = Image.FromFile(path + @"Ga.png");
            pic4.Image = Image.FromFile(path + @"Ca.png");
            pic5.Image = Image.FromFile(path + @"Cua.png");
            pic6.Image = Image.FromFile(path + @"Tom.png");
        }
        private void resetCBB()
        {
            cbbCuoc.Items.Clear();
            GiaTri();
            if (cbbCuoc.SelectedItem == null)
            {
                Khoa();
            }
            else
                MoKhoa();
        }

        int duyet = 0;                          

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demLS = 0;
            DialogResult lamMoi = MessageBox.Show("Bạn muốn làm mới trò chơi", " Thông báo", 
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (lamMoi == DialogResult.Yes)
            {
                FormNew form = new FormNew();
                form.ShowDialog();
                lbName.Text = PlayerName;
                Init();
                KhoiTao();
                listLichSuCuoc.Items.Clear();
                listLichSuCuoc.Items.Add("[ +200 vào túi tiền. ]");
                tien = 200;
                lbTuiTien.Text = tien.ToString();
                resetCBB();
                duyet = 1;
            }
            timerDemNguoc3.Enabled = true;
            timerDemNguoc3.Start();
        }

        //ĐẾM NGƯỢC
        int sec1 = 30; //Đếm ngược của form chính
        public void timerDemNguoc_Tick(object sender, EventArgs e)
        {
            sec1--;
            if (sec1 <= 9)
            {
                lbDemNguoc.ForeColor = Color.Red;
                lbDemNguoc.Text = String.Format("{0}{1}", "00:0", sec1.ToString());
            }
            else
                lbDemNguoc.Text = String.Format("{0}{1}", "00:", sec1.ToString());

            if (sec1 == 0)
            {
                timerDemNguoc.Stop();
                MessageBox.Show("Vượt quá thời gian chọn, bạn sẽ bị trừ 50 tiền");
                tien -= 50;
                lbTuiTien.Text = tien.ToString();
                sec1 = 30;
            }

        }
        int sec2 = 30; //Đếm ngược lại từ đầu khi ấn qua lượt quay tiếp theo
        private void timerDemNguoc2_Tick(object sender, EventArgs e)
        {
            sec2--;
            if (sec2 <= 9)
            {
                lbDemNguoc.ForeColor = Color.Red;
                lbDemNguoc.Text = String.Format("{0}{1}", "00:0", sec2.ToString());
            }
            else
                lbDemNguoc.Text = String.Format("{0}{1}", "00:", sec2.ToString());

            if (sec2 == 0)
            {
                timerDemNguoc2.Stop();
                timerDemNguoc2.Enabled = false;
                MessageBox.Show("Vượt quá thời gian chọn, bạn sẽ bị trừ 50 tiền");
                tien -= 50;
                lbTuiTien.Text = tien.ToString();
                sec2 = 30;
                
            }
        }

        int sec3 = 30; //Đếm ngược lại từ đầu khi làm mới game
        private void timerDemNguoc3_Tick(object sender, EventArgs e)
        {
            sec3--;
            if (sec3 <= 9)
            {
                lbDemNguoc.ForeColor = Color.Red;
                lbDemNguoc.Text = String.Format("{0}{1}", "00:0", sec3.ToString());
            }
            else
                lbDemNguoc.Text = String.Format("{0}{1}", "00:", sec3.ToString());

            if (sec3 == 0)
            {
                timerDemNguoc3.Stop();
                timerDemNguoc3.Enabled = false;
                MessageBox.Show("Vượt quá thời gian chọn, bạn sẽ bị trừ 50 tiền");
                tien -= 50;
                lbTuiTien.Text = tien.ToString();
                sec3 = 30;
            }
        }

        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            duyet = 1;      
            Init();
            KhoiTao();
            resetCBB();
            timerDemNguoc2.Enabled = true;
            timerDemNguoc2.Start();
            if (Convert.ToInt32(lbTuiTien.Text) == 0)
            {
                timerDemNguoc2.Enabled = false;
                timerDemNguoc2.Stop();
                MessageBox.Show("Bạn chơi hết tiền rồi !!");
                FormThua form = new FormThua();
                form.ShowDialog();
            }
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerDemNguoc.Stop();
        }

        int demLS = 0;

        private void XuLyTuiTien()
        {
            int heso = 0;
            foreach (int i in choose)
            {
                if (i == rand1)
                    heso++;
                if (i == rand2)
                    heso++;
                if (i == rand3)
                    heso++;
            }
            tien = mucCuoc * heso * 2;
            demLS++;
            lbTuiTien.Text = (Convert.ToInt32(lbTuiTien.Text) + tien).ToString();
            if (tien == 0) listLichSuCuoc.Items.Add(String.Format(
                "{0}{1}",demLS, ". Tiếc quá bạn đoán không trúng!"));
            else
            {
                listLichSuCuoc.Items.Add(String.Format("{0}{1}", demLS,
                    (tien > 0 ? ". +" : "") + tien + " vào túi tiền"));
            }
            choose.Clear();
            
        }
    }
}
