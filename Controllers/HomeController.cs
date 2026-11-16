using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomePageMVC.Models;

namespace HomePageMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Sobre()
    {
        return View();
    }

    public IActionResult Projetos()
    {
        var perfil = new Perfil
        {
            Nome = "Simão",
            Cargo = "Programador em Formação",
            AnosExperiencia = 1
        };

        var listaProjetos = new List<Projeto>
        {
            new Projeto { Id = 1, Titulo = "Portfólio MVC", Descricao = "Migração bem-sucedida do site estático para ASP.NET Core MVC.", Tecnologia = "C# / MVC"},
            new Projeto { Id = 2, Titulo = "Landing Page", Descricao = "Página de apresentação responsive focada na experiência mobile.", Tecnologia = "HTML / CSS"},
            new Projeto { Id = 3, Titulo = "App de Tarefas", Descricao = "Pequena aplicação interativa em JavaScript puro para gestão diária.", Tecnologia = "JavaScript"},
            new Projeto { Id = 4, Titulo = "Gestor de Stock", Descricao = "Sistema simples de controlo e listagem de produtos.", Tecnologia = "C# / LINQ" },
            new Projeto { Id = 5, Titulo = "Blog Pessoal", Descricao = "Plataforma de artigos dinâmicos com suporte a comentários.", Tecnologia = "Bootstrap 5" }
        };

        var viewModel = new ProjetosPerfilViewModel
        {
            PerfilInfo = perfil,
            ListaProjetos = listaProjetos
        };

        return View(viewModel);
    }

    public IActionResult Contato()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
