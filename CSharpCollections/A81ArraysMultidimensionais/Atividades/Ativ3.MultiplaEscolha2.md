# Array Denteado

Voc� entendeu o conceito de **array denteado (jagged array)**? 
Em que situa��o do dia-a-dia voc� usaria esse tipo de cole��o?


A. Alternativa a [CORRETA]

Para criar um **array de arrays**, por exemplo:

```
int[][] matriz = new int[3][];
matriz[0] = new int[] { 1, 3, 5, 7, 9 };
matriz[1] = new int[] { 0, 2, 4, 6 };
matriz[2] = new int[] { 11, 22 };
```

> Isso a�! Um *array denteado* ou *matriz denteada* (jagged array) 
> � uma matriz cujos elementos s�o matrizes.

B. Alternativa b

Para criar uma **matriz retangular**, por exemplo:

```
int[,] matriz = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
```

> Ops! essa � uma **matriz multidimensional**, e n�o uma matriz denteada!


C. Alternativa c

Para criar um array de tamanho vari�vel.

> Ops! Nenhum array possui *tamanho vari�vel*, nem mesmo arrays denteados.
> Se voc� precisa de tamanho vari�vel, � melhor trabalhar com uma **lista** (`List<T>`)! 




