namespace PizzariaDoZe
{
    partial class TelaCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCliente));
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.clienteCadastradoBtn = new System.Windows.Forms.Button();
            this.clienteCadastradoLabel = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.camposCadsatroUserControl1 = new PizzariaDoZe.CamposCadsatroUserControl();
            this.SuspendLayout();
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrarBtn.Location = new System.Drawing.Point(304, 435);
            this.cadastrarBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(121, 31);
            this.cadastrarBtn.TabIndex = 9;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // clienteCadastradoBtn
            // 
            this.clienteCadastradoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clienteCadastradoBtn.Location = new System.Drawing.Point(136, 435);
            this.clienteCadastradoBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clienteCadastradoBtn.Name = "clienteCadastradoBtn";
            this.clienteCadastradoBtn.Size = new System.Drawing.Size(148, 31);
            this.clienteCadastradoBtn.TabIndex = 8;
            this.clienteCadastradoBtn.Text = "Cliente já cadastrado";
            this.clienteCadastradoBtn.UseVisualStyleBackColor = true;
            // 
            // clienteCadastradoLabel
            // 
            this.clienteCadastradoLabel.AutoSize = true;
            this.clienteCadastradoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.clienteCadastradoLabel.Location = new System.Drawing.Point(13, 408);
            this.clienteCadastradoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteCadastradoLabel.Name = "clienteCadastradoLabel";
            this.clienteCadastradoLabel.Size = new System.Drawing.Size(271, 13);
            this.clienteCadastradoLabel.TabIndex = 19;
            this.clienteCadastradoLabel.Text = "* se o cliente ja for cadastrado, preencher o campo CPF";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(451, 14);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 32);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // camposCadsatroUserControl1
            // 
            this.camposCadsatroUserControl1.BackColor = System.Drawing.Color.BurlyWood;
            this.camposCadsatroUserControl1.Location = new System.Drawing.Point(28, 45);
            this.camposCadsatroUserControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.camposCadsatroUserControl1.Name = "camposCadsatroUserControl1";
            this.camposCadsatroUserControl1.Size = new System.Drawing.Size(415, 360);
            this.camposCadsatroUserControl1.TabIndex = 20;
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(569, 477);
            this.Controls.Add(this.camposCadsatroUserControl1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clienteCadastradoLabel);
            this.Controls.Add(this.clienteCadastradoBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button clienteCadastradoBtn;
        private System.Windows.Forms.Label clienteCadastradoLabel;
        private System.Windows.Forms.Button cancelBtn;
        private CamposCadsatroUserControl camposCadsatroUserControl1;
    }
}