# SortedList e SortedDictionary

Enunciado
=========

Voc� entendeu mesmo as semelhan�as e diferen�as entre SortedList e SortedDictionary?

Assinale abaixo somente as alternativas CORRETAS:

A. As classes `SortedList` e `SortedDictionary` implementam a inteface `IDictionary<TKey, TValue>` [CORRETA].

	Isso a�! Ambos implementam a inteface `IDictionary<TKey, TValue>`.


B. `SortedList` cont�m 2 listas internas (a lista de chaves e a lista de valores).
J� `SortedDictionary` � mantida internamente como uma �rvore bin�ria balanceada. [CORRETA].

    Isso a�! `SortedList` � uma cole��o chave-valor que mant�m internamente 2 listas, sendo uma lista 
    para as chaves e outra lista para valores. A lista de chaves est� sempre ordenada e seus elementos
    apontam para elementos da lista de valores
    J� num `SortedDictionary`, os elementos s�o mantidos internamente ordenados, atrav�s de uma �rvore bin�ria balanceada.

C. Um `SortedDictionary` � mais adequado que um `SortedList` se voc� precisa fazer altera��es com frequ�ncia [CORRETA].

	Isso mesmo! Uma `SortedDictionary` � mais adequada se voc� precisa inserir/remover elementos com muita frequ�ncia, pois essas
    opera��es s�o otimizadas pela sua estrutura interna de �rvore bin�ria balanceada


D. A classe `SortedList` implementa `IList<T>` e `SortedDictionary` implementa inteface `IDictionary<TKey, TValue>`.

	Quase! N�o deixe o nome de `SortedList` te enganar! Essas duas classes implementam a inteface `IDictionary<TKey, TValue>`.


E. `SortedList` mant�m internamente uma lista �nica onde cada elemento � um par chave-valor.
J� um `SortedDictionary` � uma cole��o chave-valor que mant�m internamente 2 listas, sendo uma lista 
para as chaves e outra lista para valores.

	Ops! `SortedList` mant�m 2 listas, e n�o apenas uma.
    J� num `SortedDictionary`, os elementos s�o mantidos numa �rvore bin�ria balanceada.


F. Um `SortedDictionary` � t�o r�pido quanto `SortedList` se voc� precisa fazer altera��es com frequ�ncia.

Ops! A estrutura de �rvore bin�ria balanceada de um `SortedDictionary` permite que
essa cole��o fa�a altera��es de elementos (inser��o/remo��o) mais rapidamente.

