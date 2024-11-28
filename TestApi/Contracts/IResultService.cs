
namespace TestApi.Contracts
{
    public interface IResultService
    {
        public void ArchiveResult()
        {
            // when a result is created, the result,test,questions,options are saved in archive tables

        }

        public void ArchiveTestResultQuestions()
        {
            // archive all test questions for a result         
        }

    }

}