using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmConsEstados : ProjetoElp4Paises.frmConsultas
    {
        frmCadEstados ofrmCadEstados;
        Estados oEstado;
        Controller aCtrl;

        public frmConsEstados()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {

        }
        protected override void Incluir()
        {
            ofrmCadEstados.LimpaTxt();
            ofrmCadEstados.ConhecaObj(oEstado, aCtrl);
            ofrmCadEstados.ShowDialog();
            this.CarregaLV();
        }
        protected override void Excluir()
        {
            ofrmCadEstados.ConhecaObj(oEstado, aCtrl);
            ofrmCadEstados.ShowDialog();
        }

        protected override void Alterar()
        {
            ofrmCadEstados.ConhecaObj(oEstado, aCtrl);
            ofrmCadEstados.ShowDialog();
        }

        protected override void CarregaLV()
        {
            ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
            item.SubItems.Add(oEstado.Estado);
            item.SubItems.Add(oEstado.Uf);
            //item.SubItems.Add(oEstado.OPais.Pais);
            ListV.Items.Add(item);
        }
        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                ofrmCadEstados = (frmCadEstados)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

        }
    }
}