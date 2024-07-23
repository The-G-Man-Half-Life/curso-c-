using ClaseNOvena.Models;

void separator()
{
    Console.WriteLine(@" 
***************************************
");
}

var mainPet = new Animal("pepe","macho","estrella",120);
mainPet.ToTalk();
mainPet.ToMove();
separator();
var firstPet = new Dog();
firstPet.ToTalk();
firstPet.ToMove();
separator();
var secondPet = new Cat();
secondPet.ToTalk();
secondPet.ToMove();
separator();
var thirdPet = new Fish();
thirdPet.ToTalk();
thirdPet.ToMove();