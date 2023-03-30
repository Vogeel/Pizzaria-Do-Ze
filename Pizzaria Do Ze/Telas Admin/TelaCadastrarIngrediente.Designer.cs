namespace Pizzaria_Do_Ze.Telas_Admin
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 30);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(53, 30);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(120, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(247, 30);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 30);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // ingredientelistBox
            // 
            this.ingredientelistBox.BackColor = System.Drawing.Color.BurlyWood;
            this.ingredientelistBox.FormattingEnabled = true;
            this.ingredientelistBox.Location = new System.Drawing.Point(40, 101);
            this.ingredientelistBox.Name = "ingredientelistBox";
            this.ingredientelistBox.Size = new System.Drawing.Size(158, 121);
            this.ingredientelistBox.TabIndex = 3;
            // 
            // excluirSelecionadoBtn
            // 
            this.excluirSelecionadoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirSelecionadoBtn.FlatAppearance.BorderSize = 0;
            this.excluirSelecionadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirSelecionadoBtn.Location = new System.Drawing.Point(247, 101);
            this.excluirSelecionadoBtn.Name = "excluirSelecionadoBtn";
            this.excluirSelecionadoBtn.Size = new System.Drawing.Size(107, 31);
            this.excluirSelecionadoBtn.TabIndex = 4;
            this.excluirSelecionadoBtn.Text = "Excluir selecionado";
            this.excluirSelecionadoBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(225, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 247);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(247, 195);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 27);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TelaCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(369, 234);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.excluirSelecionadoBtn);
            this.Controls.Add(this.ingredientelistBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}