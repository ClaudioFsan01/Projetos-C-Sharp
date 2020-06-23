
/* Classes e métodos selados
 • Palavra chave: sealed

 • Classe: evita que a classe seja herdada
 • Nota: ainda é possível extender a funcionalidade de uma classe selada usando
 "extension methods"
 
 • Método: evita que um método sobreposto(reescrito) possa ser sobreposto(reescrito) novamente
• Só pode ser aplicado a métodos sobrepostos(reescritos)
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Polimorfismo
{// com o uso da palavra sealed a classe ProdutoImportado não pode ser herdada 
    /*sealed*/ class ProdutoImportado : Produto    // Basta usar a notação : e o C# automaticamente herda os métodos e atributos da classe pai.
    {
        private protected int _codprodutoimportado;

        public decimal ImpostoImportacao { get; private set; }

        public ProdutoImportado(decimal preco, int qtdEstoque, decimal impostoImportacao) : base(preco, qtdEstoque)
        {
            if (impostoImportacao >= 0)
            {
                ImpostoImportacao = impostoImportacao;
            }
            else
            {
                throw new ArgumentException(" Valor da taxa de importação invalida ! \n");
            }
          
        }


        //propriedade customizada 

        public int CodigoProdImportado {
            get { return _codprodutoimportado; }
            set
            {
                if(value > 0)
                {
                    _codprodutoimportado = value;
                }
                else
                {
                    Console.WriteLine(" Codigo do produto nacional inválido !");
                }
            }
        }

        /* Desejo que o método ValorTotalEmEstoque() não seja sobreposto(reescrito) novamente por isso o uso da palavra sealed.
        Pra quê?
        • Segurança: dependendo das regras do negócio, às vezes é desejável garantir que uma classe não seja herdada, ou que um método não
        seja sobreposto novamente.
        • Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas podem ser uma porta de entrada para inconsistências
         • Performance: atributos de tipo de uma classe selada são analisados
         de forma mais rápida em tempo de execução.
         • Exemplo clássico: string         
         */
        public sealed override decimal ValorTotalEmEstoque()
        {
            return PrecoProdutoComTaxa() * QtdEstoque;
        }

        public override decimal PrecoProdutoComTaxa()
        {
           
            return (Preco * 0.15M) + (Preco*ImpostoImportacao/100) + Preco;
            // (base.PrecoProdutoComTaxa()*0.15) + ImpostoImportacao +base.PrecoProdutoComTaxa();
        }


        /* Método ToString() na classe Object é virtual podendo ser (sobreposto ou reescrito) 
         em outras classes utilizando a palavra override  */

        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return " Codigo do Produto importado : " + _codprodutoimportado +
                "- Nome : " + _nome +
                "- Preço sem a taxa : $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "- Taxa de Imposto de importação :  " + ImpostoImportacao.ToString(CultureInfo.InvariantCulture) +" % "+
                "- Preço com a taxa : $ " + PrecoProdutoComTaxa().ToString("F2", CultureInfo.InvariantCulture) +
               "- Quantidade em estoque : " + QtdEstoque +
               "- Valor total em estoque : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        /* * ToString - converte um objeto para String  
        * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/




    }
}
