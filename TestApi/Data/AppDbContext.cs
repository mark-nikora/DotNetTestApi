using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TestApi.Models;
using TestApi.Data;
using System.Diagnostics.Metrics;
using System.ComponentModel;

namespace TestApi.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Question>? Question { get; set; }
        public DbSet<Option>? Option { get; set; }

        public DbSet<TestQuestion>? TestQuestion { get; set; }

        public DbSet<Test>? Test { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            BuildRelationships(modelBuilder);
            SeedModels(modelBuilder);
        }

        private static void BuildRelationships(ModelBuilder modelBuilder)
        {
            // question 1 -- M testquestion M -- 1 test

            modelBuilder.Entity<Question>()
             .HasMany(q => q.Option)
             .WithOne(o => o.Question)
             .HasForeignKey(o => o.QuestionId);

            modelBuilder.Entity<TestQuestion>()
                .HasKey(tq => new { tq.QuestionId, tq.TestId });

            modelBuilder.Entity<TestQuestion>()
                .HasOne(tq => tq.Question)
                .WithMany(q => q.TestQuestion)
                .HasForeignKey(tq => tq.QuestionId);

            modelBuilder.Entity<TestQuestion>()
                .HasOne(tq => tq.Test)
                .WithMany(t => t.TestQuestion)
                .HasForeignKey(tq => tq.TestId);

            // question 1 -- M questionbank M -- 1 qbank

            modelBuilder.Entity<QuestionBank>()
                .HasKey(tq => new { tq.QuestionId, tq.QBankId });

            modelBuilder.Entity<QuestionBank>()
                .HasOne(qb => qb.Question)
                .WithMany(q => q.QuestionBank)
                .HasForeignKey(qb => qb.QuestionId);

            modelBuilder.Entity<QuestionBank>()
                .HasOne(tq => tq.QBank)
                .WithMany(t => t.QuestionBank)
                .HasForeignKey(tq => tq.QBankId);

        }

        private static void SeedModels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(SeedData.Tests);
            modelBuilder.Entity<Question>().HasData(SeedData.Questions);
            modelBuilder.Entity<Option>().HasData(SeedData.Options);
            modelBuilder.Entity<TestQuestion>().HasData(SeedData.TestQuestions);
            modelBuilder.Entity<Result>().HasData(SeedData.Results);
        }

    }
}


