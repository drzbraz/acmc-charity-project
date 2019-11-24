using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensão
{
    class Pessoa
    {

        protected string _CPF;

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value.Replace("-", ""); }
        }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        protected string _RG;

        public string RG
        {
            get { return _RG; }
            set { _RG = value.Replace("-", ""); }
        }
        public string EstadoCivil { get; set; }
        protected string _Celular;
        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value.Replace("(", "").Replace(")", "").Replace("-", ""); }
        }
        public string Mail { get; set; }




    }
}
