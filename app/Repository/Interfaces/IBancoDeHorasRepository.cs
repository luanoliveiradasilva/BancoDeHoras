using app.Models;

namespace app.Repository.Interfaces
{
    public interface IBancoDeHorasRepository
    {
        Task<IEnumerable<Funcionarios>> GetAllEmployeers();
        Task<IEnumerable<Funcionarios>> GetEmployeerById(int id);
    }
}