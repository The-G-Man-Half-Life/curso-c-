// ciclo for 
//crear el contador/decir cuantas vueltas realizara/ realizar el incrementador numerico

for(int i = 0; i<=10;i++)
{
    Console.WriteLine("Hola mundo");
}

//ciclo foreach

string[] nombres = {"juan","pedro","ana"};
foreach(string nombre in nombres)
{
    Console.WriteLine($"hola");
}

//ciclo while

bool flag = true;

while (flag)
{
    Console.WriteLine("Hola tonotos");
    Console.Write("Quieres repetir la palabra");
    string? respuesta = Console.ReadLine().ToLower();
    if(respuesta =="no")
    {
        flag = false;
    }
}