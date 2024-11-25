
using Microsoft.EntityFrameworkCore;
using TestApi.Contracts;
using TestApi.Models;
using TestApi.Data;
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;



namespace TestApi.Repositories
{
    public class QuestionRepository(AppDbContext context) : BaseRepository<Question>(context), IQuestionRepository
    {
        public async Task<IEnumerable<Question?>> GetTestQuestions(int Id)
        {
            var questions = await context.Set<TestQuestion>()
                         .Where(tq => tq.TestId == Id)
                         .Select(tq => tq.Question)
                         .ToListAsync();
            return questions;
        }
    }
}