using TestApi.Contracts;
using TestApi.Models;
using TestApi.Repositories;
using TestApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TestApi.Repositories
{

    public interface ITestRepository : IBaseRepository<Test>
    {
        public Task<Test?> GetTestWithQuestionsAsync(int Id);
    }
}


