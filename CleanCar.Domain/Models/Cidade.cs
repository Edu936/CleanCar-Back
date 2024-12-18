using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Domain.Models
{
    public class Cidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
    }
}
