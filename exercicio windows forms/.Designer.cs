namespace exercicio_windows_forms
{
    partial class Form11
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
            this.labelConteudo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelConteudo
            // 
            this.labelConteudo.AutoSize = true;
            this.labelConteudo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelConteudo.Location = new System.Drawing.Point(353, 217);
            this.labelConteudo.Name = "labelConteudo";
            this.labelConteudo.Size = new System.Drawing.Size(95, 16);
            this.labelConteudo.TabIndex = 1;
            this.labelConteudo.Text = "labelConteudo";
            this.labelConteudo.Click += new System.EventHandler(this.labelConteudo_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelConteudo);
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConteudo;
    }
}