using TestApi.Models;
using TestApi.Contracts;
using TestApi.Repositories;
using Microsoft.VisualBasic;
using TestApi.DTOs;
using AutoMapper;


namespace TestApi.Services
{
    public class QuestionService : IQuestionService
    {

        private IQuestionRepository _questionRepository;

        private IOptionRepository _optionRepository;

        private IMapper _mapper;

        public QuestionService(IQuestionRepository questionRepository, IOptionRepository optionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _optionRepository = optionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<QuestionDto>> GetTestQuestions(int Id)
        {
            var questions = await _questionRepository.GetTestQuestions(Id);
            var questionsDtos = _mapper.Map<List<QuestionDto>>(questions);
            questionsDtos.ForEach(async q =>
            {
                q.Options = _mapper.Map<List<OptionDto>>(await _optionRepository.GetOptionsByQuestionId(q.Id));
            });
            return questionsDtos;
        }


    }

}