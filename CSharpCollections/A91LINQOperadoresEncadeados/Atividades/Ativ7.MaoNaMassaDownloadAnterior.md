>Começando deste ponto? Você pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do capítulo anterior e continuar seus estudos a partir deste capítulo.

Aula 9

Vídeo 9.1 - LINQ: Operadores Encadeados

Quando precisamos usar coleções em C#, em geral escolhemos a classe apropriada pensando nas estratégia de _armazenamento_, 
que variam de coleção para coleção.

Neste capítulo vamos deixar um pouco de lado a estratégia de _armazenamento_ e as escolhas de _qual_ coleção usar, para focar no problema de estratégia de _consulta_ de dados dessas coleções, isto é, de _como obter_ os dados que já estão armazenados.

Vamos ver agora uma consulta simples. Imagine um array de strings:

```
string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };
```

Vamos pegar esse array e fazer um laço para consultar alguns dados:

```
Console.WriteLine("CONSULTANDO DENTRO DE UM LAÇO FOREACH");
foreach (var nome in nomes)
{
	if (nome.Contains("o"))
	{
		Console.WriteLine(nome);
	}
}
```

Essa consulta é simples de fazer e tem a intenção óbvia, que é a de imprimir todos os nomes que contém a letra "o".
Porém, se quisermos fazer uma consulta um pouco mais complexa que essa, vamos ter um código com um grande número de linhas e que será bem difícil de entender.

Felizmente, o .NET Framework possui um conjunto de recursos que facilita a criação de consultas poderosas e fáceis de ler, utilizando poucas linhas de código. Esse conjunto de recursos é chamado de **LINQ**, - Consultas Integradas à Linguagem, em inglês: "Language Integrated Queries".

Para realizar a mesma consulta acima com LINQ, podemos utilizar o operador de filtro `Where()`. Dentro dele, passamos a condição que deve ser satisfeita para os elementos que desejamos imprimir:

```
nomes.Where(n => n.Contains("o"));
```

> Note que `n => n.Contains("o")` é a _expressão lambda_ que vai definir o filtro pra gente.

Reescrevendo a código de impressão, fica assim:

```
Console.WriteLine("CONSULTANDO COM LINQ");
var query = nomes.Where(n => n.Contains("o"));
foreach (var item in query)
{
	Console.WriteLine(item);
}
Console.WriteLine();
```

Agora que nossa consulta LINQ está funcionando, vamos dar uma olhada mais de perto no método `Where()`:

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

- As extensões `LINQ` ficam localizadas no namespace `System.Linq`.
- As extensões `LINQ` ficam localizadas na classe `Enumerable`.
- O método `Where()` retorna um valor `IEnumerable<TSource>`.

Mas espere um pouco, não estamos trabalhando com array de strings? Então por que `Where` retorna `IEnumerable<TSource>`?

Aí entra uma das características do LINQ: ele facilita não só a consulta sobre arrays, mas também listas, dicionários, sets, either
todas as outras classes de coleções que implementam `IEnumerable<T>`.

Por sua vez, `IEnumerable<T>` é uma interface simples, para qualquer classe que expõe um enumerador:

```
public interface IEnumerable<out T> : IEnumerable
{
	IEnumerator<T> GetEnumerator();
}
```

E o `IEnumerator<T>` é a interface que permite que uma coleção seja _enumerada_, isto é, _varrida_ dentro de um laço `foreach`.
 
> LINQ fornece operadores de consulta poderosos para coleções em geral

Isso significa que LINQ é uma ferramenta que trata as coleções "democraticamente": para o LINQ, todas as coleções podem ser
fontes de dados, pois todas implementam `IEnumerable<T>`.

Imagine que agora você queira ordenar os nomes por ordem de tamanho dos nomes. Para isso podemos usar o método `OrderBy`, passando como argumento a propriedade `Length` da string:

```
var query = nomes.Where(n => n.Contains("o"));
query = query.OrderBy(n => n.Length);
```

Imagine também que você precise retornar os nomes em letras maiúsculas. Podemos _modificar o retorno_ de uma consulta com o método `Select`:

```
var query = nomes.Where(n => n.Contains("o"));
query = query.OrderBy(n => n.Length);
query = query.Select(n => n.ToUpper());
```

Mas espere... qual é mesmo o tipo retornado por cada um desses métodos?

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

A vantagem disso é que nossa consulta ficou mais legível. Se você já trabalhou com banco de dados, fica claro que essa sintaxe é muito parecida com uma consulta SQL!



