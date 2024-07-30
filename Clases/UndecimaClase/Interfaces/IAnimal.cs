using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UndecimaClase.Interfaces;

public interface IAnimal
{
    void Eat(double newWeight);
    void Sleep();
    void Breath();
    void Move();
}
