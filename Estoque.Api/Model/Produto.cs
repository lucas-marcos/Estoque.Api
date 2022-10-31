namespace Estoque.Api.Model;

public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public string Tipo { get; set; }
    public string Marca { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string CodigoDeBarra { get; set; }
}