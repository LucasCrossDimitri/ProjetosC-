namespace Perguntinhas
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
            this.Perguntinhas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSexo = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.MSG = new System.Windows.Forms.Button();
            this.Sr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Perguntinhas
            // 
            this.Perguntinhas.AutoSize = true;
            this.Perguntinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perguntinhas.Location = new System.Drawing.Point(55, 9);
            this.Perguntinhas.Name = "Perguntinhas";
            this.Perguntinhas.Size = new System.Drawing.Size(174, 31);
            this.Perguntinhas.TabIndex = 0;
            this.Perguntinhas.Text = "Perguntinhas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Idade";
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txbNome.Location = new System.Drawing.Point(116, 59);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(129, 26);
            this.txbNome.TabIndex = 4;
            this.txbNome.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // txbSexo
            // 
            this.txbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txbSexo.Location = new System.Drawing.Point(114, 99);
            this.txbSexo.Name = "txbSexo";
            this.txbSexo.Size = new System.Drawing.Size(131, 26);
            this.txbSexo.TabIndex = 5;
            // 
            // txbIdade
            // 
            this.txbIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txbIdade.Location = new System.Drawing.Point(116, 131);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(129, 26);
            this.txbIdade.TabIndex = 6;
            this.txbIdade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MSG
            // 
            this.MSG.Location = new System.Drawing.Point(36, 191);
            this.MSG.Name = "MSG";
            this.MSG.Size = new System.Drawing.Size(83, 39);
            this.MSG.TabIndex = 7;
            this.MSG.Text = "Mensagem";
            this.MSG.UseVisualStyleBackColor = true;
            this.MSG.Click += new System.EventHandler(this.MSG_Click);
            // 
            // Sr
            // 
            this.Sr.Location = new System.Drawing.Point(146, 191);
            this.Sr.Name = "Sr";
            this.Sr.Size = new System.Drawing.Size(83, 39);
            this.Sr.TabIndex = 8;
            this.Sr.Text = "Sair";
            this.Sr.UseVisualStyleBackColor = true;
            this.Sr.Click += new System.EventHandler(this.Sr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Sr);
            this.Controls.Add(this.MSG);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbSexo);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Perguntinhas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Perguntinhas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSexo;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Button MSG;
        private System.Windows.Forms.Button Sr;
    }
}

