﻿namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalAtendente));
            this.clienteBtn = new System.Windows.Forms.Button();
            this.visPedidoBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.editarStatusPedidoBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBtn
            // 
            this.clienteBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.clienteBtn.FlatAppearance.BorderSize = 0;
            this.clienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clienteBtn.Location = new System.Drawing.Point(12, 40);
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Size = new System.Drawing.Size(170, 40);
            this.clienteBtn.TabIndex = 0;
            this.clienteBtn.Text = "Realizar Pedido";
            this.clienteBtn.UseVisualStyleBackColor = false;
            this.clienteBtn.Click += new System.EventHandler(this.clienteBtn_Click);
            // 
            // visPedidoBtn
            // 
            this.visPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.visPedidoBtn.FlatAppearance.BorderSize = 0;
            this.visPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visPedidoBtn.Location = new System.Drawing.Point(12, 105);
            this.visPedidoBtn.Name = "visPedidoBtn";
            this.visPedidoBtn.Size = new System.Drawing.Size(170, 40);
            this.visPedidoBtn.TabIndex = 2;
            this.visPedidoBtn.Text = "Visualizar Pedidos";
            this.visPedidoBtn.UseVisualStyleBackColor = false;
            this.visPedidoBtn.Click += new System.EventHandler(this.visPedidoBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(300, 22);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(149, 23);
            this.voltarBtn.TabIndex = 3;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // editarStatusPedidoBtn
            // 
            this.editarStatusPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editarStatusPedidoBtn.FlatAppearance.BorderSize = 0;
            this.editarStatusPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarStatusPedidoBtn.Location = new System.Drawing.Point(12, 164);
            this.editarStatusPedidoBtn.Name = "editarStatusPedidoBtn";
            this.editarStatusPedidoBtn.Size = new System.Drawing.Size(170, 40);
            this.editarStatusPedidoBtn.TabIndex = 4;
            this.editarStatusPedidoBtn.Text = "Editar Status Pedidos";
            this.editarStatusPedidoBtn.UseVisualStyleBackColor = false;
            this.editarStatusPedidoBtn.Click += new System.EventHandler(this.editarStatusPedidoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // TelaPrincipalAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(465, 216);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editarStatusPedidoBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.visPedidoBtn);
            this.Controls.Add(this.clienteBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipalAtendente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clienteBtn;
        private System.Windows.Forms.Button visPedidoBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button editarStatusPedidoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}