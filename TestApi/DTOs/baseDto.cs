

namespace TestApi.DTOs
{


    public abstract class BaseDto
    {

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    }
}