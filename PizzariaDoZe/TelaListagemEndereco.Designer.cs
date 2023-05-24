namespace PizzariaDoZe
{
    partial class TelaListagemEndereco
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
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.IDcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongradouroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CidadeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUFColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPaisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDcolumn,
            this.CEPColumn,
            this.LongradouroColumn,
            this.IDCidadeColumn,
            this.CidadeColumn,
            this.IDUFColumn,
            this.IDPaisColumn,
            this.PaisColumn});
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.Size = new System.Drawing.Size(841, 362);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // IDcolumn
            // 
            this.IDcolumn.HeaderText = "ID";
            this.IDcolumn.Name = "IDcolumn";
            // 
            // CEPColumn
            // 
            this.CEPColumn.HeaderText = "CEP";
            this.CEPColumn.Name = "CEPColumn";
            // 
            // LongradouroColumn
            // 
            this.LongradouroColumn.HeaderText = "Longradouro";
            this.LongradouroColumn.Name = "LongradouroColumn";
            // 
            // IDCidadeColumn
            // 
            this.IDCidadeColumn.HeaderText = "ID Cidade";
            this.IDCidadeColumn.Name = "IDCidadeColumn";
            // 
            // CidadeColumn
            // 
            this.CidadeColumn.HeaderText = "Cidade";
            this.CidadeColumn.Name = "CidadeColumn";
            // 
            // IDUFColumn
            // 
            this.IDUFColumn.HeaderText = "ID UF";
            this.IDUFColumn.Name = "IDUFColumn";
            // 
            // IDPaisColumn
            // 
            this.IDPaisColumn.HeaderText = "ID Pais";
            this.IDPaisColumn.Name = "IDPaisColumn";
            // 
            // PaisColumn
            // 
            this.PaisColumn.HeaderText = "Pais";
            this.PaisColumn.Name = "PaisColumn";
            // 
            // TelaListagemEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 450);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "TelaListagemEndereco";
            this.Text = "TelaListagemEndereco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewDados;
        private DataGridViewTextBoxColumn IDcolumn;
        private DataGridViewTextBoxColumn CEPColumn;
        private DataGridViewTextBoxColumn LongradouroColumn;
        private DataGridViewTextBoxColumn IDCidadeColumn;
        private DataGridViewTextBoxColumn CidadeColumn;
        private DataGridViewTextBoxColumn IDUFColumn;
        private DataGridViewTextBoxColumn IDPaisColumn;
        private DataGridViewTextBoxColumn PaisColumn;
    }
}