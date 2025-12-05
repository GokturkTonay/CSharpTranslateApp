namespace CeviriUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
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
        /// içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtCikis = new System.Windows.Forms.TextBox();
            this.cmbDiller = new System.Windows.Forms.ComboBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblHedefDil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(12, 46);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGiris.Size = new System.Drawing.Size(320, 300);
            this.txtGiris.TabIndex = 0;
            // 
            // txtCikis
            // 
            this.txtCikis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCikis.Location = new System.Drawing.Point(360, 46);
            this.txtCikis.Multiline = true;
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.ReadOnly = true;
            this.txtCikis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCikis.Size = new System.Drawing.Size(320, 300);
            this.txtCikis.TabIndex = 1;
            // 
            // cmbDiller
            // 
            this.cmbDiller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDiller.FormattingEnabled = true;
            this.cmbDiller.Location = new System.Drawing.Point(495, 12);
            this.cmbDiller.Name = "cmbDiller";
            this.cmbDiller.Size = new System.Drawing.Size(185, 28);
            this.cmbDiller.TabIndex = 2;
            // 
            // btnCevir
            // 
            this.btnCevir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevir.ForeColor = System.Drawing.Color.White;
            this.btnCevir.Location = new System.Drawing.Point(12, 365);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(668, 50);
            this.btnCevir.TabIndex = 3;
            this.btnCevir.Text = "ÇEVİR";
            this.btnCevir.UseVisualStyleBackColor = false;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.Location = new System.Drawing.Point(12, 20);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(147, 18);
            this.lblGiris.TabIndex = 4;
            this.lblGiris.Text = "Çevrilecek Metin :";
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(357, 20);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(66, 18);
            this.lblCikis.TabIndex = 5;
            this.lblCikis.Text = "Sonuç :";
            // 
            // lblHedefDil
            // 
            this.lblHedefDil.AutoSize = true;
            this.lblHedefDil.Location = new System.Drawing.Point(420, 19);
            this.lblHedefDil.Name = "lblHedefDil";
            this.lblHedefDil.Size = new System.Drawing.Size(69, 16);
            this.lblHedefDil.TabIndex = 6;
            this.lblHedefDil.Text = "Hedef Dil :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 435);
            this.Controls.Add(this.lblHedefDil);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.cmbDiller);
            this.Controls.Add(this.txtCikis);
            this.Controls.Add(this.txtGiris);
            this.Name = "Form1";
            this.Text = "NTP Çeviri Asistanı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtCikis;
        private System.Windows.Forms.ComboBox cmbDiller;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblHedefDil;
    }
}