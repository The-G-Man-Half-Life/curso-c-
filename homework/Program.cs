//1
using System.Text;

Console.WriteLine("Hola, tonotos");
//2
int cantidadBernersLee = 40;
string nombre = "Mateo Montoya Ospina";
Console.WriteLine($"Hay un total de {cantidadBernersLee} miembros en BernersLee y yo soy: {nombre}");
//3
string palabra = "hola mundo chiquito";
string palabraUC = palabra.ToUpper();
Console.WriteLine(palabraUC);
string palabra2 = "HOLA MUNDO GRANDE";
string palabra2UC = palabra2.ToLower();
Console.WriteLine(palabra2UC);
//4
int firstInt = 3;
int secondInt = 2;


int suma = firstInt + secondInt;
int resta = firstInt - secondInt;
int multiplicacion = firstInt * secondInt;
int division = firstInt / secondInt;


Console.WriteLine(@$"los resultados de las operaciones entre:{firstInt} y {secondInt} son:
Suma:{suma}
resta:{resta}
multiplicacion:{multiplicacion}
division:{division}");
//5
int thirdInt = 4;
int fourthInt = 5;

bool firstComparition = thirdInt == fourthInt;
Console.WriteLine(firstComparition);

bool secondComparition = thirdInt != fourthInt;
Console.WriteLine(secondComparition);

bool thirdComparition = thirdInt < fourthInt;
Console.WriteLine(thirdComparition);

bool fourthComparition = thirdInt > fourthInt;
Console.WriteLine(fourthComparition);
//6
string sentence = "The gray fox jumps over the lazy dog";
string extraContent = "The orange";
int position = sentence.IndexOf("fox");

string resultado = extraContent + sentence.Substring(position-1);

Console.WriteLine(resultado);
//7
/*Console.Write("Escribe tu nombre: ");
string nombre2  = Console.ReadLine();

Console.Write("Escribe tu edad: ");
string edad2  = Console.ReadLine();
int edadInt = Convert.ToInt16(edad2);

Console.WriteLine($"Su nombre es: {nombre} y su edad es: {edad2}");*/
//8
Console.Write("Escribe un numero");
string numero = Console.ReadLine();
double numero2 = Convert.ToDouble(numero);

if (numero2<10)
{
    Console.WriteLine($"El numero {numero} es menor a 10");
}
else if(numero2==10)
{
    Console.WriteLine($"El numero {numero} es igual a 10");
}
else
{
    Console.WriteLine($"El numero {numero} es mayor a 10");
}
//9

//10

//11

//12

//13

//14

//15

//16

//17