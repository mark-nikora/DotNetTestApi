using System;
using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace TestApi.Models
{

    public class Option : BaseModel
    {
        public int Id { get; set; }
        public String Description { get; set; } = String.Empty;

        public bool Correct { get; set; } = false;

        public int QuestionId { get; set; }
        public Question? Question { get; set; }

    }

}

