/*fonte : https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic?view=netcore-3.1
 O namespace System.Collections.Generic contém interfaces e classes que definem coleções genéricas, 
 o que permite aos usuários criar coleções fortemente tipadas que fornecem melhor desempenho e segurança 
 de tipos do que coleções fortemente tipadas não genéricas. ex:

 CLASSES

List<T>	:Representa uma lista fortemente tipada de objetos que podem ser acessados por índice. Fornece métodos para pesquisar, 
classificar e manipular listas.
A classe List<T> implementa as interfaces : ICollection<T>  IEnumerable<T>  IList<T>  IReadOnlyCollection<T>  IReadOnlyList<T> 
ICollection  IEnumerable  IList .
------------------------------------------------------------------------------
CollectionExtensions : Fornece métodos de extensão para coleções genéricas.

Comparer<T> : Fornece uma classe base para implementações da interface genérica IComparer<T>.

---------------------------------------------------------------------------------
LinkedList<T> : Representa uma lista duplamente vinculada. Implementa as interfaces :
ICollection<T>  IEnumerable<T>  IReadOnlyCollection<T>  ICollection  IEnumerable  IDeserializationCallback  ISerializable
Cada nó em um objeto de LinkedList<T> é do tipo LinkedListNode<T>. Como o LinkedList<T> está duplamente vinculado, 
cada nó aponta para o nó de Next e volta para o nó de Previous.
--------------------------------------------------------------

Queue<T> : Representa uma coleção primeiro a entrar, primeiro a sair de objetos (FILA).
public class Queue<T> : implementa as interfaces System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IReadOnlyCollection<T>, System.Collections.ICollection
-------------------------------------------------------------------

Ambas as classes List<T> e LinkedList<T> implementam a interface ICollection<T> 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Listas
{
    class Principal
    {
       

        static void Main(string[] args)
        {
            
            GerenciarProdutos gp = new GerenciarProdutos();
            Produto produto = null;
            TotalizadorDeTributoProdutoImportado TTProdutoImportado = null;
            int op = 0, i = 0;


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
                               
                                CadastrarProduto(produto, gp);

                                Console.WriteLine("Deseja cadastrar outro produto (1-sim) (2-não) \n");
                                op = int.Parse(Console.ReadLine());
                               
                            } while (op != 2);

                           // ExibirArrayProdutos(produtos, produto);


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

                       // TotalDeTributoDeImportados(produtos,TTProdutoImportado);
                        exibirTotalDeTributoDeImportados(TTProdutoImportado);                 


                        break;

                    case 3:

                        break;

                    case 4:


                        break;

                    case 5:
                        try
                        {
                            ExibirRelatorio(gp);
                        }         
                        catch (ColecaoVaziaException e)
                        {
                            Console.WriteLine(e.Mensagem);
                        }

                        break;

                    case 6:

                        Console.WriteLine(" Total de tipos de produtos criados : "+Produto.ControleDeTiposProdutos);
                        exibirTotalDeTributoDeImportados(TTProdutoImportado);
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
                "2- Total de tributos de importação arrecadado: \n" +
                "3- Adicionar Produto  : \n" +
                "4- Remover Produto \n" +
                "5- Relatorio de produtos  " +
                "6- Sair \n");

            return int.Parse(Console.ReadLine());
        }

        public static void CadastrarProduto(Produto produto, GerenciarProdutos gp)
        {
            Console.WriteLine(" Cadastrar Produto (1- Nacional) ou (2- Importado) (3- Importado Chines)\n");
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
                Console.WriteLine(" Entre com o valor da taxa de imposto(%) do produto nacional :");
                decimal impostoNacional = decimal.Parse(Console.ReadLine());
                
                produto = new ProdutoNacional(preco, qtdEstoque, impostoNacional);
            }
            else
            {
                if(opcao == 2)
                {
                    Console.WriteLine(" Entre com o valor da taxa de imposto(%) do produto importado :");
                    decimal impostoImportado = decimal.Parse(Console.ReadLine());

                  
                    produto = new ProdutoImportado(preco, qtdEstoque, impostoImportado);

                }
                else
                {

                    Console.WriteLine(" Entre com o valor da taxa de imposto(%) do produto importado Chines :");
                    decimal impostoImportadoChines = decimal.Parse(Console.ReadLine());

                  

                    produto = new ProdutoImportadoChines(preco, qtdEstoque, impostoImportadoChines);


                }


            }           

            Console.WriteLine(" Entre com o nome do produto :");
            produto.Nome = Console.ReadLine();

          
            //MostrarProduto(p);
            ExibirProduto(produto);
            InserirProduto(produto,gp);
            //AdicionarProduto(produto);
            // RemoverProduto(p);

        }

        public static void InserirProduto(Produto produto, GerenciarProdutos gp)
        {
            Console.WriteLine(" Deseja inserir o tipo de Produto (1-Lista simples) (2-Lista Duplamente Vinculada) (3- Fila): \n");
             gp.InserirTipoDeProduto(produto, int.Parse(Console.ReadLine()));
            //MostrarProduto(p);
            //ExibirProduto(produto);

        }


        public static void AdicionarProduto(Produto produto, GerenciarProdutos gerenciarProdutos)
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

        static void ExibirRelatorio(GerenciarProdutos gp)
        {
            Console.WriteLine(" Deseja exibir relatorio de (1-Lista simples) (2-Lista Duplamente Vinculada) (3- Fila): \n");
            int op = int.Parse(Console.ReadLine());
            if (op==1){

                ExibirColecao(gp.RetornarListaSimples());          
              
                    //Console.WriteLine(" Lista simples vazia !");             
                
            }
            else
            {
                if(op == 2)
                {                    
                        ExibirColecao(gp.RetornarListaDuplamenteVinculada());                   
                        //Console.WriteLine(" Lista duplamente vinculada vazia !");                    
                   
                }
                else
                {                 
                    
                        ExibirFila(gp.RetornarFila());           
                    
                        //Console.WriteLine(" Fila vazia !");                   
                    
                }
            }
        }

        public static void ExibirColecao(ICollection<Produto> colecao) //Ambas as classes List<T> e LinkedList<T> implementam a interface ICollection<T>
        {
            if(colecao is LinkedList<Produto>)
            {
                Console.WriteLine("Deseja exibir do (1-inicio) ou (2-final) ");
                if (int.Parse(Console.ReadLine()) == 1)
                {
                    MostrarColecao(colecao);
                }
                else
                {
                    colecao.Reverse<Produto>(); // inverte a ordem dos elementos 
                    MostrarColecao(colecao);
                }

            }
            else
            {
                MostrarColecao(colecao);
            }             
            
        }

        public static void MostrarColecao(ICollection<Produto> colecao)
        {
            foreach (Produto produto in colecao)
            {
                Console.WriteLine(produto.ToString());
                Console.WriteLine("------------------");
            }
        }
        /*
        public static void ExibirListaDuplamenteVinculados(LinkedList<Produto> listaDuplamenteVinculados)
        {
            foreach (Produto produto in listaDuplamenteVinculados)
            {
                Console.WriteLine(produto.ToString());
            }
        }*/

        public static void ExibirFila(Queue<Produto> fila)  // A classe Queue<T> não implementa a interface ICollection<T>
        {
            foreach (Produto produto in fila)
            {
                Console.WriteLine(produto.ToString());
                Console.WriteLine("------------------");
            }
        }

        public static void TotalDeTributoDeImportados(Produto [] produtos, TotalizadorDeTributoProdutoImportado TTProdutoImportado)
        {
            foreach (Produto produto in produtos)
            {
                if(!(produto is ProdutoNacional)) /*verificando se o objeto não é um ProdutoNacional */
                {/*caso não seja um produto nacional é realizado um casting da variavel produto*/

                    ITributoDeProdutoImportado produtoImportado = produto as ITributoDeProdutoImportado;
                    TTProdutoImportado.AcumuladorDeTributoProdutoImportado(produtoImportado);

                    /* No nosso caso apenas a  classe ProdutoNacional  não implementa a interface ITributoDeProdutoImportado, portanto os demais objetos 
                     são ITributoDeProdutoImportado por isso é feito o casting acima.*/

                }
                
            }
        }

        public static void exibirTotalDeTributoDeImportados(TotalizadorDeTributoProdutoImportado TTProdutoImportado)
        {
            Console.WriteLine("Valor total de tributo de importação arrecadado : "+TTProdutoImportado.AcumuladorTributoProdImportado);
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

        /*
        
        public static void UpcastingDowcasting(Produto pn, Produto pi)
        {
            // DOWCASTING 

             ProdutoNacional pn2 = pn; nesse caso ocorre um erro pois o compilador não sabe que a variavel pn 
           do tipo Produto faz referencia a um  objeto do tipo ProdutoNacional sendo necessario casting.
            // fazendo dowcasting 
            ProdutoNacional pn2 = (ProdutoNacional)pn;

            ExibirProduto(pn2);

            ProdutoImportado pi2 = (ProdutoImportado)pi;

            ExibirProduto(pi2);

           É necessario muito cuidado ao fazer DOWCASTING pois devemos verificar o tipo do objeto ao qual a variavel faz referencia.
             * Caso contrario pode ocorrer erro. ex:*/

            /* ProdutoImportado pn3 = (ProdutoImportado)pn;  erro pois nesse caso a variavel pn não faz referencia a um objeto do tipo ProdutoImportado
             e sim a um objeto do tipo ProdutoNacional. Nesse caso é necessario fazer uma verificação confome o exemplo a seguir :

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



        } */

       
       
    }
}

