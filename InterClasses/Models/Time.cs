using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Time é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Time deve ter, no máximo, 50 caracteres")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        // Relacionamento entre Models (Tabelas no Bando de Dados)
        // Chave Estrangeira
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vincular o campo do ID da tabela
        public Esporte? Esporte { get; set; } // Vincular o Objeto relacionado ao ID acima
    }
}
