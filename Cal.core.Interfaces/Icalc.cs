using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.core.Interfaces;

public interface Icalc
{
    public EventHandler Procesando { get; set; }
    public EventHandler Termino { get; set; }
    int Suma(int x, int y);
    int Resta(int x, int y);
    int Division(int x, int y);
    int Multiplicacion(int x, int y);
}
