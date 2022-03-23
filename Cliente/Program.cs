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
                    Cliente cliente = new Cliente();
                    Console.WriteLine("Nome do Cliente:");
                    cliente.Name = (Console.ReadLine());
                    Console.WriteLine(cliente.Name);
                    Console.ReadLine();
                    break;
                case Menu.excluir:
                    break;
                case Menu.sair:
                    break;
            }
        }
    }
}
