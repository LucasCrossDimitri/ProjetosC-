namespace Trabalho2ParcialLucasP
{
    partial class Fibonacci
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
            this.txbfibo = new System.Windows.Forms.TextBox();
            this.ltbFibo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quant De Números:";
            // 
            // txbfibo
            // 
            this.txbfibo.Location = new System.Drawing.Point(130, 48);
            this.txbfibo.Name = "txbfibo";
            this.txbfibo.Size = new System.Drawing.Size(100, 20);
            this.txbfibo.TabIndex = 1;
            this.txbfibo.TextChanged += new System.EventHandler(this.txbfibo_TextChanged);
            // 
            // ltbFibo
            // 
            this.ltbFibo.FormattingEnabled = true;
            this.ltbFibo.Location = new System.Drawing.Point(130, 74);
            this.ltbFibo.Name = "ltbFibo";
            this.ltbFibo.Size = new System.Drawing.Size(120, 251);
            this.ltbFibo.TabIndex = 2;
            this.ltbFibo.SelectedIndexChanged += new System.EventHandler(this.ltbFibo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max: 45";
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 355);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbFibo);
            this.Controls.Add(this.txbfibo);
            this.Controls.Add(this.label1);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbfibo;
        private System.Windows.Forms.ListBox ltbFibo;
        private System.Windows.Forms.Label label2;
    }
}