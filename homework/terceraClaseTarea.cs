//1
// for(int i = 0; i<100; i++)
// {
//     Console.WriteLine($"numero:{i+1}");
// }
//2
// Console.Write("Ingrese un numero cualqiera =>");
// int number= Convert.ToInt16(Console.ReadLine());

// for (int i = 1; i <= number; i++)
// {
//     if (i%2!=0)
//     {
//         continue;
//     }
//     else
//     {
//         Console.WriteLine($"Numero par: {i}");
//     }
// }

//3
// Console.Write("Ingrese un numero entero positivo");
// string numberP = Console.ReadLine();


// int numberPR; 
// bool isInteger = int.TryParse(numberP, out numberPR);

// if(isInteger==true && int.IsPositive(numberPR))
// {
//     for(int i = 0; i<10; i++)
//     {
//         Console.WriteLine($"{i+1}.{numberPR*(i+1)}");
//     }
// }
// else
// {
//     Console.WriteLine("Debes de escribir un numero entero positivo");
// }

//4

// Random random = new Random();
// int randomNumber = random.Next(1,101);

// while(true)
// {
//     Console.Write("Adivina un numero del 1 al 100 => ");
//     string? numberInput = Console.ReadLine();
//     int numberInput2;
//     bool isInteger = int.TryParse(numberInput, out numberInput2);
//     Console.WriteLine(isInteger);
//     Console.WriteLine(int.IsNegative(numberInput2));
//     Console.WriteLine(string.IsNullOrEmpty(numberInput)==true);


//     if(isInteger==false || int.IsNegative(numberInput2)==true || string.IsNullOrEmpty(numberInput)==true)
//     {
//         Console.WriteLine("Debes de seguir las normas");
//     }
//     else{
//         if(numberInput2<randomNumber)
//     {
//         Console.WriteLine("Debes de aumentar el valor del numero");
//     }
//     else if (numberInput2>randomNumber)
//     {
//         Console.WriteLine("Debes de disminuir el valor del numero");
//     }
//     else
//     {
//         Console.WriteLine("Acabas de adivinar el numero bien hecho");
//         break;
//     }
//     }

// }

//5
// using System.Runtime.ConstrainedExecution;

// Console.Write("Ingresa un numero positivo => ");
// string? numberP = Console.ReadLine();

// int numberPR; 
// bool isInteger = int.TryParse(numberP, out numberPR);

// if(isInteger==false || int.IsNegative(numberPR)==true || string.IsNullOrEmpty(numberP))
// {
//     Console.WriteLine("Debes de apegarte a la norma");
// }
// else
// {
//     for(int i = numberPR; i>=1; i--)
//     {
//         if(i%2!=0){
//             Console.WriteLine($"Numero impar: {i}");
//         }
//         else
//         {
//             continue;
//         }
//     }
// }
//6
// while(true)
// {
// Console.Write("Ingrese la contraseña =>");
// string contraseña = Console.ReadLine();

// if (contraseña != "secreta")
// {
//     Console.WriteLine("La contraseña es incorrecta vuelve a intentarlo");
// }
// else
// {
//     Console.WriteLine("Bienvenido");
//     break;
// }
// }
//7

//8
// Console.Write("Ingrese un numero entero para verificar si es primo o no => ");
// int numero = Convert.ToInt16(Console.ReadLine());

// bool identificadorPrimo = false;

// for (int i = numero; i >= 1; i--)
// {
//     if (i == 1)
//     {
//         continue;
//     }
//     else if (numero == i)
//     {
//         continue;
//     }
//     else
//     {
//         if (numero % i == 0)
//         {
//             identificadorPrimo = false;
//             break;
//         }
//         else
//         {
//             identificadorPrimo = true;
//         }
//     }
// }
// if (identificadorPrimo == true || numero == 2)
// {
//     Console.WriteLine("El numero es primo");
// }
// else
// {
//     Console.WriteLine("El numero no es primo");
// }
//9
// Console.Write("Ingrese una palabra cualquiera");
// string palabra = Console.ReadLine();
// char[] arrayPalabra = palabra.ToCharArray();

// foreach(char c in arrayPalabra)
// {
//     Console.WriteLine(c);

// }
//10
// Console.Write("Ingrese un numero positvio");
// int numero = Convert.ToInt16(Console.ReadLine());

// int suma = 0;

// for(int i = 0; i<=numero;i++)
// {
//     suma+i;
// }
