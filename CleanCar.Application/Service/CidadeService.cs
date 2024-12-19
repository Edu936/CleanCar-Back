using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCar.Application.DTOs;
using CleanCar.Application.IService;
using CleanCar.Domain.Entities;
using CleanCar.Infrastructure.IRepository;

namespace CleanCar.Application.Service
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        public async Task<CidadeDTO> Created(CidadeDTO cidadeDTO)
        {
            Cidade cidade = new Cidade(cidadeDTO.Nome, cidadeDTO.Estado);
            await _cidadeRepository.Create(cidade);
            return cidadeDTO;
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CidadeDTO>> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Task<CidadeDTO> FetchById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CidadeDTO> Update(CidadeDTO cidadeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
