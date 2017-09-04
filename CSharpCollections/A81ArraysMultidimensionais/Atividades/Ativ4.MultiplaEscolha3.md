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

Qual alternativa tem o c�digo certo para imprimir o elemento "Bart" do array `familias`?

A. Alternativa a [CORRETA]

```<language>
Console.WriteLine(familias[1][2]);
```
	Isso a�! A express�o `familias[1][2]` acessa o segundo elemento (�ndice 1) do array
`familias`, e dentro dele acessa o terceiro elemento (�ndice 2). 


B. Alternativa b

```<language>
Console.WriteLine(familias[2][1]);
```

> Ops! Esse c�digo ir� imprimir o nome `Kiko`, porque acessa o terceiro elemento
do array `familias` (�ndice 2) e o segundo elemento desse array (�ndice 1).




C. Alternativa c

```<language>
Console.WriteLine(familias[2][3]);
```

> Ops! Esse c�digo gera o erro `Index was outside the bounds of the array.`!
Voc� se esqueceu que os array s�o base-zero e n�o base-um?


D. Alternativa d

```<language>
Console.WriteLine(familias[1,2]);
```

> Ops! A express�o `familias[1,2]` s� funciona se o array for **multidimensional**,
e n�o matriz denteada, como pede o exerc�cio!  


D. Alternativa d

```<language>
Console.WriteLine(familias[2,1]);
```

> Ops! A express�o `familias[2,1]` n�o serve para matriz denteada!
> Ela � adequada apenas para array **multidimensional**!

