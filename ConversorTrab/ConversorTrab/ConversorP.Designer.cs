namespace ConversorTrab
{
    partial class ConversorP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboGrausPara = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboGraus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtConverte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboGrausPara);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboGraus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtConverte);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversor Simples";
            // 
            // comboGrausPara
            // 
            this.comboGrausPara.FormattingEnabled = true;
            this.comboGrausPara.Items.AddRange(new object[] {
            "Kilograma",
            "Grama"});
            this.comboGrausPara.Location = new System.Drawing.Point(110, 129);
            this.comboGrausPara.Name = "comboGrausPara";
            this.comboGrausPara.Size = new System.Drawing.Size(130, 33);
            this.comboGrausPara.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboGraus
            // 
            this.comboGraus.DisplayMember = "(none)";
            this.comboGraus.FormattingEnabled = true;
            this.comboGraus.Items.AddRange(new object[] {
            "Quilómetros",
            "Metros",
            "Centímetros"});
            this.comboGraus.Location = new System.Drawing.Point(282, 65);
            this.comboGraus.Name = "comboGraus";
            this.comboGraus.Size = new System.Drawing.Size(127, 33);
            this.comboGraus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(282, 132);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(127, 30);
            this.txtResult.TabIndex = 2;
            // 
            // txtConverte
            // 
            this.txtConverte.Location = new System.Drawing.Point(110, 65);
            this.txtConverte.Name = "txtConverte";
            this.txtConverte.Size = new System.Drawing.Size(130, 30);
            this.txtConverte.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converter:";
            // 
            // ConversorP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 344);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConversorP";
            this.Text = "ConversorP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboGrausPara;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboGraus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtConverte;
        private System.Windows.Forms.Label label1;
    }
}