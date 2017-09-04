# Array Multidimensional

Enunciado
=========

Você entendeu o conceito de array multidimensional?

Observe o tabuleiro de jogo da velha abaixo:

| X  |   | O |
|----|---|---|
| X  | X | O |
|    | O | X |

Você precisa declarar um array multidimensional para representar
exatamente o tabuleiro acima.

Para ajudar, temos aqui uma **Rotina de "impressão"**:

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

E abaixo, o **resultado esperado** da rotina de impressão:

```
X.O
XXO
.OX
```

Agora é com você!

Qual das alternativas seguintes é uma implementação correta de array multidimensional
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

> Isso mesmo! O array precisa ter dimensão 3 x 3, portanto o array é 
> instanciado com `new char[3,3]`. Em seguida, o indexador do array
> multidimensional é acessado para preencher cada posição da matriz
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

> Quase! O preenchimento dos valores do array está correto, mas
a declaração `char[][] tabuleiro = new char[3][];` é apropriado para
um array "denteado" (jagged array), e não para um array multidimensional!

C. Alternativa c

```
char[][] tabuleiro = new char[3][];
tabuleiro[0] = new char[] { 'X', '.', 'O' };
tabuleiro[1] = new char[] { 'X', 'X', 'O' };
tabuleiro[2] = new char[] { '.', 'O', 'X' };
```

> Ops! Essa declaração e esse preenchimento dos valores do array são
> apropriados para um array "denteado" (jagged array), 
> mas não para um array multidimensional!

D. Alternativa d

```
char[,] tabuleiro = new char[3,3];
tabuleiro[0] = new char[] { 'X', '.', 'O' };
tabuleiro[1] = new char[] { 'X', 'X', 'O' };
tabuleiro[2] = new char[] { '.', 'O', 'X' };
```

> Ops! Essa declaração está correta, mas o preenchimento dos valores do array é
> apropriado para um array "denteado" (jagged array), 
> mas não para um array multidimensional!



