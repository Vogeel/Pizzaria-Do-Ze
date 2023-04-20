namespace Pizzaria_Do_Ze
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
            this.visPedidoBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.editarStatusPedidoBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pedidoBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itensAtendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarStatusPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // visPedidoBtn
            // 
            this.visPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.visPedidoBtn.FlatAppearance.BorderSize = 0;
            this.visPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visPedidoBtn.Location = new System.Drawing.Point(14, 125);
            this.visPedidoBtn.Name = "visPedidoBtn";
            this.visPedidoBtn.Size = new System.Drawing.Size(170, 40);
            this.visPedidoBtn.TabIndex = 2;
            this.visPedidoBtn.Text = "Visualizar Pedidos";
            this.visPedidoBtn.UseVisualStyleBackColor = false;
            this.visPedidoBtn.Click += new System.EventHandler(this.VisPedidoBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.voltarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voltarBtn.Location = new System.Drawing.Point(306, 39);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(149, 23);
            this.voltarBtn.TabIndex = 4;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = false;
            this.voltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // editarStatusPedidoBtn
            // 
            this.editarStatusPedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editarStatusPedidoBtn.FlatAppearance.BorderSize = 0;
            this.editarStatusPedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarStatusPedidoBtn.Location = new System.Drawing.Point(14, 191);
            this.editarStatusPedidoBtn.Name = "editarStatusPedidoBtn";
            this.editarStatusPedidoBtn.Size = new System.Drawing.Size(170, 40);
            this.editarStatusPedidoBtn.TabIndex = 3;
            this.editarStatusPedidoBtn.Text = "Editar Status Pedidos";
            this.editarStatusPedidoBtn.UseVisualStyleBackColor = false;
            this.editarStatusPedidoBtn.Click += new System.EventHandler(this.EditarStatusPedidoBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 239);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pedidoBtn
            // 
            this.pedidoBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.pedidoBtn.FlatAppearance.BorderSize = 0;
            this.pedidoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pedidoBtn.Location = new System.Drawing.Point(14, 61);
            this.pedidoBtn.Name = "pedidoBtn";
            this.pedidoBtn.Size = new System.Drawing.Size(170, 40);
            this.pedidoBtn.TabIndex = 1;
            this.pedidoBtn.Text = "Realizar Pedido";
            this.pedidoBtn.UseVisualStyleBackColor = false;
            this.pedidoBtn.Click += new System.EventHandler(this.pedidoBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itensAtendenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itensAtendenteToolStripMenuItem
            // 
            this.itensAtendenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPedidoToolStripMenuItem,
            this.visualizarPedidoToolStripMenuItem,
            this.editarStatusPedidoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.itensAtendenteToolStripMenuItem.Name = "itensAtendenteToolStripMenuItem";
            this.itensAtendenteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.itensAtendenteToolStripMenuItem.Text = "Itens Atendente";
            // 
            // realizarPedidoToolStripMenuItem
            // 
            this.realizarPedidoToolStripMenuItem.Name = "realizarPedidoToolStripMenuItem";
            this.realizarPedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.realizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.realizarPedidoToolStripMenuItem.Text = "Realizar pedido";
            // 
            // visualizarPedidoToolStripMenuItem
            // 
            this.visualizarPedidoToolStripMenuItem.Name = "visualizarPedidoToolStripMenuItem";
            this.visualizarPedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.visualizarPedidoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.visualizarPedidoToolStripMenuItem.Text = "Visualizar pedido";
            // 
            // editarStatusPedidoToolStripMenuItem
            // 
            this.editarStatusPedidoToolStripMenuItem.Name = "editarStatusPedidoToolStripMenuItem";
            this.editarStatusPedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.editarStatusPedidoToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.editarStatusPedidoToolStripMenuItem.Text = "Editar status pedido";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // TelaPrincipalAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(465, 246);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pedidoBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editarStatusPedidoBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.visPedidoBtn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela do Atendente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button visPedidoBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button editarStatusPedidoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button pedidoBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itensAtendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarStatusPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}