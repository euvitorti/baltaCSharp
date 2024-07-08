using System.Data.Common;

namespace Vetor
{
    class Program
    {
        static void Percorrendo()
        {
            Console.Clear();
            // var meuArray = new int[5] { 1, 2, 3, 4, 5 };

            // foreach (var i in meuArray)
            // {
            //     Console.WriteLine(i);
            // }

            // for (var i = 0; i < meuArray.Length; i++)
            // {
            //     Console.WriteLine(meuArray[i]);
            // }

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario()
            { Id = 2579, Nome = "Baltieri" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }

        public struct Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        static void Copiando()
        {
            Console.Clear();

            var arr = new int[4];
            var arrb = new int[4];

            arrb[0] = arr[0];
            arr[0] = 23;
            arr.CopyTo(arrb, 0);


            Console.WriteLine(arrb[0]);
        }

        static void Main()
        {
            Copiando();
        }
    }
}