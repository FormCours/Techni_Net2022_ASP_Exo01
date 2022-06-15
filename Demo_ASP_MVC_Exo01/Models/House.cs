namespace Demo_ASP_MVC_Exo01.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Motto { get; set; }
        public IEnumerable<string> Headquarters { get; set; }
        public int MilitaryStrength { get; set; }
        public string Image { get; set; }
    }
}
