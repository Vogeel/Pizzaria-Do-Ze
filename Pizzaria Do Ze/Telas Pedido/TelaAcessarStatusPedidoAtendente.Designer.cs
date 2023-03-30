namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaAcessarStatusPedidoAtendente
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
            this.idPedidoStaticLabel = new System.Windows.Forms.Label();
            this.idPedidosAbertoscomboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acessarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idPedidoStaticLabel
            // 
            this.idPedidoStaticLabel.AutoSize = true;
            this.idPedidoStaticLabel.Location = new System.Drawing.Point(23, 51);
            this.idPedidoStaticLabel.Name = "idPedidoStaticLabel";
            this.idPedidoStaticLabel.Size = new System.Drawing.Size(71, 13);
            this.idPedidoStaticLabel.TabIndex = 0;
            this.idPedidoStaticLabel.Text = "ID do pedido:";
            // 
            // idPedidosAbertoscomboBox
            // 
            this.idPedidosAbertoscomboBox.FormattingEnabled = true;
            this.idPedidosAbertoscomboBox.Location = new System.Drawing.Point(100, 48);
            this.idPedidosAbertoscomboBox.Name = "idPedidosAbertoscomboBox";
            this.idPedidosAbertoscomboBox.Size = new System.Drawing.Size(121, 21);
            this.idPedidosAbertoscomboBox.TabIndex = 1;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(227, 106);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acessarBtn
            // 
            this.acessarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acessarBtn.Location = new System.Drawing.Point(227, 48);
            this.acessarBtn.Name = "acessarBtn";
            this.acessarBtn.Size = new System.Drawing.Size(75, 23);
            this.acessarBtn.TabIndex = 3;
            this.acessarBtn.Text = "Acessar";
            this.acessarBtn.UseVisualStyleBackColor = true;
            this.acessarBtn.Click += new System.EventHandler(this.AcessarBtn_Click);
            // 
            // TelaAcessarStatusPedidoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(324, 143);
            this.Controls.Add(this.acessarBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.idPedidosAbertoscomboBox);
            this.Controls.Add(this.idPedidoStaticLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAcessarStatusPedidoAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessar Status do pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idPedidoStaticLabel;
        private System.Windows.Forms.ComboBox idPedidosAbertoscomboBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acessarBtn;
    }
}