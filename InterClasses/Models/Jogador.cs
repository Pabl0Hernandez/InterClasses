using System.ComponentModel.DataAnnotations;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Numero do Jogador é Obrigatório")]
        [Range(1, 99, ErrorMessage = "O Numero do Jogador deve ser entre 1 e 99.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Posição")]
        public string? Posicao { get; set; }

        // Relacionamento Jogador X Time
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
