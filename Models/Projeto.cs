namespace HomePageMVC.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public required string Titulo { get; set;}
        public required string Descricao { get; set; }
        public required string Tecnologia { get; set; }
    }
}