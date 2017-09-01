PARA SABER MAIS
===============

A classe genérica `SortedDictionary` é uma árvore de busca binária com "comportamento de recuperação de dados"
expresso na notação de complexidade `O(log n)`, onde n é o número de elementos no dicionário.

Sob esse aspecto, ela é similar à classe genérica `SortedList`, e as duas possuem complexidade de recuperação equivalente: `O(log n)`

Porém, `SortedDictionary` possui operações de inserção e remoção mais rápidas, porque essas operações em `SortedDictionary` são `O(log n)`,
enquanto as mesmas operações possuem complexidade `O(n)`.

[Classe SortedDictionary](https://msdn.microsoft.com/pt-br/library/f7fta44c.aspx) (MSDN - em inglês)

[Complexidade de Tempo: Notação Grande-O](https://pt.wikipedia.org/wiki/Grande-O) (Wikipedia - em português)