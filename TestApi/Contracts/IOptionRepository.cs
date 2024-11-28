using TestApi.Contracts;
using TestApi.Models;
using TestApi.Repositories;
using TestApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TestApi.Repositories
{

    public interface IOptionRepository : IBaseRepository<Option>
    {
        public Task<IEnumerable<Option?>> GetOptionsByQuestionId(int Id);
    }
}





