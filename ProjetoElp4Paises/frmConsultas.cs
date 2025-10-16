using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmConsultas : ProjetoElp4Paises.Frm
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        protected virtual void Pesquisar()
        {
            
        }
        protected virtual void Incluir()
        { 
        }
        protected virtual void Excluir()
        { 
        }
        protected virtual void Alterar()
        { 
        }


        protected virtual void CarregaLV()
        {
        }
        public virtual void setFrmCadastro(object obj)
        {
        }
        protected void frmConsultas_Load(object sender, EventArgs e)
        {
        }
        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }
        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }
        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
    }
}
