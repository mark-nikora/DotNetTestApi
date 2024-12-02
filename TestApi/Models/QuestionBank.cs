

using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TestApi.Models
{

    public class QuestionBank : BaseModel
    {

        public required int QBankId { get; set; }

        public QBank? QBank { get; set; }

        public int QuestionId { get; set; }
        public Question? Question { get; set; }

    }
}