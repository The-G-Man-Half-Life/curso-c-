using SextaClaseTarea.Models;

string tacticalSpaceRemastered =
@"                                                
***************************************************
    ";

void clear()
{
    Console.Clear();
}


//1 actividad
clear();
var persona = new Persona("mateo montoya ospina", 17);
Console.WriteLine($"Nombre: {persona.Nombre} y la edad es: {persona.Edad}");
Console.WriteLine(tacticalSpaceRemastered);

//2 actividad
var persona2 = new Persona2("santiago pineda");
Console.WriteLine(tacticalSpaceRemastered);

//3 actividad
var persona3 = new Persona3("patrick the rizzman");
Console.WriteLine(tacticalSpaceRemastered);

//4 actividad
var persona4 = new Persona4("AGUACATECO TACTICO");
Console.WriteLine(tacticalSpaceRemastered);