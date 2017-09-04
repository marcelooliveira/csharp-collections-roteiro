# Titulo do Exercício

Enunciado
=========

Olha nossa coleção de meses de novo aí:

```<language>
string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
```

Que operador LINQ você usaria para **ordenar** os nomes dos meses, pela ordem alfabética?


A. Alternativa a [CORRETA]

```<language>
var query = meses.OrderBy(n => n);
```

> Isso aí! O método `OrderBy` ordena os elementos de uma sequência. Ele recebe uma coleção `IEnumerable<T>` e retorna 
> uma coleção `IOrderedEnumerable<T>` ordenada.




B. Alternativa b

```<language>
var query = meses.SortBy(n => n);
```

> Ops! LINQ não possui método `SortBy`!

C. Alternativa c

```<language>
Array.Sort(meses);
```

> Quase! `Array.Sort` funciona, **mas não** é um operador LINQ!

D. Alternativa d

```<language>
var query = meses.OrderBy(n);
```

> Quase! Em vez de chamarmos o operador com `OrderBy(n)`,
temos que passar uma expressão lambda, isto é, `meses.OrderBy(n => n);`.

