

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestApi.Models
{

    public class TestQuestion : BaseModel
    {


        public required int TestId { get; set; }

        public Test? Test { get; set; }

        public int QuestionId { get; set; }

        public Question? Question { get; set; }
    }
}