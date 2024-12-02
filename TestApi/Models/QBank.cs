using System;
using Microsoft.Extensions.Options;


namespace TestApi.Models
{

    public class QBank : BaseModel
    {
        public int Id { get; set; }

        public required string Name { get; set; } = String.Empty;

        public ICollection<QuestionBank> QuestionBank { get; set; } = [];

    }

}
