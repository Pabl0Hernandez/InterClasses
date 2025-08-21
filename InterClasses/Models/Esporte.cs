using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace InterClasses.Models
{
    public class Esporte
    {
        public int EsporteID { get; set; }

        [Required(ErrorMessage = "O Nome do Esporte é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Esporte deve ter, no máximo, 50 caracteres")]

        [Display(Name = "Nome do Esporte")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade de Jogadores por Time")]
        [Range(1, 25, ErrorMessage = "A quantidade de Jogadores por Time deve ser entre 1 e 25.")]

        [Display(Name = "Quantidade de Jogadores ")]
        public int QtdJogadores { get; set; }

    }
}
