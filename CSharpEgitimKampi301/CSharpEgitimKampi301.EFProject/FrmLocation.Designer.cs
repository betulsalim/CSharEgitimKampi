namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmLocation
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
            this.BtnIdFilterGetir = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtUlke = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGunGece = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NmcKapasite = new System.Windows.Forms.NumericUpDown();
            this.CmbRehber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmcKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIdFilterGetir
            // 
            this.BtnIdFilterGetir.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnIdFilterGetir.Location = new System.Drawing.Point(32, 636);
            this.BtnIdFilterGetir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnIdFilterGetir.Name = "BtnIdFilterGetir";
            this.BtnIdFilterGetir.Size = new System.Drawing.Size(363, 47);
            this.BtnIdFilterGetir.TabIndex = 23;
            this.BtnIdFilterGetir.Text = "ID ye Göre Getir";
            this.BtnIdFilterGetir.UseVisualStyleBackColor = false;
            this.BtnIdFilterGetir.Click += new System.EventHandler(this.BtnIdFilterGetir_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnGüncelle.Location = new System.Drawing.Point(33, 565);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(363, 47);
            this.BtnGüncelle.TabIndex = 22;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnSil.Location = new System.Drawing.Point(33, 496);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(363, 47);
            this.BtnSil.TabIndex = 21;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEkle.Location = new System.Drawing.Point(33, 420);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(363, 47);
            this.BtnEkle.TabIndex = 20;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtUlke
            // 
            this.TxtUlke.Location = new System.Drawing.Point(191, 111);
            this.TxtUlke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtUlke.Name = "TxtUlke";
            this.TxtUlke.Size = new System.Drawing.Size(204, 30);
            this.TxtUlke.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ülke:";
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(191, 61);
            this.TxtSehir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(204, 30);
            this.TxtSehir.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(424, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 671);
            this.dataGridView1.TabIndex = 15;
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnListele.Location = new System.Drawing.Point(33, 343);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(363, 47);
            this.BtnListele.TabIndex = 14;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(191, 13);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(204, 30);
            this.TxtId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lokasyon Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kapasite:";
            // 
            // TxtGunGece
            // 
            this.TxtGunGece.Location = new System.Drawing.Point(191, 255);
            this.TxtGunGece.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtGunGece.Name = "TxtGunGece";
            this.TxtGunGece.Size = new System.Drawing.Size(204, 30);
            this.TxtGunGece.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gün Gece:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(191, 206);
            this.TxtFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(204, 30);
            this.TxtFiyat.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Rehber:";
            // 
            // NmcKapasite
            // 
            this.NmcKapasite.Location = new System.Drawing.Point(191, 158);
            this.NmcKapasite.Name = "NmcKapasite";
            this.NmcKapasite.Size = new System.Drawing.Size(204, 30);
            this.NmcKapasite.TabIndex = 32;
            // 
            // CmbRehber
            // 
            this.CmbRehber.FormattingEnabled = true;
            this.CmbRehber.Items.AddRange(new object[] {
            "Elif"});
            this.CmbRehber.Location = new System.Drawing.Point(191, 299);
            this.CmbRehber.Name = "CmbRehber";
            this.CmbRehber.Size = new System.Drawing.Size(204, 31);
            this.CmbRehber.TabIndex = 33;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1497, 697);
            this.Controls.Add(this.CmbRehber);
            this.Controls.Add(this.NmcKapasite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtGunGece);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIdFilterGetir);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtUlke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmcKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIdFilterGetir;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtUlke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGunGece;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NmcKapasite;
        private System.Windows.Forms.ComboBox CmbRehber;
    }
}