namespace FuturoTrabalhoApi.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // Ex: "Hard Skill" ou "Soft Skill"
    }
}
