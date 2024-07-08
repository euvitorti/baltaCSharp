namespace Calculator
{
    class Program
    {
        static void Main(string[] args){
          
            Menu();

        }

        static void Menu(){
          
            Console.WriteLine("QUAL OPERAÇÃO? ");
            Console.WriteLine("[1] SOMA");
            Console.WriteLine("[2] SUBTRAÇÃO.");
            Console.WriteLine("[3] DIVISÃO.");
            Console.WriteLine("[4] MULTIPLICAÇÃO.");
            Console.WriteLine("[5] SAIR.");

            Console.WriteLine("");
            Console.WriteLine("SELECIONE A OPÇÃO: ");
            short Escolha = short.Parse(Console.ReadLine());

            switch (Escolha)
            {
                case 1: Soma(); break;
                
                case 2: Subtracao(); break;
                
                case 3: Divisao(); break;
                
                case 4: Multiplicacao(); break;

                case 5: System.Environment.Exit(0); break;

                default: Console.WriteLine("ESOLHA INCORRETA."); Menu(); break;
            }
        }

        static void Soma(){

            Console.WriteLine("PRIMEIRO VALOR: ");
            float PrimeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("SEGUNDO VALOR: ");
            float SegundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Resultado = PrimeiroValor + SegundoValor;
            Console.WriteLine($"RESULTADO DA SOMA: {Resultado}");
        }
    
        static void Subtracao(){

            Console.WriteLine("PRIMEIRO VALOR: ");
            float PrimeiroValor = float.Parse(Console.ReadLine());
        
            Console.WriteLine("SEGUNDO VALOR: ");
            float SegundoValor = float.Parse(Console.ReadLine());
        
            Console.WriteLine("");
            
            float Resultado = PrimeiroValor - SegundoValor;
            Console.WriteLine($"RESULTADO DA SUBTRAÇÃO: {Resultado}");
        }
   
        static void Divisao(){
            // System.Console.Clear();

            Console.WriteLine("PRIMEIRO VALOR: ");
            float Valor1 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("SEGUNDO VALOR: ");
            float Valor2 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("");

            float Resultado = Valor1 / Valor2;
            Console.WriteLine($"O RESULTADO DA DIVISÃO É {Resultado}");
        }
    
        static void Multiplicacao(){
            Console.WriteLine("PRIMEIRO VALOR: ");
            float Valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("SEGUNDO VALOR: ");
            float Valor2 = float.Parse(Console.ReadLine());
        
            Console.WriteLine("");

            float Resultado = Valor1 * Valor2;
            Console.WriteLine($"RESULTADO DA MULTIPLICAÇÃO: {Resultado}");
        }
    }
}