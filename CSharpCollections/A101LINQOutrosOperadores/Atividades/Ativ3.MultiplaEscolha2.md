# Obtendo faixa cont�nua de valores de uma sequ�ncia

Enunciado
=========

Uma loja de fast-food tem um faturamento que varia dia-a-dia.

Na �ltima semana, essa loja registrou os seguintes faturamentos:

```<language>
var dias = new[] { 
new { nome = "segunda", faturamento = 1000 },
new { nome = "ter�a", faturamento = 2000 },
new { nome = "quarta", faturamento = 12500 },
new { nome = "quinta", faturamento = 11000 },
new { nome = "sexta", faturamento = 22000 },
new { nome = "s�bado", faturamento = 9000 },
new { nome = "domingo", faturamento = 18000 }};
```

Essa loja quer saber quais dias **consecutivos** tiveram **faturamento
igual ou superior** a 10 mil reais.

Qual consulta LINQ pode trazer esse resultado?

A. Alternativa a [CORRETA]

```<language>
var query = dias
    .SkipWhile(d => d.faturamento < 10000)
    .TakeWhile(d => d.faturamento >= 10000);
```

> Isso a�! O m�todo `SkipWhile(d => d.faturamento < 10000)` vai ignorar
> os dias iniciais que tiveram faturamento menor que 10 mil.
> O m�todo `TakeWhile(d => d.faturamento >= 10000)` vai pegar os dias
> consecutivos que tiveram faturamento igual ou maior a 10 mil.


B. Alternativa b

```<language>
var query = dias
    .Skip(d => d.faturamento < 10000)
    .Take(d => d.faturamento >= 10000);
```

> Ops! Os m�todos `Skip` e `Take` aceitam como par�metro o n�mero
> de elementos, mas n�o uma condi��o.

C. Alternativa c

```<language>
var query = dias
    .Skip(d => d.faturamento < 10000)
    .TakeWhile(d => d.faturamento >= 10000);
```

> Quase! O m�todo `Skip` aceita como par�metro o n�mero
> de elementos, mas n�o uma condi��o.

D. Alternativa d

```<language>
var query = dias
    .SkipWhile(d => d.faturamento < 10000)
    .Take(d => d.faturamento >= 10000);
```

> Quase! O m�todo `Take` aceita como par�metro o n�mero
> de elementos, mas n�o uma condi��o.

