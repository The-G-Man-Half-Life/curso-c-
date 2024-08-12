using Humanizer;

string nombre = "mateo";
string apellido = "montoya ospina";
int sueldo = 300000000;
Console.WriteLine($"Hola {nombre} {apellido}");
Console.WriteLine($"");

Console.WriteLine($"Tu sueldo actual es: {sueldo}");
Console.WriteLine($"Osea ganas {sueldo.ToWords()} pesos colombianos");
