namespace ProjetoElp4Paises
{
    partial class frmConsEstados
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
            this.colEstsados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // listV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstsados,
            this.colUF,
            this.colCodigoEstado,
            this.colPais});
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // colEstsados
            // 
            this.colEstsados.Text = "Estado";
            this.colEstsados.Width = 200;
            // 
            // colUF
            // 
            this.colUF.Text = "UF";
            this.colUF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colCodigoEstado
            // 
            this.colCodigoEstado.Text = "Codigo do Estado";
            this.colCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCodigoEstado.Width = 130;
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPais.Width = 200;
            // 
            // frmConsEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(919, 610);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmConsEstados";
            this.Text = "Consulta Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ColumnHeader colEstsados;
        public System.Windows.Forms.ColumnHeader colUF;
        public System.Windows.Forms.ColumnHeader colCodigoEstado;
        private System.Windows.Forms.ColumnHeader colPais;
    }
}
