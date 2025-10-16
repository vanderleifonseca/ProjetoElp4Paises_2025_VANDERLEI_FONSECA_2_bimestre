using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class ColPaises : Colecoes<Paises>
    {
        public Paises BuscarPorSigla(string sigla)
        {
            foreach (var opais in aLista)
            {
                if (opais.Sigla.Equals(sigla, StringComparison.OrdinalIgnoreCase))
                    {
                    return opais;
                }
            }
            return null;
        }
        public override void Imprimir()
        {
            foreach (var oPais in aLista)
            {
                Console.WriteLine($"Pais : {oPais.Pais}");
                Console.WriteLine($"Sigla : {oPais.Sigla}");
                Console.WriteLine($"DDI : {oPais.Ddi}");
                Console.WriteLine($"Moeda : {oPais.Moeda}");
            }
        }
    }
}
