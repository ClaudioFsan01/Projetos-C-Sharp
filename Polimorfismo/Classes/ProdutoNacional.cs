using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Polimorfismo
{
    class ProdutoNacional : Produto // Basta usar a notação : e o C# automaticamente herda os métodos e atributos da classe pai.
    {
        private protected int _codprodutonacional;
        public decimal ImpostoNacional { get; private set; }

        public ProdutoNacional(decimal preco, int qtdEstoque, decimal impostoNacional) : base(preco, qtdEstoque)
        {//Palavra base : É possível chamar a implementação da superclasse usando a palavra base.            // usando  base(preco, qtdEstoque) o construtor na super classe Produto com o parametro (preco, qtdEstoque) será invocado            if(impostoNacional >= 0)
            {
                ImpostoNacional = impostoNacional;
            }
            else
            {
                throw new ArgumentException("Valor do imposto nacional inválido ! \n");
            }
            
        }

        //propriedade customizada 

        public int CodigoProdNacional
        {
            get { return _codprodutonacional; }
            set
            {
                if (value > 0)
                {
                    _codprodutonacional = value;
                }
                else
                {
                    Console.WriteLine(" Codigo do produto nacional inválido !");
                }
            }
        }

        public override decimal ValorTotalEmEstoque()
        {
            return PrecoProdutoComTaxa() * QtdEstoque;
        }

        public override decimal PrecoProdutoComTaxa()
        {
            return Preco + (Preco*ImpostoNacional/100); 
                // base.PrecoProdutoComTaxa()+ ImpostoNacional;
        }

       

        public override string ToString() 
        {
            return " Codigo do Produto nacional : " + _codprodutonacional +
                "- Nome : " + _nome +
                "- Preço sem a taxa : $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                "- Taxa de Imposto nacional : " + ImpostoNacional.ToString(CultureInfo.InvariantCulture) +" % "+
                "- Preço com a taxa : $ " + PrecoProdutoComTaxa().ToString("F2", CultureInfo.InvariantCulture)+
               "- Quantidade em estoque : " + QtdEstoque +
               "- Valor total em estoque : $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

      


    }
}
