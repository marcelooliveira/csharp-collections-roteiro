# Titulo do Exerc�cio

Enunciado
=========

Olha nossa cole��o de meses de novo a�:

```<language>
string[] meses = { "janeiro", "fevereiro", "mar�o", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
```

Que operador LINQ voc� usaria para **ordenar** os nomes dos meses, pela ordem alfab�tica?


A. Alternativa a [CORRETA]

```<language>
var query = meses.OrderBy(n => n);
```

> Isso a�! O m�todo `OrderBy` ordena os elementos de uma sequ�ncia. Ele recebe uma cole��o `IEnumerable<T>` e retorna 
> uma cole��o `IOrderedEnumerable<T>` ordenada.




B. Alternativa b

```<language>
var query = meses.SortBy(n => n);
```

> Ops! LINQ n�o possui m�todo `SortBy`!

C. Alternativa c

```<language>
Array.Sort(meses);
```

> Quase! `Array.Sort` funciona, **mas n�o** � um operador LINQ!

D. Alternativa d

```<language>
var query = meses.OrderBy(n);
```

> Quase! Em vez de chamarmos o operador com `OrderBy(n)`,
temos que passar uma express�o lambda, isto �, `meses.OrderBy(n => n);`.

