using System;

namespace Ecommerce.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            var vinicius = new Cadastro(nome: "Vinicius Aguiar", cpf: "123.456.789/12", idade: 22);
            vinicius.Endereço = "Rua Coronel Pereira Neto";
            vinicius.Telefone = "(11) 95023-4862";
            vinicius.Email = "aguiar.santos.vinicius@gmail.com";
          
            vinicius.MostrarCadastro(vinicius);
            Console.ReadLine();
        }
    }
}
