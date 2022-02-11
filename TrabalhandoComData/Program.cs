using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 09, 23);
            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Console.WriteLine(data.ToString("dd/MM"));

            Console.ReadLine();
        }
    }
}
