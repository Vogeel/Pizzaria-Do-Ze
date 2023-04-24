namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaStatusPedidoAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaStatusPedidoAtendente));
            this.statusPagamentoLabel = new System.Windows.Forms.Label();
            this.statusPedidoLabel = new System.Windows.Forms.Label();
            this.pagoRadioBtn = new System.Windows.Forms.RadioButton();
            this.pendenteRadioBtn = new System.Windows.Forms.RadioButton();
            this.preparoRadioBtn = new System.Windows.Forms.RadioButton();
            this.retiradaRadioBtn = new System.Windows.Forms.RadioButton();
            this.saiuEntregaRadioBtn = new System.Windows.Forms.RadioButton();
            this.idPedidoStaticLabel = new System.Windows.Forms.Label();
            this.idPedidoLabel = new System.Windows.Forms.Label();
            this.entreguePorStaticLabel = new System.Windows.Forms.Label();
            this.entregadorComboBox = new System.Windows.Forms.ComboBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.pedidoGroupBox = new System.Windows.Forms.GroupBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.pedidoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPagamentoLabel
            // 
            this.statusPagamentoLabel.AutoSize = true;
            this.statusPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPagamentoLabel.Location = new System.Drawing.Point(12, 45);
            this.statusPagamentoLabel.Name = "statusPagamentoLabel";
            this.statusPagamentoLabel.Size = new System.Drawing.Size(138, 16);
            this.statusPagamentoLabel.TabIndex = 0;
            this.statusPagamentoLabel.Text = "Status do pagamento:";
            // 
            // statusPedidoLabel
            // 
            this.statusPedidoLabel.AutoSize = true;
            this.statusPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPedidoLabel.Location = new System.Drawing.Point(38, 246);
            this.statusPedidoLabel.Name = "statusPedidoLabel";
            this.statusPedidoLabel.Size = new System.Drawing.Size(112, 16);
            this.statusPedidoLabel.TabIndex = 2;
            this.statusPedidoLabel.Text = "Status do pedido:";
            // 
            // pagoRadioBtn
            // 
            this.pagoRadioBtn.AutoSize = true;
            this.pagoRadioBtn.Location = new System.Drawing.Point(173, 32);
            this.pagoRadioBtn.Name = "pagoRadioBtn";
            this.pagoRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.pagoRadioBtn.TabIndex = 1;
            this.pagoRadioBtn.TabStop = true;
            this.pagoRadioBtn.Text = "Pago";
            this.pagoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pendenteRadioBtn
            // 
            this.pendenteRadioBtn.AutoSize = true;
            this.pendenteRadioBtn.Location = new System.Drawing.Point(173, 71);
            this.pendenteRadioBtn.Name = "pendenteRadioBtn";
            this.pendenteRadioBtn.Size = new System.Drawing.Size(71, 17);
            this.pendenteRadioBtn.TabIndex = 2;
            this.pendenteRadioBtn.TabStop = true;
            this.pendenteRadioBtn.Text = "Pendente";
            this.pendenteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // preparoRadioBtn
            // 
            this.preparoRadioBtn.AutoSize = true;
            this.preparoRadioBtn.Location = new System.Drawing.Point(17, 39);
            this.preparoRadioBtn.Name = "preparoRadioBtn";
            this.preparoRadioBtn.Size = new System.Drawing.Size(79, 17);
            this.preparoRadioBtn.TabIndex = 3;
            this.preparoRadioBtn.TabStop = true;
            this.preparoRadioBtn.Text = "Em preparo";
            this.preparoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // retiradaRadioBtn
            // 
            this.retiradaRadioBtn.AutoSize = true;
            this.retiradaRadioBtn.Location = new System.Drawing.Point(173, 246);
            this.retiradaRadioBtn.Name = "retiradaRadioBtn";
            this.retiradaRadioBtn.Size = new System.Drawing.Size(118, 17);
            this.retiradaRadioBtn.TabIndex = 4;
            this.retiradaRadioBtn.TabStop = true;
            this.retiradaRadioBtn.Text = "Pronto para retirada";
            this.retiradaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // saiuEntregaRadioBtn
            // 
            this.saiuEntregaRadioBtn.AutoSize = true;
            this.saiuEntregaRadioBtn.Location = new System.Drawing.Point(173, 284);
            this.saiuEntregaRadioBtn.Name = "saiuEntregaRadioBtn";
            this.saiuEntregaRadioBtn.Size = new System.Drawing.Size(109, 17);
            this.saiuEntregaRadioBtn.TabIndex = 5;
            this.saiuEntregaRadioBtn.TabStop = true;
            this.saiuEntregaRadioBtn.Text = "Saiu para entrega";
            this.saiuEntregaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // idPedidoStaticLabel
            // 
            this.idPedidoStaticLabel.AutoSize = true;
            this.idPedidoStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedidoStaticLabel.Location = new System.Drawing.Point(299, 19);
            this.idPedidoStaticLabel.Name = "idPedidoStaticLabel";
            this.idPedidoStaticLabel.Size = new System.Drawing.Size(70, 16);
            this.idPedidoStaticLabel.TabIndex = 9;
            this.idPedidoStaticLabel.Text = "ID Pedido:";
            // 
            // idPedidoLabel
            // 
            this.idPedidoLabel.AutoSize = true;
            this.idPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedidoLabel.Location = new System.Drawing.Point(380, 19);
            this.idPedidoLabel.Name = "idPedidoLabel";
            this.idPedidoLabel.Size = new System.Drawing.Size(42, 16);
            this.idPedidoLabel.TabIndex = 10;
            this.idPedidoLabel.Text = "01011";
            // 
            // entreguePorStaticLabel
            // 
            this.entreguePorStaticLabel.AutoSize = true;
            this.entreguePorStaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entreguePorStaticLabel.Location = new System.Drawing.Point(297, 284);
            this.entreguePorStaticLabel.Name = "entreguePorStaticLabel";
            this.entreguePorStaticLabel.Size = new System.Drawing.Size(81, 15);
            this.entreguePorStaticLabel.TabIndex = 11;
            this.entreguePorStaticLabel.Text = "Entregue por:";
            // 
            // entregadorComboBox
            // 
            this.entregadorComboBox.FormattingEnabled = true;
            this.entregadorComboBox.Location = new System.Drawing.Point(377, 284);
            this.entregadorComboBox.Name = "entregadorComboBox";
            this.entregadorComboBox.Size = new System.Drawing.Size(121, 21);
            this.entregadorComboBox.TabIndex = 6;
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Location = new System.Drawing.Point(156, 12);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(112, 93);
            this.statusGroupBox.TabIndex = 13;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Pagamento";
            // 
            // pedidoGroupBox
            // 
            this.pedidoGroupBox.Controls.Add(this.preparoRadioBtn);
            this.pedidoGroupBox.Location = new System.Drawing.Point(156, 172);
            this.pedidoGroupBox.Name = "pedidoGroupBox";
            this.pedidoGroupBox.Size = new System.Drawing.Size(141, 147);
            this.pedidoGroupBox.TabIndex = 14;
            this.pedidoGroupBox.TabStop = false;
            this.pedidoGroupBox.Text = "Pedido";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelarBtn.Location = new System.Drawing.Point(408, 329);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(92, 27);
            this.cancelarBtn.TabIndex = 7;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // TelaStatusPedidoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(512, 368);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.entregadorComboBox);
            this.Controls.Add(this.entreguePorStaticLabel);
            this.Controls.Add(this.idPedidoLabel);
            this.Controls.Add(this.idPedidoStaticLabel);
            this.Controls.Add(this.saiuEntregaRadioBtn);
            this.Controls.Add(this.retiradaRadioBtn);
            this.Controls.Add(this.pendenteRadioBtn);
            this.Controls.Add(this.pagoRadioBtn);
            this.Controls.Add(this.statusPedidoLabel);
            this.Controls.Add(this.statusPagamentoLabel);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.pedidoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaStatusPedidoAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Status Pedidos";
            this.pedidoGroupBox.ResumeLayout(false);
            this.pedidoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusPagamentoLabel;
        private System.Windows.Forms.Label statusPedidoLabel;
        private System.Windows.Forms.RadioButton pagoRadioBtn;
        private System.Windows.Forms.RadioButton pendenteRadioBtn;
        private System.Windows.Forms.RadioButton preparoRadioBtn;
        private System.Windows.Forms.RadioButton retiradaRadioBtn;
        private System.Windows.Forms.RadioButton saiuEntregaRadioBtn;
        private System.Windows.Forms.Label idPedidoStaticLabel;
        private System.Windows.Forms.Label idPedidoLabel;
        private System.Windows.Forms.Label entreguePorStaticLabel;
        private System.Windows.Forms.ComboBox entregadorComboBox;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox pedidoGroupBox;
        private System.Windows.Forms.Button cancelarBtn;
    }
}