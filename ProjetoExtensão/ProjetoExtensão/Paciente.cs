using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensão
{
    class Paciente:Pessoa
    {
        protected string _TituloDeEleitor;

        public string TituloDeEleitor
        {
            get { return _TituloDeEleitor; }
            set { _TituloDeEleitor = value.Replace("-", ""); }
        }
        public string NomeMãe { get; set; }
        public string Familiares { get; set; }
        protected string _TelefoneFixo;

        public string TelefoneFixo
        {
            get { return _TelefoneFixo; }
            set { _TelefoneFixo = value.Replace("(", "").Replace(")", "").Replace("-", ""); }
        }
        protected string _ContatoAmigo;

        public string ContatoAmigo
        {
            get { return _ContatoAmigo; }
            set { _ContatoAmigo = value.Replace("(", "").Replace(")", "").Replace("-", ""); }
        }
        public string ReCadBiométrico { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Número { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public double QntConsultas { get; set; }


        public char Valida(bool Op)
        {
            char result;

            if (Op == true)
            {
                result = 'V';
            }
            else
            {
                result = 'F';
            }

            return result;

        }

    }
}
