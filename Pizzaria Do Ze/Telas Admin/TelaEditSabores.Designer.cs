namespace Pizzaria_Do_Ze.Telas_Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomePizzaTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesComboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ingredienteEscolhidosListBox = new System.Windows.Forms.ListBox();
            this.especialCheckBox = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.excluirSaborBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredientes: ";
            // 
            // nomePizzaTextBox
            // 
            this.nomePizzaTextBox.Location = new System.Drawing.Point(118, 59);
            this.nomePizzaTextBox.Name = "nomePizzaTextBox";
            this.nomePizzaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomePizzaTextBox.TabIndex = 2;
            // 
            // ingredientesComboBox
            // 
            this.ingredientesComboBox.FormattingEnabled = true;
            this.ingredientesComboBox.Location = new System.Drawing.Point(118, 135);
            this.ingredientesComboBox.Name = "ingredientesComboBox";
            this.ingredientesComboBox.Size = new System.Drawing.Size(121, 21);
            this.ingredientesComboBox.TabIndex = 3;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(262, 133);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // ingredienteEscolhidosListBox
            // 
            this.ingredienteEscolhidosListBox.FormattingEnabled = true;
            this.ingredienteEscolhidosListBox.Location = new System.Drawing.Point(118, 192);
            this.ingredienteEscolhidosListBox.Name = "ingredienteEscolhidosListBox";
            this.ingredienteEscolhidosListBox.Size = new System.Drawing.Size(132, 95);
            this.ingredienteEscolhidosListBox.TabIndex = 5;
            // 
            // especialCheckBox
            // 
            this.especialCheckBox.AutoSize = true;
            this.especialCheckBox.Location = new System.Drawing.Point(118, 97);
            this.especialCheckBox.Name = "especialCheckBox";
            this.especialCheckBox.Size = new System.Drawing.Size(93, 17);
            this.especialCheckBox.TabIndex = 6;
            this.especialCheckBox.Text = "Pizza especial";
            this.especialCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(380, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(380, 311);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(85, 30);
            this.cadastrarBtn.TabIndex = 8;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // excluirSaborBtn
            // 
            this.excluirSaborBtn.Location = new System.Drawing.Point(262, 192);
            this.excluirSaborBtn.Name = "excluirSaborBtn";
            this.excluirSaborBtn.Size = new System.Drawing.Size(112, 23);
            this.excluirSaborBtn.TabIndex = 9;
            this.excluirSaborBtn.Text = "Excluir selecionado";
            this.excluirSaborBtn.UseVisualStyleBackColor = true;
            // 
            // TelaEditSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 354);
            this.Controls.Add(this.excluirSaborBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.especialCheckBox);
            this.Controls.Add(this.ingredienteEscolhidosListBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ingredientesComboBox);
            this.Controls.Add(this.nomePizzaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEditSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditSabores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomePizzaTextBox;
        private System.Windows.Forms.ComboBox ingredientesComboBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox ingredienteEscolhidosListBox;
        private System.Windows.Forms.CheckBox especialCheckBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button excluirSaborBtn;
    }
}