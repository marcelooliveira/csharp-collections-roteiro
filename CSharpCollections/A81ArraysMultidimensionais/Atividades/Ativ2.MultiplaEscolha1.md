# Array Multidimensional

Enunciado
=========

Voc� entendeu o conceito de array multidimensional?

Observe o tabuleiro de jogo da velha abaixo:

| X  |   | O |
|----|---|---|
| X  | X | O |
|    | O | X |

Voc� precisa declarar um array multidimensional para representar
exatamente o tabuleiro acima.

Para ajudar, temos aqui uma **Rotina de "impress�o"**:

```
for(var y = 0; y < 3; y++)
{
	for(var x = 0; x < 3; x++)
	{
		Console.Write(tabuleiro[x,y]);
	}
	Console.WriteLine();
}
```

E abaixo, o **resultado esperado** da rotina de impress�o:

```
X.O
XXO
.OX
```

Agora � com voc�!

Qual das alternativas seguintes � uma implementa��o correta de array multidimensional
para o jogo da velha com o resultado acima? 

A. Alternativa a [CORRETA]

```
char[,] tabuleiro = new char[3,3];
tabuleiro[0, 0] = 'X';
tabuleiro[1, 0] = '.';
tabuleiro[2, 0] = 'O';
tabuleiro[0, 1] = 'X';
tabuleiro[1, 1] = 'X';
tabuleiro[2, 1] = 'O';
tabuleiro[0, 2] = '.';
tabuleiro[1, 2] = 'O';
tabuleiro[2, 2] = 'X';
```

> Isso mesmo! O array precisa ter dimens�o 3 x 3, portanto o array � 
> instanciado com `new char[3,3]`. Em seguida, o indexador do array
> multidimensional � acessado para preencher cada posi��o da matriz
> bidimensional, como por exemplo: `tabuleiro[0, 1] = 'X';`

B. Alternativa b

```
char[][] tabuleiro = new char[3][];
tabuleiro[0, 0] = 'X';
tabuleiro[1, 0] = '.';
tabuleiro[2, 0] = 'O';
tabuleiro[0, 1] = 'X';
tabuleiro[1, 1] = 'X';
tabuleiro[2, 1] = 'O';
tabuleiro[0, 2] = '.';
tabuleiro[1, 2] = 'O';
tabuleiro[2, 2] = 'X';
```

> Quase! O preenchimento dos valores do array est� correto, mas
a declara��o `char[][] tabuleiro = new char[3][];` � apropriado para
um array "denteado" (jagged array), e n�o para um array multidimensional!

C. Alternativa c

```
char[][] tabuleiro = new char[3][];
tabuleiro[0] = new char[] { 'X', '.', 'O' };
tabuleiro[1] = new char[] { 'X', 'X', 'O' };
tabuleiro[2] = new char[] { '.', 'O', 'X' };
```

> Ops! Essa declara��o e esse preenchimento dos valores do array s�o
> apropriados para um array "denteado" (jagged array), 
> mas n�o para um array multidimensional!

D. Alternativa d

```
char[,] tabuleiro = new char[3,3];
tabuleiro[0] = new char[] { 'X', '.', 'O' };
tabuleiro[1] = new char[] { 'X', 'X', 'O' };
tabuleiro[2] = new char[] { '.', 'O', 'X' };
```

> Ops! Essa declara��o est� correta, mas o preenchimento dos valores do array �
> apropriado para um array "denteado" (jagged array), 
> mas n�o para um array multidimensional!



