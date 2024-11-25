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
        public async Task TestController_GetById_ReturnOk()
        {
            // Arrange
            int TestId = 1;
            var controller = new TestController(_testRepository, _testService);

            // Act
            var result = await controller.GetById(TestId);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(OkObjectResult));
        }
    }

}