using System.Collections.Generic;

namespace HomePageMVC.Models
{
    public class ProjetosPerfilViewModel
    {
        public Perfil PerfilInfo { get; set; } = new Perfil();
        public List<Projeto> ListaProjetos { get; set; } = new List<Projeto>();
    }
}