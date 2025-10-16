using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class Estados:Pai
    {
        protected string estado;
        protected string uf;
        protected Paises oPais;
        public Estados() : base()
        {
            estado = string.Empty;
            uf     = string.Empty;
            oPais  = new Paises();
        }
        public Estados(int codigo, DateTime datCad, DateTime ultAlt, string estado, string uf, Paises oPais) : base(codigo, datCad, ultAlt)
        {
            this.estado = estado;
            this.uf     = uf;
            this.oPais  = oPais;
        }
        public Estados Clone()
        {
            Estados oEstado = new Estados(this.codigo, this.datcad, this.ultalt, this.estado, this.uf, this.oPais);
            return oEstado;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;
        }
        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public Paises OPais
        {
            get => oPais;
            set => oPais = value;
        }
    }
}
