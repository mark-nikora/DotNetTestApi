using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestApi.DTOs;
using TestApi.Models;
using TestApi.Repositories;
using TestApi.Services;

namespace TestApi.Controllers
{
    [Route("")]
    [ApiController]
    public class TestController(ITestRepository testRepository, ITestService testService, IMapper mapper) : Controller
    {

        private readonly ITestRepository _testRepository = testRepository;
        private readonly ITestService _testService = testService;

        private readonly IMapper _mapper = mapper;

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var testDto = await _testService.GetTestWithQuestions(id);
                return testDto == null ? NotFound() : Ok(testDto);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TestDetailsDto testDto)
        {
            var test = _mapper.Map<Test>(testDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _testRepository.Update(test);
                await _testRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TestDetailsDto testDto)
        {
            var test = _mapper.Map<Test>(testDto);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _testRepository.AddAsync(test);
                await _testRepository.SaveChangesAsync();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
            return NoContent();
        }
    }
}
