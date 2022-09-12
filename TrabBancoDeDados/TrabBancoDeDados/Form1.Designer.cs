namespace TrabBancoDeDados
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
            this.Departamento = new System.Windows.Forms.Button();
            this.FunProj = new System.Windows.Forms.Button();
            this.MatFunc = new System.Windows.Forms.Button();
            this.NumProj = new System.Windows.Forms.Button();
            this.ProjDep = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Departamento
            // 
            this.Departamento.Location = new System.Drawing.Point(62, 66);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(155, 23);
            this.Departamento.TabIndex = 0;
            this.Departamento.Text = "Departamento";
            this.Departamento.UseVisualStyleBackColor = true;
            this.Departamento.Click += new System.EventHandler(this.Departamento_Click);
            // 
            // FunProj
            // 
            this.FunProj.Location = new System.Drawing.Point(62, 144);
            this.FunProj.Name = "FunProj";
            this.FunProj.Size = new System.Drawing.Size(155, 23);
            this.FunProj.TabIndex = 1;
            this.FunProj.Text = "Funcionarios do projeto";
            this.FunProj.UseVisualStyleBackColor = true;
            this.FunProj.Click += new System.EventHandler(this.FunProj_Click);
            // 
            // MatFunc
            // 
            this.MatFunc.Location = new System.Drawing.Point(62, 221);
            this.MatFunc.Name = "MatFunc";
            this.MatFunc.Size = new System.Drawing.Size(155, 23);
            this.MatFunc.TabIndex = 2;
            this.MatFunc.Text = "Informaçôes do funcionaro";
            this.MatFunc.UseVisualStyleBackColor = true;
            this.MatFunc.Click += new System.EventHandler(this.MatFunc_Click);
            // 
            // NumProj
            // 
            this.NumProj.Location = new System.Drawing.Point(232, 66);
            this.NumProj.Name = "NumProj";
            this.NumProj.Size = new System.Drawing.Size(155, 23);
            this.NumProj.TabIndex = 3;
            this.NumProj.Text = "Numero do Projeto";
            this.NumProj.UseVisualStyleBackColor = true;
            this.NumProj.Click += new System.EventHandler(this.NumProj_Click);
            // 
            // ProjDep
            // 
            this.ProjDep.Location = new System.Drawing.Point(232, 144);
            this.ProjDep.Name = "ProjDep";
            this.ProjDep.Size = new System.Drawing.Size(155, 23);
            this.ProjDep.TabIndex = 4;
            this.ProjDep.Text = "Departamento do Projeto";
            this.ProjDep.UseVisualStyleBackColor = true;
            this.ProjDep.Click += new System.EventHandler(this.ProjDep_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(232, 221);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(155, 23);
            this.Sair.TabIndex = 5;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 323);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.ProjDep);
            this.Controls.Add(this.NumProj);
            this.Controls.Add(this.MatFunc);
            this.Controls.Add(this.FunProj);
            this.Controls.Add(this.Departamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Departamento;
        private System.Windows.Forms.Button FunProj;
        private System.Windows.Forms.Button MatFunc;
        private System.Windows.Forms.Button NumProj;
        private System.Windows.Forms.Button ProjDep;
        private System.Windows.Forms.Button Sair;
    }
}