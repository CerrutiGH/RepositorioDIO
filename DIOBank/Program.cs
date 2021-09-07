using System;
using System.Collections.Generic;
namespace DIOBank
{
    public class Program
    {

        static List<Conta> listarContas = new List<Conta>();


        static void Main(string[] args){
           
            
            string op;

            do{
                op = menu();

                switch (op){
                    case "1":
                    ListarContas();
                        break;

                    case "2":
                    InserirConta();
                        break;

                    case "3":
                    Transferir();
                        break;

                    case "4":
                   Sacar();
                        break;

                    case "5":
                    Depositar();
                        break;

                    case "C":
                   Console.Clear();
                        break;

                    case "X":
                   Environment.Exit(0);
                        break;

                     case null:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções disponíveis");
                       
                        break;

                    default:
                        Console.WriteLine("Pressione a tecla Enter e escolha uma das opções disponíveis");
                        
                        break;
                }
            } while (op != "1" || op != "2" || op != "3" || op != "4" || op != "5" || op != "C" || op != "X");
            

        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int numContaO = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int numContaD = int.Parse(Console.ReadLine());
            
             Console.Write("Digite o valor a ser transferido: ");
            double valorTransf = double.Parse(Console.ReadLine());

            listarContas[numContaO].Transferir(valorTransf, listarContas[numContaD]);
        }

        private static void Depositar()
        {
            
            Console.WriteLine("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            
            listarContas[numConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());
            
            listarContas[numConta].Sacar(valorSaque);
        }

        public static string menu()
        {
            
            Console.WriteLine("============ Menu Principal ============");
            Console.WriteLine("=     1 - Listar Contas                =");
            Console.WriteLine("=     2 - Inserir Nova Conta           =");
            Console.WriteLine("=     3 - Transferir                   =");
            Console.WriteLine("=     4 - Sacar                        =");
            Console.WriteLine("=     5 - Depositar                    =");
            Console.WriteLine("=     C - Limpar tela                  =");
            Console.WriteLine("=     X - Sair                         =");
            Console.WriteLine("========================================");
            Console.WriteLine("Qual opção você deseja: ");

            return Console.ReadLine().ToUpper();
        }
        

        private static void InserirConta()
        {
            Console.WriteLine("Digite 1 para Conta Física ou 2 para Conta Jurídica: ");
            int EntTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string EntName = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double EntSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double EntCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)EntTipoConta, Saldo: EntSaldo, Credito: EntCredito, Name: EntName);
            listarContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Contas cadastradas");
            if (listarContas.Count == 0){
                Console.WriteLine("Nada cadastrado.");
                return;
            }
            for (int i = 0; i < listarContas.Count; i++){
                Conta lsConta = listarContas[i];
                Console.Write("{0} - ", i);
                Console.WriteLine(lsConta);
                Console.Write("-------------------------------");
            }
            
        }

        
            
    }
}
