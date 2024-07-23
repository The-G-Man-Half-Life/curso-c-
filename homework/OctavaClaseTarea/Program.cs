using System.Diagnostics.Metrics;
using OctavaClaseTarea.Models;
using OctvaClaseTarea.models;
using OctvaClaseTarea.Models;

int exercise = 1;

void Separator()
{
string tacticalSeparatorTheVengeance = 
@$" 
*******************_____________{exercise}____________*******************
";
Console.WriteLine(tacticalSeparatorTheVengeance);
exercise ++;
}

//Exercise 1
Separator();
for (int i = 0; i < 5; i++)
{
    Counter1.ToIncrease();
}

//Exercise 2
Separator();
var converter = new Converter2(12);
converter.CelsiusToFarenheit();

//Exercise 3
Separator();
Configuration3.ChangeMode();
Configuration3.ChangeMode();

//Exercise 4
Separator();
var operations = new UsefulMath4(100,20);
operations.Operations();

//Exercise 5
Separator();
AritmeticCalculator5.Sum(5,2);
AritmeticCalculator5.Difference(1,2);
AritmeticCalculator5.Multiplication(10,100);
AritmeticCalculator5.Division(10000,10);
//Exercise 6
Separator();
MessagesStorage6.AddANewMessage("Wo shi");
MessagesStorage6.AddANewMessage("patrick the Rizzman");
MessagesStorage6.ShowAllMessages();
//Exercise 7
Separator();
DataBase7.ToShowConnection();
//Exercise 8
Separator();
utilityChain8.ReverseChain("patrick the rizzman");
//Exercise 9
Separator();
User9.TotalUsers();
//Exercise 10
Separator();
utilityDate9.DaysBetweenDate(new DateTime(2024,02,20), new DateTime(2024,01,20));
//Exercise 11
Separator();
Bank10.calculateInterest(100,10);
//Exercise 12
Separator();
ConfigurationApp.ToShowVersion();
//Exercise 13
Separator();
ManageInventory.inventory.Add("TANK 3 PRO");
ManageInventory.ToShowTotalOfProducts();
//Exercise 14
Separator();
TotalRegisters.Registers.Add("TANK 3 PRO");
TotalRegisters.ToShowTotalOfRegisters();
