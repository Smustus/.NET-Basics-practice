using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(); //Allows us to re-use this code
        Task<Stock?> GetByIdAsync(int id); //? since the return can be null
        Task<Stock> CreateAsync(Stock stock);
        Task<Stock?> UpdateByIdAsync(int id, UpdateStockRequestDto stockDto); 
        Task<Stock?> DeleteByIdAsync(int id); 

    }
}