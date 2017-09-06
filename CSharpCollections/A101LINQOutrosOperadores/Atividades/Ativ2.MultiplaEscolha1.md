# Obtendo faixas de valores de uma sequência

Enunciado
=========

Observe a coleção de dias da semana abaixo:

```<language>
string[] dias = { "segunda", "terça", "quarta", "quinta", "sexta", "sábado", "domingo" };
```

Qual alternativa contém o código necessário para obter a sequência: `"sexta", "sábado", "domingo"`?

A. Alternativa a [CORRETA]

```<language>
dias.Skip(4).Take(3);
```

> Isso aí! Essa linha de código "pula" quatro elementos (`segunda, terça, quarta, quinta`) e "pega" os três
> elementos seguintes (`sexta, sábado, domingo`)


B. Alternativa b

```<language>
dias.Skip(5).Take(3);
```

> Ops! Desse jeito iremos pular 5 elementos (`segunda, terça, quarta, quinta, sexta`) e pegar 3 elementos
> seguintes. Como só sobraram 2 elementos na sequência, isso irá gerar uma exceção!

C. Alternativa c

```<language>
dias.Take(4).Skip(3);
```

> Ops! Esse método pega quatro elementos, e nós precisamos de 3!

D. Alternativa d

```<language>
dias.Take(3).Skip(4);
```

> Ops! Esse método pega os três primeiros elementos, para só então pular 4. 
> Cuidado com a ordem de chamada dos métodos `Skip` e `Take`!
