namespace _5_TranNhuQuynh_1954050038
{
    partial class formVaoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVaoGame));
            this.btThoat = new System.Windows.Forms.Button();
            this.btVaoNgay = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.AutoSize = true;
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(36, 257);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(178, 74);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "THOÁT";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            this.btThoat.MouseLeave += new System.EventHandler(this.btThoat_MouseLeave);
            this.btThoat.MouseHover += new System.EventHandler(this.btThoat_MouseHover);
            // 
            // btVaoNgay
            // 
            this.btVaoNgay.AutoSize = true;
            this.btVaoNgay.BackColor = System.Drawing.Color.White;
            this.btVaoNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVaoNgay.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVaoNgay.Location = new System.Drawing.Point(623, 257);
            this.btVaoNgay.Name = "btVaoNgay";
            this.btVaoNgay.Size = new System.Drawing.Size(178, 74);
            this.btVaoNgay.TabIndex = 0;
            this.btVaoNgay.Text = "VÀO NGAY";
            this.btVaoNgay.UseVisualStyleBackColor = false;
            this.btVaoNgay.Click += new System.EventHandler(this.btVaoNgay_Click);
            this.btVaoNgay.MouseLeave += new System.EventHandler(this.btVaoNgay_MouseLeave);
            this.btVaoNgay.MouseHover += new System.EventHandler(this.btVaoNgay_MouseHover);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(268, 283);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // formVaoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::_5_TranNhuQuynh_1954050038.Properties.Resources.bìa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 544);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btVaoNgay);
            this.Controls.Add(this.btThoat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formVaoGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẦU CUA TÔM CÁ";
            this.Load += new System.EventHandler(this.formVaoGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btVaoNgay;
        private System.Windows.Forms.TextBox txtName;
    }
}

