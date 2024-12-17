using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Domain.Entities
{
    public class Cidade : Base 
    {
        public string Nome { get; private set; }
        public string Estado { get; private set; }
        public Cidade(string nome, string estado)
        {
            Nome = nome;
            Estado = estado;
            Id = Guid.NewGuid();
            IsActive = true;
            DateCreate = DateTime.Now;
        }
        public void Alterar(string nome, string estado, bool isActive)
        {
            Nome = nome;
            Estado = estado;
            IsActive = isActive;
            DateUpdate = DateTime.Now;
        }
    }
}
