namespace PizzariaDoZe.Telas_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroBorda));
            this.addBtn = new System.Windows.Forms.Button();
            this.excluirSelecionadoBtn = new System.Windows.Forms.Button();
            this.bordaListBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(12, 30);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 33);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.AddBordaBtn_Click);
            // 
            // excluirSelecionadoBtn
            // 
            this.excluirSelecionadoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirSelecionadoBtn.FlatAppearance.BorderSize = 0;
            this.excluirSelecionadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirSelecionadoBtn.Location = new System.Drawing.Point(159, 30);
            this.excluirSelecionadoBtn.Name = "excluirSelecionadoBtn";
            this.excluirSelecionadoBtn.Size = new System.Drawing.Size(122, 33);
            this.excluirSelecionadoBtn.TabIndex = 2;
            this.excluirSelecionadoBtn.Text = "Excluir selecionado";
            this.excluirSelecionadoBtn.UseVisualStyleBackColor = false;
            // 
            // bordaListBox
            // 
            this.bordaListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.bordaListBox.FormattingEnabled = true;
            this.bordaListBox.Location = new System.Drawing.Point(12, 79);
            this.bordaListBox.Name = "bordaListBox";
            this.bordaListBox.Size = new System.Drawing.Size(269, 134);
            this.bordaListBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(295, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 24);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // TelaCadastroBorda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(382, 235);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.bordaListBox);
            this.Controls.Add(this.excluirSelecionadoBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroBorda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button excluirSelecionadoBtn;
        private System.Windows.Forms.ListBox bordaListBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}