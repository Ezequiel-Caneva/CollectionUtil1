using Calc.core.Interfaces;

namespace CalcSuperPower
{
    public class Calcsuperpower : Icalc
    {
        public EventHandler Procesando { get; set; }
        public EventHandler Termino { get; set; }


        public int Suma(int x, int y)
        {
            if (Procesando != null)
            {
                Procesando.Invoke(this, new EventArgs());
            }
            var resultado = x + y + 1000;
            Thread.Sleep(1000);

            if (Termino != null)
            {
                Termino.Invoke(this, new EventArgs());
            }
            return resultado;
        }
        public int Resta(int x, int y)
        {
            return x - y + 1000;
        }
        public int Division(int x, int y)
        {
            return x / y + 1000;

        }
        public int Multiplicacion(int x, int y)
        {
            return x * y + 1000;
        }

    }
}