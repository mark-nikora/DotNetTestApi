using AutoMapper;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TestApi.Controllers;
using TestApi.DTOs;
using TestApi.Repositories;
using TestApi.Services;
using Xunit;

namespace TestApi.Tests.Controller
{

    public class TestApiControllerTests
    {
        private readonly ITestRepository _testRepository;
        private readonly ITestService _testService;
        private readonly IMapper _mapper;

        public TestApiControllerTests()
        {
            _testRepository = A.Fake<ITestRepository>();
            _testService = A.Fake<ITestService>();
            _mapper = A.Fake<IMapper>();
        }

        [Fact]
        public async Task TestController_GetTestById_ReturnOk()
        {
            // Arrange
            int TestId = 1;
            var controller = new TestController(_testRepository, _testService, _mapper);

            // Act
            var result = await controller.GetTestById(TestId);

            // Assert            
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, okResult.StatusCode);

        }

        [Fact]
        public async Task TestController_Update_ReturnOk()
        {
            // Arrange
            var testDto = new TestDetailsDto()
            {
                Id = 1,
                Name = "c# basics again",
                Description = "this c# test has been updated"
            };

            // Act
            var controller = new TestController(_testRepository, _testService, _mapper);
            var result = await controller.Update(testDto);

            // Assert
            var okResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, okResult.StatusCode);
        }
    }

}