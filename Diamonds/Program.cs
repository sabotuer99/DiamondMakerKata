using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DiamondMaker();
            var lines = dm.MakeDiamond('O');

            foreach (string line in lines)
            {
                Console.Out.WriteLine(line);
            }

            Console.In.ReadLine();
        }
    }
}
