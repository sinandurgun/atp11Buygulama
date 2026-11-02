namespace atp11BgitHubUyg
{
    partial class anaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOyunlar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrnekOyun = new System.Windows.Forms.Button();
            this.pnlOyunlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "RETRO MİNİ OYUN";
            // 
            // pnlOyunlar
            // 
            this.pnlOyunlar.AutoScroll = true;
            this.pnlOyunlar.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOyunlar.Controls.Add(this.btnOrnekOyun);
            this.pnlOyunlar.Location = new System.Drawing.Point(36, 77);
            this.pnlOyunlar.Name = "pnlOyunlar";
            this.pnlOyunlar.Size = new System.Drawing.Size(700, 400);
            this.pnlOyunlar.TabIndex = 1;
            // 
            // btnOrnekOyun
            // 
            this.btnOrnekOyun.Location = new System.Drawing.Point(3, 3);
            this.btnOrnekOyun.Name = "btnOrnekOyun";
            this.btnOrnekOyun.Size = new System.Drawing.Size(150, 50);
            this.btnOrnekOyun.TabIndex = 0;
            this.btnOrnekOyun.Text = "Örnek Oyun";
            this.btnOrnekOyun.UseVisualStyleBackColor = true;
            this.btnOrnekOyun.Click += new System.EventHandler(this.btnOrnekOyun_Click);
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlOyunlar);
            this.Controls.Add(this.label1);
            this.Name = "anaForm";
            this.Text = "ATP 11B GİTHUB UYGULAMA";
            this.pnlOyunlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlOyunlar;
        private System.Windows.Forms.Button btnOrnekOyun;
    }
}

