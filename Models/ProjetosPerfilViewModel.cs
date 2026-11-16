using System.Collections.Generic;

namespace HomePageMVC.Models
{
    public class ProjetosPerfilViewModel
    {
        public required Perfil PerfilInfo { get; set;}
        public required List<Projeto> ListaProjetos { get; set; }
    }
}