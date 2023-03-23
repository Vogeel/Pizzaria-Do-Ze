namespace Pizzaria_Do_Ze.Telas_Admin
{
    partial class TelaCadastroFornecedor
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
            this.camposCadsatroUserControl1 = new Pizzaria_Do_Ze.Telas_Admin.CamposCadsatroUserControl();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.cadastrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // camposCadsatroUserControl1
            // 
            this.camposCadsatroUserControl1.Location = new System.Drawing.Point(12, 12);
            this.camposCadsatroUserControl1.Name = "camposCadsatroUserControl1";
            this.camposCadsatroUserControl1.Size = new System.Drawing.Size(364, 224);
            this.camposCadsatroUserControl1.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(120, 241);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(106, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // cadastrarbtn
            // 
            this.cadastrarbtn.Location = new System.Drawing.Point(232, 241);
            this.cadastrarbtn.Name = "cadastrarbtn";
            this.cadastrarbtn.Size = new System.Drawing.Size(119, 23);
            this.cadastrarbtn.TabIndex = 2;
            this.cadastrarbtn.Text = "Cadastrar";
            this.cadastrarbtn.UseVisualStyleBackColor = true;
            this.cadastrarbtn.Click += new System.EventHandler(this.Cadastrarbtn_Click);
            // 
            // TelaCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 276);
            this.Controls.Add(this.cadastrarbtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.camposCadsatroUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroFornecedor";
            this.ResumeLayout(false);

        }

        #endregion

        private CamposCadsatroUserControl camposCadsatroUserControl1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button cadastrarbtn;
    }
}