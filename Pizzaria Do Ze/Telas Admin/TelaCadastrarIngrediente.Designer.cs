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
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.adicionarbtn = new System.Windows.Forms.Button();
            this.ingredientelistBox = new System.Windows.Forms.ListBox();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.fecharbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(78, 28);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(120, 20);
            this.nomeTextBox.TabIndex = 1;
            // 
            // adicionarbtn
            // 
            this.adicionarbtn.Location = new System.Drawing.Point(204, 25);
            this.adicionarbtn.Name = "adicionarbtn";
            this.adicionarbtn.Size = new System.Drawing.Size(107, 23);
            this.adicionarbtn.TabIndex = 2;
            this.adicionarbtn.Text = "Adicionar";
            this.adicionarbtn.UseVisualStyleBackColor = true;
            // 
            // ingredientelistBox
            // 
            this.ingredientelistBox.FormattingEnabled = true;
            this.ingredientelistBox.Location = new System.Drawing.Point(40, 74);
            this.ingredientelistBox.Name = "ingredientelistBox";
            this.ingredientelistBox.Size = new System.Drawing.Size(158, 121);
            this.ingredientelistBox.TabIndex = 3;
            // 
            // excluirBtn
            // 
            this.excluirBtn.Location = new System.Drawing.Point(204, 74);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(107, 23);
            this.excluirBtn.TabIndex = 4;
            this.excluirBtn.Text = "Excluir selecionado";
            this.excluirBtn.UseVisualStyleBackColor = true;
            // 
            // fecharbtn
            // 
            this.fecharbtn.Location = new System.Drawing.Point(303, 195);
            this.fecharbtn.Name = "fecharbtn";
            this.fecharbtn.Size = new System.Drawing.Size(112, 28);
            this.fecharbtn.TabIndex = 5;
            this.fecharbtn.Text = "Fechar";
            this.fecharbtn.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 234);
            this.Controls.Add(this.fecharbtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.ingredientelistBox);
            this.Controls.Add(this.adicionarbtn);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarIngrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button adicionarbtn;
        private System.Windows.Forms.ListBox ingredientelistBox;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button fecharbtn;
    }
}