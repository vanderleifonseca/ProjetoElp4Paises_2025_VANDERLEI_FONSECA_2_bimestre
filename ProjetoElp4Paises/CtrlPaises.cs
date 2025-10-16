using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlPaises : Controller
    {
        ColPaises aColPaises;
        DaoPaises aDaoPaises;

        public CtrlPaises()
        {
            aColPaises = new ColPaises();
        }
        public override string Salvar(object obj)
        {
            base.Salvar(obj);
            return aDaoPaises.Salvar(obj);
            Paises oPais = (Paises)obj;
            if (oPais.Codigo == 0)
            {
                aColPaises.Inserir((Paises)obj);
            }
            else
            {

            }
        }
    }
}


