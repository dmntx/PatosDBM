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
    public class Quack : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }

    public class Squeze : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("Squeze!!!");
        }
    }

    public class Mute : IGraznar
    {
        public void Graznar()
        {
            Console.WriteLine("<<No hace ningun ruido>>");
        }
    }
}
