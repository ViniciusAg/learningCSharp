using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ecommerce.Core.Ecommerce.Repositorio
{   
    /// <summary>
    /// Essa Classe tem como intuito Cadastrar novos clientes.
    /// </summary>
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }

        private List<Cliente> _listaDeClientes;

        /// <summary>
        /// Dados minimos para cadastrar um cliente.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="idade"></param>
        public Cliente(string nome, string cpf, int idade)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            _listaDeClientes = new List<Cliente>();
        }
        public void IncluirCliente(Cliente cliente)
        {
            _listaDeClientes.Add(cliente);

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
    }
}
