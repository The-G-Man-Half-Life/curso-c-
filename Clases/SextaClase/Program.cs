using SextaClase.Models;

Console.Clear();

//mejor practica
var miPrimeraPersona = new Person(1,"Mateo Montoya Ospina", "Masculino", "Colombiano", "3052992844","mateomoospina@gamil.com", new DateOnly(2006,10,26));
miPrimeraPersona.Saludar();
// Terrible practica nunca hacer
// miPrimeraPersona.Id = 1;
// miPrimeraPersona.Nombre = "Mateo Montoya Ospina";
// miPrimeraPersona.Genero = "Masculino";
// miPrimeraPersona.Nacionalidad = "Colombiano";
// miPrimeraPersona.Telefono = "30529992844";
// miPrimeraPersona Correo = "mateomoospina@gmail.com";
// miPrimeraPersona.FechaDeNacimiento = new DateOnly(2006,10,26);




