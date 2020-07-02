/*
 Para resolver os problemas do array, podemos trabalhar com uma classe do C# chamada List . Para
utilizarmos uma lista dentro do código precisamos informar qual é o tipo de elemento que a lista
armazenará. ex :
// cria uma lista que armazena o tipo Produto
List<Produto> lista = new List<Produto>(); 

Da mesma forma que criamos a lista de Produto, também poderíamos criar uma lista de números
inteiros ou de qualquer outro tipo do C#. Essa lista do C# armazena seus elementos dentro de um array.

funções :

Add() adiciona elemento
Remove() // remove pelo elemento
RemoveAt() // remove pelo índice

Se quisermos saber quantos elementos existem em nosso List , podemos simplesmente ler a
propriedade Count, Size(), GetTotal().

Também podemos descobrir se um elemento está dentro de uma lista:
ex: lista.Contains(c1); // true ou false
 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Listas
{
    public abstract class Produto : IComparable<Produto> // classe abstrata Produto não pode ser instanciada, somente suas classes filhas não abstratas.
    {
             
       
        private protected string _nome;  // Modificador de acesso private protected permite que a propria classe e suas subclasses(no mesmo projeto) acessem o atributo

        public static int ControleDeTiposProdutos { get; private set; }
       
        public decimal Preco { get; private protected set; }
        
        public int QtdEstoque { get; private protected set; }

    

        public Produto() //Construtor padrão
        {
            
            QtdEstoque = 0;
            ControleDeTiposProdutos++;
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
                throw new ArgumentException("Preço invalido !");
                //Console.WriteLine("Preço invalido ! \n");
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
                Console.WriteLine(" QtdEstoque com valor invalido ! ");
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

                     
       

        public abstract decimal PrecoProdutoComTaxa();  


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
        //ordenando a lista pelo nome       

        public int CompareTo(Produto produto)
        {
            return Nome.CompareTo(produto.Nome);
        }

       

       
}
}
