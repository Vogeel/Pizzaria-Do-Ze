namespace PizzariaDoZe
{
    partial class TelaCadastrarBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarBebidas));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.valorStaticLabel = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.listBoxTipo = new System.Windows.Forms.ListBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBoxTamanho = new System.Windows.Forms.ListBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.buttonVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(63, 99);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(46, 15);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome: ";
            // 
            // valorStaticLabel
            // 
            this.valorStaticLabel.AutoSize = true;
            this.valorStaticLabel.Location = new System.Drawing.Point(43, 171);
            this.valorStaticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valorStaticLabel.Name = "valorStaticLabel";
            this.valorStaticLabel.Size = new System.Drawing.Size(52, 15);
            this.valorStaticLabel.TabIndex = 3;
            this.valorStaticLabel.Text = "Valor: R$";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(110, 99);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(140, 23);
            this.textBoxNome.TabIndex = 2;
            // 
            // listBoxTipo
            // 
            this.listBoxTipo.BackColor = System.Drawing.Color.BurlyWood;
            this.listBoxTipo.FormattingEnabled = true;
            this.listBoxTipo.ItemHeight = 15;
            this.listBoxTipo.Location = new System.Drawing.Point(267, 63);
            this.listBoxTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTipo.Name = "listBoxTipo";
            this.listBoxTipo.Size = new System.Drawing.Size(135, 169);
            this.listBoxTipo.TabIndex = 8;
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.FlatAppearance.BorderSize = 0;
            this.cadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarBtn.Location = new System.Drawing.Point(598, 194);
            this.cadastrarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(104, 38);
            this.cadastrarBtn.TabIndex = 7;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(598, 14);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 38);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(579, -16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 266);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // listBoxTamanho
            // 
            this.listBoxTamanho.BackColor = System.Drawing.Color.BurlyWood;
            this.listBoxTamanho.FormattingEnabled = true;
            this.listBoxTamanho.ItemHeight = 15;
            this.listBoxTamanho.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1000",
            "1500",
            "2000"});
            this.listBoxTamanho.Location = new System.Drawing.Point(436, 63);
            this.listBoxTamanho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTamanho.Name = "listBoxTamanho";
            this.listBoxTamanho.Size = new System.Drawing.Size(135, 169);
            this.listBoxTamanho.TabIndex = 25;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(110, 29);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(140, 23);
            this.textBoxID.TabIndex = 27;
            this.textBoxID.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID:";
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(110, 163);
            this.maskedTextBoxValor.Mask = "00.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(140, 23);
            this.maskedTextBoxValor.TabIndex = 28;
            this.maskedTextBoxValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonVisualizar
            // 
            this.buttonVisualizar.FlatAppearance.BorderSize = 0;
            this.buttonVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVisualizar.Location = new System.Drawing.Point(467, 12);
            this.buttonVisualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVisualizar.Name = "buttonVisualizar";
            this.buttonVisualizar.Size = new System.Drawing.Size(104, 38);
            this.buttonVisualizar.TabIndex = 29;
            this.buttonVisualizar.Text = "Visualizar Produtos";
            this.buttonVisualizar.UseVisualStyleBackColor = true;
            this.buttonVisualizar.Click += new System.EventHandler(this.buttonVisualizar_Click);
            // 
            // TelaCadastrarBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(730, 246);
            this.Controls.Add(this.buttonVisualizar);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTamanho);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.listBoxTipo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.valorStaticLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarBebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bebidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label valorStaticLabel;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ListBox listBoxTipo;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ListBox listBoxTamanho;
        private TextBox textBoxID;
        private Label label1;
        private MaskedTextBox maskedTextBoxValor;
        private Button buttonVisualizar;
    }
}