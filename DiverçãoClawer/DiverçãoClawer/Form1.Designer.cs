namespace DiverçãoClawer
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
            this.btDv1 = new System.Windows.Forms.Button();
            this.bt2Dv = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDv1
            // 
            this.btDv1.Location = new System.Drawing.Point(80, 29);
            this.btDv1.Name = "btDv1";
            this.btDv1.Size = new System.Drawing.Size(75, 23);
            this.btDv1.TabIndex = 0;
            this.btDv1.Text = "Diverção";
            this.btDv1.UseVisualStyleBackColor = true;
            this.btDv1.Click += new System.EventHandler(this.btDv1_Click);
            // 
            // bt2Dv
            // 
            this.bt2Dv.Location = new System.Drawing.Point(80, 131);
            this.bt2Dv.Name = "bt2Dv";
            this.bt2Dv.Size = new System.Drawing.Size(75, 23);
            this.bt2Dv.TabIndex = 1;
            this.bt2Dv.Text = "Diverção";
            this.bt2Dv.UseVisualStyleBackColor = true;
            this.bt2Dv.Click += new System.EventHandler(this.bt2Dv_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(123, 87);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(32, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe um Numero: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.bt2Dv);
            this.Controls.Add(this.btDv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDv1;
        private System.Windows.Forms.Button bt2Dv;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
    }
}

