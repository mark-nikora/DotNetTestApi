

namespace TestApi.DTOs
{

    public class TestDetailsDto : BaseDto
    {
        public int Id { get; set; }
        public required string Name { get; set; } = String.Empty;
        public required string Description { get; set; } = String.Empty;
        public List<QuestionDto> Questions { get; set; } = [];
    }

}
