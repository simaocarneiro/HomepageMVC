namespace HomePageMVC.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Tecnologia { get; set; } = string.Empty;
    }
}