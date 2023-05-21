# Builder

# ✍🏻 Definição

O *State*, ou Estado, é um padrão comportamental que permite que você altere o comportamento de um objeto a partir do seu estado. É como se o objeto pudesse ser composto de diversas classes, alternando entre elas de acordo com o estado atual.

O padrão State é intimamente relacionado com o conceito de uma *Máquina de Estado Finito*.


# 🏚️Estrutura

## 💡 Propósito

### 🧩 Problema

Você cria uma aplicação para controlar o status e a pontuação de um jogador em um determinado jogo. O player possui uma pontuação inicial, podendo adquirir pontuação extra durante o jogo, além de resgatar prisioneiros, o que garante uma pontuação bônus de acordo com a quantidade de prisioneiros resgatados. Além disso, o jogador muda de estado quando zera, perde ou finaliza o game. Sendo assim, você deve controlar essas mudanças de estado. Definindo regras para que o player não possa aplicar determinadas ações de acordo com seu estado.

### 🧠 Solução

Criaremos um objeto chamado Player, que conterá todas as informações do jogador.

As alterações nas informações do jogador serão feitas a partir de seu estado e das mudanças de estado.

Para aplicarmos o padrão *State*, primeiro criaremos uma interface chamada ***IEstadosPlayer***, que conterá as definições dos métodos a serem manipulados pelas classes dos estados.

Teremos na classe Player um atributo EstadoAtual, que será do tipo da interface criada, e também os métodos instanciados nessa interface, executando o próprio método do estado atual.

Cada classe de estado então terá uma implementação única de acordo com a situação representada.

Os estados serão: *EmAndamento* (player jogando), *Zerado* (player completa o jogo), *Perdido* (player perde o jogo) e *Finalizado* (player encerra o jogo).

Na classe Player, os atributos iniciais são definidos (prisioneiros salvos = 0 e estado atual = EmAndamento), e os demais passados como parâmetro no instanciamento (nome e pontuação).

Ao alterar o estado, a classe passará então a agir de acordo com estado definido.

