namespace Pizzaria_Do_Ze.Telas_Cadastrais
{
    partial class TelaPizzaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPizzaAdmin));
            this.saboresBtn = new System.Windows.Forms.Button();
            this.valoresBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bordaBtn = new System.Windows.Forms.Button();
            this.ingredientesBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // saboresBtn
            // 
            this.saboresBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.saboresBtn.FlatAppearance.BorderSize = 0;
            this.saboresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saboresBtn.Location = new System.Drawing.Point(23, 88);
            this.saboresBtn.Name = "saboresBtn";
            this.saboresBtn.Size = new System.Drawing.Size(142, 44);
            this.saboresBtn.TabIndex = 0;
            this.saboresBtn.Text = "Sabores";
            this.saboresBtn.UseVisualStyleBackColor = false;
            this.saboresBtn.Click += new System.EventHandler(this.saboresBtn_Click);
            // 
            // valoresBtn
            // 
            this.valoresBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.valoresBtn.FlatAppearance.BorderSize = 0;
            this.valoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valoresBtn.Location = new System.Drawing.Point(23, 188);
            this.valoresBtn.Name = "valoresBtn";
            this.valoresBtn.Size = new System.Drawing.Size(142, 44);
            this.valoresBtn.TabIndex = 1;
            this.valoresBtn.Text = "Valores";
            this.valoresBtn.UseVisualStyleBackColor = false;
            this.valoresBtn.Click += new System.EventHandler(this.valoresBtn_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(340, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bordaBtn
            // 
            this.bordaBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.bordaBtn.FlatAppearance.BorderSize = 0;
            this.bordaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bordaBtn.Location = new System.Drawing.Point(23, 138);
            this.bordaBtn.Name = "bordaBtn";
            this.bordaBtn.Size = new System.Drawing.Size(142, 44);
            this.bordaBtn.TabIndex = 3;
            this.bordaBtn.Text = "Bordas";
            this.bordaBtn.UseVisualStyleBackColor = false;
            this.bordaBtn.Click += new System.EventHandler(this.bordaBtn_Click);
            // 
            // ingredientesBtn
            // 
            this.ingredientesBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ingredientesBtn.FlatAppearance.BorderSize = 0;
            this.ingredientesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingredientesBtn.Location = new System.Drawing.Point(23, 38);
            this.ingredientesBtn.Name = "ingredientesBtn";
            this.ingredientesBtn.Size = new System.Drawing.Size(142, 44);
            this.ingredientesBtn.TabIndex = 4;
            this.ingredientesBtn.Text = "Ingredientes";
            this.ingredientesBtn.UseVisualStyleBackColor = false;
            this.ingredientesBtn.Click += new System.EventHandler(this.ingredientesBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(218, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-104, -21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // TelaPizzaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(448, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingredientesBtn);
            this.Controls.Add(this.bordaBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.valoresBtn);
            this.Controls.Add(this.saboresBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPizzaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPizzaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saboresBtn;
        private System.Windows.Forms.Button valoresBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bordaBtn;
        private System.Windows.Forms.Button ingredientesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}