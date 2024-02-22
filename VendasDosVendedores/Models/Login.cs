using System.ComponentModel.DataAnnotations;

namespace VendasDosVendedores.Models;

public class Login
{
    [Key]
    public int LoginId { get; set; }

    [Required]
    [EmailAddress]
    public string Usuario { get; set; }

    [Required]
    [RegularExpression("^(?=.*[A-Z])(?=.*[!#@$%&])(?=.*[0-9])(?=.*[a-z]).{6,15}$", ErrorMessage ="A Senha deve ter no mínimo 6 caracteres e no máximo 15, uma letra maiúscula e minúscula e um número, e um caractere especial(!#@$%&)")]
    public string Senha { get; set; }

    public int VendedorId { get; set; }
    public virtual Vendedor Vendedor { get; set; }
}
