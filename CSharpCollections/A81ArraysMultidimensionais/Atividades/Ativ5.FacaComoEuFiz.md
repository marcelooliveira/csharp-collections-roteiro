# Limites do array

Enunciado
=========
Lembra da tabela de resultados de copas do mundo de futebol?

|ano\posição|Campeão|Vice|Terceiro Lugar|
|-|-|-|-|
|2014|Alemanha|Argentina|Holanda|
|2010|Espanha|Holanda|Alemanha|
|2006|Itália|França|Alemanha|


Imagine uma tabela de resultados de copas do mundo, declarada como
um array multidimensional, como abaixo, onde a primeira dimensão
representa as edições das copas do mundo e a segunda a posição dos times de futebol nessa copa:

```
string[,] resultados = new string[3, 3];

resultados[0, 0] = "Alemanha";
resultados[0, 1] = "Argentina";
resultados[0, 2] = "Holanda";

resultados[1, 0] = "Espanha";
resultados[1, 1] = "Holanda";
resultados[1, 2] = "Alemanha";

resultados[2, 0] = "Itália";
resultados[2, 1] = "França";
resultados[2, 2] = "Alemanha";
```

Para "imprimir" essa tabela no console, você implementa um laço `for`, assim:

```
for (int copa = 0; copa < 3; copa++)
{
	for (int posicao = 0; posicao < 3; posicao++)
	{
		Console.Write(resultados[copa, posicao] + " ");
	}
	Console.WriteLine();
}	
```

Porém, você não está contente com o código de impressão acima, porque
os 2 laços `for` estão "engessados" para o tamanho de array **3 x 3**:

Modifique o código dos 2 laços `for` para que eles funcionem para qualquer
tamanho de tabela de resultados, tanto para mais posições quanto para mais copas do mundo.

Solução da Alura
================

Você pode usar os métodos `GetLowerBound(indice_dimensão)` e `GetUpperBound(indice_dimensão)`
para obter o menor e o maior índice de uma dimensão, respectivamente:

```
for (int copa = resultados.GetLowerBound(0); 
    copa <= resultados.GetUpperBound(0); 
    copa++)
{
    for (int posicao = resultados.GetLowerBound(1); 
        posicao <= resultados.GetUpperBound(1); posicao++)
    {
        Console.Write(resultados[copa, posicao] + " ");
    }
    Console.WriteLine();
}
```

E se preferir, você pode trocar `resultados.GetLowerBound(0)` novamente por um valor `zero`, pois
no nosso exemplo o índice inicial sempre será `zero`:

```
for (int copa = 0; copa <= resultados.GetUpperBound(0); copa++)
{
    for (int posicao = 0; posicao <= resultados.GetUpperBound(1); posicao++)
    {
        Console.Write(resultados[copa, posicao] + " ");
    }
    Console.WriteLine();
}
```