namespace PizzariaDoZe.Compartilhado
{
    partial class MessageBoxIdiomaMudado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxIdiomaMudado));
            this.okBtn = new System.Windows.Forms.Button();
            this.labelIdiomaAlterado = new System.Windows.Forms.Label();
            this.labelReiniciarAplicacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(337, 125);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(84, 28);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // labelIdiomaAlterado
            // 
            this.labelIdiomaAlterado.AutoSize = true;
            this.labelIdiomaAlterado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdiomaAlterado.Location = new System.Drawing.Point(1, 23);
            this.labelIdiomaAlterado.Name = "labelIdiomaAlterado";
            this.labelIdiomaAlterado.Size = new System.Drawing.Size(233, 16);
            this.labelIdiomaAlterado.TabIndex = 1;
            this.labelIdiomaAlterado.Text = "Idioma/região alterada com sucesso! ";
            // 
            // labelReiniciarAplicacao
            // 
            this.labelReiniciarAplicacao.AutoSize = true;
            this.labelReiniciarAplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReiniciarAplicacao.Location = new System.Drawing.Point(0, 75);
            this.labelReiniciarAplicacao.Name = "labelReiniciarAplicacao";
            this.labelReiniciarAplicacao.Size = new System.Drawing.Size(390, 20);
            this.labelReiniciarAplicacao.TabIndex = 2;
            this.labelReiniciarAplicacao.Text = "Reinicie a aplicação para aplicar o novo Idioma/região!";
            // 
            // MessageBoxIdiomaMudado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 165);
            this.Controls.Add(this.labelReiniciarAplicacao);
            this.Controls.Add(this.labelIdiomaAlterado);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxIdiomaMudado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Idioma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label labelIdiomaAlterado;
        private System.Windows.Forms.Label labelReiniciarAplicacao;
    }
}