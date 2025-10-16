using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmCadastros : ProjetoElp4Paises.Frm
    {
        public frmCadastros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
            Sair();
        }


        public virtual void Salvar()
        {

        }
        public virtual void CarregaTxt()
        {

        }
        public virtual void LimpaTxt()
        {

        }
        public virtual void BloquearTxt()
        {

        }
        public virtual void DesbloquearTxt()
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
