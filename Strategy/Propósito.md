## Problema
Você decide criar uma aplicação para locação de livros em uma biblioteca. A determinação de valores consiste em um valor base acrescido de um valor calculado a partir do produto do tempo de locação por uma taxa.

Inicialmente parecia simples pois essa taxa era unificada, porém, veio a necessidade de catalogar os livros por faixas representadas por cores, diferenciando a porcentagem cobrada sobre o tempo locado. Com a inserção de cada faixa, você percebeu que a classe principal da locação iria ficando cada vez maior, deixando o código ilegível e complexo caso você quisesse alterar o percentual cobrado em outras taxas ou até adicionar mais uma faixa.

## Solução
O *Strategy* sugere que você defina uma interface e implemente todas as variações desse algoritmo através de classes separadas chamadas estratégias.

Temos então uma classe original, chamada *contexto*, que possui um campo que armazena a referência para uma dessas estratégias e delega o trabalho para um objeto ao invés de executá-lo por conta própria.

Assim, o contexto não seleciona o algoritmo, o cliente que passa a estratégia desejada para o contexto que então executa o algoritmo de acordo com essa estratégia selecionada. Lembrando que todas as estratégias implementam um mesmo método definido na interface, mudando de acordo com a sua variação.

Assim, o contexto torna-se independente dessas estratégias, sendo possível modificar ou adicionar novas estratégias sem modificar as existentes ou o código do contexto.

No projeto temos uma interface chamada **IFaixaDeCalculo** que possui um método que calcula o valor da locação de acordo com o tempo. Temos também um contexto chamado **CalculadoraDeLocacao** que recebe o objeto de locação (com tempo, nome do livro e o valor fixo) e a estratégia escolhida e executa o método implementado. Por fim, temos as estratégias que implementam o método da interface de acordo com sua própria porcentagem.