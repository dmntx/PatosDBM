using System;

namespace Patos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato decoy = new DuckDecoy();
            Pato patoDeHule = new Rubber();
            Pato mallard = new Mallard();
            Pato red = new RedHead();
            decoy.ShowDuck(); Console.WriteLine("\n");
            patoDeHule.ShowDuck(); Console.WriteLine("\n");
            mallard.ShowDuck(); Console.WriteLine("\n");
            red.ShowDuck();
        }
    }
}
