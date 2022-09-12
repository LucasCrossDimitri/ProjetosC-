namespace WinAppMasterDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dsProduto1 = new WinAppMasterDetail.dsProduto();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grbProduto = new System.Windows.Forms.GroupBox();
            this.grbTipoProduto = new System.Windows.Forms.GroupBox();
            this.lbtTipoProduto = new System.Windows.Forms.ListBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.datProduto = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.datTipoProduto = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduto1)).BeginInit();
            this.grbProduto.SuspendLayout();
            this.grbTipoProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "tipo.tipo_produto";
            this.dataGrid1.DataSource = this.dsProduto1;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(19, 19);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(505, 174);
            this.dataGrid1.TabIndex = 0;
            // 
            // dsProduto1
            // 
            this.dsProduto1.DataSetName = "dsProduto";
            this.dsProduto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(264, 336);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(510, 336);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grbProduto
            // 
            this.grbProduto.Controls.Add(this.dataGrid1);
            this.grbProduto.Location = new System.Drawing.Point(192, 84);
            this.grbProduto.Name = "grbProduto";
            this.grbProduto.Size = new System.Drawing.Size(530, 209);
            this.grbProduto.TabIndex = 3;
            this.grbProduto.TabStop = false;
            this.grbProduto.Text = "Produto";
            // 
            // grbTipoProduto
            // 
            this.grbTipoProduto.Controls.Add(this.lbtTipoProduto);
            this.grbTipoProduto.Location = new System.Drawing.Point(13, 73);
            this.grbTipoProduto.Name = "grbTipoProduto";
            this.grbTipoProduto.Size = new System.Drawing.Size(160, 220);
            this.grbTipoProduto.TabIndex = 4;
            this.grbTipoProduto.TabStop = false;
            this.grbTipoProduto.Text = "TipoProduto";
            // 
            // lbtTipoProduto
            // 
            this.lbtTipoProduto.DataSource = this.dsProduto1;
            this.lbtTipoProduto.DisplayMember = "tipo.descTipo";
            this.lbtTipoProduto.FormattingEnabled = true;
            this.lbtTipoProduto.Location = new System.Drawing.Point(6, 19);
            this.lbtTipoProduto.Name = "lbtTipoProduto";
            this.lbtTipoProduto.Size = new System.Drawing.Size(148, 186);
            this.lbtTipoProduto.TabIndex = 0;
            this.lbtTipoProduto.ValueMember = "tipo.codTipo";
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"D:\\Visual Studio\\BancoBiblioteca\\Ba" +
    "ncoBiblioteca\\produto.mdb\"";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        produto.*\r\nFROM            produto";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `produto` (`codProd`, `descProd`, `valorProd`, `quantProd`, `codTipo`" +
    ", `codFor`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("codProd", System.Data.OleDb.OleDbType.Integer, 0, "codProd"),
            new System.Data.OleDb.OleDbParameter("descProd", System.Data.OleDb.OleDbType.VarWChar, 0, "descProd"),
            new System.Data.OleDb.OleDbParameter("valorProd", System.Data.OleDb.OleDbType.Currency, 0, "valorProd"),
            new System.Data.OleDb.OleDbParameter("quantProd", System.Data.OleDb.OleDbType.Integer, 0, "quantProd"),
            new System.Data.OleDb.OleDbParameter("codTipo", System.Data.OleDb.OleDbType.Integer, 0, "codTipo"),
            new System.Data.OleDb.OleDbParameter("codFor", System.Data.OleDb.OleDbType.Integer, 0, "codFor")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("codProd", System.Data.OleDb.OleDbType.Integer, 0, "codProd"),
            new System.Data.OleDb.OleDbParameter("descProd", System.Data.OleDb.OleDbType.VarWChar, 0, "descProd"),
            new System.Data.OleDb.OleDbParameter("valorProd", System.Data.OleDb.OleDbType.Currency, 0, "valorProd"),
            new System.Data.OleDb.OleDbParameter("quantProd", System.Data.OleDb.OleDbType.Integer, 0, "quantProd"),
            new System.Data.OleDb.OleDbParameter("codTipo", System.Data.OleDb.OleDbType.Integer, 0, "codTipo"),
            new System.Data.OleDb.OleDbParameter("codFor", System.Data.OleDb.OleDbType.Integer, 0, "codFor"),
            new System.Data.OleDb.OleDbParameter("Original_codProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_descProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "descProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_descProd", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "descProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_valorProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "valorProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_valorProd", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "valorProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_quantProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "quantProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_quantProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "quantProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_codFor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codFor", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_codFor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codFor", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_codProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_descProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "descProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_descProd", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "descProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_valorProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "valorProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_valorProd", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "valorProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_quantProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "quantProd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_quantProd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "quantProd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_codFor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codFor", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_codFor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codFor", System.Data.DataRowVersion.Original, null)});
            // 
            // datProduto
            // 
            this.datProduto.DeleteCommand = this.oleDbDeleteCommand1;
            this.datProduto.InsertCommand = this.oleDbInsertCommand1;
            this.datProduto.SelectCommand = this.oleDbSelectCommand1;
            this.datProduto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "produto", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codProd", "codProd"),
                        new System.Data.Common.DataColumnMapping("descProd", "descProd"),
                        new System.Data.Common.DataColumnMapping("valorProd", "valorProd"),
                        new System.Data.Common.DataColumnMapping("quantProd", "quantProd"),
                        new System.Data.Common.DataColumnMapping("codTipo", "codTipo"),
                        new System.Data.Common.DataColumnMapping("codFor", "codFor")})});
            this.datProduto.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        tipo.*\r\nFROM            tipo";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `tipo` (`codTipo`, `descTipo`) VALUES (?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("codTipo", System.Data.OleDb.OleDbType.Integer, 0, "codTipo"),
            new System.Data.OleDb.OleDbParameter("descTipo", System.Data.OleDb.OleDbType.VarWChar, 0, "descTipo")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = "UPDATE `tipo` SET `codTipo` = ?, `descTipo` = ? WHERE ((`codTipo` = ?) AND ((? = " +
    "1 AND `descTipo` IS NULL) OR (`descTipo` = ?)))";
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("codTipo", System.Data.OleDb.OleDbType.Integer, 0, "codTipo"),
            new System.Data.OleDb.OleDbParameter("descTipo", System.Data.OleDb.OleDbType.VarWChar, 0, "descTipo"),
            new System.Data.OleDb.OleDbParameter("Original_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_descTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "descTipo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_descTipo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "descTipo", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = "DELETE FROM `tipo` WHERE ((`codTipo` = ?) AND ((? = 1 AND `descTipo` IS NULL) OR " +
    "(`descTipo` = ?)))";
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_codTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codTipo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_descTipo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "descTipo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_descTipo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "descTipo", System.Data.DataRowVersion.Original, null)});
            // 
            // datTipoProduto
            // 
            this.datTipoProduto.DeleteCommand = this.oleDbDeleteCommand2;
            this.datTipoProduto.InsertCommand = this.oleDbInsertCommand2;
            this.datTipoProduto.SelectCommand = this.oleDbSelectCommand2;
            this.datTipoProduto.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "tipo", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codTipo", "codTipo"),
                        new System.Data.Common.DataColumnMapping("descTipo", "descTipo")})});
            this.datTipoProduto.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 431);
            this.Controls.Add(this.grbTipoProduto);
            this.Controls.Add(this.grbProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduto1)).EndInit();
            this.grbProduto.ResumeLayout(false);
            this.grbTipoProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grbProduto;
        private System.Windows.Forms.GroupBox grbTipoProduto;
        private System.Windows.Forms.ListBox lbtTipoProduto;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter datProduto;
        private dsProduto dsProduto1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter datTipoProduto;
    }
}

