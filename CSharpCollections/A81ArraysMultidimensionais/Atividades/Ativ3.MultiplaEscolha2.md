# Array Denteado

Você entendeu o conceito de **array denteado (jagged array)**? 
Em que situação do dia-a-dia você usaria esse tipo de coleção?


A. Alternativa a [CORRETA]

Para criar um **array de arrays**, por exemplo:

```
int[][] matriz = new int[3][];
matriz[0] = new int[] { 1, 3, 5, 7, 9 };
matriz[1] = new int[] { 0, 2, 4, 6 };
matriz[2] = new int[] { 11, 22 };
```

> Isso aí! Um *array denteado* ou *matriz denteada* (jagged array) 
> é uma matriz cujos elementos são matrizes.

B. Alternativa b

Para criar uma **matriz retangular**, por exemplo:

```
int[,] matriz = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
```

> Ops! essa é uma **matriz multidimensional**, e não uma matriz denteada!


C. Alternativa c

Para criar um array de tamanho variável.

> Ops! Nenhum array possui *tamanho variável*, nem mesmo arrays denteados.
> Se você precisa de tamanho variável, é melhor trabalhar com uma **lista** (`List<T>`)! 




