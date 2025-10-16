using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlCidades : Controller
    {
        ColCidades aColCidades;
        DaoCidades aDaoCidades;
        public CtrlCidades()
        {
            aColCidades = new ColCidades();

        }
        public virtual string Salvar(object obj)
        {
            base.Salvar(obj);
            return aDaoCidades.Salvar(obj);
            Cidades oPais = (Cidades)obj;
            if (oPais.Codigo == 0)

                aColCidades.Inserir((Cidades)obj);
            else
            {
                

            }
        }

    }
}

