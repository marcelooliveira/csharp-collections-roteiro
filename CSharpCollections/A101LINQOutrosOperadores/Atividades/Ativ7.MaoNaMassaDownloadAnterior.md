>Come�ando deste ponto? Voc� pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do cap�tulo anterior e continuar seus estudos a partir deste cap�tulo.

Aula 10

V�deo 10.1 - LINQ: Outros Operadores

Nesse cap�tulo vamos explorar alguns operadores do LINQ!

Imagine que voc� tenha uma sequ�ncia de nomes de meses:

```
string[] meses = { "janeiro", "fevereiro", "mar�o", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
```

Nossa tarefa agora � listar os meses do primeiro trimestre. Como podemos fazer isso? Obviamente podemos usar um la�o `for`, com �ndices de 0 a 2,
e imprimir somente os meses com esses �ndices. Mas tem um jeito melhor.

Para obter uma quantidade N de elemntos a partir do in�cio de uma sequ�ncia, podemos usar o m�todo LINQ chamadao `Take()`:

```
Console.WriteLine("Pegar o primeiro trimestre");
Imprimir(meses.Take(3));
```

RESULTADO:
```
Pegar o primeiro trimestre
janeiro
fevereiro
mar�o
```


E se quisermos pegar todos os meses do ano, exceto os do primeiro trimestre? Nesse caso, temos que "pular" 3 meses e pegar o restante.
O verbo "pular" em ingl�s � "skip", e assim voc� tem que usar o m�todo `Skip()`:

```
Console.WriteLine("Pegar os meses depois do primeiro trimestre");
Imprimir(meses.Skip(3));
```

RESULTADO:
```
Pegar os meses depois do primeiro trimestre
abril
maio
junho
julho
agosto
setembro
outubro
novembro
dezembro
```

Mas perceba que o m�todo `Skip` acima pulou 3 meses mas pegou TODOS os meses at� o final.
E se quisermos obter uma faixa de elementos da sequ�ncia, como por exemplo os meses do terceiro trimestre?

Simples: podemos combinar os m�todos `Skip` e `Take` para obter o resultado desejado!

```
Console.WriteLine("Pegar os meses do terceiro trimestre");
Imprimir(meses.Skip(6).Take(3));
```

RESULTADO:
```
Pegar os meses do terceiro trimestre
julho
agosto
setembro
```

Tamb�m podemos pegar os elementos a partir do in�cio da sequ�ncia enquanto uma condi��o for verdadeira. Nesse caso, podemos
usar o m�todo `TakeWhile`. Por exemplo, se quisermos pegar uma sequ�ncia de meses e continuar pegando at� encontarmos um 
m�s cujo nome que come�a com a letra "s":

```
Console.WriteLine("Pegar os meses at� que o m�s comece com a letra 's'");
Imprimir(meses.TakeWhile(m => !m.StartsWith("s")));
```

RESULTADO:
```
Pegar os meses at� que o m�s comece com a letra 's'
janeiro
fevereiro
mar�o
abril
maio
junho
julho
agosto
```

E se desejarmos obter os meses a partir do m�s que inicia com a letra "s", podemos usar o m�todo `SkipWhile`:

```
Console.WriteLine("Pular os meses at� que o m�s comece com a letra 's'");
Imprimir(meses.SkipWhile(m => !m.StartsWith("s")));
```

RESULTADO:
```
Pular os meses at� que o m�s comece com a letra 's'
setembro
outubro
novembro
dezembro
```

Agora vamos ver um pouco sobre operadores de conjuntos fornecidos pelo LINQ. Para isso, vamos 
declarar duas sequ�ncias de nomes de meses:

```
string[] seq1 = { "janeiro", "fevereiro", "mar�o"};
string[] seq2 = { "fevereiro", "MAR�O", "abril" };
Console.WriteLine();
```

Perceba que colocamos o m�s de mar�o duas vezes. A segunda string come�a com "M" mai�sculo, e fizemos isso
de prop�sito. Vamos ver o porqu� disso agora:

Vamos **concatenar** os elementos de duas sequ�ncias, utiliando o m�todo `Concat`:

```
Console.WriteLine("concatenando duas sequ�ncias");
Imprimir(seq1.Concat(seq2));
```

RESULTADO:
```
concatenando duas sequ�ncias
janeiro
fevereiro
mar�o
fevereiro
MAR�O
abril
```

Como vimos no resultado, o m�todo `Concat` simplesmente faz uma "justaposi��o" dos elementos, sem levar em conta
se o valor  existe nas duas sequ�ncias! Por isso, temos uma duplica��o dos meses "fevereiro" e "mar�o".

Por�m, existe um outro m�todo para "juntar" duas sequ�ncias: o m�todo `Union`. Vamos ver do que ele � capaz: 

```
Console.WriteLine("uni�o de duas sequ�ncias");
Imprimir(seq1.Union(seq2));
```

RESULTADO:
```
uni�o de duas sequ�ncias
janeiro
fevereiro
mar�o
MAR�O
abril
```

Veja que com o `Union` conseguimos eliminar a duplica��o do m�s "fevereiro", mas o m�s de "mar�o" ainda est� duplicado.
Notamos que isso acontece porque existe diferen�a de mai�sculas/min�sculas.

Para contornar o problema, podemos usar uma _sobrecarga_ (overload) do m�todo `Union` para que ele ignore essas diferen�as
de case:

```
Console.WriteLine("uni�o de duas sequ�ncias com comparador IgnoreCase");
Imprimir(seq1.Union(seq2, StringComparer.CurrentCultureIgnoreCase));
```

RESULTADO:
```
uni�o de duas sequ�ncias com comparador IgnoreCase
janeiro
fevereiro
mar�o
abril
```

Agora sim, sucesso!

