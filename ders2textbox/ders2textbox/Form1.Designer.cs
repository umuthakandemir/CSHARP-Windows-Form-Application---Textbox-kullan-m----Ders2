namespace ders2textbox
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
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnYazi = new System.Windows.Forms.Button();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Location = new System.Drawing.Point(202, 31);
            this.lblYazi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(51, 20);
            this.lblYazi.TabIndex = 0;
            this.lblYazi.Text = "label1";
            // 
            // btnYazi
            // 
            this.btnYazi.Location = new System.Drawing.Point(178, 135);
            this.btnYazi.Name = "btnYazi";
            this.btnYazi.Size = new System.Drawing.Size(94, 31);
            this.btnYazi.TabIndex = 1;
            this.btnYazi.Text = "button1";
            this.btnYazi.UseVisualStyleBackColor = true;
            this.btnYazi.Click += new System.EventHandler(this.btnYazi_Click);
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(127, 80);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(191, 26);
            this.txtYazi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 204);
            this.Controls.Add(this.txtYazi);
            this.Controls.Add(this.btnYazi);
            this.Controls.Add(this.lblYazi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button btnYazi;
        private System.Windows.Forms.TextBox txtYazi;
    }
}

