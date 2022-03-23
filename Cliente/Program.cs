using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    internal class Program
    {
        struct Cliente
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            private string cpf;
            public string Cpf
            {
                get { return cpf; }
                set { cpf = value; }
            }
        }
        enum Menu { listagem = 1,adicionar = 2, excluir = 3 , sair = 4};
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("1-Listar\n2-Adicionar\n3-Excluir\n4-Sair");
           int intOp = int.Parse (Console.ReadLine());
            Menu opcao = (Menu)intOp;
            switch (opcao)
            {
                case Menu.listagem:
                    break;
                    case Menu.adicionar:
                    Adicionar();
                    break;
                case Menu.excluir:
                    break;
                case Menu.sair:
                    break;
            }
        }
        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Nome do Cliente:");
            cliente.Name = (Console.ReadLine());
            Console.WriteLine("Insira o E-mail::");
            cliente.Email = (Console.ReadLine());
            Console.WriteLine("Insira o Cpf::");
            cliente.Cpf = (Console.ReadLine());
            Console.WriteLine(cliente.Name+cliente.Email);
            Console.ReadLine();
        }
    }
}
