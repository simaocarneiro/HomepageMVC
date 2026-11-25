using System;
using System.Collections.Generic;
using HomePageMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomePageMVC.Controllers
{
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

        public IActionResult Projetos(string? termo)
        {
            var perfil = new Perfil
            {
                Nome = "Simão",
                Cargo = "Desenvolvedor Web em Formação",
                AnosExperiencia = 1
            };

            var listaProjetos = new List<Projeto>
            {
                new Projeto { Id = 1, Titulo = "Portfólio MVC", Descricao = "Migração bem-sucedida de site estático para ASP.NET Core MVC.", Tecnologia = "C# / MVC" },
                new Projeto { Id = 2, Titulo = "Landing Page", Descricao = "Página de apresentação responsiva focada na experiência mobile.", Tecnologia = "HTML / CSS" },
                new Projeto { Id = 3, Titulo = "App de Tarefas", Descricao = "Pequena aplicação interativa em JavaScript puro para gestão diária.", Tecnologia = "JavaScript" },
                new Projeto { Id = 4, Titulo = "Gestor de Stock", Descricao = "Sistema simples de controlo e listagem de produtos.", Tecnologia = "C# / LINQ" },
                new Projeto { Id = 5, Titulo = "Blog Pessoal", Descricao = "Plataforma de artigos dinâmicos com suporte a comentários.", Tecnologia = "Bootstrap 5" }
            };

            var projetosFiltrados = new List<Projeto>();

            if (!string.IsNullOrWhiteSpace(termo))
            {
                string pesquisa = termo.Trim();

                foreach (var projeto in listaProjetos)
                {
                    bool correspondeTitulo = projeto.Titulo.Contains(pesquisa, StringComparison.OrdinalIgnoreCase);
                    bool correspondeDescricao = projeto.Descricao.Contains(pesquisa, StringComparison.OrdinalIgnoreCase);
                    bool correspondeTecnologia = projeto.Tecnologia.Contains(pesquisa, StringComparison.OrdinalIgnoreCase);

                    if (correspondeTitulo || correspondeDescricao || correspondeTecnologia)
                    {
                        projetosFiltrados.Add(projeto);
                    }
                }
            }
            else
            {
                projetosFiltrados = listaProjetos;
            }

            var viewModel = new ProjetosPerfilViewModel
            {
                PerfilInfo = perfil,
                ListaProjetos = projetosFiltrados
            };

            ViewData["TermoPesquisa"] = termo;

            return View(viewModel);
        }

        public IActionResult Contato()
        {
            return View();
        }
    }
}