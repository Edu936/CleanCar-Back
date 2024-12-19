using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Application.DTOs;

namespace CleanCar.Application.IService
{
    public interface ICidadeService
    {
        Task<List<CidadeDTO>> FetchAll();
        Task<CidadeDTO> FetchById(Guid id);
        Task<CidadeDTO> Update(CidadeDTO cidadeDTO);
        Task<CidadeDTO> Created(CidadeDTO cidadeDTO);
        Task<bool> Delete(Guid id);
    }
}
