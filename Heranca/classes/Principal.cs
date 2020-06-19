using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Heranca
{
    class Principal
    {
        static void Main(string[] args)
        {

            // ExecutarCalculadora();

           // Produto pn = new ProdutoNacional(20.00, 2, 0.02);
           // Produto pi = new ProdutoImportado(50.00, 1, 0.5);
           // UpcastingDowcasting(pn, pi);

            Produto produto = null;
            Produto[] produtos = CriarArrayProdutos();
            int op = 0, i = 0;
          

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
                                //p = new ProdutoNacional();
                                CadastrarProduto(produto, produtos, i);

                                Console.WriteLine("Deseja cadastrar outro produto (1-sim) (2-não) \n");
                                op = int.Parse(Console.ReadLine());
                                i++;
                            } while (op != 2);

                            ExibirArrayProdutos(produtos, produto);


                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (IndexOutOfRangeException e)
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
                        ExibirArrayProdutos(produtos, produto);

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
                "2-  : \n" +
                "3- Adicionar Produto  : \n" +
                "4- Remover Produto \n" +
                "5- Relatorio de produtos  " +
                "6- Sair \n");

            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarProduto(Produto produto, Produto[] produtos, int pos)
        {
            Console.WriteLine(" Cadastrar Produto (1- Nacional) ou (2- Importado)\n");
            int opcao = int.Parse(Console.ReadLine()); 

            Console.WriteLine(" Entre com os dados do Produto \n");
                       
            Console.WriteLine(" Entre com o preço do produto :");
            decimal preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // p.SetPreco(Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(" Entre com a quantidade do estoque do produto :");
            int qtdEstoque = int.Parse(Console.ReadLine());
            //p.SetQtdEmEstoque(int.Parse(Console.ReadLine()));

            if(opcao == 1)
            {
                Console.WriteLine(" Entre com o valor da taxa de imposto do produto nacional :");
                decimal impostoNacional = decimal.Parse(Console.ReadLine());
                string.Format("{0:00.00}", impostoNacional);
                produto = new ProdutoNacional(preco, qtdEstoque, impostoNacional);
            }
            else
            {
                Console.WriteLine(" Entre com o valor da taxa de imposto do produto importado :");
                decimal impostoImportado = decimal.Parse(Console.ReadLine());

                String.Format("{0:00.00}", impostoImportado);

                produto = new ProdutoImportado(preco, qtdEstoque, impostoImportado);

            }           

            Console.WriteLine(" Entre com o nome do produto :");
            produto.Nome = Console.ReadLine();


            if (pos < produtos.Length)
            {
                produtos[pos] = produto;

            }
            else
            {
                throw new IndexOutOfRangeException(" Operação invalida ! Tentativa de adicionar quantidade de produtos superior à capacidade de estoque. \n");
            }


            //MostrarProduto(p);
            ExibirProduto(produto);
            //AdicionarProduto(p);
            // RemoverProduto(p);
            /*
            Console.WriteLine(" Deseja cadastrar (1-Produto Nacional) ou (2- Produto Importado) ?\n");
            if (int.Parse(Console.ReadLine()) ==1)
            {
                p =  OpcaoCadastro(p, produtos, pos);
            }
            else
            {
            }*/

        }
        /*
        public static void OpcaoCadastro(Produto p, Produto[] produtos, int pos)
        {
           
        }*/

        public static Produto[] CriarArrayProdutos()
        {
            Console.WriteLine(" Entre com a quantidade de produtos que serão cadastrados : \n");
            int n = int.Parse(Console.ReadLine());

            return new Produto[n];
        }

        public static void ExibirArrayProdutos(Produto[] produtos, Produto produto)
        {
            Console.WriteLine(" Relatorio de produtos : \n");
            for (int i = 0; i < produtos.Length; i++)
            {

                produto = produtos[i];
                ExibirProduto(produto);

                /*
                Console.WriteLine(produtos[i].Nome);
                Console.WriteLine(produtos[i].Preco);
                Console.WriteLine(produtos[i].QtdEstoque);
                Console.WriteLine("--------------------");
                Console.WriteLine("--------------------");
                */
            }
        }

        /*
        public static void ExecutarCalculadora(){

            //Console.WriteLine(Calculadora.Sum(new int[] { 1, 4, 5, 10})); sem usar  a palavra params no parametro do método Sum na classe Calculadora
            Console.WriteLine(Calculadora.Sum( 1, 4, 5, 10 )); // utilizando a palavra params no parametro do método Sum na classe Calculadora

            // Console.WriteLine(Calculadora.Sum(new double[] { 2.5, 4.5, 13.4 })); sem usar  a palavra params no parametro do método Sum na classe Calculadora
            Console.WriteLine(Calculadora.Sum( 2.5, 4.5, 13.4 ));
            //Console.WriteLine(Calculadora.Sum(new String[] { "Claudio", "Fatima", "Zuila", "Bibiu" }));
            Console.WriteLine(Calculadora.Sum("Claudio", "Fatima", "Zuila", "Bibiu" ));

            int x = 10;

            Calculadora.Triple(ref x); // informando no parametro com a palavra ref a variavel que será referenciada 

            Console.WriteLine(x);

            int valor = 10;
            int result; // com o modificador out não é obrigatorio iniciar a variavel resul

            Calculadora.Triple(valor, out result);

            Console.WriteLine(result);


        }
        */

        public static void UpcastingDowcasting(Produto pn, Produto pi)
        {
            // DOWCASTING 

            /* ProdutoNacional pn2 = pn; nesse caso ocorre um erro pois o compilador não sabe que a variavel pn 
           do tipo Produto faz referencia a um  objeto do tipo ProdutoNacional sendo necessario casting. */
            // fazendo dowcasting 
            ProdutoNacional pn2 = (ProdutoNacional)pn;

            ExibirProduto(pn2);

            ProdutoImportado pi2 = (ProdutoImportado)pi;

            ExibirProduto(pi2);

            /*É necessario muito cuidado ao fazer DOWCASTING pois devemos verificar o tipo do objeto ao qual a variavel faz referencia.
             * Caso contrario pode ocorrer erro. ex:*/

            /* ProdutoImportado pn3 = (ProdutoImportado)pn;  erro pois nesse caso a variavel pn não faz referencia a um objeto do tipo ProdutoImportado
             e sim a um objeto do tipo ProdutoNacional. Nesse caso é necessario fazer uma verificação confome o exemplo a seguir : */

            //verificando o tipo do objeto à qual a variavel faz referencia com a palavra (is)

            if (pn is ProdutoImportado)
            {
                ProdutoImportado pi3 = (ProdutoImportado)pn;
            }
            else
            {
                Console.WriteLine(" Erro, a variavel pn do tipo Produto não faz referencia a um objeto do tipo ProdutoImportado ");
            }

            if(pi is ProdutoNacional)
            {
                ProdutoNacional pn3 = (ProdutoNacional)pi;
            }
            else
            {
                Console.WriteLine(" Erro, a variavel pi do tipo Produto não faz referencia a um objeto do tipo ProdutoNacional ");
            }


                       
            if(pn is ProdutoNacional)
            {
                // forma opcional de fazer o casting(neste caso dowcasting) utilizando a palavra (as)
                // ProdutoNacional pn4 = (ProdutoNacional)pn;
                ProdutoNacional pn4 = pn as ProdutoNacional;
                ExibirProduto(pn4);
            }
            else
            {
                Console.WriteLine(" Erro, a variavel pn do tipo Produto não faz referencia a um objeto do tipo ProdutoNacional ");
            }

            if(pi is ProdutoImportado)
            {
                //ProdutoImportado pi4 = (ProdutoImportado)pi;
                ProdutoImportado pi4 = pi as ProdutoImportado;
                ExibirProduto(pi4);
               // MostrarProduto(pi4);
            }
            else
            {
                Console.WriteLine(" Erro, a variavel pi do tipo Produto não faz referencia a um objeto do tipo ProdutoImportado ");
            }



        }

        public static void AdicionarProduto(Produto produto)
        {
            Console.WriteLine(" Entre com a quantidade que será adicionada ao estoque : \n");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            //MostrarProduto(p);
            ExibirProduto(produto);

        }

        public static void RemoverProduto(Produto produto)
        {
            Console.WriteLine(" Entre com a quantidade que será removida do estoque : \n");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            //MostrarProduto(p);
        }
       
        
         public static void ExibirProduto(Produto produto)
         {
            Console.WriteLine("Dados do Produto : \n");

            Console.WriteLine(produto.ToString());

            //Console.Write("\n");
        }
         
        /*
        public static void MostrarProduto(Produto p)
        {
            Console.WriteLine(" Produto :" + p);
            Console.WriteLine(" \n");
        }*/
    }
}

