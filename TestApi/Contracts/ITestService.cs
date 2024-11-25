

using TestApi.DTOs;

namespace TestApi.Services
{

    public interface ITestService
    {

        public Task<TestDetailsDto?> GetTestWithQuestions(int Id);

    }

}