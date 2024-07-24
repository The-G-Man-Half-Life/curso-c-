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

circle.CalculateArea();
rectangle.CalculateArea();

// exercise 11
Separator();
var car = new Car11();
var motorcycle = new Motorcycle11();

car.ToStartUp();
motorcycle.ToStartUp();

// exercise 12

// exercise 13

// exercise 14

// exercise 15