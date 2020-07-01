using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class ColecaoVaziaException : Exception
    {
        public string Mensagem { get; private set; }

        public ColecaoVaziaException(string mensagem)
        {
            Mensagem = mensagem;
        }
    }
}
