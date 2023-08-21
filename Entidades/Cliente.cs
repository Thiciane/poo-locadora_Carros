using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, DateTime dataNascimento, string telefone, string email, string senha)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
            this.Telefone = telefone;
            this.Email = email;
            this.Senha = senha;
        }


    }
}
