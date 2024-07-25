
using TallerPOO.Models;

var student = new Student("mateo","montoya ospina","cedula", "123","mateomoospina@gmail.com","1234","mama","plata",new DateOnly(2023,12,01),new List<double> {85.5,1});
AppAdministrator.Students.Add(new Student("mateo","montoya ospina","cedula", "123","mateomoospina@gmail.com","1234","mama","plata",new DateOnly(2023,12,01),new List<double> {85.5,1}));
AppAdministrator.Students.Add(new Student("mateo","montoya ospina","cedula", "123","mateomoospina@gmail.com","1234","mama","plata",new DateOnly(2023,12,01),new List<double> {85.5,1}));

var teacher = new Teacher("John","Smith","ID","12345678","john.smith@example.com","123-456-7890","Math",50000.00,new DateTime(2020, 5, 15),new List<string> { "Algebra", "Physics 101","Calculus" });

// AppAdministrator.AddANewStudent();
// AppAdministrator.AddANewTeacher();
AppAdministrator.ShowStudents();
