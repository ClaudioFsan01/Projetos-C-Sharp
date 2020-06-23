using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Polimorfismo
{
    class ProdutoImportadoChines : ProdutoImportado // com a retirada da palavra sealed da classe ProdutoImportado a mesma passou poder ser herdada 
    {
       
        public ProdutoImportadoChines(decimal preco, int qtdEstoque, decimal impostoimportacao): base(preco, qtdEstoque, impostoimportacao)
        {
        }

        
        public override decimal PrecoProdutoComTaxa()
        {
            return Preco + (Preco * ImpostoImportacao / 100) + (Preco * 0.2M);
        }

        /* Método ToString() na classe Object é virtual podendo ser (sobreposto ou reescrito) 
        em outras classes utilizando a palavra override  */

        public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
        {//Aqui definimos como o objeto será retornado na forma de String
            return " Codigo do Produto importado Chines : " + _codprodutoimportado +
                "- Nome : " + _nome +
                "- Preço sem a taxa : $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "- Taxa de Imposto de importação Chines :  " + ImpostoImportacao.ToString(CultureInfo.InvariantCulture) + " % " +
                "- Preço com a taxa : $ " + PrecoProdutoComTaxa().ToString("F2", CultureInfo.InvariantCulture) +
               "- Quantidade em estoque : " + QtdEstoque +
               "- Valor total em estoque : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

        /* * ToString - converte um objeto para String  
        * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/



    }
}
