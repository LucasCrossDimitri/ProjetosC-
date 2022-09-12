namespace Trabalho
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
            this.BtCalc = new System.Windows.Forms.Button();
            this.BtNumero = new System.Windows.Forms.Button();
            this.BtPergunta = new System.Windows.Forms.Button();
            this.BtPesoideal = new System.Windows.Forms.Button();
            this.BtDespedida = new System.Windows.Forms.Button();
            this.BtEstuda = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtCalc
            // 
            this.BtCalc.Location = new System.Drawing.Point(38, 68);
            this.BtCalc.Name = "BtCalc";
            this.BtCalc.Size = new System.Drawing.Size(107, 58);
            this.BtCalc.TabIndex = 0;
            this.BtCalc.Text = "Calculadora simples";
            this.BtCalc.UseVisualStyleBackColor = true;
            this.BtCalc.Click += new System.EventHandler(this.BtCalc_Click);
            // 
            // BtNumero
            // 
            this.BtNumero.Location = new System.Drawing.Point(38, 159);
            this.BtNumero.Name = "BtNumero";
            this.BtNumero.Size = new System.Drawing.Size(107, 58);
            this.BtNumero.TabIndex = 1;
            this.BtNumero.Text = "Numero Inteiro";
            this.BtNumero.UseVisualStyleBackColor = true;
            this.BtNumero.Click += new System.EventHandler(this.BtNumero_Click);
            // 
            // BtPergunta
            // 
            this.BtPergunta.Location = new System.Drawing.Point(38, 248);
            this.BtPergunta.Name = "BtPergunta";
            this.BtPergunta.Size = new System.Drawing.Size(107, 58);
            this.BtPergunta.TabIndex = 2;
            this.BtPergunta.Text = "Pertguntinhas";
            this.BtPergunta.UseVisualStyleBackColor = true;
            this.BtPergunta.Click += new System.EventHandler(this.BtPergunta_Click);
            // 
            // BtPesoideal
            // 
            this.BtPesoideal.Location = new System.Drawing.Point(218, 68);
            this.BtPesoideal.Name = "BtPesoideal";
            this.BtPesoideal.Size = new System.Drawing.Size(107, 58);
            this.BtPesoideal.TabIndex = 3;
            this.BtPesoideal.Text = "Peso Ideal";
            this.BtPesoideal.UseVisualStyleBackColor = true;
            this.BtPesoideal.Click += new System.EventHandler(this.BtPesoideal_Click);
            // 
            // BtDespedida
            // 
            this.BtDespedida.Location = new System.Drawing.Point(218, 248);
            this.BtDespedida.Name = "BtDespedida";
            this.BtDespedida.Size = new System.Drawing.Size(107, 58);
            this.BtDespedida.TabIndex = 4;
            this.BtDespedida.Text = "Form de despedida";
            this.BtDespedida.UseVisualStyleBackColor = true;
            this.BtDespedida.Click += new System.EventHandler(this.BtDespedida_Click);
            // 
            // BtEstuda
            // 
            this.BtEstuda.Location = new System.Drawing.Point(218, 159);
            this.BtEstuda.Name = "BtEstuda";
            this.BtEstuda.Size = new System.Drawing.Size(107, 58);
            this.BtEstuda.TabIndex = 5;
            this.BtEstuda.Text = "Turno em que você estuda?";
            this.BtEstuda.UseVisualStyleBackColor = true;
            this.BtEstuda.Click += new System.EventHandler(this.BtEstuda_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(143, 341);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FuP Formulários";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.BtEstuda);
            this.Controls.Add(this.BtDespedida);
            this.Controls.Add(this.BtPesoideal);
            this.Controls.Add(this.BtPergunta);
            this.Controls.Add(this.BtNumero);
            this.Controls.Add(this.BtCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCalc;
        private System.Windows.Forms.Button BtNumero;
        private System.Windows.Forms.Button BtPergunta;
        private System.Windows.Forms.Button BtPesoideal;
        private System.Windows.Forms.Button BtDespedida;
        private System.Windows.Forms.Button BtEstuda;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Label label1;
    }
}

