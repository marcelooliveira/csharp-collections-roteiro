# Limites do array

Enunciado
=========
Lembra da tabela de resultados de copas do mundo de futebol?

|ano\posi��o|Campe�o|Vice|Terceiro Lugar|
|-|-|-|-|
|2014|Alemanha|Argentina|Holanda|
|2010|Espanha|Holanda|Alemanha|
|2006|It�lia|Fran�a|Alemanha|


Imagine uma tabela de resultados de copas do mundo, declarada como
um array multidimensional, como abaixo, onde a primeira dimens�o
representa as edi��es das copas do mundo e a segunda a posi��o dos times de futebol nessa copa:

```
string[,] resultados = new string[3, 3];

resultados[0, 0] = "Alemanha";
resultados[0, 1] = "Argentina";
resultados[0, 2] = "Holanda";

resultados[1, 0] = "Espanha";
resultados[1, 1] = "Holanda";
resultados[1, 2] = "Alemanha";

resultados[2, 0] = "It�lia";
resultados[2, 1] = "Fran�a";
resultados[2, 2] = "Alemanha";
```

Para "imprimir" essa tabela no console, voc� implementa um la�o `for`, assim:

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

Por�m, voc� n�o est� contente com o c�digo de impress�o acima, porque
os 2 la�os `for` est�o "engessados" para o tamanho de array **3 x 3**:

Modifique o c�digo dos 2 la�os `for` para que eles funcionem para qualquer
tamanho de tabela de resultados, tanto para mais posi��es quanto para mais copas do mundo.

Solu��o da Alura
================

Voc� pode usar os m�todos `GetLowerBound(indice_dimens�o)` e `GetUpperBound(indice_dimens�o)`
para obter o menor e o maior �ndice de uma dimens�o, respectivamente:

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

E se preferir, voc� pode trocar `resultados.GetLowerBound(0)` novamente por um valor `zero`, pois
no nosso exemplo o �ndice inicial sempre ser� `zero`:

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