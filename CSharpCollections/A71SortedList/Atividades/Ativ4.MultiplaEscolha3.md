# Titulo do Exerc�cio

Enunciado
=========

Voc� sabe como um `SortedList` funciona internamente? 

A. � um dicion�rio que implementa a interface `IDictionary <TKey, TValue>` [CORRETA]

	Isso a�! A classe `SortedList` funciona como um dicion�rio e implementa a interface `IDictionary <TKey, TValue>`
e n�o `IList<T>`.




B. � uma lista que implementa a interface `IList<T>`

	Ops! N�o se deixe enganar! Apesar do nome, `SortedList` funciona como um dicion�rio e implementa a interface `IDictionary <TKey, TValue>`
e n�o `IList<T>`.




C. � uma lista ligada que implementa a interface `IList<T>`

	Ops! A classe `SortedList` n�o � uma lista ligada, pois n�o armazena n�s (`LinkedListNode`).
Em vez disso, `SortedList` � um armazenamento chave-valor, como um dicion�rio.




D. � um conjunto ordenado que implementa a interface `ISet<T>`

	Ops! `SortedList` � um armazenamento chave-valor, e n�o um conjunto, por isso n�o implementa a interface `ISet<T>`.

