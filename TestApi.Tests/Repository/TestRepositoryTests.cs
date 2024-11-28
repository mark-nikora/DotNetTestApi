using Microsoft.EntityFrameworkCore;
using TestApi.Data;
using TestApi.Models;
using Xunit;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestApi.Repositories;
using Xunit.Abstractions;

namespace TestApi.Tests.Repository
{

    public class TestApiRepositoryTests
    {

        private ITestOutputHelper _output;

        public TestApiRepositoryTests(ITestOutputHelper output)
        {
            _output = output;
        }

        private AppDbContext GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                   .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                   .Options;
            var dbContext = new AppDbContext(options);
            dbContext.Database.EnsureCreated();

            var modelBuilder = new ModelBuilder();
            modelBuilder.Entity<Test>().HasData(SeedData.Tests);

            return dbContext;
        }

        [Fact]
        public async Task TestRepository_GetTest_ReturnsTest()
        {
            // arrange
            var id = 1;
            var dbContext = GetDatabaseContext();
            var testRepository = new TestRepository(dbContext);

            // act
            var result = await testRepository.GetById(id);

            // result
            result.Should().NotBeNull();
            result.Should().BeOfType<Test>();

            _output.WriteLine("TestRepository_GetTest_ReturnsTest has Passed");

        }

    }

}