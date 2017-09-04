# Titulo do Exercício

Enunciado
=========

Dê uma olhada nessa coleção de meses:

```<language>
string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
```

Que operador LINQ você usaria para **filtrar** somente os meses que começam pela letra "j"?

A. Alternativa a [CORRETA]

```<language>
var query = meses.Where(m => m.StartsWith("j"));	
```

	Isso aí! O método `Where` é o operador LINQ para filtrar os dados!

B. Alternativa b

```<language>
var query = meses.Filter(m => m.StartsWith("j"));	
```

	Ops! LINQ não possui operador `Filter`!


C. Alternativa c

```<language>
var query = meses.Where(m.StartsWith("j"));	
```

	Quase! Dentro do método `Where` você precisa passar uma
expressão lambda, como por exemplo `m => m.StartsWith("j")`!

D. Alternativa d

```<language>
var query = meses.Only(m => m.StartsWith("j"));	
```

	Ops! LINQ não possui operador `Only`!


