# SortedSet

Enunciado
=========

Você conhece o comportamento de um `SortedSet`?
Observe o código abaixo:

```
class Program
{
    static void Main(string[] args)
    {
        ISet<String> alunos = new SortedSet<String>()
        {
            "Vanessa Tonini",
            "Ana Losnak",
            "Rafael Nercessian",
            "Priscila Stuani"
        };

        alunos.Add("Rafael Rollo");
        alunos.Add("Fabio Gushiken");
        alunos.Add("Fabio Gushiken");
        alunos.Add("FABIO GUSHIKEN");
        foreach (var a in alunos)
            Console.WriteLine(a);
    }
}
```

O que é exibido quando esse programa é executado?

A. [CORRETA]

```
Ana Losnak
Fabio Gushiken
FABIO GUSHIKEN
Priscila Stuani
Rafael Nercessian
Rafael Rollo
Vanessa Tonini
```

	Isso aí! O `SortedSet` deixou os elementos ordenados e evitou a duplicação 
do elemento "Fabio Gushiken".




B. [ERRADA]
```
Ana Losnak
Fabio Gushiken
Priscila Stuani
Rafael Nercessian
Rafael Rollo
Vanessa Tonini
```

	Quase! Para o `SortedSet`, os elementos "Fabio Gushiken" e "FABIO GUSHIKEN"
são diferentes!

C. [ERRADA]
```
Vanessa Tonini
Ana Losnak
Rafael Nercessian
Priscila Stuani
Rafael Rollo
Fabio Gushiken
FABIO GUSHIKEN
```

	Ops! Um `SortedSet` sempre mantém os elementos ordenados!

D.  A aplicação aborta com a exceção `DuplicateKeyException` na segunda linha `alunos.Add("Fabio Gushiken");`.

	Ops! O `SortedSet`, assim como `HashSet`, não geram exceção quando você
tenta adicionar um elemento que já existe.

