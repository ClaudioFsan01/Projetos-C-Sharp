/*Classes abstratas
• São classes que não podem ser instanciadas
• É uma forma de garantir herança total: somente subclasses não
abstratas podem ser instanciadas, mas nunca a superclasse abstrata.

 Dessa forma, não podemos mais criar objetos do tipo Produto , mas podemos ainda usar variáveis do
tipo Produto, para referenciar objetos de outros tipos.

 Métodos abstratos 

 Podemos obrigar todas as classes filhas a sobrescreverem um método da classe mãe, basta declarar
 esse método com o modificador abstract na classe mãe(super classe) ao invés de virtual . Toda vez que marcamos um método
 com o modificador abstract , ele obrigatoriamente não pode ter uma implementação padrão:

 Podemos ter uma classe abstrata sem nenhum método abstrato, mas não o contrário. Se a classe tem
pelo menos um método abstrato, ela deve ser abstrata também pois como o método está incompleto, a
classe não está completa.
 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Polimorfismo
{
    public abstract class Produto // classe abstrata Produto não pode ser instanciada, somente suas classes filhas não abstratas.
    {
             
       
        private protected string _nome;  // Modificador de acesso private protected permite que a propria classe e suas subclasses(no mesmo projeto) acessem o atributo
       
        public decimal Preco { get; private protected set; }
        
        public int QtdEstoque { get; private protected set; }

    

        public Produto() //Construtor padrão
        {
            
            QtdEstoque = 0;
        }

        public Produto(decimal preco) : this() 
        {
            //_preco = preco;
            if(preco > 0)
            {
                Preco = preco;
            }
            else
            {
                Console.WriteLine("Preço invalido ! \n");
            }
          
        }
     
     
       public Produto(decimal preco, int qtdEstoque) : this(preco)
       {
            if(qtdEstoque >= 0)
            {
                          
                QtdEstoque = qtdEstoque;
            }
            else
            {
                Console.WriteLine(" Preco ou QtdEstoque com valor invalido ! ");
            }

       }
                
        // Properties customizada

            public String Nome
            {
             get { return _nome; }
              set
              {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine(" Nome invalido !");
                }

 
              }
            }



        //public double Preco { get { return _preco; } }



        // public int QtdEmEstoque { get { return _qtdEstoque; } }


        //Sobreposição ou sobrescrita
        //• É a implementação de um método de uma superclasse na subclasse
        /*Para que um método comum (não
        abstrato) possa ser sobreposto, deve
        ser incluído nele o prefixo "virtual.
        
        A palavra ( virtual ) em um método na super classe (classe pai) indica que o
        método pode ser sobreposto ou sobrescrito na subclasse (classe filha) com o uso da palavra override. "*/

       

        public abstract decimal PrecoProdutoComTaxa();  /*método com modificador abstract obriga todas as classes filhas da classe Produto
                                                       a sobrescreverem este método da classe mãe.
                                                       Toda vez que marcamos um método com o modificador abstract , ele obrigatoriamente não
                                                       pode ter uma implementação padrão.*/


        public virtual decimal ValorTotalEmEstoque()
        {
        return Preco * QtdEstoque;
        }

       public void AdicionarProdutos(int quantidade)
       {
            QtdEstoque += quantidade;
       }

       public void RemoverProdutos(int quantidade)
       {
         if (quantidade <= QtdEstoque)
         {
                QtdEstoque -= quantidade;
         }
         else
         {
            Console.WriteLine(" Quantidade no estoque menor que a solicitada ! \n");
         }

  
       }


       
}
}
