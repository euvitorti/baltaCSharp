namespace TextEditor{
using System;
using System.IO;
    class Program
    {
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.WriteLine("O QUE VOCÊ DESEJA FAZER? ");
            Console.WriteLine("1 - ABRIR UM ARQUIVO.");
            Console.WriteLine("2 - CRIAR ARQUIVO");
            Console.WriteLine("0 - SAIR");
            short Option = short.Parse(Console.ReadLine());
        
            switch(Option){
                case 0: Console.Clear(); Console.WriteLine("PROGRAMA ENCERRADO COM SUCESSO"); System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
            }
        }

        static void Open(){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo? ");
            string Path = Console.ReadLine();

            using(var File = new StreamReader(Path)){
                string  Text = File.ReadToEnd();
                Console.WriteLine(Text);
            }

            Console.WriteLine("");
            Menu();
        }

        static void Edit(){
            Console.WriteLine("DIGITE O SEU TEXTO ABAIXO: (ESC - PARA SAIR)");
            Console.WriteLine("");

            string Text = "";

            do {
                
                Text += Console.ReadLine();
                Text += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(Text);
        }
    
        static void Salvar(string Text){

            Console.WriteLine("QUAL O CAMINHO PARA SALVAR O ARQUIVO>?");
            var Path = Console.ReadLine();

            //ABRINDO O ARQUIVO E FECHANDO ELE
            using(var File = new StreamWriter(Path)){
                File.Write(Text);
            }

            Console.WriteLine($"ARQUIVO {Path}SALVO COM SUCESSO.");
            Menu();
        }
    }
}