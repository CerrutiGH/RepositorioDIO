using System;
using System.Collections.Generic;
namespace DIOBank
{
    public class Conta
    {
        private string Name {get; set;}

        private double Saldo {get; set;}

        private double Credito {get; set;}

        private TipoConta TipoConta {get; set;}

        public Conta(TipoConta tipoConta, double Saldo, double Credito, string Name){
            this.TipoConta = tipoConta;
            this.Saldo = Saldo;
            this.Credito = Credito;
            this.Name = Name;
        }

        public bool Sacar(double valorSaque){
            if (this.Saldo - valorSaque < (this.Credito * -1)){
                Console.WriteLine("Você não possui saldo suficiente para realizar essa ação.");
                return false;
            }else{
                this.Saldo -= valorSaque;

                 Console.WriteLine($"{this.Name}, seu saldo é de {this.Saldo}");
                 return true;
            }
        }

        public void Depositar(double valorDeposito){
                this.Saldo += valorDeposito;
                Console.WriteLine($"O saldo de {this.Name} é de {this.Saldo}.");
        }

        public void Transferir(double valorTransf, Conta contaDestino){
            if(this.Sacar(valorTransf)){
                contaDestino.Depositar(valorTransf);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo da Conta: " + this.TipoConta + " | ";
            retorno += "Nome: " + this.Name + " | ";
            retorno += "Saldo: " + this.Saldo + " | ";
            retorno += "Crédito: " + this.Credito + " | ";
            return retorno;
        }
    }
}