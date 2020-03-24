using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core
{   
    /// <summary>
    /// Essa Classe tem como intuito Cadastrar novos clientes.
    /// </summary>
    class Cadastro
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Dados minimos para cadastrar um cliente.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="idade"></param>
        public Cadastro(string nome, string cpf, int idade)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
        }
        public void MostrarCadastro(Cadastro cliente)
        {
            Console.WriteLine("---Dados do Cliente---");
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"CPF: {cliente.CPF}");
            Console.WriteLine($"Idade: {cliente.Idade}");

        }
    }
}
