// MELHOR TIPO É O DECIMAL

using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void TiposDeDados()
        {
            Console.Clear();
            Console.WriteLine("");

            decimal valor = 10.25m;

            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
        }

        static void Matematica()
        {
            Console.Clear();
            Console.WriteLine("");

            decimal valor = 10.25m;

            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
        }

        static void Main()
        {
            // TiposDeDados();
            Matematica();
        }
    }
}