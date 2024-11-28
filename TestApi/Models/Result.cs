using TestApi.Models;

public class Result : BaseModel
{

    public int Id { get; set; }

    public int TestId { get; set; }
    public Test? Test { get; set; }
    public required string Username { get; set; }

    public required int Mark { get; set; }

    public required int OutOf { get; set; }

}