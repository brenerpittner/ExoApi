namespace ExoApi.Models
{
    public class Projeto
    {
        // Mesmos atributos do banco de dados 'dbExoApi'
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Status { get; set; }
        public string? Data_De_Inicio { get; set; }
        public string? Area { get; set; }
    }
}
