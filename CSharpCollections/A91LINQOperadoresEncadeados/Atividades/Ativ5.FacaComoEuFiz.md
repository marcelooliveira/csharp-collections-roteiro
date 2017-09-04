Título: Montando uma consulta encadeada
=======

Enunciado:
==========

Vamos fazer umas brincadeiras com o que aprendemos sobre **LINQ**? 

Dê uma olhada no array abaixo:

```<language>
string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };
```

Agora é com você: implemente os seguintes passos:

- Crie uma **consulta** LINQ sobre a coleção `nomes`
- **Filtre** somente os nomes que possuem a letra "o"
- **Ordene** os nomes por tamanho da string, do menor para o maior
- **Transforme** e retorne os resultados da query como maiúsculas
- **Imprima** os resultados da query

Opinião da Alura:
=================

Para **filtrar** somente os nomes que possuem a letra "o", você tem que usar o operador `Where` com
uma expressão lambda com a condição: `nome.Contains("o")`:

```<language>
Where(n => n.Contains("o"))
```

Para **ordenar** os nomes pelo tamanho da string, temos que chamar o operador `OrderBy`
e então, para a ordenação, podemos usar a propriedade `Length` da string:

```<language>
OrderBy(n => n.Length)
```

E agora podemos **transformar** o resultado para maiúsculas, usando o método `ToUpper()` e retornar o resultado
com o operador `Select`:

```<language>
Select(n => n.ToUpper())
```

No final, basta criar um laço foreach para imprimir os itens:

```<language>
string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };

var query = nomes
	.Where(n => n.Contains("o"))
	.OrderBy(n => n.Length)
	.Select(n => n.ToUpper());

foreach (var item in query)
{
	Console.WriteLine(item);
}
```