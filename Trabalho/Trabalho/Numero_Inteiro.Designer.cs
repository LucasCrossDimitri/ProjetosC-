﻿namespace Trabalho
{
    partial class Numero_Inteiro
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
            this.btnChecar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInteiro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Location = new System.Drawing.Point(73, 188);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(0, 13);
            this.lblResp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado";
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(213, 127);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(75, 23);
            this.btnChecar.TabIndex = 9;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.btnChecar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Positivo ou negativo?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Inteiro";
            // 
            // txtInteiro
            // 
            this.txtInteiro.Location = new System.Drawing.Point(79, 129);
            this.txtInteiro.Name = "txtInteiro";
            this.txtInteiro.Size = new System.Drawing.Size(128, 20);
            this.txtInteiro.TabIndex = 6;
            // 
            // Numero_Inteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 222);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChecar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInteiro);
            this.Name = "Numero_Inteiro";
            this.Text = "Numero_Inteiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInteiro;
    }
}