>Come�ando deste ponto? Voc� pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do cap�tulo anterior e continuar seus estudos a partir deste cap�tulo.

Aula 11

V�deo 11.1 - Cast e Covari�ncia de Cole��es

Neste cap�tulo vamos come�ar a exibir algumas peculiaridades sobre a interface IEnumerable<T>.

No primeiro v�deo dessa aula, vamos falar sobre convers�o de valores. Imagine que voc� tenha uma string, como:

```
string titulo = "The Simpsons";
```

Uma `string` � um objeto, e todo objeto herda da classe `object`, logo voc� pode converter implicitamente essa string para um `object`, como por exemplo:

```
object obj = titulo;    
```

Essa convers�o impl�cita � feita sem problemas.

Agora imagine que voc� tenha uma lista de strings:

```
var familia = new List<string> { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
```

Pela l�gica, podemos converter `List<string>` para `List<object>`, correto?

```
List<object> listaObj = familia;
```

OPA! O Visual Studio est� acusando um erro de compila��o!

```
Cannot implicitly convert type 'System.Collections.Generic.List<string>' to 
'System.Collections.Generic.List<object>'
```

Mas por qu�??

Simples: se n�o houvesse erro de compila��o, o VS deixaria fazermos isso:

```
var familia = new List<string> { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
List<object> listaObj = familia; // ISSO N�O � PERMITIDO, MAS IMAGINE SE FOSSE!
listaObj.Add(DateTime.Now); // OK, UMA LISTA DE OBJECT PODE RECEBER UM DATETIME!
```

Mas espere... `listaObj` � na verdade uma lista de strings (`familia`)! Voc� n�o pode adicionar um `DateTime` a uma lista de strings!
E essa � uma _prote��o_ da linguagem. Ela foi desenhada assim para gerar erro de compila��o e prevenir contra erros de execu��o.

Ser� que essa "prote��o" na linguagem tamb�m se aplica a arrays? Vamos verificar...

Primeiro criamos um array de strings:

```
var familiaArray = new string[] { "Dona Florinda", "Kiko" };
```

Agora vamos tentar converter (implicitamente) um array de `string` para um array de `object`:

```
object[] objArray = familiaArray;
```

Opa! Nenhum erro de compila��o! 

Agora vamos tentar adicionar um inteiro a esse array:

```
objArray[0] = 123;
```

De novo, nenhum erro de compila��o...

Vamos ent�o rodar o c�digo. Veja o que acontece:

```
Exce��o Sem Tratamento: System.ArrayTypeMismatchException: 
Tentativa de acesso a um elemento como um tipo incompat�vel com a matriz.
```

Opa, agora sim, encontramos um problema! Por que isso acontece com arrays mas n�o com `List`?

Infelizmente, no in�cio do desenvolvimento do C#, a Microsoft adicionou esse permiss�o de convers�o impl�cita de arrays.
Quando o C# passou a ter _generics_, essa convers�o impl�cita foi proibida na classe `List` (e na interface `IList` em geral).

> Essa capacidade de trocar o tipo do elemento de uma cole��o para outro tipo de elemento (de tipo mais gen�rico) durante o cast � chamada de **covari�ncia**.

- Cast de `List<string>` para `List<object>`: N�O PODE, pois `IList` n�o permite covari�ncia.
- Cast de `List<string>` para `object[]`: PODE, MAS N�O DEVE, porque Arrays (infelizmente) permitem covari�ncia.

J� vimos sobre cast para `List<object>` e para `object[]`, mas e quanto a `IEnumerable<object>`? Vamos tentar fazer esse terceiro tipo de cast:

```
IEnumerable<object> enumObj = familia;
```

Nenhum erro de compila��o! Agora vamos rodar:

```
Pressione qualquer tecla para continuar. . .
```

Nenhum erro de execu��o! Mas por qu�? O que h� de difernete entre `IList<T>` e `IEnumerable<T>`?

Vejamos a declara��o de cada uma das interfaces:

```
public interface IList<T>
```

```
public interface IEnumerable<out T> 
```

Veja a documenta��o do par�metro T de `IEnumerable<T>`:

```
// Type parameters:
    //   T:
    //     The type of objects to enumerate.This type parameter is covariant. That is, you
    //     can use either the type you specified or any type that is more derived. For more
    //     information about covariance and contravariance, see Covariance and Contravariance
    //     in Generics.
```

Veja a diferen�a! `IEnumerable` recebe o _par�metro de tipo_ `T` como **out**, isto �, a interface garante que o tipo `T` seja usado como **retorno**, mas nunca como **entrada**. Isto �, `IEnumerable` � uma interface para sequ�ncia somente-leitura e ela garante que a cole��o n�o ser� modificada e, por isso, ela pode fazer a covari�ncia com seguran�a!



