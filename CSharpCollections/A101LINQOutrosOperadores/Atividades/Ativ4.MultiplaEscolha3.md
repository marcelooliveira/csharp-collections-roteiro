# Operadores de Conjunto (IEnumerable<T>)

Enunciado
=========

Voc� sabe como unir elementos de sequ�ncias diferentes?

Primeiro d� uma olhada na declara��o dessas duas cole��es de dias da semana:

```<language>
string[] dias1 = { "segunda", "ter�a", "quarta" };
string[] dias2 = { "ter�a", "QUARTA", "quinta" };
```

Agora observe a listagem abaixo:

```<language>
segunda
ter�a
quarta
quinta
```

Qual das alternativas consegue produzir a listagem acima? 

A. Alternativa a

`dias1.Concat(dias2);`
> Ops! O m�todo `Concat` concatena os elementos das sequ�ncias, isto �, 
> ele n�o elimina as duplicidades do elemento `ter�a`, que existe nas duas sequ�ncias.

B. Alternativa b

`dias2.Concat(dias1);`

> Ops! Esse m�todo `Concat` na sequ�ncia `dias2` iria retornar um resultado come�ando pelo primeiro elemento de `dias2`, isto �, `ter�a`.

C. Alternativa c

`dias1.Union(dias2);`

> Ops! Est� faltando um comparador de mai�sculas/min�sculas na chamada do m�todo `Union`, portanto
> portanto o resultado dessa alternativa conteria tanto o elemento `quarta` quanto `QUARTA`.

D. Alternativa d [CORRETA]

`dias1.Union(dias2, StringComparer.CurrentCultureIgnoreCase);`

> isso mesmo! O m�todo `Union` une os elementos da sequ�ncia `dias1` com os da
> sequ�ncia `dias2`, removendo as duplicidades. O comparador `StringComparer.CurrentCultureIgnoreCase`
> faz com que as diferen�as entre letras mai�sculas e min�sculas em `quarta` e `QUARTA` sejam ignoradas.
 
E. Alternativa e

`dias2.Union(dias1, StringComparer.CurrentCultureIgnoreCase);`

> Ops! Esse m�todo `Union` resultaria numa sequ�ncia come�ando pelo elemento `ter�a`, e n�o `segunda`. 

F. Alternativa f

`dias1.Concat(dias2, StringComparer.CurrentCultureIgnoreCase);`

Ops! N�o existe uma assinatura do m�todo `Concat` que aceita um comparador. 

