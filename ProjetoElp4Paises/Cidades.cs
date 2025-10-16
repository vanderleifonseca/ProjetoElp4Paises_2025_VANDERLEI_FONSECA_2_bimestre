using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class Cidades:Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oEstados;

        public Cidades() : base()
        {
            cidade        = string.Empty;
            ddd           = string.Empty;
            this.oEstados = new Estados();
        }
        public Cidades(int codigo, DateTime datcad, DateTime ultalt, string cidade, string ddd, Estados oEstado) : base(codigo, datcad, ultalt)
        {
            this.cidade   = cidade;
            this.ddd      = ddd;
            this.oEstados = oEstado;
        }
        public Cidades Clone()
        {
            Cidades aCidade = new Cidades(this.codigo, this.datcad, this.ultalt, this.cidade, this.ddd, this.oEstados);
            return aCidade;
        }
        public string Cidade
        {
            get => cidade;
            set => this.cidade = value;
        }
        public string Ddd
        {
            get => ddd;
            set => this.ddd = value;
        }
        public Estados OEstado
        {
            get => oEstados;
            set => OEstado = value;
        }
    }
}
