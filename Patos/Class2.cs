using System;
using System.Collections.Generic;
using System.Text;

namespace Patos
{
    public class VolarConAlas : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("Volando con alas");
        }
    }

    public class NoVolar : IVolar
    {
        public void Volar()
        {
            Console.WriteLine("No puedo volar");
        }
    }
    class PatoDomestico : Pato
    {
        public PatoDomestico() :
            base(new GraznarComoUnPato(), new VolarConAlas())
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato doméstico");
        }
    }

    class PatoDeJuguete : Pato
    {
        public PatoDeJuguete() :
                base(new GraznarComoUnaBocina(), new NoVolar())
        {
        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato de juguete");
        }
    }

    class PatoDecorativo : Pato
    {
        public PatoDecorativo() :
            base(new GraznarEnSilencio(), new NoVolar())
        {

        }


        public override void Mostrar()
        {
            Console.WriteLine("Soy un pato decorativo");
        }
    }
}
