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

    public Produto(int id, string descricao, string tipo, string marca, decimal preco, int quantidade, string codigoDeBarra) : this(descricao, tipo, marca, preco, quantidade, codigoDeBarra)
    {
        Id = id;
    }

    public Produto(string descricao, string tipo, string marca, decimal preco, int quantidade, string codigoDeBarra)
    {
        Descricao = descricao;
        Tipo = tipo;
        Marca = marca;
        Preco = preco;
        Quantidade = quantidade;
        CodigoDeBarra = codigoDeBarra;
    }
}