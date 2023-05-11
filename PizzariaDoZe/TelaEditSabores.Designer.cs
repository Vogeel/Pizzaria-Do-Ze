namespace PizzariaDoZe
{
    partial class TelaEditSabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditSabores));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.ingredientesLabel = new System.Windows.Forms.Label();
            this.nomePizzaTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ingredienteEscolhidosListBox = new System.Windows.Forms.ListBox();
            this.especialCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.excluirSaborBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(71, 62);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(41, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome: ";
            // 
            // ingredientesLabel
            // 
            this.ingredientesLabel.AutoSize = true;
            this.ingredientesLabel.Location = new System.Drawing.Point(41, 135);
            this.ingredientesLabel.Name = "ingredientesLabel";
            this.ingredientesLabel.Size = new System.Drawing.Size(71, 13);
            this.ingredientesLabel.TabIndex = 1;
            this.ingredientesLabel.Text = "Ingredientes: ";
            // 
            // nomePizzaTextBox
            // 
            this.nomePizzaTextBox.Location = new System.Drawing.Point(118, 59);
            this.nomePizzaTextBox.Name = "nomePizzaTextBox";
            this.nomePizzaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomePizzaTextBox.TabIndex = 1;
            // 
            // ingredientesComboBox
            // 
            this.ingredientesComboBox.FormattingEnabled = true;
            this.ingredientesComboBox.Location = new System.Drawing.Point(118, 135);
            this.ingredientesComboBox.Name = "ingredientesComboBox";
            this.ingredientesComboBox.Size = new System.Drawing.Size(167, 21);
            this.ingredientesComboBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Location = new System.Drawing.Point(338, 133);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // ingredienteEscolhidosListBox
            // 
            this.ingredienteEscolhidosListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.ingredienteEscolhidosListBox.FormattingEnabled = true;
            this.ingredienteEscolhidosListBox.Location = new System.Drawing.Point(118, 192);
            this.ingredienteEscolhidosListBox.Name = "ingredienteEscolhidosListBox";
            this.ingredienteEscolhidosListBox.Size = new System.Drawing.Size(167, 95);
            this.ingredienteEscolhidosListBox.TabIndex = 5;
            // 
            // especialCheckBox
            // 
            this.especialCheckBox.AutoSize = true;
            this.especialCheckBox.Location = new System.Drawing.Point(118, 97);
            this.especialCheckBox.Name = "especialCheckBox";
            this.especialCheckBox.Size = new System.Drawing.Size(93, 17);
            this.especialCheckBox.TabIndex = 2;
            this.especialCheckBox.Text = "Pizza especial";
            this.especialCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(380, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrarBtn.Location = new System.Drawing.Point(380, 311);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(85, 30);
            this.cadastrarBtn.TabIndex = 6;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // excluirSaborBtn
            // 
            this.excluirSaborBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirSaborBtn.Location = new System.Drawing.Point(338, 192);
            this.excluirSaborBtn.Name = "excluirSaborBtn";
            this.excluirSaborBtn.Size = new System.Drawing.Size(112, 23);
            this.excluirSaborBtn.TabIndex = 5;
            this.excluirSaborBtn.Text = "Excluir selecionado";
            this.excluirSaborBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(324, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // TelaEditSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(485, 354);
            this.Controls.Add(this.excluirSaborBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.especialCheckBox);
            this.Controls.Add(this.ingredienteEscolhidosListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ingredientesComboBox);
            this.Controls.Add(this.nomePizzaTextBox);
            this.Controls.Add(this.ingredientesLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEditSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Sabores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label ingredientesLabel;
        private System.Windows.Forms.TextBox nomePizzaTextBox;
        private System.Windows.Forms.ComboBox ingredientesComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox ingredienteEscolhidosListBox;
        private System.Windows.Forms.CheckBox especialCheckBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button excluirSaborBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}