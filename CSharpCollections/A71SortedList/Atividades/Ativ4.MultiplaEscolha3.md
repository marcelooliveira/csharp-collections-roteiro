# SortedSet

Enunciado
=========

Voc� conhece o comportamento de um `SortedSet`?
Observe o c�digo abaixo:

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

O que � exibido quando esse programa � executado?

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

	Isso a�! O `SortedSet` deixou os elementos ordenados e evitou a duplica��o 
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
s�o diferentes!

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

	Ops! Um `SortedSet` sempre mant�m os elementos ordenados!

D.  A aplica��o aborta com a exce��o `DuplicateKeyException` na segunda linha `alunos.Add("Fabio Gushiken");`.

	Ops! O `SortedSet`, assim como `HashSet`, n�o geram exce��o quando voc�
tenta adicionar um elemento que j� existe.

