using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExtensão
{
    class TrataString
    {
        public string ConverteStringDados(string txt)
        {

            string Op_1, Op_2, Op_3;
            string result = string.Empty;

            Op_1 = txt.Replace("-", "");
            Op_2 = Op_1.Replace(")", "");
            Op_3 = Op_2.Replace("(", "");
            result = Op_3.Replace(" ", "");

            return result;
        }
    }
}
