namespace MetinKarsilastirma
{
    partial class Form1
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
            this.btnDosyabir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblkelimecount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn2dosya = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl2tekerar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl2nolukelimesayisi = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnkarsilastir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblbenzerSayi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbloran = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDosyabir
            // 
            this.btnDosyabir.Location = new System.Drawing.Point(12, 2);
            this.btnDosyabir.Name = "btnDosyabir";
            this.btnDosyabir.Size = new System.Drawing.Size(119, 53);
            this.btnDosyabir.TabIndex = 0;
            this.btnDosyabir.Text = "1.Dosyayı Yükle";
            this.btnDosyabir.UseVisualStyleBackColor = true;
            this.btnDosyabir.Click += new System.EventHandler(this.btnDosyabir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelime Sayısı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tekrar Eden Kelime Sayisi  :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblkelimecount
            // 
            this.lblkelimecount.AutoSize = true;
            this.lblkelimecount.Location = new System.Drawing.Point(83, 82);
            this.lblkelimecount.Name = "lblkelimecount";
            this.lblkelimecount.Size = new System.Drawing.Size(0, 13);
            this.lblkelimecount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "1 Nolu Dosya Görünümü";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(315, 305);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn2dosya
            // 
            this.btn2dosya.Location = new System.Drawing.Point(423, 2);
            this.btn2dosya.Name = "btn2dosya";
            this.btn2dosya.Size = new System.Drawing.Size(119, 53);
            this.btn2dosya.TabIndex = 0;
            this.btn2dosya.Text = "2.Dosyayı Yükle";
            this.btn2dosya.UseVisualStyleBackColor = true;
            this.btn2dosya.Click += new System.EventHandler(this.btn2dosya_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "2  Nolu Dosya Görünümü";
            // 
            // lbl2tekerar
            // 
            this.lbl2tekerar.AutoSize = true;
            this.lbl2tekerar.Location = new System.Drawing.Point(558, 106);
            this.lbl2tekerar.Name = "lbl2tekerar";
            this.lbl2tekerar.Size = new System.Drawing.Size(0, 13);
            this.lbl2tekerar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tekrar Eden Kelime Sayisi  :";
            // 
            // lbl2nolukelimesayisi
            // 
            this.lbl2nolukelimesayisi.AutoSize = true;
            this.lbl2nolukelimesayisi.Location = new System.Drawing.Point(420, 82);
            this.lbl2nolukelimesayisi.Name = "lbl2nolukelimesayisi";
            this.lbl2nolukelimesayisi.Size = new System.Drawing.Size(74, 13);
            this.lbl2nolukelimesayisi.TabIndex = 9;
            this.lbl2nolukelimesayisi.Text = "Kelime Sayısı :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(470, 144);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(292, 305);
            this.dataGridView2.TabIndex = 14;
            // 
            // btnkarsilastir
            // 
            this.btnkarsilastir.Location = new System.Drawing.Point(351, 155);
            this.btnkarsilastir.Name = "btnkarsilastir";
            this.btnkarsilastir.Size = new System.Drawing.Size(91, 68);
            this.btnkarsilastir.TabIndex = 15;
            this.btnkarsilastir.Text = "Karşılaştır";
            this.btnkarsilastir.UseVisualStyleBackColor = true;
            this.btnkarsilastir.Click += new System.EventHandler(this.btnkarsilastir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Benzer Kelime Sayısı ";
            // 
            // lblbenzerSayi
            // 
            this.lblbenzerSayi.AutoSize = true;
            this.lblbenzerSayi.Location = new System.Drawing.Point(386, 250);
            this.lblbenzerSayi.Name = "lblbenzerSayi";
            this.lblbenzerSayi.Size = new System.Drawing.Size(13, 13);
            this.lblbenzerSayi.TabIndex = 17;
            this.lblbenzerSayi.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Benzerlik Oranı (%)";
            // 
            // lbloran
            // 
            this.lbloran.AutoSize = true;
            this.lbloran.Location = new System.Drawing.Point(386, 304);
            this.lbloran.Name = "lbloran";
            this.lbloran.Size = new System.Drawing.Size(13, 13);
            this.lbloran.TabIndex = 19;
            this.lbloran.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbloran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblbenzerSayi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnkarsilastir);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl2tekerar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl2nolukelimesayisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkelimecount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2dosya);
            this.Controls.Add(this.btnDosyabir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDosyabir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblkelimecount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn2dosya;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl2tekerar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl2nolukelimesayisi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnkarsilastir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblbenzerSayi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbloran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
    }
}

