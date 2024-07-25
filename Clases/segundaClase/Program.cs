// Console.WriteLine("Ingresa tu edad por favor: ");
// string edad2 = Console.ReadLine();
// byte edad = Convert.ToByte(edad2);

// condicional simple 
// if (edad>= 18)
// {
//     Console.WriteLine("Eres mayor de edad");
// }

// condicional normal
// if (edad>=18)
// {
//     Console.WriteLine("Eres mayor de edad");
// }
// else
// {
//     Console.WriteLine("Eres menor de edad");
// }

// Condicional compuesta

// if (edad>=18)
// {
//     Console.WriteLine("Eres mayor de edad");
// }
// else if (edad == 18)
// {
//     Console.WriteLine("tienes 18 años exactamente");
// }
// else
// {
//     Console.WriteLine("Eres menor de edad");
// }

//ejemplo de condicionales aplicadas
Console.Write("Ingresa tu numero de 1 al 7 por favor =>");
byte numero = Convert.ToByte(Console.ReadLine());

if (numero == 1)
{
    Console.WriteLine("Elegistee el Dia Lunes");
}
else if (numero == 2)
{
    Console.WriteLine("Elegistee el Dia Martes");
}
else if (numero == 3)
{
    Console.WriteLine("Elegistee el Dia Miercoles");
}
else if (numero == 4)
{
    Console.WriteLine("Elegistee el Dia Jueves");
}
else if (numero == 5)
{
    Console.WriteLine("Elegistee el Dia Viernes");
}
else if (numero == 6)
{
    Console.WriteLine("Elegistee el Dia Sabado");
}
else if (numero == 7)
{
    Console.WriteLine("Elegistee el Dia Domingo");
}
else
{
    Console.WriteLine("Debes de escribir un numero dentro del rango del 1 al 7");

}

//ejemplo de condicional usando switch

switch (numero)
{
    case 1:
        Console.Write("Elegiste el dia Lunes");
        break;
    case 2:
        Console.Write("Elegiste el dia Martes");
        break;
    case 3:
        Console.Write("Elegiste el dia Miercoles");
        break;
    case 4:
        Console.Write("Elegiste el dia Jueves");
        break;
    case 5:
        Console.Write("Elegiste el dia Viernes");
        break;
    case 6:
        Console.Write("Elegiste el dia Sabado");
        break;
    case 7:
        Console.Write("Elegiste el dia Domingo");
        break;
    default:
        Console.WriteLine("Debes de escribir un numero dentro del rango del 1 al 7");
        break;
}