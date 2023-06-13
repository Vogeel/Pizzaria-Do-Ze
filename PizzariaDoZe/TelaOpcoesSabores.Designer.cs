namespace PizzariaDoZe
{
    partial class TelaOpcoesSabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaOpcoesSabores));
            this.voltarBtn = new System.Windows.Forms.Button();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.visualizarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatAppearance.BorderSize = 0;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(206, 12);
            this.voltarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(107, 44);
            this.voltarBtn.TabIndex = 19;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cadastroBtn.FlatAppearance.BorderSize = 0;
            this.cadastroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroBtn.Location = new System.Drawing.Point(79, 129);
            this.cadastroBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(166, 51);
            this.cadastroBtn.TabIndex = 21;
            this.cadastroBtn.Text = "Cadastro";
            this.cadastroBtn.UseVisualStyleBackColor = false;
            this.cadastroBtn.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // visualizarBtn
            // 
            this.visualizarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.visualizarBtn.FlatAppearance.BorderSize = 0;
            this.visualizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizarBtn.Location = new System.Drawing.Point(79, 72);
            this.visualizarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.visualizarBtn.Name = "visualizarBtn";
            this.visualizarBtn.Size = new System.Drawing.Size(166, 51);
            this.visualizarBtn.TabIndex = 20;
            this.visualizarBtn.Text = "Visualizar";
            this.visualizarBtn.UseVisualStyleBackColor = false;
            this.visualizarBtn.Click += new System.EventHandler(this.visualizarBtn_Click);
            // 
            // TelaOpcoesSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.visualizarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaOpcoesSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabores";
            this.ResumeLayout(false);

        }

        #endregion

        private Button voltarBtn;
        private Button cadastroBtn;
        private Button visualizarBtn;
    }
}