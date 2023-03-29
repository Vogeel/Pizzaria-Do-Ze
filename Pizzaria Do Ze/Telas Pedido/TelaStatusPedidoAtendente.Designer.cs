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
            this.stautsPagamentoLabel = new System.Windows.Forms.Label();
            this.statusPagamentoLabel = new System.Windows.Forms.Label();
            this.pagoRadioBtn = new System.Windows.Forms.RadioButton();
            this.pendenteRadioBtn = new System.Windows.Forms.RadioButton();
            this.preparoRadioBtn = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.idPedidoStaticLabel = new System.Windows.Forms.Label();
            this.idPedidoLabel = new System.Windows.Forms.Label();
            this.entregadorLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.pedidoGroupBox = new System.Windows.Forms.GroupBox();
            this.pedidoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stautsPagamentoLabel
            // 
            this.stautsPagamentoLabel.AutoSize = true;
            this.stautsPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stautsPagamentoLabel.Location = new System.Drawing.Point(12, 45);
            this.stautsPagamentoLabel.Name = "stautsPagamentoLabel";
            this.stautsPagamentoLabel.Size = new System.Drawing.Size(138, 16);
            this.stautsPagamentoLabel.TabIndex = 0;
            this.stautsPagamentoLabel.Text = "Status do pagamento:";
            // 
            // statusPagamentoLabel
            // 
            this.statusPagamentoLabel.AutoSize = true;
            this.statusPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusPagamentoLabel.Location = new System.Drawing.Point(38, 246);
            this.statusPagamentoLabel.Name = "statusPagamentoLabel";
            this.statusPagamentoLabel.Size = new System.Drawing.Size(112, 16);
            this.statusPagamentoLabel.TabIndex = 2;
            this.statusPagamentoLabel.Text = "Status do pedido:";
            // 
            // pagoRadioBtn
            // 
            this.pagoRadioBtn.AutoSize = true;
            this.pagoRadioBtn.Location = new System.Drawing.Point(173, 32);
            this.pagoRadioBtn.Name = "pagoRadioBtn";
            this.pagoRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.pagoRadioBtn.TabIndex = 3;
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
            this.pendenteRadioBtn.TabIndex = 4;
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
            this.preparoRadioBtn.TabIndex = 5;
            this.preparoRadioBtn.TabStop = true;
            this.preparoRadioBtn.Text = "Em preparo";
            this.preparoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(173, 246);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(118, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Pronto para retirada";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(173, 284);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(109, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Saiu para entrega";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(406, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CancelBtn_Click);
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
            // entregadorLabel
            // 
            this.entregadorLabel.AutoSize = true;
            this.entregadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregadorLabel.Location = new System.Drawing.Point(297, 284);
            this.entregadorLabel.Name = "entregadorLabel";
            this.entregadorLabel.Size = new System.Drawing.Size(74, 15);
            this.entregadorLabel.TabIndex = 11;
            this.entregadorLabel.Text = "Entregador: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(377, 284);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
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
            // TelaStatusPedidoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(512, 368);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.entregadorLabel);
            this.Controls.Add(this.idPedidoLabel);
            this.Controls.Add(this.idPedidoStaticLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.pendenteRadioBtn);
            this.Controls.Add(this.pagoRadioBtn);
            this.Controls.Add(this.statusPagamentoLabel);
            this.Controls.Add(this.stautsPagamentoLabel);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.pedidoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaStatusPedidoAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaStatusPedidoAtendente";
            this.pedidoGroupBox.ResumeLayout(false);
            this.pedidoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stautsPagamentoLabel;
        private System.Windows.Forms.Label statusPagamentoLabel;
        private System.Windows.Forms.RadioButton pagoRadioBtn;
        private System.Windows.Forms.RadioButton pendenteRadioBtn;
        private System.Windows.Forms.RadioButton preparoRadioBtn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idPedidoStaticLabel;
        private System.Windows.Forms.Label idPedidoLabel;
        private System.Windows.Forms.Label entregadorLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.GroupBox pedidoGroupBox;
    }
}