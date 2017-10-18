# SortedList e SortedDictionary

Enunciado
=========

Você entendeu mesmo as semelhanças e diferenças entre SortedList e SortedDictionary?

Assinale abaixo somente as alternativas CORRETAS:

A. As classes `SortedList` e `SortedDictionary` implementam a inteface `IDictionary<TKey, TValue>` [CORRETA].

	Isso aí! Ambos implementam a inteface `IDictionary<TKey, TValue>`.


B. `SortedList` contém 2 listas internas (a lista de chaves e a lista de valores).
Já `SortedDictionary` é mantida internamente como uma árvore binária balanceada. [CORRETA].

    Isso aí! `SortedList` é uma coleção chave-valor que mantém internamente 2 listas, sendo uma lista 
    para as chaves e outra lista para valores. A lista de chaves está sempre ordenada e seus elementos
    apontam para elementos da lista de valores
    Já num `SortedDictionary`, os elementos são mantidos internamente ordenados, através de uma árvore binária balanceada.

C. Um `SortedDictionary` é mais adequado que um `SortedList` se você precisa fazer alterações com frequência [CORRETA].

	Isso mesmo! Uma `SortedDictionary` é mais adequada se você precisa inserir/remover elementos com muita frequência, pois essas
    operações são otimizadas pela sua estrutura interna de árvore binária balanceada


D. A classe `SortedList` implementa `IList<T>` e `SortedDictionary` implementa inteface `IDictionary<TKey, TValue>`.

	Quase! Não deixe o nome de `SortedList` te enganar! Essas duas classes implementam a inteface `IDictionary<TKey, TValue>`.


E. `SortedList` mantém internamente uma lista única onde cada elemento é um par chave-valor.
Já um `SortedDictionary` é uma coleção chave-valor que mantém internamente 2 listas, sendo uma lista 
para as chaves e outra lista para valores.

	Ops! `SortedList` mantém 2 listas, e não apenas uma.
    Já num `SortedDictionary`, os elementos são mantidos numa árvore binária balanceada.


F. Um `SortedDictionary` é tão rápido quanto `SortedList` se você precisa fazer alterações com frequência.

Ops! A estrutura de árvore binária balanceada de um `SortedDictionary` permite que
essa coleção faça alterações de elementos (inserção/remoção) mais rapidamente.

