
namespace Proje5_27MailGondermeUygulamasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAliciEpostaAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMesaj = new System.Windows.Forms.RichTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alıcı Eposta";
            // 
            // tbAliciEpostaAdresi
            // 
            this.tbAliciEpostaAdresi.Location = new System.Drawing.Point(117, 7);
            this.tbAliciEpostaAdresi.Name = "tbAliciEpostaAdresi";
            this.tbAliciEpostaAdresi.Size = new System.Drawing.Size(392, 22);
            this.tbAliciEpostaAdresi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu";
            // 
            // tbKonu
            // 
            this.tbKonu.Location = new System.Drawing.Point(117, 45);
            this.tbKonu.Name = "tbKonu";
            this.tbKonu.Size = new System.Drawing.Size(392, 22);
            this.tbKonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesaj";
            // 
            // tbMesaj
            // 
            this.tbMesaj.Location = new System.Drawing.Point(117, 88);
            this.tbMesaj.Name = "tbMesaj";
            this.tbMesaj.Size = new System.Drawing.Size(392, 350);
            this.tbMesaj.TabIndex = 5;
            this.tbMesaj.Text = "";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(117, 456);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(124, 36);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 504);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.tbMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAliciEpostaAdresi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAliciEpostaAdresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbMesaj;
        private System.Windows.Forms.Button btnGonder;
    }
}

