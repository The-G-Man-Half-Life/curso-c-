// primer metodo
string nombre = "Mateo";
string apellido = "Montoya Ospina";
byte edad = 17;
string clan = "Berners Lee";
string gmail = "mateomoospina@gmail.com";

Console.WriteLine("Mi nombre es:" + nombre + " " + apellido + " ,mi clan es: " + clan + ", mi edad es: " + edad + "mi Gmail es: " + gmail );

//segundo metodo
Console.WriteLine("Nombre:"+"Mateo Montoya Ospina");
Console.WriteLine("Gmail:" + "mateomoospina@gmail.com");
Console.WriteLine("Clan:"+"Berners Lee");
Console.WriteLine("Edad:"+"17 años");

// tercer metodo
string saludo = $"Mi nombre es: {nombre}, mi apellido es: {apellido}, mi edad es: {edad}, mi clan es: {clan} y mi gmail es: {gmail}";
Console.WriteLine(saludo);

//cuarto metodo 
string saludo2 = @$"Mi nombre es: {nombre} 
mi apellido es: {apellido},
mi edad es: {edad}, 
mi clan es: {clan} y 
mi gmail es: {gmail}";
Console.WriteLine(saludo2);