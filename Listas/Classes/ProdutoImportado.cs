
/*
  Queremos fazer com que a ProdutoImportado assine o contrato ITributoDeProdutoImportado que acabamos de criar,
para isso, precisamos colocar o nome da interface que queremos implementar logo após a declaração da
classe pai:

Como a interface ITributoDeProdutoImportado declara o método CalcularTributoDeImportacao(), toda classe que assina a
interface é obrigada a dar uma implementação para essa funcionalidade, se não implementarmos o
método da interface, a classe não compilará.

Além disso, podemos fazer com que uma classe assine uma interface sem herdar de outra classe e extendendo diretamente a interface.
ex :  class ProdutoImportado :  ITributoDeProdutoImportado 

Apesar de C# não suportar herança múltipla (ser filho de mais de uma classe), podemos implementar
quantas interfaces quisermos. Basta colocar uma na frente da outra: ex:

public class ProdutoImportado : Produto, ITributoDeProdutoImportado, OutraInterfaceQualquer
 
 */
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Listas
{
    /*com a implementação da interface ITributoDeProdutoImportado estamos dizendo que a classe ProdutoImportado é Tributável de taxa de importação */

    class ProdutoImportado : Produto, ITributoDeProdutoImportado   
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

       
        public sealed override decimal ValorTotalEmEstoque()
        {
            return PrecoProdutoComTaxa() * QtdEstoque;
        }

        public override decimal PrecoProdutoComTaxa()
        {
           
            return (Preco * 0.15M) + (Preco*ImpostoImportacao/100) + Preco;
            // (base.PrecoProdutoComTaxa()*0.15) + ImpostoImportacao +base.PrecoProdutoComTaxa();
        }

        /* Repare que, para implementarmos o método CalcularTributoDeImportacao() da interface ITributoDeProdutoImportado,
         * não podemos utilizar a palavra override , ela é reservada para a sobrescrita de métodos da Herança.*/

        public decimal CalcularTributoDeImportacao()
        {
            return (Preco * 0.15M) + (Preco * ImpostoImportacao / 100);
        }



        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return " Codigo do Produto importado : " + _codprodutoimportado +
                "- Nome : " + _nome +
                "- Preço sem a taxa : $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "- Taxa de Imposto de importação :  " + ImpostoImportacao.ToString(CultureInfo.InvariantCulture) +" % "+
                "- Total de tributo de importação : " + CalcularTributoDeImportacao() +
                "- Preço com a taxa : $ " + PrecoProdutoComTaxa().ToString("F2", CultureInfo.InvariantCulture) +
               "- Quantidade em estoque : " + QtdEstoque +
               "- Valor total em estoque : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        




    }
}
