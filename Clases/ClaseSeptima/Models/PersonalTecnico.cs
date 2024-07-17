using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseSeptima.Models;
public class PersonalTecnico
{
    public int Id  {get; set;}
    public string? Nombre {get; set;}
    public string? Apellido {get; set;}
    public string? TipoDeDcoumento {get; set;}
    public string? NumeroDeDocumento {get; set;}
    public DateOnly FechaDeNacimiento {get; set;}
    public string? RH {get; set;}
    public string? TallaSuperior {get; set;}
    public string? TallaInferior {get; set;}
    public double TallaZapatos {get; set;}


    public void CalcularEdad()
    {
        int Edad = DateTime.Now.Year - this.FechaDeNacimiento.Year; 
        if(DateTime.Now.Month == this.FechaDeNacimiento.Month && DateTime.Now.Day <= this.FechaDeNacimiento.Day)
        {
            Console.WriteLine("La edad del jugador es " + Edad);
        }
        else if(DateTime.Now.Month < this.FechaDeNacimiento.Month)
        {
            Console.WriteLine("La edad del jugador es " + Edad);
        }
        else
        {
            Edad--;
            Console.WriteLine("La edad del jugador es " + Edad);
        }
    }
}