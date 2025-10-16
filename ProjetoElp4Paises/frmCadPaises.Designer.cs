namespace ProjetoElp4Paises
{
    partial class frmCadPaises
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
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.txtDDi = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblDdi = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.TabIndex = 14;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            // 
            // txtMoeda
            // 
            this.txtMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMoeda.Location = new System.Drawing.Point(645, 64);
            this.txtMoeda.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoeda.MaxLength = 3;
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(87, 22);
            this.txtMoeda.TabIndex = 3;
            this.txtMoeda.TextChanged += new System.EventHandler(this.txtMoeda_TextChanged);
            // 
            // txtDDi
            // 
            this.txtDDi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDi.Location = new System.Drawing.Point(537, 64);
            this.txtDDi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDDi.MaxLength = 5;
            this.txtDDi.Name = "txtDDi";
            this.txtDDi.Size = new System.Drawing.Size(87, 22);
            this.txtDDi.TabIndex = 2;
            this.txtDDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDDi.TextChanged += new System.EventHandler(this.txtDDi_TextChanged);
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(429, 64);
            this.txtSigla.Margin = new System.Windows.Forms.Padding(4);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(87, 22);
            this.txtSigla.TabIndex = 1;
            this.txtSigla.TextChanged += new System.EventHandler(this.txtSigla_TextChanged);
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(135, 64);
            this.txtPais.Margin = new System.Windows.Forms.Padding(4);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(265, 22);
            this.txtPais.TabIndex = 0;
            this.txtPais.TextChanged += new System.EventHandler(this.txtPais_TextChanged);
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(641, 41);
            this.lblMoeda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(50, 16);
            this.lblMoeda.TabIndex = 21;
            this.lblMoeda.Text = "Moeda";
            // 
            // lblDdi
            // 
            this.lblDdi.AutoSize = true;
            this.lblDdi.Location = new System.Drawing.Point(533, 41);
            this.lblDdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDdi.Name = "lblDdi";
            this.lblDdi.Size = new System.Drawing.Size(30, 16);
            this.lblDdi.TabIndex = 20;
            this.lblDdi.Text = "DDI";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(429, 41);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(38, 16);
            this.lblSigla.TabIndex = 19;
            this.lblSigla.Text = "Sigla";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(131, 41);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 16);
            this.lblPais.TabIndex = 18;
            this.lblPais.Text = "Pais";
            // 
            // frmCadPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDDi);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDdi);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadPaises";
            this.Text = "Cadastro Paises";
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDdi, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDDi, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.TextBox txtDDi;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblDdi;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblPais;
    }
}
