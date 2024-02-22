using System.ComponentModel.DataAnnotations;

namespace VendasDosVendedores.Models;

public class Venda
{
    [Key]
    public int VendaId { get; set; }

    [Required]
    [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
    public DateTime Date { get; set; }
    public Produto Produto { get; set; }
    public int ProdutoId { get; set; }
    [Required]
    [Display(Name ="Quantidade do produto vendida")]
    public int Quantidade { get; set; }

    public Vendedor Vendedor { get; set; }
    public int VendedorId { get; set; }
}
