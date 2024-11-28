using TestApi.Contracts;
using TestApi.Models;
using TestApi.Repositories;
using TestApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TestApi.Repositories
{

    public interface IQuestionRepository : IBaseRepository<Question>
    {

        public Task<IEnumerable<Question?>> GetTestQuestions(int TestId);

    }

}

