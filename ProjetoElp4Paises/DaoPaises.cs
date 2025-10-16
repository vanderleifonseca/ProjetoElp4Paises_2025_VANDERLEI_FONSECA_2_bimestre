using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class DaoPaises:DAO
    {
        public virtual string Excluir(object obj)
        {
            return null;
        }
        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";
            if (oPais.Codigo==0)
            {
                mSql = "Insert into Paises (Pais, Sigla, Ddi, Moeda, datCad, UltAlt) values (@pais, @sigla, @ddi, @moeda, @datcad, @ultalt)";
            }
            else
                mSql = "Update Paises set Pais=@pais, Sigla=@sigla, Ddi=@ddi, Moeda=@moeda, datcad=@datcad, UltAlt=@ultalt where Codigo=@codigo";

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@Pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@Sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@DDI", oPais.Ddi);
                cmd.Parameters.AddWithValue("@Moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datcad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultalt", oPais.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
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
