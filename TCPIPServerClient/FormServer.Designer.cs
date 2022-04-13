
namespace TCPIPServerClient
{
    partial class FormServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtGonder = new System.Windows.Forms.TextBox();
            this.txtEkran = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 27);
            this.textBox1.TabIndex = 1;
            // 
            // txtGonder
            // 
            this.txtGonder.Location = new System.Drawing.Point(465, 319);
            this.txtGonder.Name = "txtGonder";
            this.txtGonder.Size = new System.Drawing.Size(277, 27);
            this.txtGonder.TabIndex = 2;
            // 
            // txtEkran
            // 
            this.txtEkran.Location = new System.Drawing.Point(36, 93);
            this.txtEkran.Multiline = true;
            this.txtEkran.Name = "txtEkran";
            this.txtEkran.Size = new System.Drawing.Size(706, 189);
            this.txtEkran.TabIndex = 3;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(391, 33);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(148, 34);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "Dinlemeye Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(577, 33);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(165, 34);
            this.btnDurdur.TabIndex = 5;
            this.btnDurdur.Text = "Dinlemeyi Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(602, 375);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(140, 34);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 426);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txtEkran);
            this.Controls.Add(this.txtGonder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtGonder;
        private System.Windows.Forms.TextBox txtEkran;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnGonder;
    }
}

