using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseSeptima.Models;

public class Entrenador: PersonalTecnico
{
 public byte ExperienciaEnAños {get;set;}
 public string? Nacionalidad {get; set;}
 public byte CantidadDeTitulos {get; set;}
 public double Salario {get; set;}

 public Entrenador(byte ExperienciaEnAños, string? Nacionalidad, byte CantidadDeTitulos, double Salario)
 {
    this.ExperienciaEnAños = ExperienciaEnAños;
    this.Nacionalidad = Nacionalidad;
    this.CantidadDeTitulos = CantidadDeTitulos;
    this.Salario = Salario;
 }
}
