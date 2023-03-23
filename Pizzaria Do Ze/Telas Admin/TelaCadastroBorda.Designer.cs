namespace Pizzaria_Do_Ze.Telas_Admin
{
    partial class TelaCadastroBorda
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
            this.addBordaBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.bordaListBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBordaBtn
            // 
            this.addBordaBtn.Location = new System.Drawing.Point(12, 30);
            this.addBordaBtn.Name = "addBordaBtn";
            this.addBordaBtn.Size = new System.Drawing.Size(95, 33);
            this.addBordaBtn.TabIndex = 0;
            this.addBordaBtn.Text = "Adicionar";
            this.addBordaBtn.UseVisualStyleBackColor = true;
            this.addBordaBtn.Click += new System.EventHandler(this.addBordaBtn_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.Location = new System.Drawing.Point(120, 30);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(122, 33);
            this.excluirBtn.TabIndex = 2;
            this.excluirBtn.Text = "Excluir selecionado";
            this.excluirBtn.UseVisualStyleBackColor = true;
            // 
            // bordaListBox
            // 
            this.bordaListBox.FormattingEnabled = true;
            this.bordaListBox.Location = new System.Drawing.Point(12, 79);
            this.bordaListBox.Name = "bordaListBox";
            this.bordaListBox.Size = new System.Drawing.Size(230, 134);
            this.bordaListBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(272, 180);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 33);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TelaCadastroBorda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 235);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bordaListBox);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.addBordaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroBorda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroBorda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBordaBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.ListBox bordaListBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}