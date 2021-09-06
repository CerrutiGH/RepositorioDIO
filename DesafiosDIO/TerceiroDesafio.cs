namespace DesafiosDIO
{
    public class TerceiroDesafio
    {
        public static void Terceiro(){
            int chico, bento, bernardo, marina, iara, marlene, total;

            Console.WriteLine("Digite em gramas a porção consumida por Chico: ");
            chico = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite em gramas a porção consumida por Bento: ");
            bento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite em gramas a porção consumida por Bernardo: ");
            bernardo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite em gramas a porção consumida por Marina: ");
            marina = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite em gramas a porção consumida por Iara: ");
            iara = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite em gramas a porção consumida por Marlene: ");
            marlene = Convert.ToInt32(Console.ReadLine());

            total = chico + bento + bernardo + marina + iara + marlene;
            Console.WriteLine($"O total consumido pelo grupo de amigos foram {total} gramas. ");
            Console.ReadKey();
        }
    }
}