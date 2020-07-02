/*A classe OrdenarColecaoPelaQuantidade1 implementa a interface IComparer<Produto> sendo obrigatorio
 * a implementação do método Compare(Produto produtoAtual, Produto produtoOutro) que recebe dois objetos
 * que serão comparados. Neste exemplo serão comparados dois tipos interios. A propriedade 
  QtdEstoque é do tipo primitivo inteiro. O Int Struct implementa a interface IComparable que possui 
  o método CompareTo() que recebe no parametro o outro tipo inteiro que será comparado com o inteiro atual.
  
  Os Struct int, double, decimal, flout, string etc... não implementam a interface IComparer<> mas 
  todos esses implementam a interface IComparable motivo esse que no exemplo é possivel acessar o método 
  CompareTo() e não o método Compare() para comparar dois tipos inteiros.
   
   */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class OrdenarColecaoPelaQuantidade1 : IComparer<Produto>
    {
        public int Compare(Produto produtoAtual, Produto produtoOutro)
        {
            return produtoAtual.QtdEstoque.CompareTo(produtoOutro.QtdEstoque);
        } 
    }
}
