using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteParseConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConvertTo: " + TempoConvertTo());
            Console.WriteLine("Parse    : " + TempoParse());
            Console.WriteLine("TryParse : " + TempoTryParse());
        }

        static TimeSpan TempoConvertTo()
        {
            TimeSpan inicio = DateTime.Now.TimeOfDay;
            for (int i = 0; i < 90000000; i++)
            {
                Convert.ToInt32("01234");
            }
            return DateTime.Now.TimeOfDay.Subtract(inicio);
        }

        static TimeSpan TempoParse()
        {
            TimeSpan inicio = DateTime.Now.TimeOfDay;
            for (int i = 0; i < 90000000; i++)
            {
                int.Parse("01234");
            }
            return DateTime.Now.TimeOfDay.Subtract(inicio);
        }

        static TimeSpan TempoTryParse()
        {
            int resultado;
            TimeSpan inicio = DateTime.Now.TimeOfDay;
            for (int i = 0; i < 90000000; i++)
            {
                int.TryParse("01234", out resultado);
            }
            return DateTime.Now.TimeOfDay.Subtract(inicio);
        }
    }
}
