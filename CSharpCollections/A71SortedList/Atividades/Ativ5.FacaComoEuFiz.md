# SortedSet com Comparadores

Enunciado
=========

Nosso último exercício usava esse código, lembra?

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

Faça as modificações necessárias para que no final da execução o `SortedSet` tenha o elemento `Fabio Gushiken` mas não o elemento `FABIO GUSHIKEN`.

# RESPOSTA DA ALURA:

O problema quer que a gente resolva a duplicidade de strings que diferem somente entre maíusculas e minúsculas.
Vamos resolver isso criando uma **classe comparadora**. Vamos chamá-la de `ComparadorMinusculo`:

```
internal class ComparadorMinusculo : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}
```

> Note que essa classe precisa implementar a interface `IComparer<string>`!

Agora sim, vamos passar no construtor de `SortedSet` uma nova instância de `ComparadorMinusculo`:

```
ISet<String> alunos = new SortedSet<String>(new ComparadorMinusculo())
```

O que é esse `ComparadorMinusculo`? É simplesmente um método que recebe e compara duas strings
e devolver a comparação delas por meio do método `string.Compare`, ignorando diferenças
entre maiúsculas e minúsculas:



