using System;

namespace DesafiosDIO
{
    public class MenuPrincipal
    {
        public static void Main(string[] args){
            string op;

            do{
                op = menu();

                switch (op){
                    case "1":
                    PrimeiroDesafio.Primeiro();
                        break;

                    case "2":
                    SegundoDesafio.Segundo();
                        break;

                        case "3":
                    TerceiroDesafio.Terceiro();
                        break;

                     case null:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções: 0, 1, 2 ou 3");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções: 0, 1, 2 ou 3");
                        Console.ReadKey();
                        break;
                }
            } while (op != "1" || op != "2" || op != "3");
            

        }

        public static string menu()
        {
            
            Console.Clear();
            Console.WriteLine("============ Menu Principal ============");
            Console.WriteLine("=     1 - Primeiro Desafio             =");
            Console.WriteLine("=     2 - Segundo Desafio              =");
            Console.WriteLine("=     3 - Terceiro desafio             =");
            Console.WriteLine("========================================");
            Console.WriteLine("Qual opção você deseja: ");

            return Console.ReadLine();
        }
    }
}