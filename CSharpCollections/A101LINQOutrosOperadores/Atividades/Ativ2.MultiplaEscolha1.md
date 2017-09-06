# Obtendo faixas de valores de uma sequ�ncia

Enunciado
=========

Observe a cole��o de dias da semana abaixo:

```<language>
string[] dias = { "segunda", "ter�a", "quarta", "quinta", "sexta", "s�bado", "domingo" };
```

Qual alternativa cont�m o c�digo necess�rio para obter a sequ�ncia: `"sexta", "s�bado", "domingo"`?

A. Alternativa a [CORRETA]

```<language>
dias.Skip(4).Take(3);
```

> Isso a�! Essa linha de c�digo "pula" quatro elementos (`segunda, ter�a, quarta, quinta`) e "pega" os tr�s
> elementos seguintes (`sexta, s�bado, domingo`)


B. Alternativa b

```<language>
dias.Skip(5).Take(3);
```

> Ops! Desse jeito iremos pular 5 elementos (`segunda, ter�a, quarta, quinta, sexta`) e pegar 3 elementos
> seguintes. Como s� sobraram 2 elementos na sequ�ncia, isso ir� gerar uma exce��o!

C. Alternativa c

```<language>
dias.Take(4).Skip(3);
```

> Ops! Esse m�todo pega quatro elementos, e n�s precisamos de 3!

D. Alternativa d

```<language>
dias.Take(3).Skip(4);
```

> Ops! Esse m�todo pega os tr�s primeiros elementos, para s� ent�o pular 4. 
> Cuidado com a ordem de chamada dos m�todos `Skip` e `Take`!
