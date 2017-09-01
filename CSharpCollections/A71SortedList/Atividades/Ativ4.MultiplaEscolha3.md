# Titulo do Exercício

Enunciado
=========

Você sabe como um `SortedList` funciona internamente? 

A. É um dicionário que implementa a interface `IDictionary <TKey, TValue>` [CORRETA]

	Isso aí! A classe `SortedList` funciona como um dicionário e implementa a interface `IDictionary <TKey, TValue>`
e não `IList<T>`.




B. É uma lista que implementa a interface `IList<T>`

	Ops! Não se deixe enganar! Apesar do nome, `SortedList` funciona como um dicionário e implementa a interface `IDictionary <TKey, TValue>`
e não `IList<T>`.




C. É uma lista ligada que implementa a interface `IList<T>`

	Ops! A classe `SortedList` não é uma lista ligada, pois não armazena nós (`LinkedListNode`).
Em vez disso, `SortedList` é um armazenamento chave-valor, como um dicionário.




D. É um conjunto ordenado que implementa a interface `ISet<T>`

	Ops! `SortedList` é um armazenamento chave-valor, e não um conjunto, por isso não implementa a interface `ISet<T>`.

