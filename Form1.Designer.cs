
namespace sesVerileriÜzerineVeriGizleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_MesajGizle = new System.Windows.Forms.Button();
            this.txt_GizlenecekMetin = new System.Windows.Forms.TextBox();
            this.lbl_GizlenecekMetin = new System.Windows.Forms.Label();
            this.bt_SesDosyasiEkle = new System.Windows.Forms.Button();
            this.lstbx_SesDosyalari = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_GizlenenMesaj = new System.Windows.Forms.TextBox();
            this.lbl_GizlenenMesaj = new System.Windows.Forms.Label();
            this.sesOynatici = new AxWMPLib.AxWindowsMediaPlayer();
            this.gizlenmisMesajOynatici = new AxWMPLib.AxWindowsMediaPlayer();
            this.rdbt_metinVerisi = new System.Windows.Forms.RadioButton();
            this.rdbt_goruntu = new System.Windows.Forms.RadioButton();
            this.bt_rdBtSecimi = new System.Windows.Forms.Button();
            this.rdbt_video = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sesOynatici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizlenmisMesajOynatici)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_MesajGizle
            // 
            this.bt_MesajGizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_MesajGizle.Enabled = false;
            this.bt_MesajGizle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_MesajGizle.Location = new System.Drawing.Point(381, 424);
            this.bt_MesajGizle.Name = "bt_MesajGizle";
            this.bt_MesajGizle.Size = new System.Drawing.Size(225, 35);
            this.bt_MesajGizle.TabIndex = 13;
            this.bt_MesajGizle.Text = "Mesajı Gizle";
            this.bt_MesajGizle.UseVisualStyleBackColor = false;
            this.bt_MesajGizle.Visible = false;
            this.bt_MesajGizle.Click += new System.EventHandler(this.bt_MesajGizle_Click);
            // 
            // txt_GizlenecekMetin
            // 
            this.txt_GizlenecekMetin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_GizlenecekMetin.Enabled = false;
            this.txt_GizlenecekMetin.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GizlenecekMetin.Location = new System.Drawing.Point(232, 392);
            this.txt_GizlenecekMetin.MaxLength = 50000;
            this.txt_GizlenecekMetin.Name = "txt_GizlenecekMetin";
            this.txt_GizlenecekMetin.Size = new System.Drawing.Size(546, 23);
            this.txt_GizlenecekMetin.TabIndex = 12;
            this.txt_GizlenecekMetin.Text = "Gizleme Yapmak Istediginiz Karakteri Giriniz";
            this.txt_GizlenecekMetin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_GizlenecekMetin.Visible = false;
            this.txt_GizlenecekMetin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_GizlenecekMetin_MouseClick);
            // 
            // lbl_GizlenecekMetin
            // 
            this.lbl_GizlenecekMetin.AutoSize = true;
            this.lbl_GizlenecekMetin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_GizlenecekMetin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GizlenecekMetin.Location = new System.Drawing.Point(10, 395);
            this.lbl_GizlenecekMetin.Name = "lbl_GizlenecekMetin";
            this.lbl_GizlenecekMetin.Size = new System.Drawing.Size(228, 19);
            this.lbl_GizlenecekMetin.TabIndex = 11;
            this.lbl_GizlenecekMetin.Text = "Gizlenecek Metni Giriniz : ";
            this.lbl_GizlenecekMetin.Visible = false;
            // 
            // bt_SesDosyasiEkle
            // 
            this.bt_SesDosyasiEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_SesDosyasiEkle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SesDosyasiEkle.Location = new System.Drawing.Point(462, 271);
            this.bt_SesDosyasiEkle.Name = "bt_SesDosyasiEkle";
            this.bt_SesDosyasiEkle.Size = new System.Drawing.Size(326, 67);
            this.bt_SesDosyasiEkle.TabIndex = 10;
            this.bt_SesDosyasiEkle.Text = "Ses Dosyası Ekle";
            this.bt_SesDosyasiEkle.UseVisualStyleBackColor = false;
            this.bt_SesDosyasiEkle.Click += new System.EventHandler(this.bt_SesDosyasiEkle_Click);
            // 
            // lstbx_SesDosyalari
            // 
            this.lstbx_SesDosyalari.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstbx_SesDosyalari.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_SesDosyalari.FormattingEnabled = true;
            this.lstbx_SesDosyalari.ItemHeight = 15;
            this.lstbx_SesDosyalari.Location = new System.Drawing.Point(462, 12);
            this.lstbx_SesDosyalari.Name = "lstbx_SesDosyalari";
            this.lstbx_SesDosyalari.Size = new System.Drawing.Size(326, 259);
            this.lstbx_SesDosyalari.TabIndex = 9;
            this.lstbx_SesDosyalari.SelectedIndexChanged += new System.EventHandler(this.lstbx_SesDosyalari_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // txt_GizlenenMesaj
            // 
            this.txt_GizlenenMesaj.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_GizlenenMesaj.Enabled = false;
            this.txt_GizlenenMesaj.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GizlenenMesaj.Location = new System.Drawing.Point(192, 645);
            this.txt_GizlenenMesaj.MaxLength = 17;
            this.txt_GizlenenMesaj.Name = "txt_GizlenenMesaj";
            this.txt_GizlenenMesaj.ReadOnly = true;
            this.txt_GizlenenMesaj.Size = new System.Drawing.Size(596, 26);
            this.txt_GizlenenMesaj.TabIndex = 15;
            this.txt_GizlenenMesaj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_GizlenenMesaj.Visible = false;
            // 
            // lbl_GizlenenMesaj
            // 
            this.lbl_GizlenenMesaj.AutoSize = true;
            this.lbl_GizlenenMesaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_GizlenenMesaj.Enabled = false;
            this.lbl_GizlenenMesaj.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GizlenenMesaj.Location = new System.Drawing.Point(9, 648);
            this.lbl_GizlenenMesaj.Name = "lbl_GizlenenMesaj";
            this.lbl_GizlenenMesaj.Size = new System.Drawing.Size(177, 19);
            this.lbl_GizlenenMesaj.TabIndex = 14;
            this.lbl_GizlenenMesaj.Text = "Gizlediginiz Mesaj : ";
            this.lbl_GizlenenMesaj.Visible = false;
            // 
            // sesOynatici
            // 
            this.sesOynatici.Enabled = true;
            this.sesOynatici.Location = new System.Drawing.Point(13, 12);
            this.sesOynatici.Name = "sesOynatici";
            this.sesOynatici.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sesOynatici.OcxState")));
            this.sesOynatici.Size = new System.Drawing.Size(443, 326);
            this.sesOynatici.TabIndex = 16;
            // 
            // gizlenmisMesajOynatici
            // 
            this.gizlenmisMesajOynatici.Enabled = true;
            this.gizlenmisMesajOynatici.Location = new System.Drawing.Point(13, 465);
            this.gizlenmisMesajOynatici.Name = "gizlenmisMesajOynatici";
            this.gizlenmisMesajOynatici.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gizlenmisMesajOynatici.OcxState")));
            this.gizlenmisMesajOynatici.Size = new System.Drawing.Size(775, 174);
            this.gizlenmisMesajOynatici.TabIndex = 17;
            this.gizlenmisMesajOynatici.Visible = false;
            // 
            // rdbt_metinVerisi
            // 
            this.rdbt_metinVerisi.AutoSize = true;
            this.rdbt_metinVerisi.Enabled = false;
            this.rdbt_metinVerisi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbt_metinVerisi.Location = new System.Drawing.Point(12, 357);
            this.rdbt_metinVerisi.Name = "rdbt_metinVerisi";
            this.rdbt_metinVerisi.Size = new System.Drawing.Size(174, 23);
            this.rdbt_metinVerisi.TabIndex = 18;
            this.rdbt_metinVerisi.TabStop = true;
            this.rdbt_metinVerisi.Text = "Metin Verisi Gizle";
            this.rdbt_metinVerisi.UseVisualStyleBackColor = true;
            this.rdbt_metinVerisi.Visible = false;
            // 
            // rdbt_goruntu
            // 
            this.rdbt_goruntu.AutoSize = true;
            this.rdbt_goruntu.Enabled = false;
            this.rdbt_goruntu.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbt_goruntu.Location = new System.Drawing.Point(192, 357);
            this.rdbt_goruntu.Name = "rdbt_goruntu";
            this.rdbt_goruntu.Size = new System.Drawing.Size(141, 23);
            this.rdbt_goruntu.TabIndex = 19;
            this.rdbt_goruntu.TabStop = true;
            this.rdbt_goruntu.Text = "Goruntu Gizle";
            this.rdbt_goruntu.UseVisualStyleBackColor = true;
            this.rdbt_goruntu.Visible = false;
            // 
            // bt_rdBtSecimi
            // 
            this.bt_rdBtSecimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_rdBtSecimi.Enabled = false;
            this.bt_rdBtSecimi.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_rdBtSecimi.Location = new System.Drawing.Point(465, 352);
            this.bt_rdBtSecimi.Name = "bt_rdBtSecimi";
            this.bt_rdBtSecimi.Size = new System.Drawing.Size(105, 34);
            this.bt_rdBtSecimi.TabIndex = 21;
            this.bt_rdBtSecimi.Text = "Secim Yapildi";
            this.bt_rdBtSecimi.UseVisualStyleBackColor = false;
            this.bt_rdBtSecimi.Visible = false;
            this.bt_rdBtSecimi.Click += new System.EventHandler(this.bt_rdBtSecimi_Click);
            // 
            // rdbt_video
            // 
            this.rdbt_video.AutoSize = true;
            this.rdbt_video.Enabled = false;
            this.rdbt_video.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbt_video.Location = new System.Drawing.Point(339, 357);
            this.rdbt_video.Name = "rdbt_video";
            this.rdbt_video.Size = new System.Drawing.Size(120, 23);
            this.rdbt_video.TabIndex = 22;
            this.rdbt_video.TabStop = true;
            this.rdbt_video.Text = "Video Gizle";
            this.rdbt_video.UseVisualStyleBackColor = true;
            this.rdbt_video.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 674);
            this.Controls.Add(this.rdbt_video);
            this.Controls.Add(this.bt_rdBtSecimi);
            this.Controls.Add(this.rdbt_goruntu);
            this.Controls.Add(this.rdbt_metinVerisi);
            this.Controls.Add(this.gizlenmisMesajOynatici);
            this.Controls.Add(this.sesOynatici);
            this.Controls.Add(this.bt_MesajGizle);
            this.Controls.Add(this.txt_GizlenecekMetin);
            this.Controls.Add(this.lbl_GizlenecekMetin);
            this.Controls.Add(this.bt_SesDosyasiEkle);
            this.Controls.Add(this.lstbx_SesDosyalari);
            this.Controls.Add(this.txt_GizlenenMesaj);
            this.Controls.Add(this.lbl_GizlenenMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sesOynatici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gizlenmisMesajOynatici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_MesajGizle;
        private System.Windows.Forms.TextBox txt_GizlenecekMetin;
        private System.Windows.Forms.Label lbl_GizlenecekMetin;
        private System.Windows.Forms.Button bt_SesDosyasiEkle;
        private System.Windows.Forms.ListBox lstbx_SesDosyalari;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_GizlenenMesaj;
        private System.Windows.Forms.Label lbl_GizlenenMesaj;
        private AxWMPLib.AxWindowsMediaPlayer sesOynatici;
        private AxWMPLib.AxWindowsMediaPlayer gizlenmisMesajOynatici;
        private System.Windows.Forms.RadioButton rdbt_metinVerisi;
        private System.Windows.Forms.RadioButton rdbt_goruntu;
        private System.Windows.Forms.Button bt_rdBtSecimi;
        private System.Windows.Forms.RadioButton rdbt_video;
    }
}

