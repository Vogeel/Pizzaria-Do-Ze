﻿namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaPedidosPendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPedidosPendentes));
            this.pedidosPendentesListBox = new System.Windows.Forms.ListBox();
            this.abrirPedidoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidosPendentesListBox
            // 
            this.pedidosPendentesListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.pedidosPendentesListBox.FormattingEnabled = true;
            this.pedidosPendentesListBox.Location = new System.Drawing.Point(12, 34);
            this.pedidosPendentesListBox.Name = "pedidosPendentesListBox";
            this.pedidosPendentesListBox.Size = new System.Drawing.Size(517, 394);
            this.pedidosPendentesListBox.TabIndex = 0;
            // 
            // abrirPedidoBtn
            // 
            this.abrirPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.abrirPedidoBtn.FlatAppearance.BorderSize = 0;
            this.abrirPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abrirPedidoBtn.Location = new System.Drawing.Point(548, 45);
            this.abrirPedidoBtn.Name = "abrirPedidoBtn";
            this.abrirPedidoBtn.Size = new System.Drawing.Size(135, 37);
            this.abrirPedidoBtn.TabIndex = 1;
            this.abrirPedidoBtn.Text = "Abrir pedido selecionado";
            this.abrirPedidoBtn.UseVisualStyleBackColor = false;
            this.abrirPedidoBtn.Click += new System.EventHandler(this.abrirPedidoBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(548, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 480);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // TelaPedidosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.abrirPedidoBtn);
            this.Controls.Add(this.pedidosPendentesListBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidosPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosPendentes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pedidosPendentesListBox;
        private System.Windows.Forms.Button abrirPedidoBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}