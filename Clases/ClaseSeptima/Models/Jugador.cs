using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace ClaseSeptima.Models;

public class Jugador : PersonalTecnico
{
 public string? Posicion {get; set;}
 public double Estatura {get; set;}
 public double Peso {get; set;}
 public string? ClubActual {get; set;}
 public string? PieHabil {get; set;}


 public void CalcularIMC()
 {
    double IMC = (this.Peso)/(this.Estatura * this.Estatura);
    Console.WriteLine($"El indice de masa corporal del jugador {this.Nombre} es {IMC}");
 }


 public Jugador(string? Posicion, double Estatura, double Peso, string? ClubActual, string? PieHabil)
 {
this.Posicion = Posicion;
this.Estatura = Estatura;
this.Peso = Peso;
this.ClubActual = ClubActual;
this.PieHabil = PieHabil;
 }
}
