
using Microsoft.EntityFrameworkCore;
using TestApi.Contracts;
using TestApi.Models;
using TestApi.Data;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;



namespace TestApi.Repositories
{
    public class OptionRepository(AppDbContext context) : BaseRepository<Option>(context), IOptionRepository
    {
        public async Task<IEnumerable<Option?>> GetOptionsByQuestionId(int Id)
        {
            return await _dbSet.Where(o => o.QuestionId == Id).ToListAsync();
        }
    }
}