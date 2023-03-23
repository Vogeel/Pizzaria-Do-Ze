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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroBorda));
            this.addBordaBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.bordaListBox = new System.Windows.Forms.ListBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addBordaBtn
            // 
            this.addBordaBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addBordaBtn.FlatAppearance.BorderSize = 0;
            this.addBordaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBordaBtn.Location = new System.Drawing.Point(12, 30);
            this.addBordaBtn.Name = "addBordaBtn";
            this.addBordaBtn.Size = new System.Drawing.Size(95, 33);
            this.addBordaBtn.TabIndex = 0;
            this.addBordaBtn.Text = "Adicionar";
            this.addBordaBtn.UseVisualStyleBackColor = false;
            this.addBordaBtn.Click += new System.EventHandler(this.addBordaBtn_Click);
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirBtn.FlatAppearance.BorderSize = 0;
            this.excluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBtn.Location = new System.Drawing.Point(159, 30);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(122, 33);
            this.excluirBtn.TabIndex = 2;
            this.excluirBtn.Text = "Excluir selecionado";
            this.excluirBtn.UseVisualStyleBackColor = false;
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
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.addBordaBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroBorda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroBorda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBordaBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.ListBox bordaListBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}