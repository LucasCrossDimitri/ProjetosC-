namespace Trabalho2ParcialLucasP
{
    partial class NumeroDesejado
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
            this.txbND = new System.Windows.Forms.TextBox();
            this.ltbND = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbND
            // 
            this.txbND.Location = new System.Drawing.Point(121, 35);
            this.txbND.Name = "txbND";
            this.txbND.Size = new System.Drawing.Size(120, 20);
            this.txbND.TabIndex = 0;
            this.txbND.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ltbND
            // 
            this.ltbND.FormattingEnabled = true;
            this.ltbND.Location = new System.Drawing.Point(121, 61);
            this.ltbND.Name = "ltbND";
            this.ltbND.Size = new System.Drawing.Size(120, 277);
            this.ltbND.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o Número para saber quantos Números primos á:";
            // 
            // NumeroDesejado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbND);
            this.Controls.Add(this.txbND);
            this.Name = "NumeroDesejado";
            this.Text = "NumeroDesejado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbND;
        private System.Windows.Forms.ListBox ltbND;
        private System.Windows.Forms.Label label1;
    }
}