﻿namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalAdmin));
            this.pizzaBtn = new System.Windows.Forms.Button();
            this.pedidoBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.cadastroFuncionarioBtn = new System.Windows.Forms.Button();
            this.fornecedorBtn = new System.Windows.Forms.Button();
            this.bebidasBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editarStatusPedidoBtn = new System.Windows.Forms.Button();
            this.visPedidoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pizzaBtn
            // 
            this.pizzaBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.pizzaBtn.FlatAppearance.BorderSize = 0;
            this.pizzaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pizzaBtn.Location = new System.Drawing.Point(12, 31);
            this.pizzaBtn.Name = "pizzaBtn";
            this.pizzaBtn.Size = new System.Drawing.Size(247, 35);
            this.pizzaBtn.TabIndex = 0;
            this.pizzaBtn.Text = "Pizza";
            this.pizzaBtn.UseVisualStyleBackColor = false;
            this.pizzaBtn.Click += new System.EventHandler(this.PizzaBtn_Click);
            // 
            // pedidoBtn
            // 
            this.pedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.pedidoBtn.FlatAppearance.BorderSize = 0;
            this.pedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidoBtn.Location = new System.Drawing.Point(12, 154);
            this.pedidoBtn.Name = "pedidoBtn";
            this.pedidoBtn.Size = new System.Drawing.Size(247, 35);
            this.pedidoBtn.TabIndex = 5;
            this.pedidoBtn.Text = "Realizar Pedido";
            this.pedidoBtn.UseVisualStyleBackColor = false;
            this.pedidoBtn.Click += new System.EventHandler(this.PedidoBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(474, 12);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(141, 33);
            this.voltarBtn.TabIndex = 8;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // cadastroFuncionarioBtn
            // 
            this.cadastroFuncionarioBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.cadastroFuncionarioBtn.FlatAppearance.BorderSize = 0;
            this.cadastroFuncionarioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastroFuncionarioBtn.Location = new System.Drawing.Point(12, 195);
            this.cadastroFuncionarioBtn.Name = "cadastroFuncionarioBtn";
            this.cadastroFuncionarioBtn.Size = new System.Drawing.Size(247, 35);
            this.cadastroFuncionarioBtn.TabIndex = 10;
            this.cadastroFuncionarioBtn.Text = "Cadastrar Funcionario";
            this.cadastroFuncionarioBtn.UseVisualStyleBackColor = false;
            this.cadastroFuncionarioBtn.Click += new System.EventHandler(this.CadastroFuncionarioBtn_Click);
            // 
            // fornecedorBtn
            // 
            this.fornecedorBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.fornecedorBtn.FlatAppearance.BorderSize = 0;
            this.fornecedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fornecedorBtn.Location = new System.Drawing.Point(12, 236);
            this.fornecedorBtn.Name = "fornecedorBtn";
            this.fornecedorBtn.Size = new System.Drawing.Size(247, 35);
            this.fornecedorBtn.TabIndex = 12;
            this.fornecedorBtn.Text = "Cadastrar Fornecedor";
            this.fornecedorBtn.UseVisualStyleBackColor = false;
            this.fornecedorBtn.Click += new System.EventHandler(this.FornecedorBtn_Click);
            // 
            // bebidasBtn
            // 
            this.bebidasBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.bebidasBtn.FlatAppearance.BorderSize = 0;
            this.bebidasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bebidasBtn.Location = new System.Drawing.Point(12, 277);
            this.bebidasBtn.Name = "bebidasBtn";
            this.bebidasBtn.Size = new System.Drawing.Size(247, 35);
            this.bebidasBtn.TabIndex = 13;
            this.bebidasBtn.Text = "Cadastrar Bebidas";
            this.bebidasBtn.UseVisualStyleBackColor = false;
            this.bebidasBtn.Click += new System.EventHandler(this.BebidasBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(291, 349);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // editarStatusPedidoBtn
            // 
            this.editarStatusPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editarStatusPedidoBtn.FlatAppearance.BorderSize = 0;
            this.editarStatusPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarStatusPedidoBtn.Location = new System.Drawing.Point(12, 72);
            this.editarStatusPedidoBtn.Name = "editarStatusPedidoBtn";
            this.editarStatusPedidoBtn.Size = new System.Drawing.Size(247, 35);
            this.editarStatusPedidoBtn.TabIndex = 16;
            this.editarStatusPedidoBtn.Text = "Editar Status Pedidos";
            this.editarStatusPedidoBtn.UseVisualStyleBackColor = false;
            this.editarStatusPedidoBtn.Click += new System.EventHandler(this.EditarStatusPedido_Click);
            // 
            // visPedidoBtn
            // 
            this.visPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.visPedidoBtn.FlatAppearance.BorderSize = 0;
            this.visPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visPedidoBtn.Location = new System.Drawing.Point(12, 113);
            this.visPedidoBtn.Name = "visPedidoBtn";
            this.visPedidoBtn.Size = new System.Drawing.Size(247, 35);
            this.visPedidoBtn.TabIndex = 17;
            this.visPedidoBtn.Text = "Visualizar Pedidos";
            this.visPedidoBtn.UseVisualStyleBackColor = false;
            this.visPedidoBtn.Click += new System.EventHandler(this.visPedidoBtn_Click);
            // 
            // TelaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(633, 328);
            this.Controls.Add(this.visPedidoBtn);
            this.Controls.Add(this.editarStatusPedidoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bebidasBtn);
            this.Controls.Add(this.fornecedorBtn);
            this.Controls.Add(this.cadastroFuncionarioBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.pedidoBtn);
            this.Controls.Add(this.pizzaBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela do Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pizzaBtn;
        private System.Windows.Forms.Button pedidoBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button cadastroFuncionarioBtn;
        private System.Windows.Forms.Button fornecedorBtn;
        private System.Windows.Forms.Button bebidasBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editarStatusPedidoBtn;
        private System.Windows.Forms.Button visPedidoBtn;
    }
}