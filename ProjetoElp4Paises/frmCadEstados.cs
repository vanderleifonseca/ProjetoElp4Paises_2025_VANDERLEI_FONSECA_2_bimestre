using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmCadEstados : ProjetoElp4Paises.frmCadastros
    {
        FrmConsPaises oFrmConsPaises;
        Estados oEstado;
        Controller aCtrl;

        public frmCadEstados()
        {
            InitializeComponent();
            //oEstado = new Estados();
            //oFrmConsPaises = new FrmConsPaises();
            //aCtrl = new Controller();
        }

        public void setFrmConsPaises(object obj)
        {
            if (obj != null)
            {
                oFrmConsPaises = (FrmConsPaises)obj;
            }
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            oEstado = (Estados)obj;
            aCtrl = (Controller)ctrl;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string btnSair = oFrmConsPaises.btnSair.Text;
            oFrmConsPaises.btnSair.Text = "Selecionar";
            oFrmConsPaises.ConhecaObj(oEstado.OPais, aCtrl);
            oFrmConsPaises.ShowDialog();
            this.txtCodigoPais.Text = Convert.ToString(oEstado.OPais.Codigo);
            //this.txtPais.Text = oEstado.OPais.Pais.Convert.ToString();      CORRIGIR
            oFrmConsPaises.btnSair.Text = btnSair;
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
