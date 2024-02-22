using System.ComponentModel.DataAnnotations;

namespace VendasDosVendedores.Models;

public class Vendedor
{
    [Required]
    [StringLength(200, MinimumLength =3, ErrorMessage ="O {} deve ter no mínimo {} palavras e no máximo {}")]
    [Display(Name = "Nome do vendedor")]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name ="Email do vendedor")]
    public string Email { get; set; }

    [Required]
    [Display(Name ="Rg do vendedor")]
    [RegularExpression("(^\\d{1,2}).?(\\d{3}).?(\\d{3})-?(\\d{1,2}|X|x$)", ErrorMessage ="O Rg deve ser escrito dessa forma: xx.xxx.xxx-xx")]
    public string RG { get; set; }

    [Required]
    [Display(Name = "Cpf do vendedor")]
    [RegularExpression("(^\\d{3}\\.\\d{3}\\.\\d{3}\\-\\d{2}$)")]
    public string Cpf { get; set; }

    [Required]
    [Display(Name = "Endereço do vendedor")]
    public string Endereco { get; set; }
}
