using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using ProjetoByteBank.Controller;
namespace ProjetoByteBank
{
    public class Program
    {
        public static Transactions transactions = new Transactions();
        static void ShowMenu()
        {
            
            Console.WriteLine("1 - Cadastrar novo usuário");
            Console.WriteLine("2 - Deletar um usuário");
            Console.WriteLine("3 - Listar todas as contas registradas");
            Console.WriteLine("4 - Detalhes de um usuário");
            Console.WriteLine("5 - Quantia armazenada no banco");
            Console.WriteLine("6 - Depositar ");
            Console.WriteLine("7 - Sacar ");
            Console.WriteLine("8 - Transferir ");
            Console.WriteLine("0 - Para sair do programa");
            Console.Write("Digite a opção desejada: ");
        }
        

        static void DetalhesDeUmUsuario(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            
           
        }

        static void ValorNoBanco()
        {

        }

        static void DepositarValor(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            Console.Write("Insira o CPF do usuário: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Insira o valor a ser depositado:R$ ");
            saldos.Add((double.Parse(Console.ReadLine())));
            Console.Clear();

        }

        static void SacarValor(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            
        }
        static void TransferirValor(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Antes de começar a usar, vamos configurar alguns valores: ");

            List<string> cpfs = new List<string>();
            List<string> titulares = new List<string>();
            List<string> senhas = new List<string>();
            List<double> saldos = new List<double>();

            int option;

            

            do
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                

                    Console.WriteLine("-----------------");

                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("Estou encerrando o programa...");
                            break;
                        case 1:
                            transactions.CadastrarUsuario(cpfs, titulares, senhas, saldos);
                            break;
                        case 2:
                            transactions.DeletarUsuario(cpfs, senhas);
                            break;
                        case 3:
                            transactions.ListarTodasAsContas(cpfs, titulares, saldos);
                            break;
                        case 4:
                            transactions.DetalharUsuario(cpfs, senhas, titulares, saldos);
                            break;
                        case 5:
                            ValorNoBanco();
                            break;
                        case 6:
                            DepositarValor(cpfs, titulares, saldos);
                            break;
                        case 7:
                            SacarValor(cpfs, titulares, saldos);
                            break;
                        case 8:
                            TransferirValor(cpfs, titulares, saldos);
                            break;
                    }
                
                Console.WriteLine("-----------------");

            } while (option != 0);

                
        }
    }
}