>Começando deste ponto? Você pode fazer o [DOWNLOAD](	
https://www.caelum.com.br/favicon.ico) completo do projeto do capítulo anterior e continuar seus estudos a partir deste capítulo.

Aula 11

Vídeo 11.1 - Cast e Covariância de Coleções

Neste capítulo vamos começar a exibir algumas peculiaridades sobre a interface IEnumerable<T>.

No primeiro vídeo dessa aula, vamos falar sobre conversão de valores. Imagine que você tenha uma string, como:

```
string titulo = "The Simpsons";
```

Uma `string` é um objeto, e todo objeto herda da classe `object`, logo você pode converter implicitamente essa string para um `object`, como por exemplo:

```
object obj = titulo;    
```

Essa conversão implícita é feita sem problemas.

Agora imagine que você tenha uma lista de strings:

```
var familia = new List<string> { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
```

Pela lógica, podemos converter `List<string>` para `List<object>`, correto?

```
List<object> listaObj = familia;
```

OPA! O Visual Studio está acusando um erro de compilação!

```
Cannot implicitly convert type 'System.Collections.Generic.List<string>' to 
'System.Collections.Generic.List<object>'
```

Mas por quê??

Simples: se não houvesse erro de compilação, o VS deixaria fazermos isso:

```
var familia = new List<string> { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
List<object> listaObj = familia; // ISSO NÃO É PERMITIDO, MAS IMAGINE SE FOSSE!
listaObj.Add(DateTime.Now); // OK, UMA LISTA DE OBJECT PODE RECEBER UM DATETIME!
```

Mas espere... `listaObj` é na verdade uma lista de strings (`familia`)! Você não pode adicionar um `DateTime` a uma lista de strings!
E essa é uma _proteção_ da linguagem. Ela foi desenhada assim para gerar erro de compilação e prevenir contra erros de execução.

Será que essa "proteção" na linguagem também se aplica a arrays? Vamos verificar...

Primeiro criamos um array de strings:

```
var familiaArray = new string[] { "Dona Florinda", "Kiko" };
```

Agora vamos tentar converter (implicitamente) um array de `string` para um array de `object`:

```
object[] objArray = familiaArray;
```

Opa! Nenhum erro de compilação! 

Agora vamos tentar adicionar um inteiro a esse array:

```
objArray[0] = 123;
```

De novo, nenhum erro de compilação...

Vamos então rodar o código. Veja o que acontece:

```
Exceção Sem Tratamento: System.ArrayTypeMismatchException: 
Tentativa de acesso a um elemento como um tipo incompatível com a matriz.
```

Opa, agora sim, encontramos um problema! Por que isso acontece com arrays mas não com `List`?

Infelizmente, no início do desenvolvimento do C#, a Microsoft adicionou esse permissão de conversão implícita de arrays.
Quando o C# passou a ter _generics_, essa conversão implícita foi proibida na classe `List` (e na interface `IList` em geral).

> Essa capacidade de trocar o tipo do elemento de uma coleção para outro tipo de elemento (de tipo mais genérico) durante o cast é chamada de **covariância**.

- Cast de `List<string>` para `List<object>`: NÃO PODE, pois `IList` não permite covariância.
- Cast de `List<string>` para `object[]`: PODE, MAS NÃO DEVE, porque Arrays (infelizmente) permitem covariância.

Já vimos sobre cast para `List<object>` e para `object[]`, mas e quanto a `IEnumerable<object>`? Vamos tentar fazer esse terceiro tipo de cast:

```
IEnumerable<object> enumObj = familia;
```

Nenhum erro de compilação! Agora vamos rodar:

```
Pressione qualquer tecla para continuar. . .
```

Nenhum erro de execução! Mas por quê? O que há de difernete entre `IList<T>` e `IEnumerable<T>`?

Vejamos a declaração de cada uma das interfaces:

```
public interface IList<T>
```

```
public interface IEnumerable<out T> 
```

Veja a documentação do parâmetro T de `IEnumerable<T>`:

```
// Type parameters:
    //   T:
    //     The type of objects to enumerate.This type parameter is covariant. That is, you
    //     can use either the type you specified or any type that is more derived. For more
    //     information about covariance and contravariance, see Covariance and Contravariance
    //     in Generics.
```

Veja a diferença! `IEnumerable` recebe o _parâmetro de tipo_ `T` como **out**, isto é, a interface garante que o tipo `T` seja usado como **retorno**, mas nunca como **entrada**. Isto é, `IEnumerable` é uma interface para sequência somente-leitura e ela garante que a coleção não será modificada e, por isso, ela pode fazer a covariância com segurança!



