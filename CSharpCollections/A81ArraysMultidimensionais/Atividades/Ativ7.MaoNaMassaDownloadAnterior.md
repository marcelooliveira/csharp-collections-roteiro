>Come�ando deste ponto? Voc� pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do cap�tulo anterior e continuar seus estudos a partir deste cap�tulo.

Aula 8

V�deo 8.1 - Arrays Multidimensionais

No in�cio do curso vimos como os arrays s�o um tipo de cole��o que ajudam a armazenar informa��es em posi��es fixas em mem�ria.

Imagine que voc� queira agora armazenar os nomes das sele��es que ficaram nas primeiras posi��es nas �ltimas tr�s copas do mundo:

![File](file.png)

Voc� poderia armazenar esses nomes dentro de um array de strings. Como s�o tr�s copas do mundo e tr�s primeiros lugares, ent�o teremos um total de 3 x 3 strings, num total de 9 elementos.

![File](file2.png)

Imprimindo o conte�do desse array, ter�amos uma sequ�ncia de strings, como esperado:

![File](file3.png)

![File](file4.png)

Um array � uma cole��o de elementos mantidos em mem�ria sequencialmente, ent�o ser quisermos acessar o vice campe�o da copa de 2010, temos que fazer algumas contas: 

> �ndice = INDICE_COPA * QTD_CAMPEOES_POR_COPA + INDICE_VICECAMPEAO

Como temos:

> INDICE_COPA = 1
QTD_CAMPEOES_POR_COPA = 3
INDICE_VICECAMPEAO = 1

Ent�o:

> �ndice = 1 * 3 + 1 = 4

Logo, se acessarmos resultados[4], obteremos a string �Holanda�

O problema dessa abordagem � que, para acessarmos elementos espec�ficos desse array de sele��es, precisamos calcular o �ndice de acesso, o que n�o � muito intuitivo!

O problema que estamos vendo aqui � que estamos tentando encaixar dados de uma �tabela de resultados� dentro de um �array linear�. � mais ou menos como pegar uma fileira de garrafas de cerveja e tentar �adivinhar� qual posi��o elas ocupariam se tiv�ssemos que coloc�-las ordenadamente dentro de um engradado de cerveja. O problema todo � que uma 
�fileira� de garrafas possui apenas uma dimens�o (o comprimento), enquanto um engradado de cervejas � uma matriz com comprimento e profundidade.

Felizmente, o .NET Framework fornece uma outra op��o para trabalhar com arrays com mais de uma �dimens�o�. Essa op��o se  chama arrays multidimensionais:.

A sua inicializa��o � bastante parecida com a de um array convencional, por�m a diferen�a mais marcante � o uso de v�rgulas para definir o tamanho de cada uma das dimens�es. Podemos reescrever nosso array de dimens�es num modo multidimensional adicionando uma nova dimens�o, e assim nosso array ficar� com uma dimens�o para o �comprimento� (o �ndice da copa, sendo 0 = Copa 2014, 1 = Copa 2010, 2 = Copa 2006) e outra dimens�o para a posi��o da sele��o no campeonato (0 = campe�o, 1 = vice, 2 = terceiro lugar).

![File](file5.png)

Dessa forma, nosso array ficou mais bem organizado. Podemos ver claramente, pelos �ndices, como os elementos est�o organizados por linhas e colunas na matriz de strings. 

Mas como podemos acessar esses elementos? Vamos reutilizar nosso la�o foreach para imprimir os elementos:

![File](file6.png)

![File](file7.png)

Como vimos pela imagem acima, o acesso aos elementos de um array multidimensional pode ser feito sequencialmente, exatamente como fazemos com array simples!

Isso acontece porque um array multidimensional  � na verdade armazenado em mem�ria exatamente como um array comum! E ele tamb�m implementa o m�todo GetEnumerator(), e assim a instru��o foreach consegue acessar os elementos sequencialmente.

Podemos melhorar a legibilidade do nosso c�digo introduzindo constantes para mapear os �ndices das duas dimens�es para seus significados. Assim teremos para o primeiro �ndice:

![File](file8.png)

E para o segundo �ndice:

![File](file9.png)

podemos ainda criar um novo array simples para as copas:

![File](file10.png)

Por fim, vamos armazenar os resultados agora substituindo os �n�meros m�gicos� pelas constantes que representam as posi��es na matriz de sele��es:

![File](file11.png)

![File](file12.png)

Agora vamos imprimir novamente os elementos. Mas desta vez, como queremos imprimir os resultados graficamente como uma matriz, n�o vamos usar um simples la�o foreach para varrer todos os elementos igualmente.Em vez disso, vamos criar dois la�os �aninhados�, sendo um para varrer as linhas e o segundo la�o para varrer as colunas da matriz.

O la�o externo, varrendo as copas, pode ser escrito como:

![File](file13.png)

Note que estamos varrendo do �ndice 0 ao �ndice 2, porque j� sabemos os limites dos �ndices dessa matriz. Entretanto, tamb�m podemos perguntar para o array qual s�o esses limites. Dessa forma, nosso c�digo poder� trabalhar com arrays multidimensionais de quaisquer tamanho, n�o apenas 3 x 3!

![File](file14.png)

Perceba que os m�todos GetLowerBound(0) e GetUpperBound(0) retornam exatamente esses limites. O par�metro 0 que est� sendo passado aqui � justamente para obter dados sobre a primeira dimens�o, que � zero.

Agora podemos prosseguir e imprimir tamb�m a copa:

![File](file15.png)

E por fim criamos o segundo la�o, novamente usando os m�todos GetLowerBound(1) e GetLowerBound(1) para a segunda dimens�o (a posi��o da sele��o na copa).

![File](file16.png)

![File](file17.png)

Dessa forma conseguimos construir com sucesso um array multidimensional, que � armazenado em mem�ria tal como um array unidimensional, por�m pode ser acessado de maneira mais conveniente para o desenvolvedor!

