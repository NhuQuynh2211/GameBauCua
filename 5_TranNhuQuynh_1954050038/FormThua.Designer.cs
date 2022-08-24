
namespace _5_TranNhuQuynh_1954050038
{
    partial class FormThua
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
            this.bttChoiTiep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttChoiTiep
            // 
            this.bttChoiTiep.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bttChoiTiep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttChoiTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttChoiTiep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttChoiTiep.Location = new System.Drawing.Point(290, 118);
            this.bttChoiTiep.Name = "bttChoiTiep";
            this.bttChoiTiep.Size = new System.Drawing.Size(112, 50);
            this.bttChoiTiep.TabIndex = 1;
            this.bttChoiTiep.Text = "Chơi lại";
            this.bttChoiTiep.UseVisualStyleBackColor = false;
            this.bttChoiTiep.Click += new System.EventHandler(this.bttChoiTiep_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẠN CÓ MUỐN CHƠI LẠI HAY KHÔNG? ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bttThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttThoat.Location = new System.Drawing.Point(82, 118);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(106, 50);
            this.bttThoat.TabIndex = 1;
            this.bttThoat.Text = "Thoát";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // FormThua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(477, 231);
            this.Controls.Add(this.bttThoat);
            this.Controls.Add(this.bttChoiTiep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttChoiTiep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttThoat;
    }
}