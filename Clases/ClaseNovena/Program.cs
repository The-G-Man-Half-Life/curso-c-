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
var firstPet = new Dog("antonio","macho","Retriever",200);
firstPet.ToTalk();
firstPet.ToMove();
separator();
var secondPet = new Cat("antonio","macho","Retriever",200);
secondPet.ToTalk();
secondPet.ToMove();
separator();
var thirdPet = new Fish("antonio","macho","Retriever",200);
thirdPet.ToTalk();
thirdPet.ToMove();