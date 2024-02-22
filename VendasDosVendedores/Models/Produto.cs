using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasDosVendedores.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O {} deve ter no mínimo {} palavras e no máximo {}")]
    [Display(Name = "Nome do produto")]
    public string Nome { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O {} deve ter no mínimo {} palavras e no máximo {}")]
    [Display(Name = "Descrição curta do produto")]
    public string DescricaoCurta { get; set; }

    [Required]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O {} deve ter no mínimo {} palavras e no máximo {}")]
    [Display(Name = "Descrição detalhada do produto")]
    public string DescricaoDetalhada { get; set; }

    [Required]
    [Column(TypeName ="decimal(10,2")]
    [Display(Name ="Preço do produto")]
    [Range(1, 99999.99, ErrorMessage = "O preço deve estar entre 1 e 99999.99")]
    public decimal Preco { get; set; }

    [Required]
    [Display(Name ="Quantidade do Produto")]
    public int Quantidade { get; set; }

    [Required]
    [Display(Name = "Imagem grande do Produto")]
    public string ImageGrande { get; set; }

    [Required]
    [Display(Name = "Imagem pequena do Produto")]
    public string ImagePequena { get; set; }

}
