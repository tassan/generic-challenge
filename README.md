# Desafio 1: Implementando uma Pilha Genérica 

## Descrição:
Neste desafio, seu objetivo é implementar uma classe genérica chamada `GenericStack<T>` que simule uma pilha (stack) utilizando um array interno para armazenar os elementos. A classe deve fornecer os métodos típicos de uma pilha, como Push, Pop, Peek e Count.

## Requisitos:

1. Implemente a classe genérica `GenericStack<T>` com os seguintes métodos e propriedades:
* `Push(T item)`: Adiciona um item no topo da pilha.
* `Pop()`: Remove e retorna o item do topo da pilha. Lança uma exceção se a pilha estiver vazia.
* `Peek()`: Retorna o item do topo da pilha sem removê-lo. Lança uma exceção se a pilha estiver vazia.
* `Count`: Propriedade de somente leitura que retorna o número de elementos na pilha.
2. A classe deve ser capaz de lidar com diferentes tipos de elementos.

## Dicas:

* Use um array interno para armazenar os elementos da pilha.
* Mantenha um contador para rastrear o número de elementos na pilha.
* Certifique-se de tratar casos em que a pilha está vazia ao implementar Pop e Peek.

## Exemplo de Uso:

```csharp
GenericStack<int> intStack = new GenericStack<int>();
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

Console.WriteLine(intStack.Peek()); // Deve imprimir 30
Console.WriteLine(intStack.Pop());  // Deve imprimir 30
Console.WriteLine(intStack.Pop());  // Deve imprimir 20
Console.WriteLine(intStack.Count);  // Deve imprimir 1
```

# Desafio: Transformando uma Pilha Genérica em uma Fila Genérica

## Descrição:
Neste desafio, você irá expandir sua classe genérica `GenericStack<T>` para criar uma classe genérica chamada `GenericQueue<T>`, que representará uma fila (queue) utilizando um array interno para armazenar os elementos. A ideia é que você estenda a funcionalidade anterior da pilha genérica para suportar operações de fila.

## Requisitos:

1. Utilize a classe genérica `GenericStack<T>` implementada no desafio anterior como base para a implementação da `GenericQueue<T>`.
2. Implemente a classe genérica `GenericQueue<T>` com os seguintes métodos e propriedades:
* `Enqueue(T item)`: Adiciona um item no final da fila.
* `Dequeue()`: Remove e retorna o item do início da fila. Lança uma exceção se a fila estiver vazia.
3. A classe deve ser capaz de lidar com diferentes tipos de elementos.

## Dicas:

* Você pode usar dois stacks (pilhas) para implementar a fila. Um dos stacks será usado para enfileirar novos elementos e o outro para desenfileirar elementos.
* Ao desenfileirar elementos, verifique se o stack de desenfileirar está vazio. Se estiver, transfira os elementos do stack de enfileirar para o stack de desenfileirar na ordem inversa.

## Exemplo de Uso:

```csharp
GenericQueue<int> intQueue = new GenericQueue<int>();
intQueue.Enqueue(10);
intQueue.Enqueue(20);
intQueue.Enqueue(30);

Console.WriteLine(intQueue.Dequeue()); // Deve imprimir 10
Console.WriteLine(intQueue.Dequeue()); // Deve imprimir 20

```