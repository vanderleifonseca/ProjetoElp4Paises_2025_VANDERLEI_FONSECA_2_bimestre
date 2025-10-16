using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class FormPrincipal : Form
    {
        Interfaces aInter = new Interfaces();
        Paises oPais = new Paises();
        Estados oEstado = new Estados();
        Cidades aCidade = new Cidades();
        Controller aCtrl = new Controller();
        CtrlPaises aCtrlPaises = new CtrlPaises();
        CtrlCidades aCtrlCidades = new CtrlCidades();
        CtrlEstados aCtrlEstados = new CtrlEstados();

        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            aInter.PecaPaises(oPais, aCtrlPaises);
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, aCtrl);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(oPais, aCtrl);
        }
    }
}
