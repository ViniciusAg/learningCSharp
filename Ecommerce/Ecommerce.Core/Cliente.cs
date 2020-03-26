using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ecommerce.Core
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
        }
    }
}
