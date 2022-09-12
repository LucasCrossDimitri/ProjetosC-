namespace Numero_Inteiro
{
    partial class txtValor1
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
            this.txtInteiro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChecar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInteiro
            // 
            this.txtInteiro.Location = new System.Drawing.Point(103, 102);
            this.txtInteiro.Name = "txtInteiro";
            this.txtInteiro.Size = new System.Drawing.Size(128, 20);
            this.txtInteiro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Inteiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Positivo ou negativo?";
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(237, 100);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(75, 23);
            this.btnChecar.TabIndex = 3;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(97, 161);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(0, 13);
            this.lblResp.TabIndex = 5;
            // 
            // txtValor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChecar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInteiro);
            this.Name = "txtValor1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtValor1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInteiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResp;
    }
}

