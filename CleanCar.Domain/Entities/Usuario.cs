using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Domain.Entities
{
    public class Usuario : Base
    {
        public string CPF { get; private set; }
        public string User { get; private set; }
        public string Nome { get; private set; }
        public string Cargo { get; private set; }
        public Guid Passoword { get; private set; }
        public Usuario(string nome, string cpf, string cargo, string user, Guid passoword)
        {
            CPF = cpf;
            Nome = nome;
            User = user;
            Cargo = cargo;
            IsActive = true;
            Id = Guid.NewGuid();
            Passoword = passoword;
            DateCreate = DateTime.Now;
        }

        public void Alterar(string nome, string cpf, string cargo, string user, Guid password, bool isActive)
        {
            CPF = cpf;
            Nome = nome;
            User = user;
            Cargo = cargo;
            IsActive = isActive;
            Passoword = password;
            DateUpdate = DateTime.Now;
        }
    }
}
