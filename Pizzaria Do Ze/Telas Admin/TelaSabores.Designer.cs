namespace Pizzaria_Do_Ze.Telas_Admin
{
    partial class TelaSabores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSabores));
            this.saboresListBox = new System.Windows.Forms.ListBox();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // saboresListBox
            // 
            this.saboresListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.saboresListBox.FormattingEnabled = true;
            this.saboresListBox.Location = new System.Drawing.Point(32, 91);
            this.saboresListBox.Name = "saboresListBox";
            this.saboresListBox.Size = new System.Drawing.Size(403, 212);
            this.saboresListBox.TabIndex = 0;
            // 
            // voltarBtn
            // 
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(380, 2);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(81, 33);
            this.voltarBtn.TabIndex = 4;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // operacoesUserControl1
            // 
            this.operacoesUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(174)))), ((int)(((byte)(139)))));
            this.operacoesUserControl1.Location = new System.Drawing.Point(-2, 2);
            this.operacoesUserControl1.Name = "operacoesUserControl1";
            this.operacoesUserControl1.Size = new System.Drawing.Size(295, 70);
            this.operacoesUserControl1.TabIndex = 18;
            // 
            // TelaSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(466, 313);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.saboresListBox);
            this.Controls.Add(this.operacoesUserControl1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sabores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox saboresListBox;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private OperacoesUserControl operacoesUserControl1;
    }
}