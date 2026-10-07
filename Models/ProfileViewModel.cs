namespace miperfil.Models
{
    // Representa una categoría de tecnologías (Backend, Frontend, etc.)
    public class SkillCategory
    {
        public string CategoryName { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
    }

    // Clase que representa un proyecto individual
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> TechStack { get; set; } = new();
    }

    // Contiene toda la información del perfil laboral
    public class ProfileViewModel
    {
        public string FullName { get; set; } = string.Empty;
        public string RoleTitle { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public List<SkillCategory> SkillCategories { get; set; } = new();
        public List<string> LearningStack { get; set; } = new();

       //para agregar los projects
        public List<Project> Projects { get; set; } = new();

        public string GithubUrl { get; set; } = string.Empty;
    }
}