using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoEstados:DAO
    {
        public virtual string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo==0)
            {
                mSql = "Insert into Estados (Estado, Uf, Codigo, datCad, UltAlt) values (@estado, @uf, @codigo, @datcad, @ultalt)";
            }
            else
            
                mSql = "Update Estados set Estado=@estado, Uf=@uf, Codigo=@codigo, datcad=@datcad, UltAlt=@ultalt where Codigo=@codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@Uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@Codigo", oEstado.Codigo);
                cmd.Parameters.AddWithValue("@datcad", oEstado.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oEstado.UltAlt);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Select @@IDENTITY";
                mOk = cmd.ExecuteScalar().ToString();
            }
            return mOk;
        }
        public override List<Object> Listar()
        {
            return null;
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Object> Pesquisar(string chave)
        {
            return null;
        }
    }
}
