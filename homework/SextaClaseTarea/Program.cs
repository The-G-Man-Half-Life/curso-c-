using System.Timers;
using SextaClaseTarea.Models;


void tacticalSpaceRemastered()
{
Console.WriteLine(@"                                                
***************************************************
    ");
}

void clear()
{
    Console.Clear();
}


//1 actividad
clear();
var persona = new Persona("mateo montoya ospina", 17);
Console.WriteLine($"Nombre: {persona.Nombre} y la edad es: {persona.Edad}");
tacticalSpaceRemastered();

//2 actividad
var persona2 = new Persona2("santiago pineda");
tacticalSpaceRemastered();

//3 actividad
var persona3 = new Persona3("patrick the rizzman");
tacticalSpaceRemastered();

//4 actividad
var persona4 = new Persona4("AGUACATECO TACTICO",200);
tacticalSpaceRemastered();

//5 actividad
var coche5 = new Coche5("toyota","suv",new DateOnly(2023,04,12));
Console.WriteLine(coche5.Marca + " " + coche5.Modelo + " " + coche5.Año);
tacticalSpaceRemastered();

//6 actividad
var coche6 = new Coche6("ferrari","deportivo", new DateOnly(2024,12,12));
coche6.MostrarDetalles();
tacticalSpaceRemastered();

// 7 actividad
var coche7 = new Coche6("hyundai","casual", new DateOnly(2024,05,28));
coche7.MostrarDetalles();
coche7.ActualizarAño(new DateOnly(2000,12,11));
coche7.MostrarDetalles();
tacticalSpaceRemastered();

//8 actividad
var libro8 = new LIbro8("Huckleberry Finn","mark twain" );
Console.WriteLine($"El libro {libro8.Titulo} lo creo {libro8.Autor}");
tacticalSpaceRemastered();

//9 actividad
var libro9 = new Libro9("El amor en los tiempos del colera", "Gabriel Garcia Marquez", "Florentino Ariza");
Console.WriteLine($"El libro {libro9.Titulo} fue escrita por: {libro9.Autor} y dice {libro9.Texto} que tiene {libro9.CantidadDePalabras}palabras");
tacticalSpaceRemastered();

//10 actividad
var calcular10 = new Calculadora10(12,10);
Console.WriteLine($"Los numeros {calcular10.NumeroA} y {calcular10.NumeroB} al sumarlos da: {calcular10.Suma} y al restarlos da: {calcular10.Resta}");
tacticalSpaceRemastered();

//11 actividad
var producto11 = new Producto11("FUNDA DE AURICULARES EN FORMA DE PATRICIO RIZZMAN", 19000);
Console.WriteLine($"El producto {producto11.Nombre} tiene el precio: {producto11.Precio}");
tacticalSpaceRemastered();

//12 actividad
var producto12 = new Producto12("FUNDA CONTRACAIDAS,PROTECTOR DE CAMARAS Y AGARRE DE ANILLA PARA POCO X6 PRO", 28000);
Console.WriteLine($"El producto {producto12.Nombre} cuesta un total de: {producto12.Precio}");
producto12.CambiarNombre("Funda Protectora de poco x6 pro");