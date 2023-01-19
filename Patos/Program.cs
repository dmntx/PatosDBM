using System;

namespace Patos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato1 = new PatoDecorativo();
            pato1.Mostrar();
            pato1.Graznar();
            pato1.Volar();
            pato1.Nadar();
        }
    }
}
