using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class ProdutoImportado : Produto    // Basta usar a notação : e o C# automaticamente herda os métodos e atributos da classe pai.
    {
        private protected int _codprodutoimportado;

        public double ImpostoImportacao { get; private set; }

        public ProdutoImportado(double preco, int qtdEstoque, double impostoImportacao) : base(preco, qtdEstoque)
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

        public override double ValorTotalEmEstoque()
        {
            return PrecoProdutoComTaxa() * QtdEstoque;
        }

        public override double PrecoProdutoComTaxa()
        {
            return (Preco * 0.15) + ImpostoImportacao + Preco;
            // (base.PrecoProdutoComTaxa()*0.15) + ImpostoImportacao +base.PrecoProdutoComTaxa();
        }



    }
}
