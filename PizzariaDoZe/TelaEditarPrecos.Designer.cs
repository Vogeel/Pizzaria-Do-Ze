namespace PizzariaDoZe
{
    partial class TelaEditarPrecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarPrecos));
            this.atualizarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.moedaLabel = new System.Windows.Forms.Label();
            this.moedaLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.MaskedTextBoxBorda = new System.Windows.Forms.MaskedTextBox();
            this.listBoxTamanho = new System.Windows.Forms.ListBox();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.FlatAppearance.BorderSize = 0;
            this.atualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atualizarBtn.Location = new System.Drawing.Point(273, 249);
            this.atualizarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(125, 40);
            this.atualizarBtn.TabIndex = 5;
            this.atualizarBtn.Text = "Salvar";
            this.atualizarBtn.UseVisualStyleBackColor = true;
            this.atualizarBtn.Click += new System.EventHandler(this.atualizarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(465, 14);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(125, 40);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // moedaLabel
            // 
            this.moedaLabel.AutoSize = true;
            this.moedaLabel.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moedaLabel.Location = new System.Drawing.Point(27, 140);
            this.moedaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moedaLabel.Name = "moedaLabel";
            this.moedaLabel.Size = new System.Drawing.Size(46, 18);
            this.moedaLabel.TabIndex = 13;
            this.moedaLabel.Text = "Valor:";
            // 
            // moedaLabel1
            // 
            this.moedaLabel1.AutoSize = true;
            this.moedaLabel1.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moedaLabel1.Location = new System.Drawing.Point(27, 195);
            this.moedaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moedaLabel1.Name = "moedaLabel1";
            this.moedaLabel1.Size = new System.Drawing.Size(124, 18);
            this.moedaLabel1.TabIndex = 15;
            this.moedaLabel1.Text = "Valor com Borda:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // MaskedTextBoxValor
            // 
            this.MaskedTextBoxValor.Location = new System.Drawing.Point(27, 161);
            this.MaskedTextBoxValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaskedTextBoxValor.Mask = "###.##";
            this.MaskedTextBoxValor.Name = "MaskedTextBoxValor";
            this.MaskedTextBoxValor.PromptChar = ' ';
            this.MaskedTextBoxValor.Size = new System.Drawing.Size(116, 23);
            this.MaskedTextBoxValor.TabIndex = 1;
            this.MaskedTextBoxValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // MaskedTextBoxBorda
            // 
            this.MaskedTextBoxBorda.Location = new System.Drawing.Point(27, 216);
            this.MaskedTextBoxBorda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaskedTextBoxBorda.Mask = "###.##";
            this.MaskedTextBoxBorda.Name = "MaskedTextBoxBorda";
            this.MaskedTextBoxBorda.PromptChar = ' ';
            this.MaskedTextBoxBorda.Size = new System.Drawing.Size(116, 23);
            this.MaskedTextBoxBorda.TabIndex = 2;
            this.MaskedTextBoxBorda.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // listBoxTamanho
            // 
            this.listBoxTamanho.FormattingEnabled = true;
            this.listBoxTamanho.ItemHeight = 15;
            this.listBoxTamanho.Location = new System.Drawing.Point(206, 31);
            this.listBoxTamanho.Name = "listBoxTamanho";
            this.listBoxTamanho.Size = new System.Drawing.Size(120, 109);
            this.listBoxTamanho.TabIndex = 19;
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.ItemHeight = 15;
            this.listBoxCategoria.Location = new System.Drawing.Point(206, 175);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(120, 64);
            this.listBoxCategoria.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(66, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(206, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tamanho:";
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.FlatAppearance.BorderSize = 0;
            this.buttonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisualizar.Location = new System.Drawing.Point(332, 14);
            this.buttonVisualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(93, 40);
            this.buttonVisualizar.TabIndex = 26;
            this.buttonVisualizar.Text = "Visualizar Preços";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click);
            // 
            // TelaEditarPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(626, 300);
            this.Controls.Add(this.buttonVisualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCategoria);
            this.Controls.Add(this.listBoxTamanho);
            this.Controls.Add(this.MaskedTextBoxBorda);
            this.Controls.Add(this.MaskedTextBoxValor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moedaLabel1);
            this.Controls.Add(this.moedaLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.atualizarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEditarPrecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Preços";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button atualizarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label moedaLabel;
        private System.Windows.Forms.Label moedaLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxValor;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxBorda;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private Label label1;
        private TextBox textBoxID;
        private Label label2;
        private Label label3;
        private Button buttonVisualizar;
    }
}