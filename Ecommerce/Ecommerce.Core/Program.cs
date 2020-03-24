using Ecommerce.Core.Ecommerce.Repositorio;
using System;

namespace Ecommerce.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var vinicius = new Cliente(nome: "Vinicius", cpf: "123.456.789/12", idade: 22);
            var thamirys = new Cliente(nome: "Thamirys", cpf: "111.222.333/44", idade: 24);
            vinicius.IncluirCliente(vinicius);
            vinicius.IncluirCliente(thamirys);
        
            vinicius.ListaDeClientes();

            vinicius.DeletarCliente("Thamirys");

            vinicius.ListaDeClientes();

            Console.ReadLine();
        }
    }
}
