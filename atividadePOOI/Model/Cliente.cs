using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadePOOI.Model
{
    public class Cliente
    {
        public string NomeEmp { get; private set; }
        public string CNPJ { get; private set; }
        public  string CEP { get; private set; }

        public Cliente(string nomemp, string cnpj, string cep)
        {
            NomeEmp = nomemp;
            CNPJ = cnpj;
            CEP = cep;
        }
    }
}
