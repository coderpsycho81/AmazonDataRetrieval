
namespace AmazonVeriAnalizi
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baslikBTN = new System.Windows.Forms.Button();
            this.özellikBTN = new System.Windows.Forms.Button();
            this.detayBTN = new System.Windows.Forms.Button();
            this.resimBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resimText = new System.Windows.Forms.RichTextBox();
            this.detayText = new System.Windows.Forms.RichTextBox();
            this.özellikText = new System.Windows.Forms.RichTextBox();
            this.baslikText = new System.Windows.Forms.RichTextBox();
            this.kaydetBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "URL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox1.Location = new System.Drawing.Point(111, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 37);
            this.textBox1.TabIndex = 1;
            // 
            // baslikBTN
            // 
            this.baslikBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.baslikBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.baslikBTN.Enabled = false;
            this.baslikBTN.FlatAppearance.BorderSize = 0;
            this.baslikBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslikBTN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.baslikBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.baslikBTN.Location = new System.Drawing.Point(12, 65);
            this.baslikBTN.Name = "baslikBTN";
            this.baslikBTN.Size = new System.Drawing.Size(93, 36);
            this.baslikBTN.TabIndex = 2;
            this.baslikBTN.Text = "BAŞLIK";
            this.baslikBTN.UseVisualStyleBackColor = false;
            this.baslikBTN.Click += new System.EventHandler(this.baslikBTN_Click);
            // 
            // özellikBTN
            // 
            this.özellikBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.özellikBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.özellikBTN.Enabled = false;
            this.özellikBTN.FlatAppearance.BorderSize = 0;
            this.özellikBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.özellikBTN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.özellikBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.özellikBTN.Location = new System.Drawing.Point(12, 113);
            this.özellikBTN.Name = "özellikBTN";
            this.özellikBTN.Size = new System.Drawing.Size(93, 36);
            this.özellikBTN.TabIndex = 3;
            this.özellikBTN.Text = "ÖZELLİK";
            this.özellikBTN.UseVisualStyleBackColor = false;
            this.özellikBTN.Click += new System.EventHandler(this.özellikBTN_Click);
            // 
            // detayBTN
            // 
            this.detayBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.detayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detayBTN.Enabled = false;
            this.detayBTN.FlatAppearance.BorderSize = 0;
            this.detayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detayBTN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.detayBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.detayBTN.Location = new System.Drawing.Point(12, 159);
            this.detayBTN.Name = "detayBTN";
            this.detayBTN.Size = new System.Drawing.Size(93, 36);
            this.detayBTN.TabIndex = 4;
            this.detayBTN.Text = "DETAYLI";
            this.detayBTN.UseVisualStyleBackColor = false;
            this.detayBTN.Click += new System.EventHandler(this.detayBTN_Click);
            // 
            // resimBTN
            // 
            this.resimBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(187)))), ((int)(((byte)(195)))));
            this.resimBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resimBTN.Enabled = false;
            this.resimBTN.FlatAppearance.BorderSize = 0;
            this.resimBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resimBTN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.resimBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.resimBTN.Location = new System.Drawing.Point(12, 206);
            this.resimBTN.Name = "resimBTN";
            this.resimBTN.Size = new System.Drawing.Size(93, 36);
            this.resimBTN.TabIndex = 5;
            this.resimBTN.Text = "RESİM";
            this.resimBTN.UseVisualStyleBackColor = false;
            this.resimBTN.Click += new System.EventHandler(this.resimBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.resimText);
            this.groupBox1.Controls.Add(this.detayText);
            this.groupBox1.Controls.Add(this.özellikText);
            this.groupBox1.Controls.Add(this.baslikText);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.groupBox1.Location = new System.Drawing.Point(111, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(108, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Yükleniyor...";
            this.label1.Visible = false;
            // 
            // resimText
            // 
            this.resimText.Location = new System.Drawing.Point(6, 23);
            this.resimText.Name = "resimText";
            this.resimText.Size = new System.Drawing.Size(420, 157);
            this.resimText.TabIndex = 11;
            this.resimText.Text = "";
            this.resimText.Visible = false;
            // 
            // detayText
            // 
            this.detayText.Location = new System.Drawing.Point(6, 23);
            this.detayText.Name = "detayText";
            this.detayText.Size = new System.Drawing.Size(420, 157);
            this.detayText.TabIndex = 10;
            this.detayText.Text = "";
            this.detayText.Visible = false;
            // 
            // özellikText
            // 
            this.özellikText.Location = new System.Drawing.Point(6, 23);
            this.özellikText.Name = "özellikText";
            this.özellikText.Size = new System.Drawing.Size(420, 157);
            this.özellikText.TabIndex = 9;
            this.özellikText.Text = "";
            this.özellikText.Visible = false;
            // 
            // baslikText
            // 
            this.baslikText.Location = new System.Drawing.Point(6, 23);
            this.baslikText.Name = "baslikText";
            this.baslikText.Size = new System.Drawing.Size(420, 157);
            this.baslikText.TabIndex = 0;
            this.baslikText.Text = "";
            this.baslikText.Visible = false;
            // 
            // kaydetBTN
            // 
            this.kaydetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(81)))));
            this.kaydetBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kaydetBTN.FlatAppearance.BorderSize = 0;
            this.kaydetBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBTN.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.kaydetBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.kaydetBTN.Location = new System.Drawing.Point(12, 248);
            this.kaydetBTN.Name = "kaydetBTN";
            this.kaydetBTN.Size = new System.Drawing.Size(532, 36);
            this.kaydetBTN.TabIndex = 8;
            this.kaydetBTN.Text = "KAYDET";
            this.kaydetBTN.UseVisualStyleBackColor = false;
            this.kaydetBTN.Click += new System.EventHandler(this.kaydetBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(551, 289);
            this.Controls.Add(this.kaydetBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resimBTN);
            this.Controls.Add(this.detayBTN);
            this.Controls.Add(this.özellikBTN);
            this.Controls.Add(this.baslikBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazon Veri Çekme / A. Kerim BOZTEPE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button baslikBTN;
        private System.Windows.Forms.Button özellikBTN;
        private System.Windows.Forms.Button detayBTN;
        private System.Windows.Forms.Button resimBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox baslikText;
        private System.Windows.Forms.RichTextBox özellikText;
        private System.Windows.Forms.RichTextBox detayText;
        private System.Windows.Forms.RichTextBox resimText;
        private System.Windows.Forms.Button kaydetBTN;
        private System.Windows.Forms.Label label1;
    }
}

