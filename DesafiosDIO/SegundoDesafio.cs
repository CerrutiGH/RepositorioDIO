using System;
namespace DesafiosDIO
{
    public class SegundoDesafio
    {
        public static void Segundo(){
            int km, min;
            
            Console.WriteLine("Digite a distância em quilometros que a moto x está da moto y: ");
            km = Convert.ToInt32(Console.ReadLine());
            min = km * 2;
            Console.WriteLine($"A moto x está a {min} minutos da moto y.");
            Console.ReadKey();
        }
    }
}