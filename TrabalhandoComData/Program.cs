using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Data sem  Horario
            DateTime data = new DateTime(2017, 09, 23);
            Console.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Console.WriteLine(data.ToString("dd/MM"));


            //Data com Horario
            data = new DateTime(2017, 09, 23, 13, 14, 15, 987);
            Console.WriteLine(data);
            Console.WriteLine(data.ToString("HH:mm"));
            Console.WriteLine(data.ToString("HH:mm:ss.fff"));

            //Data por extenso
            Console.WriteLine(data.ToString("D"));
            Console.WriteLine(data.ToString("m"));
            Console.WriteLine(data.ToString("Y"));

            // Formatação de data ida e volta
            Console.WriteLine(data.ToString("G"));
            Console.WriteLine(data.ToString("O"));
            Console.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:ss.fff"));

            // Pega hora com segundo ou sem
            Console.WriteLine(data.ToString("t"));
            Console.WriteLine(data.ToString("T"));

            Console.ReadLine();
        }
    }
}
