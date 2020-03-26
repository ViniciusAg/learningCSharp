using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ecommerce.Core;

namespace Ecommerce.Core.Ecommerce.Repositorio
{   /// <summary>
    /// Resposavel por realizar o gerenciamento dos clientes. 
    /// </summary>
    class ClienteRepositorio
    {
        private List<Cliente> _listaDeClientes = new List<Cliente>();

        public ClienteRepositorio()
        {
        }
        public void IncluirCliente(string nome, string cpf, int idade)
        {
            _listaDeClientes.Add(new Cliente(nome, cpf, idade));

        }
        public void DeletarCliente(string nome)
        {
            _listaDeClientes.RemoveAll(x => x.Nome.ToLower() == nome.ToLower());
        }
        public void ListaDeClientes()
        {
            Console.WriteLine("---Lista de Clientes Cadastrados---");
            _listaDeClientes.OrderByDescending(x => x.Nome).ToList().ForEach(x => { Console.WriteLine($"Nome: {x.Nome} | CPF: {x.CPF} | Idade: {x.Idade}"); });
            Console.WriteLine("-----------------------------------");
        }
        //public void AlterarClientes(Cliente cliente)
        //{   
        //}
    }
}
