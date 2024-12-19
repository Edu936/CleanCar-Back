using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Domain.Entities;

namespace CleanCar.Infrastructure.IRepository
{
    public interface ICidadeRepository
    {
        Task<List<Cidade>> FetchAll();
        Task<Cidade> FetchById (int id);
        Task<Cidade> Create (Cidade cidade);
        Task<Cidade> Update (Cidade cidade);
        Task<bool> Delete (int id);
    }
}
