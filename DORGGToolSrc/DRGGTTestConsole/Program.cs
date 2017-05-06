using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DRGGTLib.DarkOrbit;

namespace DRGGTTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i;

            i = new PartePortal(1494069886, 6, 44, 111, 45);
            Console.WriteLine(i.Descricao);

            i = new PartePortal(6, 71);
            Console.WriteLine(i.Descricao);

            i = new Item(3, 4, 1, 12, 1494069886);
            Console.WriteLine(i.Descricao);

            i = new Item(0, 2, 1, 280, 1494069886);
            Console.WriteLine(i.Descricao);

            i = new Item(5, 0, 1, 1, 1494069886);
            Console.WriteLine(i.Descricao);

            i = new Item(7, 0, 1, 1, 1494069886);
            Console.WriteLine(i.Descricao);

            Console.ReadKey();
        }
    }
}
