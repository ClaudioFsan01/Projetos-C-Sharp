using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class GerenciarProdutos
    {
        List<Produto> listarProduto = new List<Produto>();
        LinkedList<Produto> listaProdutoDuplamenteVinculados = new LinkedList<Produto>();
        Queue<Produto> filaProdutos = new Queue<Produto>();
       
        public GerenciarProdutos()
        {

        }

        public void InserirTipoDeProduto(Produto produto, int opcao)
        {
            if(opcao == 1)
            {
                listarProduto.Add(produto);
            }
            else
            {
                if(opcao == 2)
                {
                    Console.WriteLine("Deseja inserir (1- No inicio) ou (2-No final) ");
                    if (int.Parse(Console.ReadLine())==1)
                    {
                        listaProdutoDuplamenteVinculados.AddFirst(produto);
                    }
                    else
                    {
                        listaProdutoDuplamenteVinculados.AddLast(produto);
                    }
                    
                }
                else
                {
                    filaProdutos.Enqueue(produto);
                }
            }
        }

        public List<Produto> RetornarListaSimples()
        {
            return listarProduto;
        }

        public LinkedList<Produto> RetornarListaDuplamenteVinculada()
        {
            return listaProdutoDuplamenteVinculados;
        }

        public Queue<Produto> RetornarFila()
        {
            return filaProdutos;
        }
    }
}
