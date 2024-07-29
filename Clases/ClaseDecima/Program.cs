using ClaseDecima.Models;

//using father class
var firstAnimal = new Animal(12,"pedro","rata");

//using the child class
var secondAnimal = new Dog(2,"Destroyer of worlds","Canine",true);

Console.WriteLine(secondAnimal.GetName());