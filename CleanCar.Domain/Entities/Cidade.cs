using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Domain.Entities
{
    public class Cidade
    {
        public int Id { get; init; }
        public string Nome { get; private set; }
        public string Estado { get; private set; }
        public Cidade() { }
        public Cidade(string nome, string estado)
        {
            Nome = nome;
            Estado = estado;
        }
        public void Alterar(string nome, string estado)
        {
            Nome = nome;
            Estado = estado;
        }
    }
}
