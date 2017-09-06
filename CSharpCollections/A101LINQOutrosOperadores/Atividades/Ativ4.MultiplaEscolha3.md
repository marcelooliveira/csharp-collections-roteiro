# Operadores de Conjunto (IEnumerable<T>)

Enunciado
=========

Você sabe como unir elementos de sequências diferentes?

Primeiro dê uma olhada na declaração dessas duas coleções de dias da semana:

```<language>
string[] dias1 = { "segunda", "terça", "quarta" };
string[] dias2 = { "terça", "QUARTA", "quinta" };
```

Agora observe a listagem abaixo:

```<language>
segunda
terça
quarta
quinta
```

Qual das alternativas consegue produzir a listagem acima? 

A. Alternativa a

`dias1.Concat(dias2);`
> Ops! O método `Concat` concatena os elementos das sequências, isto é, 
> ele não elimina as duplicidades do elemento `terça`, que existe nas duas sequências.

B. Alternativa b

`dias2.Concat(dias1);`

> Ops! Esse método `Concat` na sequência `dias2` iria retornar um resultado começando pelo primeiro elemento de `dias2`, isto é, `terça`.

C. Alternativa c

`dias1.Union(dias2);`

> Ops! Está faltando um comparador de maiúsculas/minúsculas na chamada do método `Union`, portanto
> portanto o resultado dessa alternativa conteria tanto o elemento `quarta` quanto `QUARTA`.

D. Alternativa d [CORRETA]

`dias1.Union(dias2, StringComparer.CurrentCultureIgnoreCase);`

> isso mesmo! O método `Union` une os elementos da sequência `dias1` com os da
> sequência `dias2`, removendo as duplicidades. O comparador `StringComparer.CurrentCultureIgnoreCase`
> faz com que as diferenças entre letras maiúsculas e minúsculas em `quarta` e `QUARTA` sejam ignoradas.
 
E. Alternativa e

`dias2.Union(dias1, StringComparer.CurrentCultureIgnoreCase);`

> Ops! Esse método `Union` resultaria numa sequência começando pelo elemento `terça`, e não `segunda`. 

F. Alternativa f

`dias1.Concat(dias2, StringComparer.CurrentCultureIgnoreCase);`

Ops! Não existe uma assinatura do método `Concat` que aceita um comparador. 

