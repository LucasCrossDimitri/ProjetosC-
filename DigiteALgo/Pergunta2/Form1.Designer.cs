namespace Pergunta2
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
            this.Msg = new System.Windows.Forms.Button();
            this.Verificar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.Location = new System.Drawing.Point(42, 50);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(192, 32);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "Mensagem";
            this.Msg.UseVisualStyleBackColor = true;
            this.Msg.Click += new System.EventHandler(this.Msg_Click);
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(42, 185);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(192, 32);
            this.Verificar.TabIndex = 1;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(42, 123);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(192, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.Msg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Msg;
        private System.Windows.Forms.Button Verificar;
        private System.Windows.Forms.TextBox txbNome;
    }
}

