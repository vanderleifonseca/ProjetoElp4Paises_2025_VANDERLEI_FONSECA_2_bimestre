using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoCidades:DAO
    {
        public virtual string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Cidades aCidades = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidades.Codigo==0)
            {
                mSql = "Insert into Cidades (Cidade, Ddd, datCad, UltAlt) values (@cidade, @ddd, @datcad, @ultalt)";
            }
            else
            
                mSql = "Update Cidades set Cidade=@cidade, Ddd=@ddd, datcad=@datcad, UltAlt=@ultalt where Codigo=@codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Cidades", aCidades.Cidade);
                cmd.Parameters.AddWithValue("@DDD", aCidades.Ddd);
                cmd.Parameters.AddWithValue("@Codigo", aCidades.Codigo);
                cmd.Parameters.AddWithValue("@datcad", aCidades.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", aCidades.UltAlt);
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
