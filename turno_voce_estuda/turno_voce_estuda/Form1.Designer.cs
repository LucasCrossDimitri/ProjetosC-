namespace turno_voce_estuda
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
            this.lblResp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.CheckBox();
            this.V = new System.Windows.Forms.CheckBox();
            this.N = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(91, 176);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(0, 13);
            this.lblResp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Em que turno você estuda?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turno";
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(67, 94);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(67, 17);
            this.M.TabIndex = 13;
            this.M.Text = "Matutino";
            this.M.UseVisualStyleBackColor = true;
            this.M.CheckedChanged += new System.EventHandler(this.M_CheckedChanged);
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(67, 115);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(76, 17);
            this.V.TabIndex = 14;
            this.V.Text = "Vespertino";
            this.V.UseVisualStyleBackColor = true;
            this.V.CheckedChanged += new System.EventHandler(this.V_CheckedChanged);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(67, 138);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(64, 17);
            this.N.TabIndex = 15;
            this.N.Text = "Noturno";
            this.N.UseVisualStyleBackColor = true;
            this.N.CheckedChanged += new System.EventHandler(this.N_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 226);
            this.Controls.Add(this.N);
            this.Controls.Add(this.V);
            this.Controls.Add(this.M);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox M;
        private System.Windows.Forms.CheckBox V;
        private System.Windows.Forms.CheckBox N;
    }
}

