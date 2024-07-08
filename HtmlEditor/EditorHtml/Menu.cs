using System;

namespace EditorHtml
{
    public static class Menu
    {

        public static void Show()
        {

            Console.Clear();

            //COR DE FUNDO E DA LETRA
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScream();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScream()
        {

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void WriteOptions()
        {

            // ESCREVER EM UM LUGAR ESPECÍFICO NA TELA
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("-----------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("0 - SAIR");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - NOVO ARQUIVO");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - ABRIR");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("OPÇÃO: ");
        }

        public static void HandleMenuOption(short option)
        {

            switch (option)
            {
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                default: Show(); break;
            }
        }
    }
}