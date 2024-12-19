using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCar.Application.DTOs
{
    public record CidadeDTO(Guid Id, string Nome, string Estado);
}
