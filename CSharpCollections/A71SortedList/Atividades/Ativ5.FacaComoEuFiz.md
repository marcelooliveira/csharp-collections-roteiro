# SortedSet com Comparadores

Enunciado
=========

Nosso �ltimo exerc�cio usava esse c�digo, lembra?

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

Fa�a as modifica��es necess�rias para que no final da execu��o o `SortedSet` tenha o elemento `Fabio Gushiken` mas n�o o elemento `FABIO GUSHIKEN`.

# RESPOSTA DA ALURA:

O problema quer que a gente resolva a duplicidade de strings que diferem somente entre ma�usculas e min�sculas.
Vamos resolver isso criando uma **classe comparadora**. Vamos cham�-la de `ComparadorMinusculo`:

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

Agora sim, vamos passar no construtor de `SortedSet` uma nova inst�ncia de `ComparadorMinusculo`:

```
ISet<String> alunos = new SortedSet<String>(new ComparadorMinusculo())
```

O que � esse `ComparadorMinusculo`? � simplesmente um m�todo que recebe e compara duas strings
e devolver a compara��o delas por meio do m�todo `string.Compare`, ignorando diferen�as
entre mai�sculas e min�sculas:



