namespace Tabuada
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
            this.Limpar = new System.Windows.Forms.Button();
            this.Limites = new System.Windows.Forms.Button();
            this.txbLI = new System.Windows.Forms.TextBox();
            this.txbLF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Limite Inicial";
            // 
            // Limpar
            // 
            this.Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Limpar.Location = new System.Drawing.Point(187, 149);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(95, 37);
            this.Limpar.TabIndex = 1;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Limites
            // 
            this.Limites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limites.Location = new System.Drawing.Point(51, 149);
            this.Limites.Name = "Limites";
            this.Limites.Size = new System.Drawing.Size(82, 37);
            this.Limites.TabIndex = 2;
            this.Limites.Text = "Limites";
            this.Limites.UseVisualStyleBackColor = true;
            this.Limites.Click += new System.EventHandler(this.Limites_Click);
            // 
            // txbLI
            // 
            this.txbLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLI.Location = new System.Drawing.Point(140, 26);
            this.txbLI.Name = "txbLI";
            this.txbLI.Size = new System.Drawing.Size(171, 26);
            this.txbLI.TabIndex = 3;
            // 
            // txbLF
            // 
            this.txbLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLF.Location = new System.Drawing.Point(140, 75);
            this.txbLF.Name = "txbLF";
            this.txbLF.Size = new System.Drawing.Size(171, 26);
            this.txbLF.TabIndex = 5;
            this.txbLF.TextChanged += new System.EventHandler(this.txbLF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Limite Final";
            // 
            // ltbTabuada
            // 
            this.ltbTabuada.FormattingEnabled = true;
            this.ltbTabuada.Location = new System.Drawing.Point(34, 212);
            this.ltbTabuada.Name = "ltbTabuada";
            this.ltbTabuada.Size = new System.Drawing.Size(157, 173);
            this.ltbTabuada.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 397);
            this.Controls.Add(this.ltbTabuada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLF);
            this.Controls.Add(this.txbLI);
            this.Controls.Add(this.Limites);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button Limites;
        private System.Windows.Forms.TextBox txbLI;
        private System.Windows.Forms.TextBox txbLF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbTabuada;
    }
}

