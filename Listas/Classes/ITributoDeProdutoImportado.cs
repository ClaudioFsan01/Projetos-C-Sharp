/*
 Nem todas os produtos  possui taxa de importação como por exemplo : Os Produtos nacionais.
 Portando não faz sentido inserir um método abstrato que calcula o valor do tributo de importação na classe pai Produto
 pois assim a classe ProdutoNacional herdaria esse método sendo obrigada a implementalo. Mas não faz sentido
 inserirmos esse método nas classes filhas ProdutoImportado e ProdutoImportadoChines pois assim não usariamos
 o recurso Polimorfismo. Precisamos achar uma maneira de "achar um pai em comum" apenas para as classes filhas 
  ProdutoImportado e ProdutoImportadoChines. Mas o que podemos fazer é dizer para o compilador que garantiremos 
  a existência do método que calcula o valor do tributo de importação  nessas classes filhas e nas 
  proximas que necessitarem desse método. 
  Como fazemos isso? Simples. Fazemos a classe "assinar" um contrato! Nesse caso, queremos assinar o
contrato que fala que essa classe é Tributável de taxa de importação. Contratos no C# são conhecidos como interfaces. A declaração
de uma interface é praticamente igual a de uma classe, porém utilizamos a palavra interface ao invés
de class .

A convenção de nomes do C# para uma interface é seguir a mesma convenção de nomenclatura de
classes porém com um I no começo do nome.

Dentro da interface, queremos colocar a declaração do método CalcularTributoDeImportacao() . Métodos declarados em uma
interface nunca possuem implementação e sempre são públicos.
 
Pra quê interfaces?
• Para criar sistemas com baixo acoplamento e flexíveis
 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public interface ITributoDeProdutoImportado
    {
        decimal CalcularTributoDeImportacao();
    }
}
