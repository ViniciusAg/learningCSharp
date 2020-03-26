using Ecommerce.Core.Ecommerce.Repositorio;
using System;

namespace Ecommerce.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerente = new ClienteRepositorio();
            gerente.IncluirCliente(nome: "Thamirys", cpf: "111.222.333/44", idade: 24);
            gerente.IncluirCliente(nome: "Vinicius", cpf: "123.456.789/12", idade: 22);
            
            gerente.ListaDeClientes();

            gerente.DeletarCliente("Thamirys");

            gerente.ListaDeClientes();

            Console.ReadLine();
        }
    }
}
