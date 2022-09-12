namespace Trabalho2ParcialLucasP
{
    partial class FatorialNumero
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
            this.lblFato = new System.Windows.Forms.Label();
            this.txtFato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // lblFato
            // 
            this.lblFato.AutoSize = true;
            this.lblFato.Location = new System.Drawing.Point(64, 82);
            this.lblFato.Name = "lblFato";
            this.lblFato.Size = new System.Drawing.Size(0, 13);
            this.lblFato.TabIndex = 1;
            // 
            // txtFato
            // 
            this.txtFato.Location = new System.Drawing.Point(67, 41);
            this.txtFato.Name = "txtFato";
            this.txtFato.Size = new System.Drawing.Size(100, 20);
            this.txtFato.TabIndex = 2;
            this.txtFato.TextChanged += new System.EventHandler(this.txtFato_TextChanged);
            // 
            // FatorialNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 171);
            this.Controls.Add(this.txtFato);
            this.Controls.Add(this.lblFato);
            this.Controls.Add(this.label1);
            this.Name = "FatorialNumero";
            this.Text = "FatorialNumero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFato;
        private System.Windows.Forms.TextBox txtFato;
    }
}