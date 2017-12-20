namespace Gerçek_Zamanlı_Sistemler
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
            this.btn_portAc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rapor = new System.Windows.Forms.Button();
            this.lbl_portDurum = new System.Windows.Forms.Label();
            this.btn_uyarıDereceDegistir = new System.Windows.Forms.Button();
            this.txt_uyariDerece = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_derece = new System.Windows.Forms.Label();
            this.lbl_kapıState = new System.Windows.Forms.Label();
            this.lbl_uyariDerece = new System.Windows.Forms.Label();
            this.lbl_Ortalama = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_portAc
            // 
            this.btn_portAc.Location = new System.Drawing.Point(400, 33);
            this.btn_portAc.Name = "btn_portAc";
            this.btn_portAc.Size = new System.Drawing.Size(66, 35);
            this.btn_portAc.TabIndex = 0;
            this.btn_portAc.Text = "Portu Aç";
            this.btn_portAc.UseVisualStyleBackColor = true;
            this.btn_portAc.Click += new System.EventHandler(this.btn_portAc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Merhaba Sinan Durgut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Derece :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kapı Durum :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Son 24 Saat Ortalama Derece :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Uyarı Derecesi :";
            // 
            // btn_rapor
            // 
            this.btn_rapor.Location = new System.Drawing.Point(400, 74);
            this.btn_rapor.Name = "btn_rapor";
            this.btn_rapor.Size = new System.Drawing.Size(66, 35);
            this.btn_rapor.TabIndex = 6;
            this.btn_rapor.Text = "Rapor";
            this.btn_rapor.UseVisualStyleBackColor = true;
            this.btn_rapor.Click += new System.EventHandler(this.btn_rapor_Click);
            // 
            // lbl_portDurum
            // 
            this.lbl_portDurum.AutoSize = true;
            this.lbl_portDurum.Location = new System.Drawing.Point(402, 9);
            this.lbl_portDurum.Name = "lbl_portDurum";
            this.lbl_portDurum.Size = new System.Drawing.Size(64, 13);
            this.lbl_portDurum.TabIndex = 7;
            this.lbl_portDurum.Text = "Port : Kapalı";
            // 
            // btn_uyarıDereceDegistir
            // 
            this.btn_uyarıDereceDegistir.Location = new System.Drawing.Point(153, 167);
            this.btn_uyarıDereceDegistir.Name = "btn_uyarıDereceDegistir";
            this.btn_uyarıDereceDegistir.Size = new System.Drawing.Size(75, 23);
            this.btn_uyarıDereceDegistir.TabIndex = 8;
            this.btn_uyarıDereceDegistir.Text = "Değiştir";
            this.btn_uyarıDereceDegistir.UseVisualStyleBackColor = true;
            this.btn_uyarıDereceDegistir.Click += new System.EventHandler(this.btn_uyarıDereceDegistir_Click);
            // 
            // txt_uyariDerece
            // 
            this.txt_uyariDerece.Location = new System.Drawing.Point(31, 169);
            this.txt_uyariDerece.Name = "txt_uyariDerece";
            this.txt_uyariDerece.Size = new System.Drawing.Size(100, 20);
            this.txt_uyariDerece.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Uyarı Derecesi Değiştir :";
            // 
            // lbl_derece
            // 
            this.lbl_derece.AutoSize = true;
            this.lbl_derece.Location = new System.Drawing.Point(82, 96);
            this.lbl_derece.Name = "lbl_derece";
            this.lbl_derece.Size = new System.Drawing.Size(20, 13);
            this.lbl_derece.TabIndex = 11;
            this.lbl_derece.Text = "0 °";
            // 
            // lbl_kapıState
            // 
            this.lbl_kapıState.AutoSize = true;
            this.lbl_kapıState.Location = new System.Drawing.Point(82, 119);
            this.lbl_kapıState.Name = "lbl_kapıState";
            this.lbl_kapıState.Size = new System.Drawing.Size(36, 13);
            this.lbl_kapıState.TabIndex = 12;
            this.lbl_kapıState.Text = "Kapalı";
            // 
            // lbl_uyariDerece
            // 
            this.lbl_uyariDerece.AutoSize = true;
            this.lbl_uyariDerece.Location = new System.Drawing.Point(354, 119);
            this.lbl_uyariDerece.Name = "lbl_uyariDerece";
            this.lbl_uyariDerece.Size = new System.Drawing.Size(20, 13);
            this.lbl_uyariDerece.TabIndex = 13;
            this.lbl_uyariDerece.Text = "0 °";
            // 
            // lbl_Ortalama
            // 
            this.lbl_Ortalama.AutoSize = true;
            this.lbl_Ortalama.Location = new System.Drawing.Point(354, 96);
            this.lbl_Ortalama.Name = "lbl_Ortalama";
            this.lbl_Ortalama.Size = new System.Drawing.Size(20, 13);
            this.lbl_Ortalama.TabIndex = 14;
            this.lbl_Ortalama.Text = "0 °";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kullanıcı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Ortalama);
            this.Controls.Add(this.lbl_uyariDerece);
            this.Controls.Add(this.lbl_kapıState);
            this.Controls.Add(this.lbl_derece);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_uyariDerece);
            this.Controls.Add(this.btn_uyarıDereceDegistir);
            this.Controls.Add(this.lbl_portDurum);
            this.Controls.Add(this.btn_rapor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_portAc);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_portAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rapor;
        private System.Windows.Forms.Label lbl_portDurum;
        private System.Windows.Forms.Button btn_uyarıDereceDegistir;
        private System.Windows.Forms.TextBox txt_uyariDerece;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_derece;
        private System.Windows.Forms.Label lbl_kapıState;
        private System.Windows.Forms.Label lbl_uyariDerece;
        private System.Windows.Forms.Label lbl_Ortalama;
        private System.Windows.Forms.Button button1;
    }
}

