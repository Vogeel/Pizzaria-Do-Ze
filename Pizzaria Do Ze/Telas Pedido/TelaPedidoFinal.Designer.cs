namespace PizzariaDoZe.Telas_Pedido
{
    partial class TelaPedidoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidoFinal));
            this.retiradaRadioBtn = new System.Windows.Forms.RadioButton();
            this.entregaRadioBtn = new System.Windows.Forms.RadioButton();
            this.entregaLabel = new System.Windows.Forms.Label();
            this.totalPedidoLabel = new System.Windows.Forms.Label();
            this.totalPagarPedidoLabel = new System.Windows.Forms.Label();
            this.taxaEntregaLabel = new System.Windows.Forms.Label();
            this.formaPagamentoLabel = new System.Windows.Forms.Label();
            this.cartaoRadioBtn = new System.Windows.Forms.RadioButton();
            this.pixRadioBtn = new System.Windows.Forms.RadioButton();
            this.dinheiroRadioBtn = new System.Windows.Forms.RadioButton();
            this.trocoTextBox = new System.Windows.Forms.TextBox();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pagamentoGroupBox = new System.Windows.Forms.GroupBox();
            this.entregaGroupBox = new System.Windows.Forms.GroupBox();
            this.moedaLabel = new System.Windows.Forms.Label();
            this.pagamentoGroupBox.SuspendLayout();
            this.entregaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // retiradaRadioBtn
            // 
            this.retiradaRadioBtn.AutoSize = true;
            this.retiradaRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.retiradaRadioBtn.Name = "retiradaRadioBtn";
            this.retiradaRadioBtn.Size = new System.Drawing.Size(65, 17);
            this.retiradaRadioBtn.TabIndex = 1;
            this.retiradaRadioBtn.TabStop = true;
            this.retiradaRadioBtn.Text = "Retirada";
            this.retiradaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // entregaRadioBtn
            // 
            this.entregaRadioBtn.AutoSize = true;
            this.entregaRadioBtn.Location = new System.Drawing.Point(6, 53);
            this.entregaRadioBtn.Name = "entregaRadioBtn";
            this.entregaRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.entregaRadioBtn.TabIndex = 2;
            this.entregaRadioBtn.TabStop = true;
            this.entregaRadioBtn.Text = "Entrega";
            this.entregaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // entregaLabel
            // 
            this.entregaLabel.AutoSize = true;
            this.entregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entregaLabel.Location = new System.Drawing.Point(32, 46);
            this.entregaLabel.Name = "entregaLabel";
            this.entregaLabel.Size = new System.Drawing.Size(70, 20);
            this.entregaLabel.TabIndex = 2;
            this.entregaLabel.Text = "Entrega:";
            // 
            // totalPedidoLabel
            // 
            this.totalPedidoLabel.AutoSize = true;
            this.totalPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPedidoLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPedidoLabel.Location = new System.Drawing.Point(33, 352);
            this.totalPedidoLabel.Name = "totalPedidoLabel";
            this.totalPedidoLabel.Size = new System.Drawing.Size(114, 18);
            this.totalPedidoLabel.TabIndex = 3;
            this.totalPedidoLabel.Text = "Total do pedido:";
            // 
            // totalPagarPedidoLabel
            // 
            this.totalPagarPedidoLabel.AutoSize = true;
            this.totalPagarPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagarPedidoLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.totalPagarPedidoLabel.Location = new System.Drawing.Point(153, 352);
            this.totalPagarPedidoLabel.Name = "totalPagarPedidoLabel";
            this.totalPagarPedidoLabel.Size = new System.Drawing.Size(63, 18);
            this.totalPagarPedidoLabel.TabIndex = 4;
            this.totalPagarPedidoLabel.Text = "R$95,00";
            // 
            // taxaEntregaLabel
            // 
            this.taxaEntregaLabel.AutoSize = true;
            this.taxaEntregaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxaEntregaLabel.Location = new System.Drawing.Point(216, 69);
            this.taxaEntregaLabel.Name = "taxaEntregaLabel";
            this.taxaEntregaLabel.Size = new System.Drawing.Size(263, 13);
            this.taxaEntregaLabel.TabIndex = 5;
            this.taxaEntregaLabel.Text = "*Taxa fixa de R$5,00 em pedidos abaixo de R$100,00";
            // 
            // formaPagamentoLabel
            // 
            this.formaPagamentoLabel.AutoSize = true;
            this.formaPagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamentoLabel.Location = new System.Drawing.Point(32, 198);
            this.formaPagamentoLabel.Name = "formaPagamentoLabel";
            this.formaPagamentoLabel.Size = new System.Drawing.Size(166, 20);
            this.formaPagamentoLabel.TabIndex = 6;
            this.formaPagamentoLabel.Text = "Forma de pagamento:";
            // 
            // cartaoRadioBtn
            // 
            this.cartaoRadioBtn.AutoSize = true;
            this.cartaoRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.cartaoRadioBtn.Name = "cartaoRadioBtn";
            this.cartaoRadioBtn.Size = new System.Drawing.Size(56, 17);
            this.cartaoRadioBtn.TabIndex = 3;
            this.cartaoRadioBtn.TabStop = true;
            this.cartaoRadioBtn.Text = "Cartão";
            this.cartaoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pixRadioBtn
            // 
            this.pixRadioBtn.AutoSize = true;
            this.pixRadioBtn.Location = new System.Drawing.Point(6, 57);
            this.pixRadioBtn.Name = "pixRadioBtn";
            this.pixRadioBtn.Size = new System.Drawing.Size(42, 17);
            this.pixRadioBtn.TabIndex = 4;
            this.pixRadioBtn.TabStop = true;
            this.pixRadioBtn.Text = "PIX";
            this.pixRadioBtn.UseVisualStyleBackColor = true;
            // 
            // dinheiroRadioBtn
            // 
            this.dinheiroRadioBtn.AutoSize = true;
            this.dinheiroRadioBtn.Location = new System.Drawing.Point(6, 97);
            this.dinheiroRadioBtn.Name = "dinheiroRadioBtn";
            this.dinheiroRadioBtn.Size = new System.Drawing.Size(64, 17);
            this.dinheiroRadioBtn.TabIndex = 5;
            this.dinheiroRadioBtn.TabStop = true;
            this.dinheiroRadioBtn.Text = "Dinheiro";
            this.dinheiroRadioBtn.UseVisualStyleBackColor = true;
            // 
            // trocoTextBox
            // 
            this.trocoTextBox.Location = new System.Drawing.Point(386, 239);
            this.trocoTextBox.Name = "trocoTextBox";
            this.trocoTextBox.Size = new System.Drawing.Size(100, 20);
            this.trocoTextBox.TabIndex = 6;
            // 
            // trocoLabel
            // 
            this.trocoLabel.AutoSize = true;
            this.trocoLabel.Location = new System.Drawing.Point(298, 242);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(65, 13);
            this.trocoLabel.TabIndex = 11;
            this.trocoLabel.Text = "Troco para: ";
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalizarBtn.Location = new System.Drawing.Point(458, 405);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(96, 23);
            this.finalizarBtn.TabIndex = 7;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = true;
            this.finalizarBtn.Click += new System.EventHandler(this.FinalizarBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(458, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // pagamentoGroupBox
            // 
            this.pagamentoGroupBox.Controls.Add(this.dinheiroRadioBtn);
            this.pagamentoGroupBox.Controls.Add(this.pixRadioBtn);
            this.pagamentoGroupBox.Controls.Add(this.cartaoRadioBtn);
            this.pagamentoGroupBox.Location = new System.Drawing.Point(204, 141);
            this.pagamentoGroupBox.Name = "pagamentoGroupBox";
            this.pagamentoGroupBox.Size = new System.Drawing.Size(88, 129);
            this.pagamentoGroupBox.TabIndex = 14;
            this.pagamentoGroupBox.TabStop = false;
            this.pagamentoGroupBox.Text = "Pagamento";
            // 
            // entregaGroupBox
            // 
            this.entregaGroupBox.Controls.Add(this.entregaRadioBtn);
            this.entregaGroupBox.Controls.Add(this.retiradaRadioBtn);
            this.entregaGroupBox.Location = new System.Drawing.Point(110, 12);
            this.entregaGroupBox.Name = "entregaGroupBox";
            this.entregaGroupBox.Size = new System.Drawing.Size(88, 77);
            this.entregaGroupBox.TabIndex = 15;
            this.entregaGroupBox.TabStop = false;
            this.entregaGroupBox.Text = "Entrega";
            // 
            // moedaLabel
            // 
            this.moedaLabel.AutoSize = true;
            this.moedaLabel.Location = new System.Drawing.Point(358, 242);
            this.moedaLabel.Name = "moedaLabel";
            this.moedaLabel.Size = new System.Drawing.Size(21, 13);
            this.moedaLabel.TabIndex = 29;
            this.moedaLabel.Text = "R$";
            // 
            // TelaPedidoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.moedaLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.trocoLabel);
            this.Controls.Add(this.trocoTextBox);
            this.Controls.Add(this.formaPagamentoLabel);
            this.Controls.Add(this.taxaEntregaLabel);
            this.Controls.Add(this.totalPagarPedidoLabel);
            this.Controls.Add(this.totalPedidoLabel);
            this.Controls.Add(this.entregaLabel);
            this.Controls.Add(this.pagamentoGroupBox);
            this.Controls.Add(this.entregaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Pedido";
            this.pagamentoGroupBox.ResumeLayout(false);
            this.pagamentoGroupBox.PerformLayout();
            this.entregaGroupBox.ResumeLayout(false);
            this.entregaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton retiradaRadioBtn;
        private System.Windows.Forms.RadioButton entregaRadioBtn;
        private System.Windows.Forms.Label entregaLabel;
        private System.Windows.Forms.Label totalPedidoLabel;
        private System.Windows.Forms.Label totalPagarPedidoLabel;
        private System.Windows.Forms.Label taxaEntregaLabel;
        private System.Windows.Forms.Label formaPagamentoLabel;
        private System.Windows.Forms.RadioButton cartaoRadioBtn;
        private System.Windows.Forms.RadioButton pixRadioBtn;
        private System.Windows.Forms.RadioButton dinheiroRadioBtn;
        private System.Windows.Forms.TextBox trocoTextBox;
        private System.Windows.Forms.Label trocoLabel;
        private System.Windows.Forms.Button finalizarBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox pagamentoGroupBox;
        private System.Windows.Forms.GroupBox entregaGroupBox;
        private System.Windows.Forms.Label moedaLabel;
    }
}