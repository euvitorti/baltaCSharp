// DATA É STRUCT
//var data = new DateTime();

using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
namespace Data
{
    class Program
    {
        static void Valores()
        {
            Console.Clear();

            Console.WriteLine("PEGANDO A DATA ATUAL");
            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.WriteLine("");

            Console.WriteLine("ESPECIFICANDO");
            data = DateTime.Now;
            Console.WriteLine($"YEAR: {data.Year}");
            Console.WriteLine($"MONTH: {data.Month}");
            Console.WriteLine($"DAY: {data.Day}");
            Console.WriteLine($"Day of Week: {data.DayOfWeek}");
            Console.WriteLine($"HOUR: {data.Hour}");
            Console.WriteLine($"MINUTES: {data.Minute}");
            Console.WriteLine($"SECONDS: {data.Second}");
        }

        static void Formatando()
        {
            Console.Clear();
            var data = DateTime.Now;

            // USAR OS SEGUINTES CARACTERES PARA FORMATAR DENTRO DA STRING. - d,y,m, h, m, s
            var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);

            Console.WriteLine(formatada);
        }

        static void PadraoFormatacao()
        {
            Console.Clear();
            var data = DateTime.Now;

            // t - d -  T - D - f - g - r - s - u
            var formatada = String.Format("{0:s}", data);

            Console.WriteLine(formatada);
        }

        static void AdicionandoValores()
        {
            Console.Clear();

            var data = DateTime.Now;
            Console.WriteLine(data);

            Console.WriteLine(data.AddDays(12));

            Console.WriteLine(data.AddMonths(1));

            Console.WriteLine(data.AddYears(1));
        }

        static void ComparandoDatas()
        {
            Console.Clear();

            // DateTime? data = null;//DateTime.Now;
            var data = DateTime.Now;
            Console.WriteLine(data);

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É IGUAL.");
            }
            else
            {
                Console.WriteLine("Não é igual");
            }

            Console.WriteLine(data);
        }

        static void Globalizacao()
        {
            // CultureInfo
            //PROCURAR POR CultureInfo no Google

            var brasil = new CultureInfo("pt-BR");
            var portugal = new CultureInfo("pt-PT");
            var eua = new CultureInfo("en-US");

            Console.WriteLine("");

            Console.WriteLine(DateTime.Now.ToString("D", brasil));
            Console.WriteLine(DateTime.Now.ToString("D", portugal));
            Console.WriteLine(DateTime.Now.ToString("D", eua));
        }

        static void Zona()
        {
            //GLOBAL
            var utcDate = DateTime.UtcNow;

            Console.WriteLine("");

            Console.WriteLine(utcDate);

            Console.WriteLine("");

            Console.WriteLine(utcDate.ToLocalTime());

            Console.WriteLine("");

            var timeZoneAustraulia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            var horaAustraulia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustraulia);

            Console.WriteLine(timeZoneAustraulia);

            Console.WriteLine("");

            Console.WriteLine(horaAustraulia);

            Console.WriteLine("UTILIZAR");

            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var i in timeZones)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, i));
                Console.WriteLine("----------");
            }
        }

        static void FracaoDoSegundo()
        {
            //USA MUITO NA PARTE DE FUNCIONÁRIOS, PARA O CALCULO DE HORAS
            Console.WriteLine("");
            var fracao = new TimeSpan();
            Console.WriteLine(fracao);

            Console.WriteLine("");

            var nanoSegundos = new TimeSpan(1);
            Console.WriteLine(nanoSegundos);

            Console.WriteLine("");

            Console.WriteLine("HORA-MINUTO-SEGUNDO");
            var horaMinutoSegundo = new TimeSpan(7, 45, 5);
            Console.WriteLine(horaMinutoSegundo);

            Console.WriteLine("");

            Console.WriteLine("DIA-HORA-MINUTO-SEGUNDO");
            var diaHoraMinutoSegundo = new TimeSpan(19, 7, 45, 6);
            Console.WriteLine(diaHoraMinutoSegundo);

            Console.WriteLine("");

            Console.WriteLine("DIA-HORA-MINUTO-SEGUNDO-MILISEGUNDO");
            var diaHoraMinutoSegundoMilisegundo = new TimeSpan(19, 7, 5, 8, 5);
            Console.WriteLine(diaHoraMinutoSegundoMilisegundo);

            Console.WriteLine(horaMinutoSegundo - diaHoraMinutoSegundo);
            Console.WriteLine(diaHoraMinutoSegundo.Days);
            Console.WriteLine(diaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }

        static void OutrosMetodos()
        {
            Console.WriteLine("");

            Console.WriteLine($"DIAS NO MÊS: {DateTime.DaysInMonth(2024, 2)}");
            Console.WriteLine($"FIM DE SEMANA OU NÃO: {IsWeekend(DateTime.Now.DayOfWeek)}");
            Console.WriteLine($"HORÁRIO DE VERÃO: {DateTime.Now.IsDaylightSavingTime()}");
        }

        static bool IsWeekend(DayOfWeek today){
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

        static void Main(string[] args)
        {
            Valores();
            Formatando();
            PadraoFormatacao();
            AdicionandoValores();
            ComparandoDatas();
            Globalizacao();
            Zona();
            FracaoDoSegundo();
            OutrosMetodos();
        }
    }
}