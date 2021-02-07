namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        //public string Platform { get; set; }
        //Just choosing a field to not expose to clients
    }
}