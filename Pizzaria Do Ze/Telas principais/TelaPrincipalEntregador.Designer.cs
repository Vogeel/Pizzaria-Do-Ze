namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalEntregador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalEntregador));
            this.pedPendentesBtn = new System.Windows.Forms.Button();
            this.pedEntreguesBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pedPendentesBtn
            // 
            this.pedPendentesBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.pedPendentesBtn.FlatAppearance.BorderSize = 0;
            this.pedPendentesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedPendentesBtn.Location = new System.Drawing.Point(9, 63);
            this.pedPendentesBtn.Name = "pedPendentesBtn";
            this.pedPendentesBtn.Size = new System.Drawing.Size(194, 37);
            this.pedPendentesBtn.TabIndex = 0;
            this.pedPendentesBtn.Text = "Visualizar Pedidos Pendentes";
            this.pedPendentesBtn.UseVisualStyleBackColor = false;
            this.pedPendentesBtn.Click += new System.EventHandler(this.pedPendentesBtn_Click);
            // 
            // pedEntreguesBtn
            // 
            this.pedEntreguesBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.pedEntreguesBtn.FlatAppearance.BorderSize = 0;
            this.pedEntreguesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedEntreguesBtn.Location = new System.Drawing.Point(9, 149);
            this.pedEntreguesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.pedEntreguesBtn.Name = "pedEntreguesBtn";
            this.pedEntreguesBtn.Size = new System.Drawing.Size(194, 37);
            this.pedEntreguesBtn.TabIndex = 1;
            this.pedEntreguesBtn.Text = "Visualizar Pedidos Entregues";
            this.pedEntreguesBtn.UseVisualStyleBackColor = false;
            this.pedEntreguesBtn.Click += new System.EventHandler(this.pedEntreguesBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(369, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(75, 23);
            this.voltarBtn.TabIndex = 2;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // TelaPrincipalEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(456, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.pedEntreguesBtn);
            this.Controls.Add(this.pedPendentesBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalEntregador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipalEntregador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pedPendentesBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button pedEntreguesBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}