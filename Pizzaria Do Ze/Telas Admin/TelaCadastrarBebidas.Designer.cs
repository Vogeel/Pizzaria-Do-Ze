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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeTB = new System.Windows.Forms.TextBox();
            this.valorTB = new System.Windows.Forms.TextBox();
            this.bebidasListBox = new System.Windows.Forms.ListBox();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tamanhoComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamanho (ML):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor: R$";
            // 
            // nomeTB
            // 
            this.nomeTB.Location = new System.Drawing.Point(94, 86);
            this.nomeTB.Name = "nomeTB";
            this.nomeTB.Size = new System.Drawing.Size(121, 20);
            this.nomeTB.TabIndex = 5;
            // 
            // valorTB
            // 
            this.valorTB.Location = new System.Drawing.Point(94, 145);
            this.valorTB.Name = "valorTB";
            this.valorTB.Size = new System.Drawing.Size(121, 20);
            this.valorTB.TabIndex = 7;
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
            this.cadastrarBtn.TabIndex = 9;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(487, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Excluir selecionado";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(513, 12);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(89, 33);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = false;
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
            this.tipoComboBox.TabIndex = 12;
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
            this.tamanhoComboBox.TabIndex = 13;
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
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.bebidasListBox);
            this.Controls.Add(this.valorTB);
            this.Controls.Add(this.nomeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarBebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarBebidas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeTB;
        private System.Windows.Forms.TextBox valorTB;
        private System.Windows.Forms.ListBox bebidasListBox;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.ComboBox tamanhoComboBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}