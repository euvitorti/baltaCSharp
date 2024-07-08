//SEMPRE DO MAIS ESPECÍFICO PARA O GENÉRICO

using System.Dynamic;

namespace TratamentoDeErro
{
    class Program
    {
        static void Main()
        {
            var vetor = new int[3];

            try
            {
                // Console.Clear();
                // for (var i = 0; i < 10; i++)
                // {
                //     //Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
                //     Console.WriteLine(vetor[i]);
                // }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("ÍNDICE NÃO ENCONTRADO");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Falha ao cadastrar o usuário.");
            }
            catch (MinhaException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.QuandoAconteceu);
                Console.WriteLine("Falha ao cadastrar o usuário.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("ALGO DEU ERRADO.");
            }
            // SEMPRE VAI SER EXECUTADO, SE OCORRER ERRO OU NÃO
            finally
            {
                Console.WriteLine("TENTE NOVAMENTE.");
            }
        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                // throw new ArgumentNullException("O CAMPO NOME NÃO PODE SER VAZIO.");
                throw new MinhaException(DateTime.Now);
            }
        }

        // HERANÇA
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}