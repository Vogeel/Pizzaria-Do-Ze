namespace PizzariaDoZe.Telas_Admin
{
    partial class OperacoesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.excluirBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excluirBtn
            // 
            this.excluirBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.excluirBtn.FlatAppearance.BorderSize = 0;
            this.excluirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirBtn.Location = new System.Drawing.Point(197, 20);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(81, 33);
            this.excluirBtn.TabIndex = 20;
            this.excluirBtn.Text = "Excluir";
            this.excluirBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Location = new System.Drawing.Point(110, 20);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(81, 33);
            this.editBtn.TabIndex = 19;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(23, 20);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(81, 33);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // OperacoesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(174)))), ((int)(((byte)(139)))));
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "OperacoesUserControl";
            this.Size = new System.Drawing.Size(295, 70);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button excluirBtn;
        public System.Windows.Forms.Button editBtn;
        public System.Windows.Forms.Button addBtn;
    }
}
