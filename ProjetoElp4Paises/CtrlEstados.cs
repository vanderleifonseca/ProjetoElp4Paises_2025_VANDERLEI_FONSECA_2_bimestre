using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class CtrlEstados : Controller
    {
        ColEstados aColEstados;
        DaoEstados aDaoEstados;
        public CtrlEstados()
        {
            aColEstados = new ColEstados();
        }
        public override string Salvar(object obj)
        {
            base.Salvar(obj);
            return aDaoEstados.Salvar(obj);
            Estados oPais = (Estados)obj;
            if (oPais.Codigo == 0)
            
                aColEstados.Inserir((Estados)obj);
            else
            {

            }
        }
    }

}

