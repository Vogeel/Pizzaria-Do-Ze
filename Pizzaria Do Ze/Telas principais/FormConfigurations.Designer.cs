namespace Pizzaria_Do_Ze.Telas_principais
{
    partial class FormConfigurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurations));
            this.idiomaComboBox = new System.Windows.Forms.ComboBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.mudarIdiomaLabel = new System.Windows.Forms.Label();
            this.reiniciarCheckBox = new System.Windows.Forms.CheckBox();
            this.IdiomaRegiaoGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.labelReiniciar = new System.Windows.Forms.Label();
            this.IdiomaRegiaoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idiomaComboBox
            // 
            this.idiomaComboBox.FormattingEnabled = true;
            this.idiomaComboBox.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.idiomaComboBox.Location = new System.Drawing.Point(38, 111);
            this.idiomaComboBox.Name = "idiomaComboBox";
            this.idiomaComboBox.Size = new System.Drawing.Size(121, 21);
            this.idiomaComboBox.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(367, 219);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 33);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // mudarIdiomaLabel
            // 
            this.mudarIdiomaLabel.AutoSize = true;
            this.mudarIdiomaLabel.Location = new System.Drawing.Point(38, 95);
            this.mudarIdiomaLabel.Name = "mudarIdiomaLabel";
            this.mudarIdiomaLabel.Size = new System.Drawing.Size(77, 13);
            this.mudarIdiomaLabel.TabIndex = 2;
            this.mudarIdiomaLabel.Text = "Idioma/Região";
            // 
            // reiniciarCheckBox
            // 
            this.reiniciarCheckBox.AutoSize = true;
            this.reiniciarCheckBox.Location = new System.Drawing.Point(165, 113);
            this.reiniciarCheckBox.Name = "reiniciarCheckBox";
            this.reiniciarCheckBox.Size = new System.Drawing.Size(15, 14);
            this.reiniciarCheckBox.TabIndex = 2;
            this.reiniciarCheckBox.UseVisualStyleBackColor = true;
            // 
            // IdiomaRegiaoGroupBox
            // 
            this.IdiomaRegiaoGroupBox.Controls.Add(this.labelReiniciar);
            this.IdiomaRegiaoGroupBox.Location = new System.Drawing.Point(29, 61);
            this.IdiomaRegiaoGroupBox.Name = "IdiomaRegiaoGroupBox";
            this.IdiomaRegiaoGroupBox.Size = new System.Drawing.Size(359, 144);
            this.IdiomaRegiaoGroupBox.TabIndex = 4;
            this.IdiomaRegiaoGroupBox.TabStop = false;
            this.IdiomaRegiaoGroupBox.Text = "Idioma/Região";
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(286, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 33);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // labelReiniciar
            // 
            this.labelReiniciar.AutoSize = true;
            this.labelReiniciar.Location = new System.Drawing.Point(157, 53);
            this.labelReiniciar.Name = "labelReiniciar";
            this.labelReiniciar.Size = new System.Drawing.Size(186, 13);
            this.labelReiniciar.TabIndex = 0;
            this.labelReiniciar.Text = "Reiniciar aplicação para mudar idioma";
            // 
            // FormConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(455, 264);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.reiniciarCheckBox);
            this.Controls.Add(this.mudarIdiomaLabel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.idiomaComboBox);
            this.Controls.Add(this.IdiomaRegiaoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfigurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigurations";
            this.IdiomaRegiaoGroupBox.ResumeLayout(false);
            this.IdiomaRegiaoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox idiomaComboBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label mudarIdiomaLabel;
        private System.Windows.Forms.CheckBox reiniciarCheckBox;
        private System.Windows.Forms.GroupBox IdiomaRegiaoGroupBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label labelReiniciar;
    }
}