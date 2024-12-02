using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Contracts;
using TestApi.DTOs;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class QuestionController(IQuestionRepository questionRepository, IQuestionService questionService, IMapper mapper) : Controller
    {

        public readonly IQuestionService _questionService = questionService;
        private readonly IQuestionRepository _questionRepository = questionRepository;

        private readonly IMapper _mapper = mapper;

        [HttpGet]
        public async Task<IActionResult> GetTestQuestions(int id)
        {
            try
            {
                var questionDtos = await _questionService.GetTestQuestions(id);
                return questionDtos == null ? NotFound() : Ok(questionDtos);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
