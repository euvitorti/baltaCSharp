using System;
using System.Text;

namespace Caractere{
    class Program
    {
            
        static void Main(string[] args){
            Console.WriteLine("GUIDS");
            Id();

            Console.WriteLine("");

            Console.WriteLine("INTERPOLAÇÃO");
            Interpolacao();
        
            Console.WriteLine("");

            Console.WriteLine("COMPARAÇÃO DE STRINGS");
            Comparacao();
        
            Console.WriteLine("");

            Console.WriteLine("STARTWITH/ENDWITH");
            ComecaComTerminaCom();

            Console.WriteLine("");

            Console.WriteLine("ÍNDICES");
            Indice();

            Console.WriteLine("");

            Console.WriteLine("MAIUSCULA E MINUSCULA");
            MaiusculaMinuscula();
        
            Console.WriteLine("");

            Console.WriteLine("MANIPULANDO STRING");
            Manipulando();

            Console.WriteLine("");

            Console.WriteLine("STRING BUILDER");
            ConstrucaoString();
        }

        static void Id(){

            //Guids
            // Guid - Identificador único - Gera um hash grande
            
            var Id = Guid.NewGuid();
            // Id.ToString();
            // Id = new Guid("fe55ef53-86e0-4051-ae9c-2af3516ea57a");
    
            Console.WriteLine(Id.ToString().Substring(0,8));
        }
   
        static void Interpolacao(){
            //INTERPOLAÇÃO DE STRINGS

            var Price = 10.20;
            Console.WriteLine("");
            //Primeira forma de concatenação
            Console.WriteLine("COM +");
            var Texto = "O PREÇO DO PRODUTO É R$ " + Price + ".";
            Console.WriteLine(Texto);
            Console.WriteLine("");

            //SEGUNDA FORMA COM .FORMAT
            Console.WriteLine("SEGUNDA FORMA COM .FORMAT");
            Texto = string.Format("O PREÇO DO PRODUTO É R$ {0} APENAS NA PROMOÇÃO.", Price);           
            Console.WriteLine(Texto);
            Console.WriteLine("");
 
            //SEGUNDA FORMA COM $
            Console.WriteLine("SEGUNDA FORMA COM $");
            //DANDO QUEBRA DE LINHA - É SÓ DAR O @
            Texto = $@"O PREÇO DO PRODUTO É R$ ${Price} APENAS NA PROMOÇÃO. ESTOU ESCREVENDO QUALQUER COISA PARA DAR QUEBRA DE LINHA. PARA DAR QUEBRA DE LINHA É SÓ DAR O @. OU O \n.";
            Console.WriteLine(Texto);
            Console.WriteLine("");
        }
    
        static void Comparacao(){

            var Texto = "ESTE TEXTO É UM TESTE";

            // C# É CASESENSITIVE - PARA COMPARAR SEM ISSO USA O StringComparison.OrdinalIgnoreCase
            Console.WriteLine(Texto.Contains("TESTE", StringComparison.OrdinalIgnoreCase));
            

            // OUTRA FORMA DE COMPARAÇÃO
            // Console.WriteLine(Texto.CompareTo("Testando"));
        }

        static void ComecaComTerminaCom(){

            var Texto = "HELLO WORLD";
            
            Console.WriteLine("");
            Console.WriteLine("STARTWITH");

            Console.WriteLine(Texto.StartsWith("HELLO"));
            Console.WriteLine(Texto.StartsWith("World"));
            Console.WriteLine(Texto.StartsWith("Hello"));

            Console.WriteLine("");
            Console.WriteLine("ENDWITH");
            Console.WriteLine("");

            Console.WriteLine(Texto.EndsWith("HELLO"));
            Console.WriteLine(Texto.EndsWith("World", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(Texto.EndsWith("WORLD"));
        }
    
        static void Indice(){
            var Texto = "HELLO WORLD, MY FIRST PROGRAM";

            Console.WriteLine(Texto.IndexOf(","));
            Console.WriteLine(Texto.LastIndexOf("M"));
        }
    
        static void MaiusculaMinuscula(){

            var Texto = "Hello World";

            Console.WriteLine(Texto.Insert(5, " MY "));
            Console.WriteLine(Texto.ToLower());
            Console.WriteLine(Texto.ToUpper());
            Console.WriteLine(Texto.Remove(5,6));
            Console.WriteLine(Texto.Length);
        }
   
        static void Manipulando(){

            var Texto = " Este textto é um teste ";
            
            Console.WriteLine("");
            
            //TROCAR UM POR O OUTRO
            Console.WriteLine(Texto.Replace("textto", "texto"));

            Console.WriteLine("");

            Console.WriteLine("SPLIT");
            // SPLIT COLOCA AS STRINGS EM LISTA
            var Divisao = Texto.Split(" ");
            Console.WriteLine(Divisao[0]);
            Console.WriteLine(Divisao[1]);
            Console.WriteLine(Divisao[2]);
            Console.WriteLine(Divisao[3]);
            Console.WriteLine(Divisao[4]);

            Console.WriteLine("");

            Console.WriteLine("SUBSTRING");
            var Resultado = Texto.Substring(5, 5);
            Console.WriteLine(Resultado);

            Console.WriteLine("");

            Console.WriteLine("TRIM - REMOVE OS ESPAÇOS NO FINAL");
            Console.WriteLine(Texto.Trim());
        }
 
        static void ConstrucaoString(){

            var Texto = new StringBuilder();

            Texto.Append("Hello ");
            Texto.Append("World ");
            Texto.Append(char.Parse("!"));

            // TEM QUE CONVERTER, POIS OS ITENS ACIMA NÃO É UMA STRING
            Texto.ToString();
            Console.WriteLine(Texto);
        }
    }
}