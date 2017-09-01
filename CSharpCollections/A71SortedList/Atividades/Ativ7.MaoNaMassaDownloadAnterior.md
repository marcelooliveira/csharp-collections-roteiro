Aula 7
V�deo 7.1 - SortedList

A pr�xima classe que veremos � a SortedList<TKey, TValue>. Para ilustrar isso, vamos rever a declara��o do nosso dicion�rio original
com os tr�s alunos iniciais, al�m de Wanderson Macedo adicionado, e h� o loop foreach usual para exibir os valores.

![File](file.png)

Vamos executar esse c�digo:. 

![File](file2.png)

Nada de novo aqui, mas observe a ordem dos elementos. 
Eles foram enumerados na mesma ordem que os adicionei ao dicion�rio, que era basicamente uma ordem aleat�ria.
Agora, eu n�o confiaria muito nesse comportamento de ordena��o. Os dicion�rios geralmente n�o t�m uma ordem definida, mas � o que acontece neste caso.


E agora vou fazer uma altera��o neste c�digo. Vou mudar o tipo de cole��o de um dicion�rio <string, Aluno> para um SortedList <string, Aluno>.

![File](file3.png)

Nada mudou, al�m da declara��o do SortedList. Vamos rodar agora o c�digo. 



N�s obtivemos os mesmos valores, mas olhe a ordem agora. Eles s�o organizados em ordem alfab�tica.
Essa ordena��o � feita alfabeticamente pela chave, n�o pelo valor, e isso � um SortedList. � um dicion�rio que mant�m automaticamente seus valores classificados.
Mas n�o se deixe enganar pelo nome! Para todos os efeitos, um SortedList � um dicion�rio, ***n�o uma lista***. 
Ele implementa a interface IDictionary <TKey, TValue>, como podemos ver:

![File](file4.png)

e voc� a usa basicamente da mesma forma que Dictionary <TKey, TValue>. Como exemplo, posso procurar o valor Rafael Nercessian fornecendo
 A chave "RN". 

![File](file5.png)

Agora vamos executar o c�digo. 

![File](file6.png)

E funciona corretamente! A raz�o pela qual o nome do tipo � SortedList � devido � implementa��o interna.

Internamente, � completamente diferente de um Dictionary<TKey, TValue>. N�o h� tabela de hash. Em vez disso, os elementos s�o classificados pela chave e
 Em seguida, armazenados basicamente em uma lista. 

Na verdade, duas listas, uma para as chaves e outra para os valores. E o ponto � que, como eles est�o classificados pela chave, � muito r�pido procurar valores usando a chave.

![File](file7.png)

Ao procurar um elemento, voc� s� pode apenas fazer uma busca bin�ria na lista de chaves. 

 A pesquisa funciona no m�dulo sobre o tipo Array, e � muito r�pido. E a �nica quest�o de desempenho �, naturalmente, que, porque estamos usando listas, fazer modifica��es no dicion�rio � bastante custoso porque voc� precisa mover elementos subsequentes para manter a lista ordenada e todos os elementos em sequ�ncia. Este � exatamente o mesmo problema de desempenho que o List<T> possui, ent�o n�o � recomend�vel adicionar e remover valores em uma SortedList<T> com muita frequ�ncia.
Mas se voc� pode fornecer o SortedList com uma cole��o pr�-preenchida no construtor e ent�o voc� n�o precisa adicionar nenhum elemento depois disso, ent�o o SortedList se torna um dicion�rio muito bom. Tenha em mente tamb�m que, porque est� ordenando tudo o que voc� realmente precisa de chaves que possam ser de maneira significativa comparadas para que os elementos possam ser ordenados. E, como estamos usando strings como as chaves, o .NET j� sabe nativamente como ordenar strings.
