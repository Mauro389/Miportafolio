using Microsoft.AspNetCore.Mvc;
using miperfil.Models;

namespace miperfil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Creamos la información del perfil
            var profile = new ProfileViewModel
            {
                FullName = "Mauro González",
                RoleTitle = "Desarrollador de Software | Enfoque Backend & Web",
                Summary = "Estudiante de Ingeniería de Sistemas apasionado por el desarrollo de APIs en .NET, arquitectura de bases de datos, tecnologías web y soluciones en la nube.",
                SkillCategories = new List<SkillCategory>
                {
                    new SkillCategory
                    {
                        CategoryName = "Backend & Bases de Datos",
                        Skills = new List<string> { ".NET / C#", "ASP.NET Core Web API", "SQL Server" }
                    },
                    new SkillCategory
                    {
                        CategoryName = "Frontend & UI",
                        Skills = new List<string> { "HTML5", "CSS3", "JavaScript", "Diseño Responsivo" }
                    }
                },
                LearningStack = new List<string> { "Docker & Contenedores", "Conceptos DevOps & CI/CD", "Despliegue en Azure" },
                GithubUrl = "https://github.com",

                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "El Patio de mi Abuela - Dashboard Móvil",
                        Description = "Aplicación móvil para gestión de órdenes, comandas y monitoreo en tiempo real.",
                        ImageUrl = "/images/movil.jpeg",
                        TechStack = new List<string> { "Mobile", "UI/UX", "APIs" }
                    },
                    new Project
                    {
                        Title = "Sistema de Facturación & Administración Web",
                        Description = "Panel administrativo web para control de ventas, facturación y resumen financiero.",
                        ImageUrl = "/images/dashboard.jpeg",
                        TechStack = new List<string> { "ASP.NET Core", "SQL Server", "Dashboard Analytics" }
                    },
                    new Project
                    {
                        Title = "Menú Digital e Interfaz",
                        Description = "Módulo visual e interactivo para gestión de productos y pedidos.",
                        ImageUrl = "/images/menu.jpeg",
                        TechStack = new List<string> { "HTML5/CSS3", "JavaScript", "Diseño Web" }
                    },
                    new Project
                    {
                        Title = "Arquitectura de APIs & Servicios Web",
                        Description = "Diseño e implementación de Web APIs RESTful documentadas y estructuradas.",
                        ImageUrl = "/images/api.jpeg",
                        TechStack = new List<string> { "C#", "ASP.NET Core Web API", "Swagger" }
                    },
                    new Project
                    {
                        Title = "Contenedores & Despliegue DevOps",
                        Description = "Configuración de entorno de contenedores y despliegues con Docker.",
                        ImageUrl = "/images/devops.jpeg",
                        TechStack = new List<string> { "Docker", "DevOps", "Cloud" }
                    }
                },




            };

            // Se envía el objeto 'profile' a la vista
            return View(profile);
        }
    }
}