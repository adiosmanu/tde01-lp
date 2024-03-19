class tde01{
    static void Main(){

    

// 1. Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor. //

byte idade = 35;

Console.WriteLine(idade);

// 2.  Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.//

string nome = "Maria";

Console.WriteLine(nome);

//3. Crie uma variável chamada altura e atribua a ela o valor 3.45//

object altura = 3.45;

Console.WriteLine(altura);

// 4. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor//


 const int ano = 12;

 Console.WriteLine(ano);

 // 5. Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.//

 double? nota = 7.80;

 Console.WriteLine(nota);

//6 . Quais as diferenças entre os tipos por valor e os tipos por referência ?
// A diferença entre os tipos por valor e tipos de referencia são como os dados são armazenados na memória,
//na alocação de memória e no comportamento de cópia e nulidade.

 // 7. O que é um nullable type e qual a sua utilidade ?
 // Nullable Type é um tipo de dado que pode conter um valor, ou pode ser null. ou seja, não contem nenhum valor.
 // Ele é utilizado para representrar a ausência de valor.

 //8. O que é Camel Case ? Dê um exemplo de sua aplicação.//
 //É usado para nomear campos para dar o prefixo a eles. 
 //Ele ajuda a tornar o código mais legivel facilitanto a identificar palavras compostas e diferenciar maiusculas das minusculas.

 //9. O que é Pascal Case ? Dê um exemplo de sua aplicação
// É usada como um identificador onde todas as palavras são concatenada sem espaços.
// É utilizada para nomes de classes, metódos e outros identificadores.

//10. Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. 
//(Use o operador aritmético + para realizar a operação de soma)//

int x = 77;
int y = 66;

int soma = x + y;

Console.WriteLine("A soma entre x e y é de: " + soma);

//11. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
//bool: false
//char: '\0',caractere nulo
//int: 0
//double: 0.0
//float:0.0f
//decimal: 0.0m
//string: null

















}
}