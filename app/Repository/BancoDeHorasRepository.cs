using app.Infrastructure;
using app.Models;
using app.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
    public class BancoDeHorasRepository(BancoDeHorasDbContext bancoDeHorasDbContext) : IBancoDeHorasRepository
    {

        private readonly BancoDeHorasDbContext _bancoDeHorasDbContext = bancoDeHorasDbContext;

        public async Task<IEnumerable<Funcionarios>> GetAllEmployeers() => (await _bancoDeHorasDbContext.Funcionarios
        .ToListAsync())
        .Select(emplo => (Funcionarios)emplo);

        public async Task<IEnumerable<Funcionarios>> GetEmployeerById(int id)
        {
            var selectEmployeer = await _bancoDeHorasDbContext.Funcionarios
            .Where(emplo => emplo.IdFuncionarios == id)
            .ToListAsync();

            if (selectEmployeer == null || selectEmployeer.Count == 0)
            {
                throw new Exception("Usuário não encontrado.");
            }

            return selectEmployeer;
        }
    }
}