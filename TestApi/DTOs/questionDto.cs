using System;
using Microsoft.Extensions.Options;


namespace TestApi.DTOs
{

    public class QuestionDto
    {
        public int Id { get; set; }

        public required string Description { get; set; }

        public int Mark { get; set; } = 0;

        public List<OptionDto>? Options { get; set; }

    }


}
