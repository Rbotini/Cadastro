using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    internal class Program
    {
        enum Menu { listagem = 1,adicionar = 2, excluir = 3 , sair = 4};
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("1-Listar\n2-Adicionar\n3-Excluir\n4-Sair");
            Console.ReadLine();
        }
    }
}
