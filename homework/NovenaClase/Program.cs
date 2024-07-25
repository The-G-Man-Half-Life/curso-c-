using NovenaClase.models;
using NovenaClase.Models;

int counter = 1;
void Separator()
{
    Console.WriteLine(@$"

****************____{counter}_____***********************

");
counter++;
}

// exercise 1
Console.Clear();
Separator();
var cellphone = new BasicClass("Poco X6 Pro", "Mediatek 8300 ultra");
Console.WriteLine($"The name of the device is: {cellphone.CellphoneName} and it has the processor: {cellphone.ProcessorName}");

// exercise 2
Separator();
var Computer = new BasicClass2("Dell","Rizen900");
Console.WriteLine($"The name of the device is {Computer.ComputerName} and its brain is {Computer.Brand}");

// exercise 3
Separator();
var Computer2 = new BasicClass2("Lenovo","Rizen9000");
Console.WriteLine($"The name of the device is {Computer.ComputerName} and its brain is {Computer.Brand}");

// exercise 4
Separator();
var drone = new Drone3("Tacticopter",20000000000000000);

// exercise 5
Separator();
var listEstudiante = new List<Student5>{
    new Student5("pepe",12,"123"),
    new Student5("Santiago",17,"178"),
    new Student5("Duman",19,"12356")
};

foreach (var item in listEstudiante)
    {
        Console.WriteLine($"Name: {item.Name} Age: {item.Age} Tuition: {item.Tuition}");

    }

// exercise 6
Separator();
var bedroom = new BedRoom(new DateTime(2004,12,02),new DateTime(2015,12,12),"12","Suite");
Console.WriteLine($"startingDate: {bedroom.StartingDate} finishingDate: {bedroom.FinishingDate} bedroomNumber: {bedroom.RoomNumber} bedroomType: {bedroom.TypeOfRoom}");

// exercise 7
Separator();
var store = new Store8();
// store.Addgarment();
store.ShowClothes();
store.FindGarment("suite");

// exercise 8
Separator();
var factory = new Factory8();
// factory.AddEmployee();
factory.FindAndEmployee("santiago");
factory.ShowEmployees();

// exercise 9
Separator();
var school = new School9();
// school.AddACourse();
school.findACourse("math");
school.ShowCourses();

// exercise 10
Separator();
var circle = new Circle10();
var rectangle = new Rectangle10();

// circle.CalculateArea();
// rectangle.CalculateArea();

// exercise 11
Separator();
var car = new Car11();
var motorcycle = new Motorcycle11();

car.ToStartUp();
motorcycle.ToStartUp();

// exercise 12
Separator();
var programmer = new Programmer12();
var manager = new Manager12();

programmer.ToWork();
manager.ToWork();
// exercise 13
Separator();
var bus = new Bus13("Ferrari",2015,"water and earth","xl",4,"etanol","large travel bus");
var motorcycle2 = new Motorcycle13("honda",2024,"earth","diesel","SuperHonda");
var car2 = new Car13("ant",2020,"earth",6,"diesel","SuperSport");

bus.StartTravel();
bus.StopTravel();
bus.ShowDetails();

motorcycle2.StartTravel();
motorcycle2.StopTravel();
motorcycle2.ShowDetails();

car2.StartTravel();
car2.StopTravel();
car2.ShowDetails();

// exercise 14
Separator();
var foodItem = new Food14( "Apple", "Organic Farms Inc.", 50, 1.2, new DateTime(2024, 9, 30), "Fruit", false);
var clothesItem = new Clothes14( "T-shirt", "Fashion Co.", 20, 15.99, "Medium", "Cotton", "Casual");
var electronicItem = new Electronic14( "Smart TV", "Tech Innovations", 5, 799.99, 150, "Television");

foodItem.FinalPriceWithTaxes();
clothesItem.FinalPriceWithTaxes();
electronicItem.FinalPriceWithTaxes();

// exercise 15
Separator();
var nurse = new Nurse15( "Emily Smith", "N002", 50000.00, "Emergency Room");
var manager2 = new Manager15("John Doe","M001",60000.00,"Sales");
var doctor = new Doctor15( "Dr. Sarah Johnson", "D001", 120000.00, "Cardiology", "Cardiac Electrophysiology", 10);

nurse.ShowDetails();
nurse.ShowSalary();
manager2.ShowDetails();
manager2.ShowSalary();
doctor.ShowDetails();
doctor.ShowSalary();