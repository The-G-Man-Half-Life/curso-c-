using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using ClaseOctava.Models;

//Usage of properties and methods
/*var example = new Ejemplo("Mateo", "Montoya Ospina");
Console.WriteLine(example.Name);
Console.WriteLine(example.Surname);
example.ToGreet();*/


//Usage of properties and methods with other syntax
/*StaticExample.Name = "Mateo";
StaticExample.Surname = "Montoya Ospina";
Console.WriteLine(StaticExample.Name);
Console.WriteLine(StaticExample.Surname);
StaticExample.ToGreet();*/

//Usage of a static class
// StaticExample.ToGreet();


//Usage of an hybrid class
var newUser = new HybridExample(1,"Mateo","Montoya Ospina",180);
HybridExample.ToShowHead();
newUser.ToShowInformation();
Console.WriteLine(HybridExample.ActualTime.ToString("yyyy/MM/dd"));
HybridExample.ToshowFooter();


