/*Queremos fazer com que a ProdutoImportadoChines assine o contrato ITributoDeProdutoImportado que acabamos de criar,
para isso, precisamos colocar o nome da interface que queremos implementar logo após a declaração da
classe pai:
Como a interface ITributoDeProdutoImportado declara o método CalcularTributoDeImportacao(), toda classe que assina a
interface é obrigada a dar uma implementação para essa funcionalidade, se não implementarmos o
método da interface, a classe não compilará.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interface
{ /*com a implementação da interface ITributoDeProdutoImportado estamos dizendo que a classe ProdutoImportadoChines é Tributável de taxa de importação */

    class ProdutoImportadoChines : ProdutoImportado, ITributoDeProdutoImportado  
    {
       
        public ProdutoImportadoChines(decimal preco, int qtdEstoque, decimal impostoimportacao): base(preco, qtdEstoque, impostoimportacao)
        {
        }

        
        public override decimal PrecoProdutoComTaxa()
        {
            return Preco + (Preco * ImpostoImportacao / 100) + (Preco * 0.2M);
        }

        /* Repare que, para implementarmos o método CalcularTributoDeImportacao() da interface ITributoDeProdutoImportado,
        * não podemos utilizar a palavra override , ela é reservada para a sobrescrita de métodos da Herança.*/

        public new decimal CalcularTributoDeImportacao()
        {
            return (Preco * ImpostoImportacao / 100) + (Preco * 0.2M);
        }


        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return " Codigo do Produto importado Chines : " + _codprodutoimportado +
                "- Nome : " + _nome +
                "- Preço sem a taxa : $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "- Taxa de Imposto de importação Chines :  " + ImpostoImportacao.ToString(CultureInfo.InvariantCulture) + " % " +
                "- Total de tributo de importação : " + CalcularTributoDeImportacao()+
                "- Preço com a taxa : $ " + PrecoProdutoComTaxa().ToString("F2", CultureInfo.InvariantCulture) +
               "- Quantidade em estoque : " + QtdEstoque +
               "- Valor total em estoque : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

      



    }
}
