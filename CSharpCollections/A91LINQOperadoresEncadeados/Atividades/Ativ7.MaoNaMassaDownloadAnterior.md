>Come�ando deste ponto? Voc� pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do cap�tulo anterior e continuar seus estudos a partir deste cap�tulo.

Aula 9

V�deo 9.1 - LINQ: Operadores Encadeados

Quando precisamos usar cole��es em C#, em geral escolhemos a classe apropriada pensando nas estrat�gia de _armazenamento_, 
que variam de cole��o para cole��o.

Neste cap�tulo vamos deixar um pouco de lado a estrat�gia de _armazenamento_ e as escolhas de _qual_ cole��o usar, para focar no problema de estrat�gia de _consulta_ de dados dessas cole��es, isto �, de _como obter_ os dados que j� est�o armazenados.

Vamos ver agora uma consulta simples. Imagine um array de strings:

```
string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };
```

Vamos pegar esse array e fazer um la�o para consultar alguns dados:

```
Console.WriteLine("CONSULTANDO DENTRO DE UM LA�O FOREACH");
foreach (var nome in nomes)
{
	if (nome.Contains("o"))
	{
		Console.WriteLine(nome);
	}
}
```

Essa consulta � simples de fazer e tem a inten��o �bvia, que � a de imprimir todos os nomes que cont�m a letra "o".
Por�m, se quisermos fazer uma consulta um pouco mais complexa que essa, vamos ter um c�digo com um grande n�mero de linhas e que ser� bem dif�cil de entender.

Felizmente, o .NET Framework possui um conjunto de recursos que facilita a cria��o de consultas poderosas e f�ceis de ler, utilizando poucas linhas de c�digo. Esse conjunto de recursos � chamado de **LINQ**, - Consultas Integradas � Linguagem, em ingl�s: "Language Integrated Queries".

Para realizar a mesma consulta acima com LINQ, podemos utilizar o operador de filtro `Where()`. Dentro dele, passamos a condi��o que deve ser satisfeita para os elementos que desejamos imprimir:

```
nomes.Where(n => n.Contains("o"));
```

> Note que `n => n.Contains("o")` � a _express�o lambda_ que vai definir o filtro pra gente.

Reescrevendo a c�digo de impress�o, fica assim:

```
Console.WriteLine("CONSULTANDO COM LINQ");
var query = nomes.Where(n => n.Contains("o"));
foreach (var item in query)
{
	Console.WriteLine(item);
}
Console.WriteLine();
```

Agora que nossa consulta LINQ est� funcionando, vamos dar uma olhada mais de perto no m�todo `Where()`:

```
namespace System.Linq
{
	...
	public static class Enumerable
	{
		...
		public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate);
		...
	}
	...
}
```

Podemos notar algumas coisas:

- As extens�es `LINQ` ficam localizadas no namespace `System.Linq`.
- As extens�es `LINQ` ficam localizadas na classe `Enumerable`.
- O m�todo `Where()` retorna um valor `IEnumerable<TSource>`.

Mas espere um pouco, n�o estamos trabalhando com array de strings? Ent�o por que `Where` retorna `IEnumerable<TSource>`?

A� entra uma das caracter�sticas do LINQ: ele facilita n�o s� a consulta sobre arrays, mas tamb�m listas, dicion�rios, sets, either
todas as outras classes de cole��es que implementam `IEnumerable<T>`.

Por sua vez, `IEnumerable<T>` � uma interface simples, para qualquer classe que exp�e um enumerador:

```
public interface IEnumerable<out T> : IEnumerable
{
	IEnumerator<T> GetEnumerator();
}
```

E o `IEnumerator<T>` � a interface que permite que uma cole��o seja _enumerada_, isto �, _varrida_ dentro de um la�o `foreach`.
 
> LINQ fornece operadores de consulta poderosos para cole��es em geral

Isso significa que LINQ � uma ferramenta que trata as cole��es "democraticamente": para o LINQ, todas as cole��es podem ser
fontes de dados, pois todas implementam `IEnumerable<T>`.

Imagine que agora voc� queira ordenar os nomes por ordem de tamanho dos nomes. Para isso podemos usar o m�todo `OrderBy`, passando como argumento a propriedade `Length` da string:

```
var query = nomes.Where(n => n.Contains("o"));
query = query.OrderBy(n => n.Length);
```

Imagine tamb�m que voc� precise retornar os nomes em letras mai�sculas. Podemos _modificar o retorno_ de uma consulta com o m�todo `Select`:

```
var query = nomes.Where(n => n.Contains("o"));
query = query.OrderBy(n => n.Length);
query = query.Select(n => n.ToUpper());
```

Mas espere... qual � mesmo o tipo retornado por cada um desses m�todos?

- Where: retorna `IEnumerable<T>`
- OrderBy: retorna `IEnumerable<T>`
- Select: retorna `IEnumerable<T>`

Nesse caso, podemos simplesmente **encadear** esses _operadores LINQ_:

```
query = nomes
	.Where(n => n.Contains("o"))
	.OrderBy(n => n.Length)
	.Select(n => n.ToUpper());
```

A vantagem disso � que nossa consulta ficou mais leg�vel. Se voc� j� trabalhou com banco de dados, fica claro que essa sintaxe � muito parecida com uma consulta SQL!



