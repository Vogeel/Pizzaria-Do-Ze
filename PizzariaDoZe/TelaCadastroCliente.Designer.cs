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
            this.SuspendLayout();
            // 
            // cadastrarBtn
            // 
            this.cadastrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cadastrarBtn.Location = new System.Drawing.Point(298, 295);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(104, 27);
            this.cadastrarBtn.TabIndex = 9;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.CadastrarBtn_Click);
            // 
            // clienteCadastradoBtn
            // 
            this.clienteCadastradoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clienteCadastradoBtn.Location = new System.Drawing.Point(164, 295);
            this.clienteCadastradoBtn.Name = "clienteCadastradoBtn";
            this.clienteCadastradoBtn.Size = new System.Drawing.Size(127, 27);
            this.clienteCadastradoBtn.TabIndex = 8;
            this.clienteCadastradoBtn.Text = "Cliente já cadastrado";
            this.clienteCadastradoBtn.UseVisualStyleBackColor = true;
            // 
            // clienteCadastradoLabel
            // 
            this.clienteCadastradoLabel.AutoSize = true;
            this.clienteCadastradoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteCadastradoLabel.Location = new System.Drawing.Point(10, 325);
            this.clienteCadastradoLabel.Name = "clienteCadastradoLabel";
            this.clienteCadastradoLabel.Size = new System.Drawing.Size(271, 13);
            this.clienteCadastradoLabel.TabIndex = 19;
            this.clienteCadastradoLabel.Text = "* se o cliente ja for cadastrado, preencher o campo CPF";

            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(387, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(89, 28);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(488, 347);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.clienteCadastradoLabel);
            this.Controls.Add(this.clienteCadastradoBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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
    }
}