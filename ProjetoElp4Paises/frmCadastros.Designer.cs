namespace ProjetoElp4Paises
{
    partial class frmCadastros
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDatCad = new System.Windows.Forms.Label();
            this.txtUltAlt = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(15, 64);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtCodigo.Size = new System.Drawing.Size(104, 22);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(721, 511);
            this.btnSair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(601, 511);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(16, 42);
            this.lbl_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(51, 16);
            this.lbl_Codigo.TabIndex = 3;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 514);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 514);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 514);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDatCad
            // 
            this.txtDatCad.AutoSize = true;
            this.txtDatCad.Location = new System.Drawing.Point(131, 476);
            this.txtDatCad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDatCad.Name = "txtDatCad";
            this.txtDatCad.Size = new System.Drawing.Size(67, 16);
            this.txtDatCad.TabIndex = 7;
            this.txtDatCad.Text = "Data Cad.";
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.AutoSize = true;
            this.txtUltAlt.Location = new System.Drawing.Point(284, 476);
            this.txtUltAlt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUltAlt.Name = "txtUltAlt";
            this.txtUltAlt.Size = new System.Drawing.Size(62, 16);
            this.txtUltAlt.TabIndex = 8;
            this.txtUltAlt.Text = "Dat Ul Alt";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.AutoSize = true;
            this.txtCodUsuario.Location = new System.Drawing.Point(429, 475);
            this.txtCodUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(54, 16);
            this.txtCodUsuario.TabIndex = 9;
            this.txtCodUsuario.Text = "Usuário";
            // 
            // frmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.txtUltAlt);
            this.Controls.Add(this.txtDatCad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCadastros";
            this.Text = "Cadastro de Paises";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.txtCodUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtDatCad;
        private System.Windows.Forms.Label txtUltAlt;
        private System.Windows.Forms.Label txtCodUsuario;
        public System.Windows.Forms.Button btnSalvar;
    }
}
