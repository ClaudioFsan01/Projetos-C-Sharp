using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class ProdutoNacional : Produto // Basta usar a notação : e o C# automaticamente herda os métodos e atributos da classe pai.
    {
        private protected int _codprodutonacional;
        public double ImpostoNacional { get; private set; }

        public ProdutoNacional(double preco, int qtdEstoque, double impostoNacional) : base(preco, qtdEstoque)
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

        public override double ValorTotalEmEstoque()
        {
            return PrecoProdutoComTaxa() * QtdEstoque;
        }

        public override double PrecoProdutoComTaxa()
        {
            return Preco + ImpostoNacional; 
                // base.PrecoProdutoComTaxa()+ ImpostoNacional;
        }

       


    }
}
