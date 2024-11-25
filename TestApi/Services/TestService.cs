using TestApi.Models;
using TestApi.Contracts;
using TestApi.Repositories;
using Microsoft.VisualBasic;
using TestApi.DTOs;
using AutoMapper;


namespace TestApi.Services
{
    public class TestService : ITestService
    {

        private ITestRepository _testRepository;
        private IQuestionRepository _questionRepository;

        private IOptionRepository _optionRepository;

        private IMapper _mapper;

        public TestService(ITestRepository testRepository, IQuestionRepository questionRepository, IOptionRepository optionRepository, IMapper mapper)
        {
            _testRepository = testRepository;
            _questionRepository = questionRepository;
            _optionRepository = optionRepository;
            _mapper = mapper;
        }

        public async Task<TestDetailsDto?> GetTestWithQuestions(int Id)
        {
            var test = await _testRepository.GetTestWithQuestionsAsync(Id);
            var testDto = _mapper.Map<TestDetailsDto>(test);
            testDto.Questions = test!.TestQuestion
                                .Select(tq => _mapper.Map<QuestionDto>(tq.Question))
                                .ToList();
            testDto.Questions.ForEach(async q =>
            {
                q.Options = _mapper.Map<List<OptionDto>>(await _optionRepository.GetOptionsByQuestionId(q.Id));
            });
            return testDto;
        }


    }

}