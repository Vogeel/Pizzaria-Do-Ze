namespace PizzariaDoZe
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.voltarBtn = new System.Windows.Forms.Button();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.visualizarClienteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatAppearance.BorderSize = 0;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(207, 12);
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
            this.cadastroBtn.Location = new System.Drawing.Point(80, 129);
            this.cadastroBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(166, 51);
            this.cadastroBtn.TabIndex = 21;
            this.cadastroBtn.Text = "Cadastro";
            this.cadastroBtn.UseVisualStyleBackColor = false;
            this.cadastroBtn.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // visualizarClienteBtn
            // 
            this.visualizarClienteBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.visualizarClienteBtn.FlatAppearance.BorderSize = 0;
            this.visualizarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizarClienteBtn.Location = new System.Drawing.Point(80, 72);
            this.visualizarClienteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.visualizarClienteBtn.Name = "visualizarClienteBtn";
            this.visualizarClienteBtn.Size = new System.Drawing.Size(166, 51);
            this.visualizarClienteBtn.TabIndex = 20;
            this.visualizarClienteBtn.Text = "Visualizar";
            this.visualizarClienteBtn.UseVisualStyleBackColor = false;
            this.visualizarClienteBtn.Click += new System.EventHandler(this.visualizarClienteBtn_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(323, 242);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.visualizarClienteBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFuncionario";
            this.ResumeLayout(false);

        }

        #endregion

        private Button voltarBtn;
        private Button cadastroBtn;
        private Button visualizarClienteBtn;
    }
}