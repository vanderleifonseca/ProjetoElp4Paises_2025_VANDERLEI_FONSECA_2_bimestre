using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DAO
    {
        protected SqlConnection cnn;
        public DAO()
        {
            cnn = Banco.Abrir();
        }            
        
        public virtual string Excluir(object obj)
        {
            return null;
        }

        public virtual string Salvar(object obj)
        {
            return null;
        }
        public virtual List<Object> Listar()
        {
            return null;
        }

        public virtual Object CarregaObj(int chave)
        {
            return null;
        }

        public virtual List<Object> Pesquisar(string chave)
        {
            return null;
        }
    }
}

