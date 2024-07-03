//1
// using System.Text;

// Console.WriteLine("Hola, tonotos");
//2
// int cantidadBernersLee = 40;
// string nombre = "Mateo Montoya Ospina";
// Console.WriteLine($"Hay un total de {cantidadBernersLee} miembros en BernersLee y yo soy: {nombre}");
//3
// string palabra = "hola mundo chiquito";
// string palabraUC = palabra.ToUpper();
// Console.WriteLine(palabraUC);
// string palabra2 = "HOLA MUNDO GRANDE";
// string palabra2UC = palabra2.ToLower();
// Console.WriteLine(palabra2UC);
//4
// int firstInt = 3;
// int secondInt = 2;


// int suma = firstInt + secondInt;
// int resta = firstInt - secondInt;
// int multiplicacion = firstInt * secondInt;
// int division = firstInt / secondInt;


// Console.WriteLine(@$"los resultados de las operaciones entre:{firstInt} y {secondInt} son:
// Suma:{suma}
// resta:{resta}
// multiplicacion:{multiplicacion}
// division:{division}");
//5
// int thirdInt = 4;
// int fourthInt = 5;

// bool firstComparition = thirdInt == fourthInt;
// Console.WriteLine(firstComparition);

// bool secondComparition = thirdInt != fourthInt;
// Console.WriteLine(secondComparition);

// bool thirdComparition = thirdInt < fourthInt;
// Console.WriteLine(thirdComparition);

// bool fourthComparition = thirdInt > fourthInt;
// Console.WriteLine(fourthComparition);
// //6
// string sentence = "The gray fox jumps over the lazy dog";
// string extraContent = "The orange";
// int position = sentence.IndexOf("fox");

// string resultado = extraContent + sentence.Substring(position-1);

// Console.WriteLine(resultado);
//7
/*Console.Write("Escribe tu nombre: ");
string nombre2  = Console.ReadLine();

Console.Write("Escribe tu edad: ");
string edad2  = Console.ReadLine();
int edadInt = Convert.ToInt16(edad2);

Console.WriteLine($"Su nombre es: {nombre} y su edad es: {edad2}");*/
//8
// Console.Write("Escribe un numero");
// string numero = Console.ReadLine();
// double numero2 = Convert.ToDouble(numero);

// if (numero2<10)
// {
//     Console.WriteLine($"El numero {numero} es menor a 10");
// }
// else if(numero2==10)
// {
//     Console.WriteLine($"El numero {numero} es igual a 10");
// }
// else
// {
//     Console.WriteLine($"El numero {numero} es mayor a 10");
// }
//9
// double sixthInt = 6;
// double seventhInt = 7;

// double sumaD = sixthInt + seventhInt;
// double restaD = sixthInt - seventhInt;
// double multiplicacionD = sixthInt * seventhInt;
// double divisionD = sixthInt / seventhInt;


// Console.WriteLine(@$"los resultados de las operaciones entre:{sixthInt} y {seventhInt} son:
// Suma:{sumaD}
// resta:{restaD}
// multiplicacion:{multiplicacionD}
// division:{divisionD}");
//10
// string cadena1 = "Hola"
// string cadena2 = "tonotos"

// Console.WriteLine($"{cadena1} + {cadena2}")
//11
// int number = 3;
// double numberD = Convert.ToDouble(number);

// Console.WriteLine(number + " " + numberD)
//12
// Console.Write("Ingrese un numero cualquiera: ");
// string number2 = Console.ReadLine();
// double number = Convert.ToDouble(number);

// if (number<0)
// {
//     Console.WriteLine("El numero es menor a 0");
// }
// else if(number==0)
// {
//     Console.WriteLine("El numero es 0");
// }
// else
// {
//     Console.WriteLine("El numero es mayor a 0");
// }
//13
// for (int i = 0; i<10; i++)
// {
//     Console.WriteLine(i);
// }
//14

//15
Console.Write("Ingrese un numero cualquiera: ")
string number = Console.ReadLine();
double number2 = Convert.ToDouble(number);

for (int i = 0; i < number2; i++)
{
    Console.WriteLine($"{i}. {i*number2}");
}
//16

//17