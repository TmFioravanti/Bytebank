using System;
using System.ComponentModel;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoByteBank
{
    public class Program
    {


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

        static void RegistrarNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            cpfs.Add(Console.ReadLine());
            Console.Write("Digite o nome: ");
            titulares.Add(Console.ReadLine());
            Console.Write("Digite a senha: ");
            senhas.Add(Console.ReadLine());
            saldos.Add(0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Usuário Registrado com sucesso!");
            Console.ResetColor();
            Console.WriteLine("aperte enter para retornar ao menu principal");
            Console.ReadLine();
            Console.Clear();

        }
        static void DeletarUsuario(List<string> cpfs, List<string> senhas)
        {
            Console.Write("Insira o CPF do usuário a ser deletado: ");
            cpfs.Remove(Console.ReadLine());
            Console.WriteLine("Digite a senha para confirmar: ");
            senhas.Remove(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Usuário deletado com sucesso!");
            Console.ResetColor();
            Console.Clear();

        }

        static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
        {
            for (int i = 0; i < cpfs.Count; i++)
            {
                Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R${saldos[i]:F2}");
            }
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
                        RegistrarNovoUsuario(cpfs, titulares, senhas, saldos);
                        break;
                    case 2:
                        DeletarUsuario(cpfs, senhas);
                        break;
                    case 3:
                        ListarTodasAsContas(cpfs, titulares, saldos);
                        break;
                    case 4:
                        DetalhesDeUmUsuario(cpfs, titulares, saldos);
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