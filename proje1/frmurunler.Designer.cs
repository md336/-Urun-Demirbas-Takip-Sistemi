namespace proje1
{
    partial class frmurunler
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
            this.btnBarkodOlustur = new System.Windows.Forms.Button();
            this.btnQROlustur = new System.Windows.Forms.Button();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarkodOlustur
            // 
            this.btnBarkodOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarkodOlustur.Location = new System.Drawing.Point(246, 64);
            this.btnBarkodOlustur.Name = "btnBarkodOlustur";
            this.btnBarkodOlustur.Size = new System.Drawing.Size(128, 32);
            this.btnBarkodOlustur.TabIndex = 0;
            this.btnBarkodOlustur.Text = "Barkod Oluştur";
            this.btnBarkodOlustur.UseVisualStyleBackColor = true;
            this.btnBarkodOlustur.Click += new System.EventHandler(this.btnBarkodOlustur_Click);
            // 
            // btnQROlustur
            // 
            this.btnQROlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQROlustur.Location = new System.Drawing.Point(246, 109);
            this.btnQROlustur.Name = "btnQROlustur";
            this.btnQROlustur.Size = new System.Drawing.Size(128, 35);
            this.btnQROlustur.TabIndex = 1;
            this.btnQROlustur.Text = "QR Oluştur";
            this.btnQROlustur.UseVisualStyleBackColor = true;
            this.btnQROlustur.Click += new System.EventHandler(this.btnQROlustur_Click);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(118, 73);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(100, 20);
            this.txtUrunKodu.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Kodu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 247);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmurunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.btnQROlustur);
            this.Controls.Add(this.btnBarkodOlustur);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmurunler";
            this.Text = "Demirbaş Barkod";
            this.Load += new System.EventHandler(this.frmurunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarkodOlustur;
        private System.Windows.Forms.Button btnQROlustur;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}