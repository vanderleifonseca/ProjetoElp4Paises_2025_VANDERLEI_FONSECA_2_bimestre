using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class Banco
    {
        public static SqlConnection Abrir()
        {
            string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\NITRO\Desktop\4 periodo\Kaneco - ELP IV\ProjetoElp4Paises_01-09-25_VANDERLEI_FONSECA\ProjetoElp4Paises\ELP4_2025.mdf"";Integrated Security=True";
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }
    }
}
