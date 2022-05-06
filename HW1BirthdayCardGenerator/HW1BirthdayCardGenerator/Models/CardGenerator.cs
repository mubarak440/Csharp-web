using System.ComponentModel.DataAnnotations;

namespace HW1BirthdayCardGenerator.Models
{
    public class CardGenerator
    {
        [Required(ErrorMessage = "Please enter From")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter To")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; } 

    }
}
