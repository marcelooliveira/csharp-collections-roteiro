# Jagged Arrays

Enunciado
=========

Observe a **matriz denteada** abaixo (a mesma que vimos em aula):

```<language>
string[][] familias = new string[3][];

familias[0] = new string[] 
{ "Fred", "Wilma", "Pedrita" };
familias[1] = new string[] 
{ "Homer", "Marge", "Bart", "Lisa", "Maggie" };
familias[2] = new string[] 
{ "Florinda", "Kiko" };
```

Qual alternativa tem o código certo para imprimir o elemento "Bart" do array `familias`?

A. Alternativa a [CORRETA]

```<language>
Console.WriteLine(familias[1][2]);
```
	Isso aí! A expressão `familias[1][2]` acessa o segundo elemento (índice 1) do array
`familias`, e dentro dele acessa o terceiro elemento (índice 2). 


B. Alternativa b

```<language>
Console.WriteLine(familias[2][1]);
```

> Ops! Esse código irá imprimir o nome `Kiko`, porque acessa o terceiro elemento
do array `familias` (índice 2) e o segundo elemento desse array (índice 1).




C. Alternativa c

```<language>
Console.WriteLine(familias[2][3]);
```

> Ops! Esse código gera o erro `Index was outside the bounds of the array.`!
Você se esqueceu que os array são base-zero e não base-um?


D. Alternativa d

```<language>
Console.WriteLine(familias[1,2]);
```

> Ops! A expressão `familias[1,2]` só funciona se o array for **multidimensional**,
e não matriz denteada, como pede o exercício!  


D. Alternativa d

```<language>
Console.WriteLine(familias[2,1]);
```

> Ops! A expressão `familias[2,1]` não serve para matriz denteada!
> Ela é adequada apenas para array **multidimensional**!

