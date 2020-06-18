/* UPCASTING 
 * Ocorre quando uma variavel do tipo da Super classe (classe mae) faz referencia a um objeto 
 * do tipo da subclasse (classe filha), ocorrendo nesse caso POLIMORFISMO. 
 * ex : Produto produto = new ProdutoImportado();
 * 
 * DOWCASTING (processo inverso)
  Ocorre quando uma variavel do tipo da subclasse (classe filha) faz referencia a um objeto 
 * do tipo da Super classe (classe mae) , ocorrendo nesse caso POLIMORFISMO. Porem nesse caso 
 * é necessario fazer um CASTING.
 * 
 * ex : ProdutoImportado pi = (ProdutoImportado)produto;  Foi necessario fazer o casting (ProdutoImportado)produto pois 
 * a variavel produto é do tipo da Super classe Produto e o compilador antes da execução não sabe q essa variavel 
 * está fazendo referencia para um objeto do tipo ProdutoImportado ocorrendo assim um erro sendo necessario fazer o casting. 
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Heranca
{
    class Produto
    {
             
       
        private protected string _nome;  // Modificador de acessor private protected permite que a propria classe e suas subclasses acessem ao atributo
        //private double _preco;
        public double Preco { get; private protected set; }
        //private int _qtdEstoque;
        public int QtdEstoque { get; private protected set; }

    

    public Produto() //Construtor padrão
    {
            
            QtdEstoque = 0;
    }

    public Produto(double preco) : this() 
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
     
        /*
    public Produto(double preco, int qtdEstoque) : this(preco) 
    {
            //_qtdEstoque = qtdEstoque;
            QtdEstoque = qtdEstoque;
    }*/

      public Produto(double preco, int qtdEstoque) : this(preco)
      {
            if(qtdEstoque >= 0)
            {
                //_preco = preco;
                //_qtdEstoque = qtdEstoque;               
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
    

    public double ValorTotalEmEstoque()
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
        //

        public void CastingDowCasting()
        {


        }

    
    public override string ToString() //Retorna uma cadeira de caracteres que representa o objeto atual 
    {//Aqui definimos como o objeto será retornado na forma de String
        return _nome +
            ", $ " +
            Preco.ToString("F2", CultureInfo.InvariantCulture) +
            " " + QtdEstoque +
            " unidade, total : $ " +
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

    }

    /* * ToString - converte um objeto para String  
    * Utilizando o método ToString podemos escolher como o objeto será representado na forma de String*/

}
}
