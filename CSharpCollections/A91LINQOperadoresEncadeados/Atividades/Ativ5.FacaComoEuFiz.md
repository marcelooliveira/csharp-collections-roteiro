T�tulo: Montando uma consulta encadeada
=======

Enunciado:
==========

Vamos fazer umas brincadeiras com o que aprendemos sobre **LINQ**? 

D� uma olhada no array abaixo:

```<language>
string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };
```

Agora � com voc�: implemente os seguintes passos:

- Crie uma **consulta** LINQ sobre a cole��o `nomes`
- **Filtre** somente os nomes que possuem a letra "o"
- **Ordene** os nomes por tamanho da string, do menor para o maior
- **Transforme** e retorne os resultados da query como mai�sculas
- **Imprima** os resultados da query

Opini�o da Alura:
=================

Para **filtrar** somente os nomes que possuem a letra "o", voc� tem que usar o operador `Where` com
uma express�o lambda com a condi��o: `nome.Contains("o")`:

```<language>
Where(n => n.Contains("o"))
```

Para **ordenar** os nomes pelo tamanho da string, temos que chamar o operador `OrderBy`
e ent�o, para a ordena��o, podemos usar a propriedade `Length` da string:

```<language>
OrderBy(n => n.Length)
```

E agora podemos **transformar** o resultado para mai�sculas, usando o m�todo `ToUpper()` e retornar o resultado
com o operador `Select`:

```<language>
Select(n => n.ToUpper())
```

No final, basta criar um la�o foreach para imprimir os itens:

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