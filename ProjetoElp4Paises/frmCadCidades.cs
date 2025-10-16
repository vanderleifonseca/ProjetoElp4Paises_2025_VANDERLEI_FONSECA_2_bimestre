using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoElp4Paises
{
    public partial class frmCadCidades : ProjetoElp4Paises.frmCadastros
    {
        frmConsEstados ofrmConsEstados;
        public frmCadCidades()
        {
            InitializeComponent();
        }

        public void setFrmConsEstados(object obj)
        {
            if (obj != null)
            {
                ofrmConsEstados = (frmConsEstados)obj;
            }

        }

        private void frmCadCidades_Load(object sender, EventArgs e)
        {
            
        }
    }
}