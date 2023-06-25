namespace PizzariaDoZe
{
    partial class TelaPedidoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidoCliente));
            this.clienteLabel = new System.Windows.Forms.Label();
            this.totalPagarLabel = new System.Windows.Forms.Label();
            this.bordaLabel = new System.Windows.Forms.Label();
            this.saboresLabel = new System.Windows.Forms.Label();
            this.tamanhoPizzaStaticLabel = new System.Windows.Forms.Label();
            this.ComboBoxSabor = new System.Windows.Forms.ComboBox();
            this.ComboBoxBorda = new System.Windows.Forms.ComboBox();
            this.precoTotalPagarLabel = new System.Windows.Forms.Label();
            this.addPizzaBtn = new System.Windows.Forms.Button();
            this.saboresPizzarListBox = new System.Windows.Forms.ListBox();
            this.seguinteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.bebidaLabel = new System.Windows.Forms.Label();
            this.ComboBoxBebida = new System.Windows.Forms.ComboBox();
            this.addBebidaBtn = new System.Windows.Forms.Button();
            this.bebidaslistBox = new System.Windows.Forms.ListBox();
            this.excluirBebidaBtn = new System.Windows.Forms.Button();
            this.excluirPizzaBtn = new System.Windows.Forms.Button();
            this.retirarIngredienteBtn = new System.Windows.Forms.Button();
            this.saborGroupBox = new System.Windows.Forms.GroupBox();
            this.bebidasGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.moedaLabel = new System.Windows.Forms.Label();
            this.comboBoxTamanhoPiza = new System.Windows.Forms.ComboBox();
            this.trocoLabel = new System.Windows.Forms.Label();
            this.trocoTextBox = new System.Windows.Forms.TextBox();
            this.pagamentoGroupBox = new System.Windows.Forms.GroupBox();
            this.dinheiroRadioBtn = new System.Windows.Forms.RadioButton();
            this.pixRadioBtn = new System.Windows.Forms.RadioButton();
            this.cartaoRadioBtn = new System.Windows.Forms.RadioButton();
            this.entregaGroupBox = new System.Windows.Forms.GroupBox();
            this.entregaRadioBtn = new System.Windows.Forms.RadioButton();
            this.retiradaRadioBtn = new System.Windows.Forms.RadioButton();
            this.comboBoxCLiente = new System.Windows.Forms.ComboBox();
            this.saborGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pagamentoGroupBox.SuspendLayout();
            this.entregaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.BackColor = System.Drawing.Color.Wheat;
            this.clienteLabel.Location = new System.Drawing.Point(77, 83);
            this.clienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(50, 15);
            this.clienteLabel.TabIndex = 0;
            this.clienteLabel.Text = "Cliente: ";
            // 
            // totalPagarLabel
            // 
            this.totalPagarLabel.AutoSize = true;
            this.totalPagarLabel.BackColor = System.Drawing.Color.Wheat;
            this.totalPagarLabel.Location = new System.Drawing.Point(13, 492);
            this.totalPagarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalPagarLabel.Name = "totalPagarLabel";
            this.totalPagarLabel.Size = new System.Drawing.Size(80, 15);
            this.totalPagarLabel.TabIndex = 2;
            this.totalPagarLabel.Text = "Total a pagar: ";
            // 
            // bordaLabel
            // 
            this.bordaLabel.AutoSize = true;
            this.bordaLabel.BackColor = System.Drawing.Color.Wheat;
            this.bordaLabel.Location = new System.Drawing.Point(84, 239);
            this.bordaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bordaLabel.Name = "bordaLabel";
            this.bordaLabel.Size = new System.Drawing.Size(41, 15);
            this.bordaLabel.TabIndex = 3;
            this.bordaLabel.Text = "Borda:";
            // 
            // saboresLabel
            // 
            this.saboresLabel.AutoSize = true;
            this.saboresLabel.BackColor = System.Drawing.Color.Wheat;
            this.saboresLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saboresLabel.Location = new System.Drawing.Point(71, 190);
            this.saboresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saboresLabel.Name = "saboresLabel";
            this.saboresLabel.Size = new System.Drawing.Size(51, 15);
            this.saboresLabel.TabIndex = 4;
            this.saboresLabel.Text = "Sabores:";
            // 
            // tamanhoPizzaStaticLabel
            // 
            this.tamanhoPizzaStaticLabel.AutoSize = true;
            this.tamanhoPizzaStaticLabel.BackColor = System.Drawing.Color.Wheat;
            this.tamanhoPizzaStaticLabel.Location = new System.Drawing.Point(21, 135);
            this.tamanhoPizzaStaticLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tamanhoPizzaStaticLabel.Name = "tamanhoPizzaStaticLabel";
            this.tamanhoPizzaStaticLabel.Size = new System.Drawing.Size(104, 15);
            this.tamanhoPizzaStaticLabel.TabIndex = 5;
            this.tamanhoPizzaStaticLabel.Text = "Tamanho da Pizza:";
            // 
            // ComboBoxSabor
            // 
            this.ComboBoxSabor.FormattingEnabled = true;
            this.ComboBoxSabor.Location = new System.Drawing.Point(135, 187);
            this.ComboBoxSabor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxSabor.Name = "ComboBoxSabor";
            this.ComboBoxSabor.Size = new System.Drawing.Size(140, 23);
            this.ComboBoxSabor.TabIndex = 1;
            // 
            // ComboBoxBorda
            // 
            this.ComboBoxBorda.FormattingEnabled = true;
            this.ComboBoxBorda.Location = new System.Drawing.Point(135, 239);
            this.ComboBoxBorda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxBorda.Name = "ComboBoxBorda";
            this.ComboBoxBorda.Size = new System.Drawing.Size(140, 23);
            this.ComboBoxBorda.TabIndex = 3;
            // 
            // precoTotalPagarLabel
            // 
            this.precoTotalPagarLabel.AutoSize = true;
            this.precoTotalPagarLabel.BackColor = System.Drawing.Color.Wheat;
            this.precoTotalPagarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.precoTotalPagarLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.precoTotalPagarLabel.Location = new System.Drawing.Point(132, 492);
            this.precoTotalPagarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.precoTotalPagarLabel.Name = "precoTotalPagarLabel";
            this.precoTotalPagarLabel.Size = new System.Drawing.Size(44, 18);
            this.precoTotalPagarLabel.TabIndex = 9;
            this.precoTotalPagarLabel.Text = "90,00";
            // 
            // addPizzaBtn
            // 
            this.addPizzaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPizzaBtn.Location = new System.Drawing.Point(284, 185);
            this.addPizzaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPizzaBtn.Name = "addPizzaBtn";
            this.addPizzaBtn.Size = new System.Drawing.Size(88, 27);
            this.addPizzaBtn.TabIndex = 2;
            this.addPizzaBtn.Text = "Adicionar";
            this.addPizzaBtn.UseVisualStyleBackColor = true;
            // 
            // saboresPizzarListBox
            // 
            this.saboresPizzarListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.saboresPizzarListBox.FormattingEnabled = true;
            this.saboresPizzarListBox.ItemHeight = 15;
            this.saboresPizzarListBox.Location = new System.Drawing.Point(526, 72);
            this.saboresPizzarListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saboresPizzarListBox.Name = "saboresPizzarListBox";
            this.saboresPizzarListBox.Size = new System.Drawing.Size(206, 139);
            this.saboresPizzarListBox.TabIndex = 11;
            // 
            // seguinteBtn
            // 
            this.seguinteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seguinteBtn.Location = new System.Drawing.Point(760, 475);
            this.seguinteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.seguinteBtn.Name = "seguinteBtn";
            this.seguinteBtn.Size = new System.Drawing.Size(99, 32);
            this.seguinteBtn.TabIndex = 9;
            this.seguinteBtn.Text = "Seguinte";
            this.seguinteBtn.UseVisualStyleBackColor = true;
            this.seguinteBtn.Click += new System.EventHandler(this.SeguinteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBtn.Location = new System.Drawing.Point(760, 14);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 35);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // bebidaLabel
            // 
            this.bebidaLabel.AutoSize = true;
            this.bebidaLabel.BackColor = System.Drawing.Color.Wheat;
            this.bebidaLabel.Location = new System.Drawing.Point(84, 294);
            this.bebidaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bebidaLabel.Name = "bebidaLabel";
            this.bebidaLabel.Size = new System.Drawing.Size(46, 15);
            this.bebidaLabel.TabIndex = 14;
            this.bebidaLabel.Text = "Bebida:";
            // 
            // ComboBoxBebida
            // 
            this.ComboBoxBebida.FormattingEnabled = true;
            this.ComboBoxBebida.Location = new System.Drawing.Point(135, 294);
            this.ComboBoxBebida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComboBoxBebida.Name = "ComboBoxBebida";
            this.ComboBoxBebida.Size = new System.Drawing.Size(140, 23);
            this.ComboBoxBebida.TabIndex = 4;
            // 
            // addBebidaBtn
            // 
            this.addBebidaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBebidaBtn.Location = new System.Drawing.Point(284, 292);
            this.addBebidaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBebidaBtn.Name = "addBebidaBtn";
            this.addBebidaBtn.Size = new System.Drawing.Size(88, 27);
            this.addBebidaBtn.TabIndex = 5;
            this.addBebidaBtn.Text = "Adicionar";
            this.addBebidaBtn.UseVisualStyleBackColor = true;
            // 
            // bebidaslistBox
            // 
            this.bebidaslistBox.BackColor = System.Drawing.Color.BurlyWood;
            this.bebidaslistBox.FormattingEnabled = true;
            this.bebidaslistBox.ItemHeight = 15;
            this.bebidaslistBox.Location = new System.Drawing.Point(526, 294);
            this.bebidaslistBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bebidaslistBox.Name = "bebidaslistBox";
            this.bebidaslistBox.Size = new System.Drawing.Size(206, 139);
            this.bebidaslistBox.TabIndex = 17;
            // 
            // excluirBebidaBtn
            // 
            this.excluirBebidaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirBebidaBtn.Location = new System.Drawing.Point(740, 294);
            this.excluirBebidaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirBebidaBtn.Name = "excluirBebidaBtn";
            this.excluirBebidaBtn.Size = new System.Drawing.Size(130, 27);
            this.excluirBebidaBtn.TabIndex = 8;
            this.excluirBebidaBtn.Text = "Excluir selecionado";
            this.excluirBebidaBtn.UseVisualStyleBackColor = true;
            // 
            // excluirPizzaBtn
            // 
            this.excluirPizzaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excluirPizzaBtn.Location = new System.Drawing.Point(232, 17);
            this.excluirPizzaBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirPizzaBtn.Name = "excluirPizzaBtn";
            this.excluirPizzaBtn.Size = new System.Drawing.Size(130, 27);
            this.excluirPizzaBtn.TabIndex = 6;
            this.excluirPizzaBtn.Text = "Excluir selecionado";
            this.excluirPizzaBtn.UseVisualStyleBackColor = true;
            // 
            // retirarIngredienteBtn
            // 
            this.retirarIngredienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retirarIngredienteBtn.Location = new System.Drawing.Point(526, 218);
            this.retirarIngredienteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.retirarIngredienteBtn.Name = "retirarIngredienteBtn";
            this.retirarIngredienteBtn.Size = new System.Drawing.Size(206, 27);
            this.retirarIngredienteBtn.TabIndex = 7;
            this.retirarIngredienteBtn.Text = "Retirar algum ingrediente";
            this.retirarIngredienteBtn.UseVisualStyleBackColor = true;
            this.retirarIngredienteBtn.Click += new System.EventHandler(this.RetirarIngredienteBtn_Click);
            // 
            // saborGroupBox
            // 
            this.saborGroupBox.Controls.Add(this.excluirPizzaBtn);
            this.saborGroupBox.Location = new System.Drawing.Point(507, 54);
            this.saborGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saborGroupBox.Name = "saborGroupBox";
            this.saborGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saborGroupBox.Size = new System.Drawing.Size(369, 205);
            this.saborGroupBox.TabIndex = 21;
            this.saborGroupBox.TabStop = false;
            this.saborGroupBox.Text = "Sabores Escolhidos";
            // 
            // bebidasGroupBox
            // 
            this.bebidasGroupBox.Location = new System.Drawing.Point(507, 263);
            this.bebidasGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bebidasGroupBox.Name = "bebidasGroupBox";
            this.bebidasGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bebidasGroupBox.Size = new System.Drawing.Size(369, 205);
            this.bebidasGroupBox.TabIndex = 22;
            this.bebidasGroupBox.TabStop = false;
            this.bebidasGroupBox.Text = "Bebidas Escolhidas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 524);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // moedaLabel
            // 
            this.moedaLabel.AutoSize = true;
            this.moedaLabel.BackColor = System.Drawing.Color.Wheat;
            this.moedaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.moedaLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.moedaLabel.Location = new System.Drawing.Point(107, 492);
            this.moedaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moedaLabel.Name = "moedaLabel";
            this.moedaLabel.Size = new System.Drawing.Size(27, 18);
            this.moedaLabel.TabIndex = 24;
            this.moedaLabel.Text = "R$";
            // 
            // comboBoxTamanhoPiza
            // 
            this.comboBoxTamanhoPiza.FormattingEnabled = true;
            this.comboBoxTamanhoPiza.Location = new System.Drawing.Point(135, 127);
            this.comboBoxTamanhoPiza.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTamanhoPiza.Name = "comboBoxTamanhoPiza";
            this.comboBoxTamanhoPiza.Size = new System.Drawing.Size(140, 23);
            this.comboBoxTamanhoPiza.TabIndex = 25;
            // 
            // trocoLabel
            // 
            this.trocoLabel.AutoSize = true;
            this.trocoLabel.Location = new System.Drawing.Point(8, 140);
            this.trocoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trocoLabel.Name = "trocoLabel";
            this.trocoLabel.Size = new System.Drawing.Size(68, 15);
            this.trocoLabel.TabIndex = 34;
            this.trocoLabel.Text = "Troco para: ";
            // 
            // trocoTextBox
            // 
            this.trocoTextBox.Location = new System.Drawing.Point(80, 137);
            this.trocoTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trocoTextBox.Name = "trocoTextBox";
            this.trocoTextBox.Size = new System.Drawing.Size(63, 23);
            this.trocoTextBox.TabIndex = 32;
            // 
            // pagamentoGroupBox
            // 
            this.pagamentoGroupBox.Controls.Add(this.dinheiroRadioBtn);
            this.pagamentoGroupBox.Controls.Add(this.pixRadioBtn);
            this.pagamentoGroupBox.Controls.Add(this.trocoLabel);
            this.pagamentoGroupBox.Controls.Add(this.cartaoRadioBtn);
            this.pagamentoGroupBox.Controls.Add(this.trocoTextBox);
            this.pagamentoGroupBox.Location = new System.Drawing.Point(221, 344);
            this.pagamentoGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pagamentoGroupBox.Name = "pagamentoGroupBox";
            this.pagamentoGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pagamentoGroupBox.Size = new System.Drawing.Size(151, 171);
            this.pagamentoGroupBox.TabIndex = 35;
            this.pagamentoGroupBox.TabStop = false;
            this.pagamentoGroupBox.Text = "Pagamento";
            // 
            // dinheiroRadioBtn
            // 
            this.dinheiroRadioBtn.AutoSize = true;
            this.dinheiroRadioBtn.Location = new System.Drawing.Point(8, 112);
            this.dinheiroRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dinheiroRadioBtn.Name = "dinheiroRadioBtn";
            this.dinheiroRadioBtn.Size = new System.Drawing.Size(70, 19);
            this.dinheiroRadioBtn.TabIndex = 5;
            this.dinheiroRadioBtn.TabStop = true;
            this.dinheiroRadioBtn.Text = "Dinheiro";
            this.dinheiroRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pixRadioBtn
            // 
            this.pixRadioBtn.AutoSize = true;
            this.pixRadioBtn.Location = new System.Drawing.Point(8, 66);
            this.pixRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pixRadioBtn.Name = "pixRadioBtn";
            this.pixRadioBtn.Size = new System.Drawing.Size(42, 19);
            this.pixRadioBtn.TabIndex = 4;
            this.pixRadioBtn.TabStop = true;
            this.pixRadioBtn.Text = "PIX";
            this.pixRadioBtn.UseVisualStyleBackColor = true;
            // 
            // cartaoRadioBtn
            // 
            this.cartaoRadioBtn.AutoSize = true;
            this.cartaoRadioBtn.Location = new System.Drawing.Point(8, 22);
            this.cartaoRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cartaoRadioBtn.Name = "cartaoRadioBtn";
            this.cartaoRadioBtn.Size = new System.Drawing.Size(60, 19);
            this.cartaoRadioBtn.TabIndex = 3;
            this.cartaoRadioBtn.TabStop = true;
            this.cartaoRadioBtn.Text = "Cartão";
            this.cartaoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // entregaGroupBox
            // 
            this.entregaGroupBox.Controls.Add(this.entregaRadioBtn);
            this.entregaGroupBox.Controls.Add(this.retiradaRadioBtn);
            this.entregaGroupBox.Location = new System.Drawing.Point(13, 344);
            this.entregaGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entregaGroupBox.Name = "entregaGroupBox";
            this.entregaGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entregaGroupBox.Size = new System.Drawing.Size(103, 89);
            this.entregaGroupBox.TabIndex = 36;
            this.entregaGroupBox.TabStop = false;
            this.entregaGroupBox.Text = "Entrega";
            // 
            // entregaRadioBtn
            // 
            this.entregaRadioBtn.AutoSize = true;
            this.entregaRadioBtn.Location = new System.Drawing.Point(8, 61);
            this.entregaRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entregaRadioBtn.Name = "entregaRadioBtn";
            this.entregaRadioBtn.Size = new System.Drawing.Size(65, 19);
            this.entregaRadioBtn.TabIndex = 2;
            this.entregaRadioBtn.TabStop = true;
            this.entregaRadioBtn.Text = "Entrega";
            this.entregaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // retiradaRadioBtn
            // 
            this.retiradaRadioBtn.AutoSize = true;
            this.retiradaRadioBtn.Location = new System.Drawing.Point(8, 22);
            this.retiradaRadioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.retiradaRadioBtn.Name = "retiradaRadioBtn";
            this.retiradaRadioBtn.Size = new System.Drawing.Size(68, 19);
            this.retiradaRadioBtn.TabIndex = 1;
            this.retiradaRadioBtn.TabStop = true;
            this.retiradaRadioBtn.Text = "Retirada";
            this.retiradaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // comboBoxCLiente
            // 
            this.comboBoxCLiente.FormattingEnabled = true;
            this.comboBoxCLiente.Location = new System.Drawing.Point(135, 75);
            this.comboBoxCLiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCLiente.Name = "comboBoxCLiente";
            this.comboBoxCLiente.Size = new System.Drawing.Size(140, 23);
            this.comboBoxCLiente.TabIndex = 38;
            // 
            // TelaPedidoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(884, 522);
            this.Controls.Add(this.comboBoxCLiente);
            this.Controls.Add(this.pagamentoGroupBox);
            this.Controls.Add(this.entregaGroupBox);
            this.Controls.Add(this.comboBoxTamanhoPiza);
            this.Controls.Add(this.precoTotalPagarLabel);
            this.Controls.Add(this.moedaLabel);
            this.Controls.Add(this.retirarIngredienteBtn);
            this.Controls.Add(this.excluirBebidaBtn);
            this.Controls.Add(this.bebidaslistBox);
            this.Controls.Add(this.addBebidaBtn);
            this.Controls.Add(this.ComboBoxBebida);
            this.Controls.Add(this.bebidaLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.seguinteBtn);
            this.Controls.Add(this.saboresPizzarListBox);
            this.Controls.Add(this.addPizzaBtn);
            this.Controls.Add(this.ComboBoxBorda);
            this.Controls.Add(this.ComboBoxSabor);
            this.Controls.Add(this.tamanhoPizzaStaticLabel);
            this.Controls.Add(this.saboresLabel);
            this.Controls.Add(this.bordaLabel);
            this.Controls.Add(this.totalPagarLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.saborGroupBox);
            this.Controls.Add(this.bebidasGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.saborGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pagamentoGroupBox.ResumeLayout(false);
            this.pagamentoGroupBox.PerformLayout();
            this.entregaGroupBox.ResumeLayout(false);
            this.entregaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label totalPagarLabel;
        private System.Windows.Forms.Label bordaLabel;
        private System.Windows.Forms.Label saboresLabel;
        private System.Windows.Forms.Label tamanhoPizzaStaticLabel;
        private System.Windows.Forms.ComboBox ComboBoxSabor;
        private System.Windows.Forms.ComboBox ComboBoxBorda;
        private System.Windows.Forms.Label precoTotalPagarLabel;
        private System.Windows.Forms.Button addPizzaBtn;
        private System.Windows.Forms.ListBox saboresPizzarListBox;
        private System.Windows.Forms.Button seguinteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label bebidaLabel;
        private System.Windows.Forms.ComboBox ComboBoxBebida;
        private System.Windows.Forms.Button addBebidaBtn;
        private System.Windows.Forms.ListBox bebidaslistBox;
        private System.Windows.Forms.Button excluirBebidaBtn;
        private System.Windows.Forms.Button excluirPizzaBtn;
        private System.Windows.Forms.Button retirarIngredienteBtn;
        private System.Windows.Forms.GroupBox saborGroupBox;
        private System.Windows.Forms.GroupBox bebidasGroupBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label moedaLabel;
        private ComboBox comboBoxTamanhoPiza;
        private Label trocoLabel;
        private TextBox trocoTextBox;
        private GroupBox pagamentoGroupBox;
        private RadioButton dinheiroRadioBtn;
        private RadioButton pixRadioBtn;
        private RadioButton cartaoRadioBtn;
        private GroupBox entregaGroupBox;
        private RadioButton entregaRadioBtn;
        private RadioButton retiradaRadioBtn;
        private ComboBox comboBoxCLiente;
    }
}