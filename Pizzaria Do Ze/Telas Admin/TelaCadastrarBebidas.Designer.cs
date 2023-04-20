namespace Pizzaria_Do_Ze.Telas_Admin
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
            this.tipoLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.tamanhoLabel = new System.Windows.Forms.Label();
            this.valorStaticLabel = new System.Windows.Forms.Label();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.valorTB = new System.Windows.Forms.TextBox();
            this.bebidasListBox = new System.Windows.Forms.ListBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.excluirSelecionadoBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tamanhoComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(54, 55);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(34, 13);
            this.tipoLabel.TabIndex = 0;
            this.tipoLabel.Text = "Tipo: ";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(54, 86);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(41, 13);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome: ";
            // 
            // tamanhoLabel
            // 
            this.tamanhoLabel.AutoSize = true;
            this.tamanhoLabel.Location = new System.Drawing.Point(9, 117);
            this.tamanhoLabel.Name = "tamanhoLabel";
            this.tamanhoLabel.Size = new System.Drawing.Size(79, 13);
            this.tamanhoLabel.TabIndex = 2;
            this.tamanhoLabel.Text = "Tamanho (ML):";
            // 
            // valorStaticLabel
            // 
            this.valorStaticLabel.AutoSize = true;
            this.valorStaticLabel.Location = new System.Drawing.Point(37, 148);
            this.valorStaticLabel.Name = "valorStaticLabel";
            this.valorStaticLabel.Size = new System.Drawing.Size(51, 13);
            this.valorStaticLabel.TabIndex = 3;
            this.valorStaticLabel.Text = "Valor: R$";
            // 
            // nomeTB
            // 
            this.nomeTB.Location = new System.Drawing.Point(94, 86);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(121, 20);
            this.nomeTB.TabIndex = 2;
            // 
            // valorTB
            // 
            this.valorTB.Location = new System.Drawing.Point(94, 145);
            this.valorTB.Name = "valorTB";
            this.valorTB.Size = new System.Drawing.Size(121, 20);
            this.valorTB.TabIndex = 4;
            // 
            // bebidasListBox
            // 
            this.bebidasListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.bebidasListBox.FormattingEnabled = true;
            this.bebidasListBox.Location = new System.Drawing.Point(94, 218);
            this.bebidasListBox.Name = "bebidasListBox";
            this.bebidasListBox.Size = new System.Drawing.Size(324, 134);
            this.bebidasListBox.TabIndex = 8;
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.FlatAppearance.BorderSize = 0;
            this.cadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarBtn.Location = new System.Drawing.Point(513, 360);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(89, 33);
            this.cadastrarBtn.TabIndex = 7;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // excluirSelecionadoBtn
            // 
            this.excluirSelecionadoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirSelecionadoBtn.FlatAppearance.BorderSize = 0;
            this.excluirSelecionadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirSelecionadoBtn.Location = new System.Drawing.Point(487, 218);
            this.excluirSelecionadoBtn.Name = "excluirSelecionadoBtn";
            this.excluirSelecionadoBtn.Size = new System.Drawing.Size(115, 33);
            this.excluirSelecionadoBtn.TabIndex = 6;
            this.excluirSelecionadoBtn.Text = "Excluir selecionado";
            this.excluirSelecionadoBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(513, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 33);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Cerveja",
            "Suco",
            "Refrigerante",
            "Água"});
            this.tipoComboBox.Location = new System.Drawing.Point(94, 52);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoComboBox.TabIndex = 1;
            // 
            // tamanhoComboBox
            // 
            this.tamanhoComboBox.FormattingEnabled = true;
            this.tamanhoComboBox.Items.AddRange(new object[] {
            "150 ml",
            "300 ml",
            "600 ml",
            "1 L",
            "1,5 L",
            "2 L"});
            this.tamanhoComboBox.Location = new System.Drawing.Point(94, 114);
            this.tamanhoComboBox.Name = "tamanhoComboBox";
            this.tamanhoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tamanhoComboBox.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(467, -14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 427);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // TelaCadastrarBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(626, 407);
            this.Controls.Add(this.tamanhoComboBox);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.excluirSelecionadoBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.bebidasListBox);
            this.Controls.Add(this.valorTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.valorStaticLabel);
            this.Controls.Add(this.tamanhoLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label tamanhoLabel;
        private System.Windows.Forms.Label valorStaticLabel;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.TextBox valorTB;
        private System.Windows.Forms.ListBox bebidasListBox;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button excluirSelecionadoBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.ComboBox tamanhoComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}