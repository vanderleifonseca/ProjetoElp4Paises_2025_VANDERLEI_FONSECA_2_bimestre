﻿using System;
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
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }
        protected virtual void Sair()
        {
            Close();
        }

        public virtual void ConhecaObj(object obj, object ctrl)
        { 
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }
    }
}
