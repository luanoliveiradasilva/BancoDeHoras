using app.Infrastructure;
using app.Models;
using app.Repository;
using Microsoft.EntityFrameworkCore;

namespace app.Tests.Test.Repository
{
    public class BancoDeHorasRepositoryTest
    {

        private readonly BancoDeHorasDbContext _dbContext;

        public BancoDeHorasRepositoryTest()
        {
            DbContextOptionsBuilder dbOptions = new();

            dbOptions.UseInMemoryDatabase(Guid.NewGuid().ToString());

            _dbContext = new BancoDeHorasDbContext(dbOptions.Options);
        }


        [Fact]
        public async void ShoulReturnAllEmployeers()
        {
            //Arrange
            var employeers = new List<Funcionarios>()
            {
                new(){
                    IdFuncionarios = 1,
                    Nome = "Teste 1",
                    Email = "teate@teste.com",
                    SenhaHash = "1234",
                }
            };

            _dbContext.Funcionarios.AddRange(employeers);

            await _dbContext.SaveChangesAsync();

            var repo = new BancoDeHorasRepository(_dbContext);

            //Act
            IEnumerable<Funcionarios> result = await repo.GetAllEmployeers();

            //Assert 
            Assert.NotNull(result);
        }

        [Fact]
        public async void ShouldReturnEmployeerById()
        {
            //Arrange
            int id = 2;

            var employeers = new List<Funcionarios>()
            {
                new(){
                    IdFuncionarios = 1,
                    Nome = "Teste 1",
                    Email = "teate@teste.com",
                    SenhaHash = "1234"
                },
                new(){
                    IdFuncionarios = 2,
                    Nome = "Teste 2",
                    Email = "teate@teste.com",
                    SenhaHash = "1234"
                }
            };

            _dbContext.Funcionarios.AddRange(employeers);
            await _dbContext.SaveChangesAsync();

            var repo = new BancoDeHorasRepository(_dbContext);

            var actual = employeers.Where(empl => empl.IdFuncionarios == id).ToList();

            //Act
            IEnumerable<Funcionarios> expected = await repo.GetEmployeerById(id);

            //Assert
            Assert.NotNull(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async void ShoulReturnNotfounEmployeer()
        {
            //Arrange
            int id = 3;

            var employeers = new List<Funcionarios>()
            {
                new(){
                    IdFuncionarios = 1,
                    Nome = "Teste 1",
                    Email = "teate@teste.com",
                    SenhaHash = "1234"
                },
                new(){
                    IdFuncionarios = 2,
                    Nome = "Teste 2",
                    Email = "teate@teste.com",
                    SenhaHash = "1234"
                }
            };

            _dbContext.Funcionarios.AddRange(employeers);
            await _dbContext.SaveChangesAsync();

            var repo = new BancoDeHorasRepository(_dbContext);

            var actual = employeers.Where(empl => empl.IdFuncionarios == id).ToList();

            //Act
            IEnumerable<Funcionarios> expected = await repo.GetEmployeerById(id);
        }
    }
}