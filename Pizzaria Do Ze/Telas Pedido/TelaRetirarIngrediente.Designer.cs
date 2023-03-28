﻿namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaRetirarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRetirarIngrediente));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ingredientesListBox = new System.Windows.Forms.ListBox();
            this.retirarBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.ConcluirBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sabor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ingredientesListBox
            // 
            this.ingredientesListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.ingredientesListBox.FormattingEnabled = true;
            this.ingredientesListBox.Location = new System.Drawing.Point(106, 85);
            this.ingredientesListBox.Name = "ingredientesListBox";
            this.ingredientesListBox.Size = new System.Drawing.Size(166, 121);
            this.ingredientesListBox.TabIndex = 2;
            // 
            // retirarBtn
            // 
            this.retirarBtn.FlatAppearance.BorderSize = 0;
            this.retirarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retirarBtn.Location = new System.Drawing.Point(301, 85);
            this.retirarBtn.Name = "retirarBtn";
            this.retirarBtn.Size = new System.Drawing.Size(114, 27);
            this.retirarBtn.TabIndex = 3;
            this.retirarBtn.Text = "Retirar Selecionado";
            this.retirarBtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(323, 12);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 27);
            this.cancelbtn.TabIndex = 4;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // ConcluirBtn
            // 
            this.ConcluirBtn.FlatAppearance.BorderSize = 0;
            this.ConcluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConcluirBtn.Location = new System.Drawing.Point(323, 206);
            this.ConcluirBtn.Name = "ConcluirBtn";
            this.ConcluirBtn.Size = new System.Drawing.Size(86, 27);
            this.ConcluirBtn.TabIndex = 5;
            this.ConcluirBtn.Text = "Concluir";
            this.ConcluirBtn.UseVisualStyleBackColor = true;
            this.ConcluirBtn.Click += new System.EventHandler(this.ConcluirBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(295, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // TelaRetirarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(427, 245);
            this.Controls.Add(this.ConcluirBtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.retirarBtn);
            this.Controls.Add(this.ingredientesListBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRetirarIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRetirarIngrediente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox ingredientesListBox;
        private System.Windows.Forms.Button retirarBtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button ConcluirBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}