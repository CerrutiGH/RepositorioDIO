using System;
namespace DesafiosDIO
{
    public class PrimeiroDesafio
    {
        public static void Primeiro(){
            double x, y, r;

            Console.WriteLine("Digite o primeiro número: ");
             x = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("Digite o segundo número: ");
             y = Convert.ToDouble(Console.ReadLine());

             r = x / y;

             if(y == 0){
                 Console.WriteLine("Divisão Impossível");
             } else{
                 Console.WriteLine($"O resultado é igual a {r}");
             }
             
             Console.ReadKey();

        }
        
    }
}