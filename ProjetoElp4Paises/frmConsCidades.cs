using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmConsCidades : ProjetoElp4Paises.frmConsultas
    {
        frmCadCidades oFrmCadCidades;
        Cidades aCidade;
        Controller aCtrl;

        frmCadCidades oFrmCadCidade;
        public frmConsCidades()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            oFrmCadCidades.LimpaTxt();
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            oFrmCadCidades.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadCidades.ShowDialog();
        }

        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(aCidade.Cidade));
            item.SubItems.Add(aCidade.Cidade);
            item.SubItems.Add(aCidade.Ddd);
            item.SubItems.Add(aCidade.Cidade);
            ListV.Items.Add(item);
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (frmCadCidades)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
        }





    }
}