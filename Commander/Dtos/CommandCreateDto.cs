using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        //public int Id { get; set; }
        //We don't want the client passing the Id
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
        //Data annotations are necessary here to throw a 400 instead of 500 error when client
        //forgets information
    }
}