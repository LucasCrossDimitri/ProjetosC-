namespace TrabalhoFinalPoo1
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
            this.btnFator = new System.Windows.Forms.Button();
            this.btnFabo = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnPossiveis = new System.Windows.Forms.Button();
            this.btnFuturo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFator
            // 
            this.btnFator.Location = new System.Drawing.Point(28, 61);
            this.btnFator.Name = "btnFator";
            this.btnFator.Size = new System.Drawing.Size(192, 23);
            this.btnFator.TabIndex = 0;
            this.btnFator.Text = "Fatorial de um Numero";
            this.btnFator.UseVisualStyleBackColor = true;
            // 
            // btnFabo
            // 
            this.btnFabo.Location = new System.Drawing.Point(28, 90);
            this.btnFabo.Name = "btnFabo";
            this.btnFabo.Size = new System.Drawing.Size(192, 23);
            this.btnFabo.TabIndex = 1;
            this.btnFabo.Text = "Série de Fibonacci";
            this.btnFabo.UseVisualStyleBackColor = true;
            // 
            // btnPrimo
            // 
            this.btnPrimo.Location = new System.Drawing.Point(28, 119);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(192, 23);
            this.btnPrimo.TabIndex = 2;
            this.btnPrimo.Text = "Numero Primo?";
            this.btnPrimo.UseVisualStyleBackColor = true;
            // 
            // btnPossiveis
            // 
            this.btnPossiveis.Location = new System.Drawing.Point(28, 148);
            this.btnPossiveis.Name = "btnPossiveis";
            this.btnPossiveis.Size = new System.Drawing.Size(192, 23);
            this.btnPossiveis.TabIndex = 3;
            this.btnPossiveis.Text = "Quantos Numeros Primos possiveis?";
            this.btnPossiveis.UseVisualStyleBackColor = true;
            // 
            // btnFuturo
            // 
            this.btnFuturo.Location = new System.Drawing.Point(28, 177);
            this.btnFuturo.Name = "btnFuturo";
            this.btnFuturo.Size = new System.Drawing.Size(192, 23);
            this.btnFuturo.TabIndex = 4;
            this.btnFuturo.Text = "Futuramente...";
            this.btnFuturo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trab Poo1 Clawer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFuturo);
            this.Controls.Add(this.btnPossiveis);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.btnFabo);
            this.Controls.Add(this.btnFator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFator;
        private System.Windows.Forms.Button btnFabo;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnPossiveis;
        private System.Windows.Forms.Button btnFuturo;
        private System.Windows.Forms.Label label1;
    }
}

