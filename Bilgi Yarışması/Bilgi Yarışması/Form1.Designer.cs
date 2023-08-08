namespace Bilgi_Yarışması
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldoğrusayısı = new System.Windows.Forms.Label();
            this.labelyanlışsayısı = new System.Windows.Forms.Label();
            this.labelsorusayısı = new System.Windows.Forms.Label();
            this.buttonsonraki = new System.Windows.Forms.Button();
            this.labeldoğru = new System.Windows.Forms.Label();
            this.labelyanlış = new System.Windows.Forms.Label();
            this.labeldoğrucevap = new System.Windows.Forms.Label();
            this.labelcevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(1, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(669, 281);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttona
            // 
            this.buttona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttona.Location = new System.Drawing.Point(12, 302);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(326, 72);
            this.buttona.TabIndex = 1;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonb.Location = new System.Drawing.Point(344, 302);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(326, 72);
            this.buttonb.TabIndex = 1;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttond
            // 
            this.buttond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttond.Location = new System.Drawing.Point(344, 380);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(326, 72);
            this.buttond.TabIndex = 1;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // buttonc
            // 
            this.buttonc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonc.Location = new System.Drawing.Point(12, 380);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(326, 72);
            this.buttonc.TabIndex = 1;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.buttonc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(722, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doğru :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(722, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yanlış :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(703, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soru No :";
            // 
            // labeldoğrusayısı
            // 
            this.labeldoğrusayısı.AutoSize = true;
            this.labeldoğrusayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoğrusayısı.Location = new System.Drawing.Point(810, 138);
            this.labeldoğrusayısı.Name = "labeldoğrusayısı";
            this.labeldoğrusayısı.Size = new System.Drawing.Size(23, 25);
            this.labeldoğrusayısı.TabIndex = 2;
            this.labeldoğrusayısı.Text = "0";
            // 
            // labelyanlışsayısı
            // 
            this.labelyanlışsayısı.AutoSize = true;
            this.labelyanlışsayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlışsayısı.Location = new System.Drawing.Point(810, 94);
            this.labelyanlışsayısı.Name = "labelyanlışsayısı";
            this.labelyanlışsayısı.Size = new System.Drawing.Size(23, 25);
            this.labelyanlışsayısı.TabIndex = 2;
            this.labelyanlışsayısı.Text = "0";
            // 
            // labelsorusayısı
            // 
            this.labelsorusayısı.AutoSize = true;
            this.labelsorusayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsorusayısı.Location = new System.Drawing.Point(810, 48);
            this.labelsorusayısı.Name = "labelsorusayısı";
            this.labelsorusayısı.Size = new System.Drawing.Size(23, 25);
            this.labelsorusayısı.TabIndex = 2;
            this.labelsorusayısı.Text = "0";
            // 
            // buttonsonraki
            // 
            this.buttonsonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonsonraki.Location = new System.Drawing.Point(696, 206);
            this.buttonsonraki.Name = "buttonsonraki";
            this.buttonsonraki.Size = new System.Drawing.Size(203, 63);
            this.buttonsonraki.TabIndex = 3;
            this.buttonsonraki.Text = "Sonraki";
            this.buttonsonraki.UseVisualStyleBackColor = true;
            this.buttonsonraki.Click += new System.EventHandler(this.button5_Click);
            // 
            // labeldoğru
            // 
            this.labeldoğru.AutoSize = true;
            this.labeldoğru.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeldoğru.Location = new System.Drawing.Point(688, 301);
            this.labeldoğru.Name = "labeldoğru";
            this.labeldoğru.Size = new System.Drawing.Size(211, 58);
            this.labeldoğru.TabIndex = 4;
            this.labeldoğru.Text = "DOĞRU";
            this.labeldoğru.Visible = false;
            this.labeldoğru.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelyanlış
            // 
            this.labelyanlış.AutoSize = true;
            this.labelyanlış.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelyanlış.Location = new System.Drawing.Point(686, 379);
            this.labelyanlış.Name = "labelyanlış";
            this.labelyanlış.Size = new System.Drawing.Size(202, 58);
            this.labelyanlış.TabIndex = 4;
            this.labelyanlış.Text = "YANLIŞ";
            this.labelyanlış.Visible = false;
            // 
            // labeldoğrucevap
            // 
            this.labeldoğrucevap.AutoSize = true;
            this.labeldoğrucevap.Location = new System.Drawing.Point(476, 499);
            this.labeldoğrucevap.Name = "labeldoğrucevap";
            this.labeldoğrucevap.Size = new System.Drawing.Size(44, 16);
            this.labeldoğrucevap.TabIndex = 5;
            this.labeldoğrucevap.Text = "label4";
            this.labeldoğrucevap.Visible = false;
            // 
            // labelcevap
            // 
            this.labelcevap.AutoSize = true;
            this.labelcevap.Location = new System.Drawing.Point(542, 499);
            this.labelcevap.Name = "labelcevap";
            this.labelcevap.Size = new System.Drawing.Size(44, 16);
            this.labelcevap.TabIndex = 5;
            this.labelcevap.Text = "label4";
            this.labelcevap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 477);
            this.Controls.Add(this.labelcevap);
            this.Controls.Add(this.labeldoğrucevap);
            this.Controls.Add(this.labelyanlış);
            this.Controls.Add(this.labeldoğru);
            this.Controls.Add(this.buttonsonraki);
            this.Controls.Add(this.labelsorusayısı);
            this.Controls.Add(this.labelyanlışsayısı);
            this.Controls.Add(this.labeldoğrusayısı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldoğrusayısı;
        private System.Windows.Forms.Label labelyanlışsayısı;
        private System.Windows.Forms.Label labelsorusayısı;
        private System.Windows.Forms.Button buttonsonraki;
        private System.Windows.Forms.Label labeldoğru;
        private System.Windows.Forms.Label labelyanlış;
        private System.Windows.Forms.Label labeldoğrucevap;
        private System.Windows.Forms.Label labelcevap;
    }
}

