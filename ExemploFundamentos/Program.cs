using ExemploFundamentos.Common.Models; 

//LISTAS
/*
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
*/
/*
Console.WriteLine("Percorrendo o array com o for");
for(int contador = 0; contador < listaString.Count; contador++){
    Console.WriteLine($"Posição N° {contador} = {listaString[contador]}");
}

Console.WriteLine("Percorrendo o array com o foreach");
int contadorForeach = 0;
foreach(string item in listaString){
    Console.WriteLine($"Posição N° {contadorForeach} = {item}");
    contadorForeach++;
}
*/


















//ARRAY

int[] arrayInteiros = new int[4];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;


Console.WriteLine("Percorrendo o array com o for");
Console.WriteLine(arrayInteiros[5]);
for(int contador = 0; contador <arrayInteiros.Length;contador++){
    Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o array com o foreach");
int contadorForeach = 0;
foreach(int valor in arrayInteiros){
    Console.WriteLine($"Posição N° {contadorForeach} = {valor}");
    contadorForeach++;
}

//redimensionando o array
//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//copiando array
//int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
//Array.Copy(arrayInteiros,arrayInteirosDobrado,arrayInteiros.Length);























/*
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Bruno";
pessoa1.Idade = 22;
pessoa1.Apresentar();
*/







/*
string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");
    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastgro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            //Environment.Exit(0);//encerrar programa
            break;
        default:
        Console.WriteLine("Digite uma opção válida");
            break;
    }

}
//Refatorar...
Console.WriteLine("Ola");
*/




























//OPERADORES ARITIMETICOS
/*
Calculadora calc = new Calculadora();
calc.Somar(9, 6);
calc.Subtrair(10,50);
calc.Multiplicar(15,50);
calc.Dividir(3,3);

//usando potencia
calc.Potencia(3,3);

//funcoes trigonometricas
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

//incremento e decremento
int numero = 10;
Console.WriteLine(numero);
Console.WriteLine("Incrementando o 10");
//numero = numero + 1;
numero ++;

Console.WriteLine(numero);

Console.WriteLine($"Decrementando o {numero}");
//numero = numero + 1;
numero --;

Console.WriteLine(numero);

//Calculando raiz quadrada
calc.RaizQuadrada(9);

*/





















//OPERADORES CONDICIONAIS
//SWITCH CASE
/*
Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();
//alternativa para quando se tem um if alinhado
//em via de regra se vc tem varios else if, considere troca-los por switch
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é Vogal");
        break;
}
*/

//Maneira reduzida, mas não o mais indicado/melhor
/*
if (letra =="a" ||
    letra =="e" ||
    letra =="i" ||
    letra =="o" ||
    letra =="u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é vogal");
}
*/


//Muito grande, desnecessario
/*if(letra == "a")
{
    Console.WriteLine("Vogal");
}
else if(letra == "e")
{
    Console.WriteLine("Vogal");
}
else if(letra == "i")
{
    Console.WriteLine("Vogal");
}
else if(letra == "o")
{
    Console.WriteLine("Vogal");
}
else if(letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é vogal");
}
*/
// IF
/*int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeEmEstoque>=quantidadeCompra && quantidadeCompra > 0;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
*/






















//CONVERTENDO DE MANEIRA SEGURA
/*
string a = "15-";//por exemplo se colocar um caracter q não seja numero

//int b = 0;

//int.TryParse(a, out b);//tenta converter a, se não conseguir o valor de saida é o b

int.TryParse(a, out int b);//posso declarar uma nova variavel acessivel dessa linha para baixo

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");
*/




//CONVERTENDO TIPOS DE VARIAVEIS
/*
//STRING PARA OUTROS TIPOS

//diferenca entre Convert e Parse é o Tratamento de valores nulos

//Convert.To... - valor null se transforma em 0
//int a = Convert.ToInt32("5");

// ....parse - da erro/encerra o programa
//int a = int.Parse("5");

//PARA STRING
//.ToString() tudo que vai fazer tem ele, seja para qualquer tipo
//int inteiro = 5;
//string a = inteiro.ToString();


//IMPLICITO
//um tipo menor que o outro é convertido implicitamente

//O inteiro cabe no double por exemplo, mas não o contrario
//int a = 5;
//double b = a;

//O inteiro cabe no long por exemplo, mas não o contrario
//int a = 5;
//long b = a;


//Console.WriteLine(b);
*/






















/*
string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.79;

//decimal geralmente usado para valores monetarios
decimal money = 20.22M;//use um sufixo "M" para criar um literal desse tipo

Console.WriteLine($"{apresentacao} {altura} {quantidade}{money}");
*/

/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Bruno";
pessoa1.Idade = 22;
pessoa1.Apresentar();*/