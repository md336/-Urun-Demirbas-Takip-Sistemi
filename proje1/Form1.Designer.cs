namespace proje1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtürünkodu = new System.Windows.Forms.TextBox();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txtalankisi = new System.Windows.Forms.TextBox();
            this.txtgaranti = new System.Windows.Forms.TextBox();
            this.txtalistarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.btnresim = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtürünara = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerigoster = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(583, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alan Kişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alış Tarihi";
            // 
            // txtürünkodu
            // 
            this.txtürünkodu.Location = new System.Drawing.Point(92, 245);
            this.txtürünkodu.Name = "txtürünkodu";
            this.txtürünkodu.Size = new System.Drawing.Size(100, 20);
            this.txtürünkodu.TabIndex = 5;
            // 
            // txturunadi
            // 
            this.txturunadi.Location = new System.Drawing.Point(92, 279);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(100, 20);
            this.txturunadi.TabIndex = 6;
            // 
            // txtalankisi
            // 
            this.txtalankisi.Location = new System.Drawing.Point(92, 319);
            this.txtalankisi.Name = "txtalankisi";
            this.txtalankisi.Size = new System.Drawing.Size(100, 20);
            this.txtalankisi.TabIndex = 7;
            // 
            // txtgaranti
            // 
            this.txtgaranti.Location = new System.Drawing.Point(461, 234);
            this.txtgaranti.Name = "txtgaranti";
            this.txtgaranti.Size = new System.Drawing.Size(100, 20);
            this.txtgaranti.TabIndex = 8;
            // 
            // txtalistarih
            // 
            this.txtalistarih.Location = new System.Drawing.Point(92, 361);
            this.txtalistarih.Name = "txtalistarih";
            this.txtalistarih.Size = new System.Drawing.Size(100, 20);
            this.txtalistarih.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(333, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resim Yükle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(347, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(347, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Miktar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(333, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Garanti Süresi";
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(461, 314);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtfiyat.TabIndex = 16;
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(461, 275);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(100, 20);
            this.txtmiktar.TabIndex = 17;
            // 
            // btnresim
            // 
            this.btnresim.Location = new System.Drawing.Point(461, 359);
            this.btnresim.Name = "btnresim";
            this.btnresim.Size = new System.Drawing.Size(100, 23);
            this.btnresim.TabIndex = 18;
            this.btnresim.Text = "Yükle>>";
            this.btnresim.UseVisualStyleBackColor = true;
            this.btnresim.Click += new System.EventHandler(this.btnresim_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnekle.Location = new System.Drawing.Point(130, 401);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(94, 37);
            this.btnekle.TabIndex = 19;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(261, 401);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(95, 37);
            this.btnguncelle.TabIndex = 20;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(391, 401);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(84, 37);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(581, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 167);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btntemizle.Location = new System.Drawing.Point(510, 401);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(94, 37);
            this.btntemizle.TabIndex = 23;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(34, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ürün Kodu Ara";
            // 
            // txtürünara
            // 
            this.txtürünara.Location = new System.Drawing.Point(156, 27);
            this.txtürünara.Name = "txtürünara";
            this.txtürünara.Size = new System.Drawing.Size(100, 20);
            this.txtürünara.TabIndex = 25;
            this.txtürünara.TextChanged += new System.EventHandler(this.txtürünara_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerigoster});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // ürünlerigoster
            // 
            this.ürünlerigoster.Name = "ürünlerigoster";
            this.ürünlerigoster.Size = new System.Drawing.Size(202, 22);
            this.ürünlerigoster.Text = "Ürün İçin Barkod oluştur";
            this.ürünlerigoster.Click += new System.EventHandler(this.ürünlerigoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.txtürünara);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnresim);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtalistarih);
            this.Controls.Add(this.txtgaranti);
            this.Controls.Add(this.txtalankisi);
            this.Controls.Add(this.txturunadi);
            this.Controls.Add(this.txtürünkodu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Demirbaş Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtürünkodu;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txtalankisi;
        private System.Windows.Forms.TextBox txtgaranti;
        private System.Windows.Forms.TextBox txtalistarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Button btnresim;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtürünara;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerigoster;
    }
}

