using System;
using System.Collections.Generic;
using System.Text;

namespace Patos
{
    interface IVolar
    {
        void Volar();
    }

    interface IGraznar
    {
        void Graznar();
    }
    public class GraznarComoUnPato : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Cuac, cuac!");
        }
    }

    public class GraznarComoUnaBocina : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("¡Meec, meec!");
        }
    }

    public class GraznarEnSilencio : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("");
        }
    }
}
