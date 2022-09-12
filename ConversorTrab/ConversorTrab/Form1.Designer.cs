namespace ConversorTrab
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
            this.BtP = new System.Windows.Forms.Button();
            this.btT = new System.Windows.Forms.Button();
            this.BtM = new System.Windows.Forms.Button();
            this.BtH = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtP
            // 
            this.BtP.Location = new System.Drawing.Point(27, 189);
            this.BtP.Name = "BtP";
            this.BtP.Size = new System.Drawing.Size(114, 23);
            this.BtP.TabIndex = 0;
            this.BtP.Text = "Conversor Peso";
            this.BtP.UseVisualStyleBackColor = true;
            this.BtP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btT
            // 
            this.btT.Location = new System.Drawing.Point(27, 66);
            this.btT.Name = "btT";
            this.btT.Size = new System.Drawing.Size(114, 23);
            this.btT.TabIndex = 1;
            this.btT.Text = "Conversor Temp";
            this.btT.UseVisualStyleBackColor = true;
            this.btT.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtM
            // 
            this.BtM.Location = new System.Drawing.Point(168, 66);
            this.BtM.Name = "BtM";
            this.BtM.Size = new System.Drawing.Size(114, 23);
            this.BtM.TabIndex = 2;
            this.BtM.Text = "Conversor Medidas";
            this.BtM.UseVisualStyleBackColor = true;
            this.BtM.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtH
            // 
            this.BtH.Location = new System.Drawing.Point(168, 189);
            this.BtH.Name = "BtH";
            this.BtH.Size = new System.Drawing.Size(114, 23);
            this.BtH.TabIndex = 3;
            this.BtH.Text = "Conversor Horas";
            this.BtH.UseVisualStyleBackColor = true;
            this.BtH.Click += new System.EventHandler(this.button4_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(118, 243);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 299);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.BtH);
            this.Controls.Add(this.BtM);
            this.Controls.Add(this.btT);
            this.Controls.Add(this.BtP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtP;
        private System.Windows.Forms.Button btT;
        private System.Windows.Forms.Button BtM;
        private System.Windows.Forms.Button BtH;
        private System.Windows.Forms.Button btSair;
    }
}

