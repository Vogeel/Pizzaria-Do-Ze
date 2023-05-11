namespace PizzariaDoZe
{
    partial class TelaCadastrarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarIngrediente));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.ingredientelistBox = new System.Windows.Forms.ListBox();
            this.excluirSelecionadoBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(14, 35);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(40, 15);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(62, 35);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(139, 23);
            this.nomeTextBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(288, 35);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 35);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ingredientelistBox
            // 
            this.ingredientelistBox.BackColor = System.Drawing.Color.BurlyWood;
            this.ingredientelistBox.FormattingEnabled = true;
            this.ingredientelistBox.ItemHeight = 15;
            this.ingredientelistBox.Location = new System.Drawing.Point(47, 117);
            this.ingredientelistBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ingredientelistBox.Name = "ingredientelistBox";
            this.ingredientelistBox.Size = new System.Drawing.Size(184, 139);
            this.ingredientelistBox.TabIndex = 3;
            // 
            // excluirSelecionadoBtn
            // 
            this.excluirSelecionadoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirSelecionadoBtn.FlatAppearance.BorderSize = 0;
            this.excluirSelecionadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirSelecionadoBtn.Location = new System.Drawing.Point(288, 117);
            this.excluirSelecionadoBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirSelecionadoBtn.Name = "excluirSelecionadoBtn";
            this.excluirSelecionadoBtn.Size = new System.Drawing.Size(125, 36);
            this.excluirSelecionadoBtn.TabIndex = 3;
            this.excluirSelecionadoBtn.Text = "Excluir selecionado";
            this.excluirSelecionadoBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, -8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 285);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(288, 225);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 31);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(62, 9);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(54, 23);
            this.IDTextBox.TabIndex = 22;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(14, 9);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "ID:";
            // 
            // TelaCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(430, 270);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.excluirSelecionadoBtn);
            this.Controls.Add(this.ingredientelistBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListBox ingredientelistBox;
        private System.Windows.Forms.Button excluirSelecionadoBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelBtn;
        private TextBox IDTextBox;
        private Label idLabel;
    }
}