namespace Primeiro_Exemplo
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
            this.Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmar.Location = new System.Drawing.Point(41, 292);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(134, 63);
            this.Confirmar.TabIndex = 0;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exemplo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(166, 126);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(392, 46);
            this.txb1.TabIndex = 2;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite Um Número: ";
            // 
            // txb2
            // 
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.Location = new System.Drawing.Point(342, 194);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(216, 46);
            this.txb2.TabIndex = 5;
            this.txb2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Verificar
            // 
            this.Verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verificar.Location = new System.Drawing.Point(181, 292);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(134, 63);
            this.Verificar.TabIndex = 6;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(321, 292);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(134, 63);
            this.Sair.TabIndex = 7;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Primeiro_Exemplo.Properties.Resources.Koala;
            this.pictureBox1.Location = new System.Drawing.Point(564, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // resp
            // 
            this.resp.AutoSize = true;
            this.resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.resp.Location = new System.Drawing.Point(503, 292);
            this.resp.Name = "resp";
            this.resp.Size = new System.Drawing.Size(0, 39);
            this.resp.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 507);
            this.Controls.Add(this.resp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirmar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label resp;
    }
}

