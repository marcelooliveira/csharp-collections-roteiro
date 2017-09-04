# Titulo do Exerc�cio

Enunciado
=========

D� uma olhada nessa cole��o de meses:

```<language>
string[] meses = { "janeiro", "fevereiro", "mar�o", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
```

Que operador LINQ voc� usaria para **filtrar** somente os meses que come�am pela letra "j"?

A. Alternativa a [CORRETA]

```<language>
var query = meses.Where(m => m.StartsWith("j"));	
```

	Isso a�! O m�todo `Where` � o operador LINQ para filtrar os dados!

B. Alternativa b

```<language>
var query = meses.Filter(m => m.StartsWith("j"));	
```

	Ops! LINQ n�o possui operador `Filter`!


C. Alternativa c

```<language>
var query = meses.Where(m.StartsWith("j"));	
```

	Quase! Dentro do m�todo `Where` voc� precisa passar uma
express�o lambda, como por exemplo `m => m.StartsWith("j")`!

D. Alternativa d

```<language>
var query = meses.Only(m => m.StartsWith("j"));	
```

	Ops! LINQ n�o possui operador `Only`!


