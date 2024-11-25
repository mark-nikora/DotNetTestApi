using Microsoft.EntityFrameworkCore;
using TestApi.Contracts;
using TestApi.Models;
using TestApi.Data;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;



namespace TestApi.Repositories
{
    public class TestRepository(AppDbContext context) : BaseRepository<Test>(context), ITestRepository
    {

        public async Task<Test?> GetTestWithQuestionsAsync(int Id)
        {
            return await _dbSet
                         .Include(t => t.TestQuestion)
                             .ThenInclude(tq => tq.Question)
                         .FirstOrDefaultAsync(t => t.Id == Id);
        }

    }
}