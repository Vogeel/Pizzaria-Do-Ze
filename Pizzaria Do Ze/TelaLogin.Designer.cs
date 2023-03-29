namespace Pizzaria_Do_Ze
{
    partial class TelaLogin
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
            this.bemvindoLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bemvindoLabel
            // 
            this.bemvindoLabel.AutoSize = true;
            this.bemvindoLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bemvindoLabel.Location = new System.Drawing.Point(128, 27);
            this.bemvindoLabel.Name = "bemvindoLabel";
            this.bemvindoLabel.Size = new System.Drawing.Size(107, 23);
            this.bemvindoLabel.TabIndex = 0;
            this.bemvindoLabel.Text = "Bem-Vindo";
            this.bemvindoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.Location = new System.Drawing.Point(44, 83);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(64, 18);
            this.usuarioLabel.TabIndex = 1;
            this.usuarioLabel.Text = "Usuario:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLabel.Location = new System.Drawing.Point(54, 135);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(54, 18);
            this.senhaLabel.TabIndex = 2;
            this.senhaLabel.Text = "Senha:";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(114, 84);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(114, 136);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(132, 20);
            this.senhaTextBox.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Tan;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(104, 174);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Tan;
            this.loginBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBtn.Location = new System.Drawing.Point(185, 174);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(335, 223);
            this.ControlBox = false;
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.bemvindoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label bemvindoLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}

