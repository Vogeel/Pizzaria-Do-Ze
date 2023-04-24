namespace Pizzaria_Do_Ze.Telas_Admin
{
    partial class TelaEditarPrecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarPrecos));
            this.brotoLabel = new System.Windows.Forms.Label();
            this.mediaLabel = new System.Windows.Forms.Label();
            this.giganteLabel = new System.Windows.Forms.Label();
            this.extragiganteLabel = new System.Windows.Forms.Label();
            this.especiaisLabel = new System.Windows.Forms.Label();
            this.atualizarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acrecimoEspecialLabel = new System.Windows.Forms.Label();
            this.moedaLabel = new System.Windows.Forms.Label();
            this.moedaLabel1 = new System.Windows.Forms.Label();
            this.moedaLabel2 = new System.Windows.Forms.Label();
            this.moedaLabel3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.valorBrotoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valorGiganteMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valorMediaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.valorExtraMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // brotoLabel
            // 
            this.brotoLabel.AutoSize = true;
            this.brotoLabel.BackColor = System.Drawing.Color.Wheat;
            this.brotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brotoLabel.Location = new System.Drawing.Point(10, 84);
            this.brotoLabel.Name = "brotoLabel";
            this.brotoLabel.Size = new System.Drawing.Size(45, 18);
            this.brotoLabel.TabIndex = 0;
            this.brotoLabel.Text = "Broto";
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Wheat;
            this.mediaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLabel.Location = new System.Drawing.Point(10, 109);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(48, 18);
            this.mediaLabel.TabIndex = 1;
            this.mediaLabel.Text = "Media";
            // 
            // giganteLabel
            // 
            this.giganteLabel.AutoSize = true;
            this.giganteLabel.BackColor = System.Drawing.Color.Wheat;
            this.giganteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giganteLabel.Location = new System.Drawing.Point(10, 136);
            this.giganteLabel.Name = "giganteLabel";
            this.giganteLabel.Size = new System.Drawing.Size(59, 18);
            this.giganteLabel.TabIndex = 2;
            this.giganteLabel.Text = "Gigante";
            // 
            // extragiganteLabel
            // 
            this.extragiganteLabel.AutoSize = true;
            this.extragiganteLabel.BackColor = System.Drawing.Color.Wheat;
            this.extragiganteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extragiganteLabel.Location = new System.Drawing.Point(10, 161);
            this.extragiganteLabel.Name = "extragiganteLabel";
            this.extragiganteLabel.Size = new System.Drawing.Size(98, 18);
            this.extragiganteLabel.TabIndex = 3;
            this.extragiganteLabel.Text = "Extra-Gigante";
            // 
            // especiaisLabel
            // 
            this.especiaisLabel.AutoSize = true;
            this.especiaisLabel.BackColor = System.Drawing.Color.Wheat;
            this.especiaisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especiaisLabel.Location = new System.Drawing.Point(10, 188);
            this.especiaisLabel.Name = "especiaisLabel";
            this.especiaisLabel.Size = new System.Drawing.Size(72, 18);
            this.especiaisLabel.TabIndex = 4;
            this.especiaisLabel.Text = "Especiais";
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.FlatAppearance.BorderSize = 0;
            this.atualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarBtn.Location = new System.Drawing.Point(135, 240);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(107, 35);
            this.atualizarBtn.TabIndex = 5;
            this.atualizarBtn.Text = "Substituir preços";
            this.atualizarBtn.UseVisualStyleBackColor = true;
            this.atualizarBtn.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(399, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(107, 35);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // acrecimoEspecialLabel
            // 
            this.acrecimoEspecialLabel.AutoSize = true;
            this.acrecimoEspecialLabel.BackColor = System.Drawing.Color.Wheat;
            this.acrecimoEspecialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acrecimoEspecialLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.acrecimoEspecialLabel.Location = new System.Drawing.Point(10, 206);
            this.acrecimoEspecialLabel.Name = "acrecimoEspecialLabel";
            this.acrecimoEspecialLabel.Size = new System.Drawing.Size(236, 13);
            this.acrecimoEspecialLabel.TabIndex = 12;
            this.acrecimoEspecialLabel.Text = "*Tem um acrescimo de 30% sobre o valor normal";
            // 
            // moedaLabel
            // 
            this.moedaLabel.AutoSize = true;
            this.moedaLabel.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedaLabel.Location = new System.Drawing.Point(109, 84);
            this.moedaLabel.Name = "moedaLabel";
            this.moedaLabel.Size = new System.Drawing.Size(27, 18);
            this.moedaLabel.TabIndex = 13;
            this.moedaLabel.Text = "R$";
            // 
            // moedaLabel1
            // 
            this.moedaLabel1.AutoSize = true;
            this.moedaLabel1.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedaLabel1.Location = new System.Drawing.Point(109, 112);
            this.moedaLabel1.Name = "moedaLabel1";
            this.moedaLabel1.Size = new System.Drawing.Size(27, 18);
            this.moedaLabel1.TabIndex = 15;
            this.moedaLabel1.Text = "R$";
            // 
            // moedaLabel2
            // 
            this.moedaLabel2.AutoSize = true;
            this.moedaLabel2.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedaLabel2.Location = new System.Drawing.Point(109, 138);
            this.moedaLabel2.Name = "moedaLabel2";
            this.moedaLabel2.Size = new System.Drawing.Size(27, 18);
            this.moedaLabel2.TabIndex = 16;
            this.moedaLabel2.Text = "R$";
            // 
            // moedaLabel3
            // 
            this.moedaLabel3.AutoSize = true;
            this.moedaLabel3.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moedaLabel3.Location = new System.Drawing.Point(109, 161);
            this.moedaLabel3.Name = "moedaLabel3";
            this.moedaLabel3.Size = new System.Drawing.Size(27, 18);
            this.moedaLabel3.TabIndex = 17;
            this.moedaLabel3.Text = "R$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 411);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // valorBrotoMaskedTextBox
            // 
            this.valorBrotoMaskedTextBox.Location = new System.Drawing.Point(142, 82);
            this.valorBrotoMaskedTextBox.Mask = "#,###.##";
            this.valorBrotoMaskedTextBox.Name = "valorBrotoMaskedTextBox";
            this.valorBrotoMaskedTextBox.PromptChar = ' ';
            this.valorBrotoMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorBrotoMaskedTextBox.TabIndex = 1;
            // 
            // valorGiganteMaskedTextBox
            // 
            this.valorGiganteMaskedTextBox.Location = new System.Drawing.Point(142, 136);
            this.valorGiganteMaskedTextBox.Mask = "#,###.##";
            this.valorGiganteMaskedTextBox.Name = "valorGiganteMaskedTextBox";
            this.valorGiganteMaskedTextBox.PromptChar = ' ';
            this.valorGiganteMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorGiganteMaskedTextBox.TabIndex = 3;
            // 
            // valorMediaMaskedTextBox
            // 
            this.valorMediaMaskedTextBox.Location = new System.Drawing.Point(142, 109);
            this.valorMediaMaskedTextBox.Mask = "#,###.##";
            this.valorMediaMaskedTextBox.Name = "valorMediaMaskedTextBox";
            this.valorMediaMaskedTextBox.PromptChar = ' ';
            this.valorMediaMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorMediaMaskedTextBox.TabIndex = 2;
            // 
            // valorExtraMaskedTextBox
            // 
            this.valorExtraMaskedTextBox.Location = new System.Drawing.Point(142, 162);
            this.valorExtraMaskedTextBox.Mask = "#,###.##";
            this.valorExtraMaskedTextBox.Name = "valorExtraMaskedTextBox";
            this.valorExtraMaskedTextBox.PromptChar = ' ';
            this.valorExtraMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorExtraMaskedTextBox.TabIndex = 4;
            // 
            // TelaEditarPrecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(537, 301);
            this.Controls.Add(this.valorExtraMaskedTextBox);
            this.Controls.Add(this.valorMediaMaskedTextBox);
            this.Controls.Add(this.valorGiganteMaskedTextBox);
            this.Controls.Add(this.valorBrotoMaskedTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moedaLabel3);
            this.Controls.Add(this.moedaLabel2);
            this.Controls.Add(this.moedaLabel1);
            this.Controls.Add(this.moedaLabel);
            this.Controls.Add(this.acrecimoEspecialLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.especiaisLabel);
            this.Controls.Add(this.extragiganteLabel);
            this.Controls.Add(this.giganteLabel);
            this.Controls.Add(this.mediaLabel);
            this.Controls.Add(this.brotoLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEditarPrecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Preços";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brotoLabel;
        private System.Windows.Forms.Label mediaLabel;
        private System.Windows.Forms.Label giganteLabel;
        private System.Windows.Forms.Label extragiganteLabel;
        private System.Windows.Forms.Label especiaisLabel;
        private System.Windows.Forms.Button atualizarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label acrecimoEspecialLabel;
        private System.Windows.Forms.Label moedaLabel;
        private System.Windows.Forms.Label moedaLabel1;
        private System.Windows.Forms.Label moedaLabel2;
        private System.Windows.Forms.Label moedaLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox valorBrotoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox valorGiganteMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox valorMediaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox valorExtraMaskedTextBox;
    }
}