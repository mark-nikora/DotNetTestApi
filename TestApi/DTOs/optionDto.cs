using System;
using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using TestApi.DTOs;


namespace TestApi.DTOs
{

    public class OptionDto : BaseDto
    {
        public int Id { get; set; }
        public String Description { get; set; } = String.Empty;

        public bool Correct { get; set; } = false;

    }

}

