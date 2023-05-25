namespace PizzariaDoZe
{
    partial class TelaVisualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisualizarCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComplementoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BairroCloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeCloumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UFColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisColumns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteColumn,
            this.nomeColumn,
            this.cpfColumn,
            this.telefoneColumn,
            this.emailColumn,
            this.cepColumn,
            this.ComplementoColumn,
            this.NumeroColumn,
            this.BairroCloumn,
            this.CidadeCloumn,
            this.UFColumn,
            this.PaisColumns});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // idClienteColumn
            // 
            this.idClienteColumn.HeaderText = "ID";
            this.idClienteColumn.Name = "idClienteColumn";
            // 
            // nomeColumn
            // 
            this.nomeColumn.HeaderText = "Nome";
            this.nomeColumn.Name = "nomeColumn";
            // 
            // cpfColumn
            // 
            this.cpfColumn.HeaderText = "CPF";
            this.cpfColumn.Name = "cpfColumn";
            // 
            // telefoneColumn
            // 
            this.telefoneColumn.HeaderText = "Telefone";
            this.telefoneColumn.Name = "telefoneColumn";
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "E-mail";
            this.emailColumn.Name = "emailColumn";
            // 
            // cepColumn
            // 
            this.cepColumn.HeaderText = "CEP";
            this.cepColumn.Name = "cepColumn";
            // 
            // ComplementoColumn
            // 
            this.ComplementoColumn.HeaderText = "Complemento";
            this.ComplementoColumn.Name = "ComplementoColumn";
            // 
            // NumeroColumn
            // 
            this.NumeroColumn.HeaderText = "Numero";
            this.NumeroColumn.Name = "NumeroColumn";
            // 
            // BairroCloumn
            // 
            this.BairroCloumn.HeaderText = "Bairro";
            this.BairroCloumn.Name = "BairroCloumn";
            // 
            // CidadeCloumn
            // 
            this.CidadeCloumn.HeaderText = "Cidade";
            this.CidadeCloumn.Name = "CidadeCloumn";
            // 
            // UFColumn
            // 
            this.UFColumn.HeaderText = "UF";
            this.UFColumn.Name = "UFColumn";
            // 
            // PaisColumns
            // 
            this.PaisColumns.HeaderText = "Pais";
            this.PaisColumns.Name = "PaisColumns";
            // 
            // TelaVisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 292);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisualizarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVisualizarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idClienteColumn;
        private DataGridViewTextBoxColumn nomeColumn;
        private DataGridViewTextBoxColumn cpfColumn;
        private DataGridViewTextBoxColumn telefoneColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn cepColumn;
        private DataGridViewTextBoxColumn ComplementoColumn;
        private DataGridViewTextBoxColumn NumeroColumn;
        private DataGridViewTextBoxColumn BairroCloumn;
        private DataGridViewTextBoxColumn CidadeCloumn;
        private DataGridViewTextBoxColumn UFColumn;
        private DataGridViewTextBoxColumn PaisColumns;
    }
}