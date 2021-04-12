using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            ContaCorrente conta2 = new ContaCorrente(865, 86712542);

            Console.WriteLine("------ TOTAL DE CONTAS ------");
            Console.WriteLine("Total de contas Criadas: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("");
            
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Gabriela Costa";
            conta.Titular.Profissao = "Veterinária";
            conta.Titular.CPF = "435.634.989-20";

            Console.WriteLine("------ SALDO ------");
            conta.Saldo = 500;
            Console.WriteLine("Seu saldo é de: " + conta.Saldo);
            Console.WriteLine("");

            Console.WriteLine("------ DEPÓSITO ------");
            conta.Depositar(200);
            Console.WriteLine("Seu saldo é de: " + conta.Saldo);
            Console.WriteLine("");

            Console.WriteLine("------ SAQUE ------");
            conta.Sacar(100);
            Console.WriteLine("Seu saldo é de: " + conta.Saldo);
            Console.WriteLine("");

            Console.WriteLine("------ TRANFERÊNCIA ------");
            conta.Transferir(50, conta2);
            Console.WriteLine("Seu saldo é de: " + conta.Saldo);
            Console.WriteLine("Saldo conta2 é de: " + conta2.Saldo);
            Console.WriteLine("");

            Console.WriteLine("------ DADOS DA CONTA DO TITULAR ------");
            Console.WriteLine("Nome do Titular: " + conta.Titular.Nome);
            Console.WriteLine("Número da conta: " + conta.Agencia);
            Console.WriteLine("Número da Agência: " + conta.Numero);
            Console.WriteLine("Saldo da conta: " + conta.Saldo);
            Console.WriteLine("");

            Console.WriteLine("------ DADOS DO CLIENTE ------");
            Console.WriteLine("Nome do Cliente: " + conta.Titular.Nome);
            Console.WriteLine("Nome do Cliente: " + conta.Titular.Profissao);
            Console.WriteLine("Nome do Cliente: " + conta.Titular.CPF);

            Console.ReadLine();
        }
    }
}
