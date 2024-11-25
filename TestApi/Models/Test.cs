
namespace TestApi.Models
{

    public class Test : BaseModel
    {
        public int Id { get; set; }
        public required string Name { get; set; } = String.Empty;
        public required string Description { get; set; } = String.Empty;
        public ICollection<TestQuestion> TestQuestion { get; set; } = [];
    }

}
