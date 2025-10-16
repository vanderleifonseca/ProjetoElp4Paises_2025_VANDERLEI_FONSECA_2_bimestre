using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmCadPaises : ProjetoElp4Paises.frmCadastros
    {
        Paises oPais;
        CtrlPaises aCtrlPaises;
        public frmCadPaises()
        {
            InitializeComponent();
            oPais  = new Paises();
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if(obj != null)
                oPais = (Paises)obj;
            if(ctrl != null)
            {
                aCtrlPaises = (CtrlPaises)ctrl;
            }
                
        }
        public override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            {
                oPais.Codigo = Convert.ToInt32(txtCodigo.Text);
                oPais.Pais = txtPais.Text;
                oPais.Sigla = txtSigla.Text;
                oPais.Ddi = txtDDi.Text;
                oPais.Moeda = txtMoeda.Text;
                MessageBox.Show(aCtrlPaises.Salvar(oPais));
            }
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(oPais.Codigo);
            this.txtPais.Text   = oPais.Pais;
            this.txtSigla.Text  = oPais.Sigla;
            this.txtDDi.Text    = oPais.Ddi;
            this.txtMoeda.Text = oPais.Moeda;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDDi.Clear();
            this.txtMoeda.Clear();
        }
        public override void BloquearTxt()
        {
            this.txtCodigo.Enabled  = false;
            this.txtPais.Enabled  = false;
            this.txtSigla.Enabled = false;
            this.txtDDi.Enabled   = false;
            this.txtMoeda.Enabled = false;
        }
        public override void DesbloquearTxt()
        {
            this.txtCodigo.Enabled  = true;
            this.txtPais.Enabled  = true;
            this.txtSigla.Enabled = true;
            this.txtDDi.Enabled   = true;
            this.txtMoeda.Enabled = true;
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDDi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMoeda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }
    }
}
