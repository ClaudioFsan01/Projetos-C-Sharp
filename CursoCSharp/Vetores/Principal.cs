﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vetores
{
    class Principal
    {
        static void Main(string[] args)
        {
            Produto p = null;
            Produto[] produtos = null;
            int op = 0, i=0;

            //ManipularVetores mv = new ManipularVetores();
           // mv.criarVetorInteiros();
           // mv.criarVetorDouble();
          //  mv.criarVetorString();

            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        try
                        {

                            do
                            {
                                CadastrarProduto(p, produtos, i);

                                Console.WriteLine("Deseja continuar o cadastro de produto (1-sim) (2-não) \n");
                                op = int.Parse(Console.ReadLine());
                                i++;
                            } while (op != 2);

                            ExibirArrayProdutos(produtos);


                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }                       
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                       

                        break;
                    case 2:


                        break;

                    case 3:

                        break;

                    case 4:

                      
                        break;

                    case 5:

                        break;

                    case 6:
                        Console.WriteLine(" Programa encerrado ! \n");
                        break;
                }


            } while (op != 6);

            Console.Read();

        }


        public static int Menu()
        {
            Console.WriteLine(" Menu de Opções : \n" +
                "1- Cadastrar Produto : \n" +
                "2- Adicionar Produto : \n" +
                "3- Remover Produto : \n" +
                "4- Relatorio de produtos \n"+
                "5-  "+
                "6- Sair \n");

            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarProduto(Produto p, Produto[] produtos, int pos)
        {
           
                Console.WriteLine(" Entre com os dados do Produto \n");

              
                Console.WriteLine(" Entre com o preço do produto :");
                double preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // p.SetPreco(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine(" Entre com a quantidade do estoque do produto :");
                int qtdEstoque = int.Parse(Console.ReadLine());
                //p.SetQtdEmEstoque(int.Parse(Console.ReadLine()));

                p = new Produto(preco, qtdEstoque);

               Console.WriteLine(" Entre com o nome do produto :");
               p.Nome = Console.ReadLine();

              if(produtos == null)
              {
                produtos = RetornarArrayProdutos();
              }
            produtos[pos] = p;

            //MostrarProduto(p);
            ExibirProduto(p);
                //AdicionarProduto(p);
               // RemoverProduto(p);
           
           
        }

        public static Produto[] RetornarArrayProdutos()
        {
            Console.WriteLine(" Entre com o tamanho n do vetor : \n");
            int n = int.Parse(Console.ReadLine());

            return new Produto[n];
        }

        public static void ExibirArrayProdutos(Produto[] produtos)
        {
            Console.WriteLine(" Relatorio de produtos : \n");
            for (int i=0; i< produtos.Length; i++)
            {
                Console.WriteLine(produtos[i].Nome);
                Console.WriteLine(produtos[i].Preco);
                Console.WriteLine(produtos[i].QtdEstoque);
                Console.WriteLine("--------------------");
                Console.WriteLine("--------------------");

            }
        }

        public static void AdicionarProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será adicionada ao estoque : \n");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            //MostrarProduto(p);
            ExibirProduto(p);

        }

        public static void RemoverProduto(Produto p)
        {
            Console.WriteLine(" Entre com a quantidade que será removida do estoque : \n");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            MostrarProduto(p);
        }
       
         public static void ExibirProduto(Produto p)
         {
            Console.WriteLine("Dados do Produto : \n");
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.QtdEstoque);
            //Console.Write("\n");



        }


        public static void MostrarProduto(Produto p)
        {
            Console.WriteLine(" Produto :" + p);
            Console.WriteLine(" \n");
        }
    }
}
