using System;
using System.Collections.Generic;
using System.Text;

namespace Patos
{
    abstract class Pato
    {
        private readonly IGraznar _estrategiaGraznar;
        private readonly IVolar _estrategiaVolar;

        protected Pato(IGraznar estrategiaGraznar, IVolar estrategiaVolar)
        {
            _estrategiaGraznar = estrategiaGraznar;
            _estrategiaVolar = estrategiaVolar;
        }

        public void Graznar()
        {
            _estrategiaGraznar.Graznar();
        }

        public void Volar()
        {
            _estrategiaVolar.Volar();
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");
        }


        public abstract void Mostrar();
    }
}
