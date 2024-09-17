using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoByteBank.Controller
{
    public class Transactions
    {
       public void CadastrarUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf: ");
            string cpf = Console.ReadLine();
            if (cpf != null && cpf.Length == 11) {
                if (cpfs.Contains(cpf)){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CPF já cadastrado!");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    cpfs.Add(cpf);
                }
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CPF inválido! O CPF deve conter 11 números.");
                Console.ResetColor();
                return;
            }
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
        public void DeletarUsuario(List<string> cpfs, List<string> senhas)
        {
            
                Console.Write("Insira o CPF do usuário a ser deletado: ");
                string cpf = Console.ReadLine();
                int index = cpfs.IndexOf(cpf);

                if (index >= 0)
                {
                    Console.WriteLine("Digite a senha para confirmar: ");
                    string senha = Console.ReadLine();
                    if (senhas[index] == senha)
                    {
                        cpfs.RemoveAt(index);
                        senhas.RemoveAt(index);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Usuário deletado com sucesso!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Senha incorreta. Não foi possível deletar o usuário.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Usuário não encontrado.");
                    Console.ResetColor();
                }

                Console.WriteLine("Aperte enter para retornar ao menu principal");
                Console.ReadLine();
                Console.Clear();
            
        }


    }

}
