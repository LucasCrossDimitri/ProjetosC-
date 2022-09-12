namespace TrabBancoDeDados
{
    partial class MatFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatFuncionario));
            this.dtfuncionarios = new System.Windows.Forms.DataGrid();
            this.dsFunc1 = new TrabBancoDeDados.DsFunc();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.DatFunc = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtfuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFunc1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtfuncionarios
            // 
            this.dtfuncionarios.DataMember = "MatFuncionario";
            this.dtfuncionarios.DataSource = this.dsFunc1;
            this.dtfuncionarios.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dtfuncionarios.Location = new System.Drawing.Point(23, 36);
            this.dtfuncionarios.Name = "dtfuncionarios";
            this.dtfuncionarios.Size = new System.Drawing.Size(641, 264);
            this.dtfuncionarios.TabIndex = 0;
            this.dtfuncionarios.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate);
            // 
            // dsFunc1
            // 
            this.dsFunc1.DataSetName = "DsFunc";
            this.dsFunc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"c:\\users\\110002224\\documents\\visual" +
    " studio 2013\\Projects\\TrabBancoDeDados\\TrabBancoDeDados\\Departamento.mdb\"";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        MatFuncionario.*\r\nFROM            MatFuncionario";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Departamento.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `MatFuncionario` (`Mat funcionario`, `nome do funcionario`, `salario`" +
    ", `casado`, `foto`, `data admição`, `data demição`, `cod dept`) VALUES (?, ?, ?," +
    " ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Mat_funcionario", System.Data.OleDb.OleDbType.Integer, 0, "Mat funcionario"),
            new System.Data.OleDb.OleDbParameter("nome_do_funcionario", System.Data.OleDb.OleDbType.VarWChar, 0, "nome do funcionario"),
            new System.Data.OleDb.OleDbParameter("salario", System.Data.OleDb.OleDbType.Currency, 0, "salario"),
            new System.Data.OleDb.OleDbParameter("casado", System.Data.OleDb.OleDbType.Boolean, 0, "casado"),
            new System.Data.OleDb.OleDbParameter("foto", System.Data.OleDb.OleDbType.LongVarBinary, 0, "foto"),
            new System.Data.OleDb.OleDbParameter("data_admição", System.Data.OleDb.OleDbType.Date, 0, "data admição"),
            new System.Data.OleDb.OleDbParameter("data_demição", System.Data.OleDb.OleDbType.Date, 0, "data demição"),
            new System.Data.OleDb.OleDbParameter("cod_dept", System.Data.OleDb.OleDbType.Integer, 0, "cod dept")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection2;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Mat_funcionario", System.Data.OleDb.OleDbType.Integer, 0, "Mat funcionario"),
            new System.Data.OleDb.OleDbParameter("nome_do_funcionario", System.Data.OleDb.OleDbType.VarWChar, 0, "nome do funcionario"),
            new System.Data.OleDb.OleDbParameter("salario", System.Data.OleDb.OleDbType.Currency, 0, "salario"),
            new System.Data.OleDb.OleDbParameter("casado", System.Data.OleDb.OleDbType.Boolean, 0, "casado"),
            new System.Data.OleDb.OleDbParameter("foto", System.Data.OleDb.OleDbType.LongVarBinary, 0, "foto"),
            new System.Data.OleDb.OleDbParameter("data_admição", System.Data.OleDb.OleDbType.Date, 0, "data admição"),
            new System.Data.OleDb.OleDbParameter("data_demição", System.Data.OleDb.OleDbType.Date, 0, "data demição"),
            new System.Data.OleDb.OleDbParameter("cod_dept", System.Data.OleDb.OleDbType.Integer, 0, "cod dept"),
            new System.Data.OleDb.OleDbParameter("Original_Mat_funcionario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mat funcionario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nome_do_funcionario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nome do funcionario", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nome_do_funcionario", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nome do funcionario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_salario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "salario", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_salario", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "salario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_casado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "casado", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_casado", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "casado", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_data_admição", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "data admição", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_data_admição", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "data admição", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_data_demição", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "data demição", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_data_demição", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "data demição", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cod_dept", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cod dept", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cod_dept", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cod dept", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection2;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Mat_funcionario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Mat funcionario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_nome_do_funcionario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "nome do funcionario", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_nome_do_funcionario", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "nome do funcionario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_salario", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "salario", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_salario", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "salario", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_casado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "casado", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_casado", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "casado", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_data_admição", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "data admição", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_data_admição", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "data admição", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_data_demição", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "data demição", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_data_demição", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "data demição", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_cod_dept", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cod dept", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_cod_dept", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cod dept", System.Data.DataRowVersion.Original, null)});
            // 
            // DatFunc
            // 
            this.DatFunc.DeleteCommand = this.oleDbDeleteCommand1;
            this.DatFunc.InsertCommand = this.oleDbInsertCommand1;
            this.DatFunc.SelectCommand = this.oleDbSelectCommand1;
            this.DatFunc.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "MatFuncionario", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Mat funcionario", "Mat funcionario"),
                        new System.Data.Common.DataColumnMapping("nome do funcionario", "nome do funcionario"),
                        new System.Data.Common.DataColumnMapping("salario", "salario"),
                        new System.Data.Common.DataColumnMapping("casado", "casado"),
                        new System.Data.Common.DataColumnMapping("foto", "foto"),
                        new System.Data.Common.DataColumnMapping("data admição", "data admição"),
                        new System.Data.Common.DataColumnMapping("data demição", "data demição"),
                        new System.Data.Common.DataColumnMapping("cod dept", "cod dept")})});
            this.DatFunc.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // MatFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtfuncionarios);
            this.Name = "MatFuncionario";
            this.Text = "MatFuncionario";
            this.Load += new System.EventHandler(this.MatFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtfuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFunc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dtfuncionarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter DatFunc;
        private DsFunc dsFunc1;
    }
}