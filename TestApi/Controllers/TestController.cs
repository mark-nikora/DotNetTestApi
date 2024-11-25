using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using TestApi.Repositories;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("")]
    [ApiController]
    public class TestController(ITestRepository testRepository, ITestService testService) : Controller
    {

        private readonly ITestRepository _testRepository = testRepository;
        private readonly ITestService _testService = testService;

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var testDto = await _testService.GetTestWithQuestions(id);
            return testDto == null ? NotFound() : Ok(testDto);
        }
    }
}
