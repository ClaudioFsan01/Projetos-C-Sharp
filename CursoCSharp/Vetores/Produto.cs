
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetores
{
    class Produto
    {
      
       
        private String _nome;
        //private double _preco;
        public double Preco { get; private set; }
        //private int _qtdEstoque;
        public int QtdEstoque { get; private set; }

    

    public Produto() //Construtor padrão
    {
            
            QtdEstoque = 0;
    }

    public Produto(String nome, double preco) : this() 
    {
        _nome = nome;
            //_preco = preco;
            Preco = preco;
    }

    public Produto(String nome, double preco, int qtdEstoque) : this(nome, preco) 
    {
            //_qtdEstoque = qtdEstoque;
            QtdEstoque = qtdEstoque;
    }

      public Produto(double preco, int qtdEstoque)
      {
            if(preco>0 && qtdEstoque >= 0)
            {
                //_preco = preco;
                //_qtdEstoque = qtdEstoque;
                Preco = preco;
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
