//1.
// Console.Write("Ingrese un numero aleatorio");
// int number = Convert.ToInt16(Console.ReadLine());

// if(number == 0)
// {
//     Console.WriteLine("El numero escrito es 0");
// }

// else if (number%2==0)
// {
//     Console.WriteLine("El numero es par");
// }
// else
// {
//     Console.WriteLine("El numero es impar");
// }
//2.
// Console.Write("Ingrese su nombre: ");
// string nombre = Console.ReadLine();
// if (string.IsNullOrEmpty(nombre))
// {
//     Console.WriteLine("Este no es un valor valido por favor escriba su nombre bien");

// }
// else
// {
//     Console.WriteLine("Bienvenido");
// }
//3.
// Console.Write("Ingrese su edad");
// int edad = Convert.ToInt16(Console.ReadLine());

// if (edad < 18)
// {
//     Console.WriteLine("Eres menor de edad");
// }
// else
// {
//     Console.WriteLine("Eres mayor de edad");
// }
// //4.
// Console.Write("Ingrese un numero de entre 1 al 7");
// int dia = Convert.ToInt16(Console.ReadLine());

// switch (dia)
// {
//     case 1:
//         Console.WriteLine("Este numero corresponde al dia lunes");
//         break;
//     case 2:
//         Console.WriteLine("Este numero corresponde al dia martes");
//         break;
//     case 3:
//         Console.WriteLine("Este numero corresponde al dia miercoles");
//         break;
//     case 4:
//         Console.WriteLine("Este numero corresponde al dia jueves");
//         break;
//     case 5:
//         Console.WriteLine("Este numero corresponde al dia viernes");
//         break;
//     case 6:
//         Console.WriteLine("Este numero corresponde al dia sabado");
//         break;
//     case 7:
//         Console.WriteLine("Este numero corresponde al dia domingo");
//         break;

//     default:
//         Console.WriteLine("Ingrese un numero dentro del rango de 1 a 7");
//         break;
// }
// //5.
// Console.Write("Ingrese su nacionalidad");
// string? nacionalidad = Console.ReadLine().ToLower();

// string verificacion = ((nacionalidad == "colombiano") || (nacionalidad == "colombiana")) ? "Eres nativo bienvenido" : "Eres extranjero largate";
// Console.WriteLine(verificacion);
// //6.
// Console.Write("Ingrese un primer numero =>");
// int number1 = Convert.ToInt16(Console.ReadLine());

// Console.Write("Ingrese un segundo numero =>");
// int number2 = Convert.ToInt16(Console.ReadLine());

// Console.Write("Ingrese un tercer numero =>");
// int number3 = Convert.ToInt16(Console.ReadLine());

// if ((number1 > number2) && (number2 > number3))
// {
//     Console.WriteLine($"El numero:{number1} es mayor a {number2} y {number3}");
// }
// else if (number2 > number3)
// {
//     Console.WriteLine($"El numero:{number2} es mayor a {number1} y {number3}");
// }
// else if (number2 < number3)
// {
//     Console.WriteLine($"El numero:{number3} es mayor a {number2} y {number1}");
// }
// else
// {
//     Console.WriteLine("Los tres numeros son iguales");
// }
// //7.

// string contraseña = "gates4ever";
// Console.Write("Ingrese su contraseña");
// string contraseñaInput = Console.ReadLine();

// if (contraseñaInput == "")
// {
//     Console.WriteLine("Escribe bien la contraseña no la puedes dejar en blanco");
// }
// else if (contraseñaInput == contraseña)
// {
//     Console.WriteLine("La contraseña es correcta puedes pasar");
// }
// else
// {
//     Console.WriteLine("La contraseña es incorrecta vuelva a intentarlo");
// }

// //8.
// Console.Write("Ingrese un numero de entre 1 al 12");
// int mes = Convert.ToInt16(Console.ReadLine());

// switch (mes)
// {
//     case 1:
//         Console.WriteLine("Este numero corresponde al mes Enero");
//         break;
//     case 2:
//         Console.WriteLine("Este numero corresponde al mes Febrero");
//         break;
//     case 3:
//         Console.WriteLine("Este numero corresponde al mes Marzo");
//         break;
//     case 4:
//         Console.WriteLine("Este numero corresponde al mes Abril");
//         break;
//     case 5:
//         Console.WriteLine("Este numero corresponde al mes Mayo");
//         break;
//     case 6:
//         Console.WriteLine("Este numero corresponde al mes Junio");
//         break;
//     case 7:
//         Console.WriteLine("Este numero corresponde al mes Julio");
//         break;

//     case 8:
//         Console.WriteLine("Este numero corresponde al mes Agosto");
//         break;
//     case 9:
//         Console.WriteLine("Este numero corresponde al mes Septiembre");
//         break;
//     case 10:
//         Console.WriteLine("Este numero corresponde al mes Octubre");
//         break;
//     case 11:
//         Console.WriteLine("Este numero corresponde al mes Noviembre");
//         break;
//     case 12:
//         Console.WriteLine("Este numero corresponde al mes Diciembre");
//         break;
//     default:
//         Console.WriteLine("Ingrese un numero dentro del rango de 1 al 12");
//         break;
// }
// //9.
// Console.Write("Ingrese su nota de 1 a 5: ");
// double nota = Convert.ToDouble(Console.ReadLine());


// if ((nota <= 1))
// {
//     Console.WriteLine("F");
// }

// else if ((nota <= 2))
// {
//     Console.WriteLine("D");
// }

// else if ((nota <= 3))
// {
//     Console.WriteLine("C");
// }
// else if ((nota <= 4))
// {
//     Console.WriteLine("B");
// }
// else if ((nota <= 5))
// {
//     Console.WriteLine("A");
// }
// //10.
// Console.Write("Ingrese una letra cualquiera");
// string letra = Console.ReadLine().ToLower();

// if (letra.Length > 1 && string.IsNullOrEmpty(letra) && string.IsNullOrWhiteSpace(letra))
// {
//     Console.WriteLine("Lo que ingresaste no esta bien hecho hazlo de buena manera");
// }
// else
// {
//     switch (letra)
//     {
//         case "a":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "à":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "e":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "è":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "i":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "ì":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "o":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "ò":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "ù":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         case "ü":
//             Console.WriteLine("Esta es una vocal");
//             break;
//         default:
//             Console.WriteLine("Esta es una consonante");
//             break;
//     }
// }
// //11.
// Console.Write("Ingrese un numero: ");
// double number4 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ingrese otro numero: ");
// double number5 = Convert.ToDouble(Console.ReadLine());

// if (number4 == number5)
// {
//     Console.WriteLine("Ambos numeros son iguales");
// }
// else if (number4 < number5)
// {
//     Console.WriteLine($"El numero {number4} es menor a {number5}");
// }
// else if (number4 > number5)
// {
//     Console.WriteLine($"El numero {number5} es menor a {number4}");
// }
// else
// {
//     Console.WriteLine("Escriba un numero");
// }
// //12.
// Console.Write("Ingrese su direccion");
// string direccion = Console.ReadLine();

// if ((string.IsNullOrEmpty(direccion)) || (string.IsNullOrWhiteSpace(direccion)))
// {
//     Console.WriteLine("Debes de escribir tu direccion");
// }
// else
// {
//     Console.WriteLine("Tu direccion ha sido aceptada");
// }

// //13.
// Console.Write("Ingrese un numero cualquiera");
// double numero = Convert.ToDouble(Console.ReadLine());

// if (numero < 0)
// {
//     Console.WriteLine("El numero es negativo");
// }
// else if (numero == 0)
// {
//     Console.WriteLine("El numero es 0");
// }
// else
// {
//     Console.WriteLine("El numero es positivo");
// }
// //14.
// Console.Write("Ingrese una letra");
// string letrA = Console.ReadLine().ToLower();

// if (string.IsNullOrEmpty(letrA) || letrA.Length > 1)
// {
//     Console.WriteLine("Debes de escribir una letra cualquiera");
// }
// else if ((letrA == "a") || (letrA == "e") || (letrA == "i") || (letrA == "o") || (letrA == "u"))
// {
//     Console.WriteLine("La letra que escribiste es una vocal");
// }
// else
// {
//     Console.WriteLine("La letra que escribiste es una consonante");
// }
// //15.
// Console.Write("Ingrese una temperatura en grados celsius: ");
// double gradosCelsius = Convert.ToDouble(Console.ReadLine());

// if (gradosCelsius >= 30)
// {
//     Console.WriteLine("Esta caliente la temperatura");
// }
// else if ((gradosCelsius < 30) || (gradosCelsius > 10))
// {
//     Console.WriteLine("la temperatura esta templada");
// }
// else if (gradosCelsius <= 10)
// {
//     Console.WriteLine("La temperatura es fria");
// }
// //16.
// Console.Write("Ingrese un año cualquiera: ");
// double año = Convert.ToDouble(Console.ReadLine());
// bool verificacion1 = año % 4 == 0;
// bool verificacion3 = año % 400 == 0;

// if (verificacion1 == true)
// {
//     Console.WriteLine("El año es bisiesto");
// }
// else if (verificacion3 = true)
// {
//     Console.WriteLine("El año es bisiesto");
// }
// else
// {
//     Console.WriteLine("Este año no es bisiesto");
// }
// //17.
// Console.Write("Ingresa un numero");
// string numerO = Console.ReadLine();

// if (string.IsNullOrEmpty(numerO) || string.IsNullOrWhiteSpace(numerO))
// {
//     Console.WriteLine("Ingrese un valor valido");
// }
// else
// {
//     double numerO2 = Convert.ToDouble(numerO);
//     Console.WriteLine(numerO2);
// }
// //18.
// Console.Write("Ingrese un numero del 1 al 7");
// int valor = Convert.ToInt16(Console.ReadLine());

// switch (valor)
// {
//     case 1:
//         Console.WriteLine("Este es un dia laboral");
//         break;
//     case 2:
//         Console.WriteLine("Este es un dia laboral");
//         break;
//     case 3:
//         Console.WriteLine("Este es un dia laboral");
//         break;
//     case 4:
//         Console.WriteLine("Este es un dia laboral");
//         break;
//     case 5:
//         Console.WriteLine("Este es un dia laboral");
//         break;
//     case 6:
//         Console.WriteLine("Este es un dia de descanso");
//         break;
//     case 7:
//         Console.WriteLine("Este es un dia de descanso");
//         break;
// }