using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class TotalizadorDeTributoProdutoImportado
    {
        public decimal AcumuladorTributoProdImportado { get; private protected set; }



        /* Qualquer classe que implemente a interface ITributoDeProdutoImportado é tributavel de taxa de importação.
         A variavel produto do tipo ITributoDeProdutoImportado pode fazer referencia a um objeto de uma classe que implementou a interface ITributoDeProdutoImportado.
          /*Desta forma, podemos dizer que a classe TotalizadorDeTributoProdutoImportado recebe um ITributoDeProdutoImportado
        qualquer. O polimorfismo funciona com interface.
        
         A interfcace é a classe pai e as classes que a implementaram são as filhas*/

        public void AcumuladorDeTributoProdutoImportado(ITributoDeProdutoImportado produto)
        {
           AcumuladorTributoProdImportado += produto.CalcularTributoDeImportacao();
        }
    }
}
