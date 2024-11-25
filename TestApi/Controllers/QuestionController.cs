using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Contracts;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    // [Route("")]
    // [ApiController]
    // public class QuestionController : Controller
    // {

    //     private readonly IQuestionRepository _questionRepository;

    //     public QuestionController(IQuestionRepository questionRepository)
    //     {
    //         _questionRepository = questionRepository;
    //     }

    //     [HttpGet]
    //     public async Task<IActionResult> GetQuestion(int id)
    //     {
    //         var result = await _questionRepository.GetQuestion(id);
    //         if (result == null)
    //         {
    //             return NotFound(id);
    //         }
    //         return Ok(result);
    //     }
    // }
}
