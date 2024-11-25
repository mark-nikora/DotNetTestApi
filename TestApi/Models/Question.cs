using System;
using Microsoft.Extensions.Options;


namespace TestApi.Models
{

    public class Question : BaseModel
    {
        public int Id { get; set; }

        public required string Description { get; set; } = String.Empty;

        public int Mark { get; set; } = 0;

        public ICollection<Option> Option { get; set; } = [];

        public ICollection<TestQuestion> TestQuestion { get; set; } = [];


    }

}
