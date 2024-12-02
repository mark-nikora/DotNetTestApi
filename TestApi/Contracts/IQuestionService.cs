using TestApi.DTOs;

namespace TestApi.Contracts
{

    public interface IQuestionService
    {
        public Task<IEnumerable<QuestionDto>> GetTestQuestions(int Id);

    }

}