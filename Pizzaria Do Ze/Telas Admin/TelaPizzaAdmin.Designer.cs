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
            this.saboresBtn = new System.Windows.Forms.Button();
            this.valoresBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bordaBtn = new System.Windows.Forms.Button();
            this.ingredientesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saboresBtn
            // 
            this.saboresBtn.Location = new System.Drawing.Point(119, 93);
            this.saboresBtn.Name = "saboresBtn";
            this.saboresBtn.Size = new System.Drawing.Size(142, 44);
            this.saboresBtn.TabIndex = 0;
            this.saboresBtn.Text = "Sabores";
            this.saboresBtn.UseVisualStyleBackColor = true;
            this.saboresBtn.Click += new System.EventHandler(this.saboresBtn_Click);
            // 
            // valoresBtn
            // 
            this.valoresBtn.Location = new System.Drawing.Point(119, 193);
            this.valoresBtn.Name = "valoresBtn";
            this.valoresBtn.Size = new System.Drawing.Size(142, 44);
            this.valoresBtn.TabIndex = 1;
            this.valoresBtn.Text = "Valores";
            this.valoresBtn.UseVisualStyleBackColor = true;
            this.valoresBtn.Click += new System.EventHandler(this.valoresBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bordaBtn
            // 
            this.bordaBtn.Location = new System.Drawing.Point(119, 143);
            this.bordaBtn.Name = "bordaBtn";
            this.bordaBtn.Size = new System.Drawing.Size(142, 44);
            this.bordaBtn.TabIndex = 3;
            this.bordaBtn.Text = "Bordas";
            this.bordaBtn.UseVisualStyleBackColor = true;
            this.bordaBtn.Click += new System.EventHandler(this.bordaBtn_Click);
            // 
            // ingredientesBtn
            // 
            this.ingredientesBtn.Location = new System.Drawing.Point(119, 43);
            this.ingredientesBtn.Name = "ingredientesBtn";
            this.ingredientesBtn.Size = new System.Drawing.Size(142, 44);
            this.ingredientesBtn.TabIndex = 4;
            this.ingredientesBtn.Text = "Ingredientes";
            this.ingredientesBtn.UseVisualStyleBackColor = true;
            this.ingredientesBtn.Click += new System.EventHandler(this.ingredientesBtn_Click);
            // 
            // TelaPizzaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 288);
            this.Controls.Add(this.ingredientesBtn);
            this.Controls.Add(this.bordaBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.valoresBtn);
            this.Controls.Add(this.saboresBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPizzaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPizzaAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saboresBtn;
        private System.Windows.Forms.Button valoresBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bordaBtn;
        private System.Windows.Forms.Button ingredientesBtn;
    }
}