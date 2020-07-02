/*https://docs.microsoft.com/pt-br/dotnet/api/system.icomparable-1.compareto?view=netcore-3.1
 * 
 * Namespace:
System.Collections.Generic
List<T>.Sort Método

Classifica os elementos ou uma parte dos elementos na List<T> usando a implementação IComparer<T> especificada ou padrão,
ou um delegado Comparison<T> fornecido para comparar os elementos de lista.

Sort() : Classifica os elementos em todo o List<T> usando o comparador padrão.
Chamar o método Sort resulta no uso do comparador padrão para o tipo de parte, e 
o método Sort é implementado usando um método anônimo.

Sort(IComparer<T>) : Classifica os elementos em todo o List<T> usando o comparador especificado.
-------------------------------------------------

IComparer<T> Interface 
Define um método que um tipo implementa para comparar dois objetos
<T> O tipo de objetos a serem comparados.Este parâmetro de tipo é contravariante. 
Isso significa que é possível usar o tipo especificado ou qualquer tipo menos derivado.

método : public int Compare (T x, T y);
Compara dois objetos e retorna um valor inteiro que indica se um é menor, igual ou maior do que o outro.
----------------------------------------------
IComparable<T>.CompareTo(T) Método
Compara a instância atual com outro objeto do mesmo tipo e retorna um inteiro -1 que indica se a instância atual precede, 
valor 1 caso a instancia atual segue, ou valor 0 caso ocorre na mesma posição da ordem de classificação do outro objeto.

Parâmetros
other
T
Um objeto para comparar com essa instância.

public int CompareTo (T other);
-------------------------------------------------

Nesse exemplo vou optar que a classe OrdenarColecaoPeloPreco , ao contrario da classe Produto que implementa a 
a interface IComparable<T>, implemente a interface IComparer<T>, pois neste caso a classe OrdenarColecaoPeloPreco
não extende a classe Produto assim não herdando a propriedade Preco. Por isso a escolha de implementar a interface 
IComparer<T> que possui o método Compare (T x, T y) que recebe no parametro dois objetos que serão comparados, 
o atual e outro da lista, sendo assim possivel acessar as propriedades de ambos.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class OrdenarColecaoPeloPreco : IComparer<Produto>
    {
        //Ambas as classes String, int , float , double e os demais tipos primitivos implementam a interface IComparable<T>

        //List<int> numeros = new List<int>();
        //List<double> numerosDouble = new List<double>();


                                    
        public int Compare(Produto produtoAtual, Produto produtoOutro)
        {
            return produtoAtual.Preco.CompareTo(produtoOutro.Preco);
        }
               




        /* criando a classe anonima 

          Instanciando a interface IComparer<T> e ao mesmo tempo implementando 
          o método public int Compare (T x, T y) no objeto instanciado. O uso das chaves {} permiti
          instanciar a interface IComparer<T>  ,criando assim, uma classe anonima.
          Dispensando assim a necessidade de criar uma classe Comparador que implementa a 
          interface IComparer<T> 

           * */
           /*
            IComparer<Produto> compararPreco = new IComparer<Produto>()
            {
                public int Compare(Produto produtoAtual, Produto produtoOutro)
                {    
                 return 
                }
            };*/
        /*
        public static void ListaString()
        {
            List<String> nomes = new List<String>();
            nomes.Add("Claudio");
            nomes.Add("Ana");
            nomes.Add("Beto");

            nomes.Sort();

            foreach(String nome in nomes)
            {
                Console.WriteLine(nome);  
            }
        }
        */
    }
}
