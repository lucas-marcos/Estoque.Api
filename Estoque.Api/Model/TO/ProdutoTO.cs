using Estoque.Api.Framework;
using FluentValidation.Results;

namespace Estoque.Api.Model.TO;
using FluentValidation;

public class ProdutoTO
{
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string CodigoDeBarra { get; set; }
    
    private List<ValidationFailure> Erros { get; set; }
    public bool IsValid()
    {
        var produtoTOValidator = new ProdutoTOValidator();

        Erros = produtoTOValidator.Validate(this).Errors;
        return Erros.Count == 0;
    }

    public List<string> RetornarErros() => Erros.Select(a => a.ErrorMessage).ToList();

    public Produto ToProduto()
    {
        var produto = new Produto();

        ObjectExtensions<ProdutoTO, Produto>.Copy(this, produto);

        return produto;
    }
}

public class ProdutoTOValidator : AbstractValidator<ProdutoTO>
{
    public ProdutoTOValidator()
    {
        RuleFor(a => a.Descricao).NotNull().NotEmpty().WithMessage("É necessário informar um nome para o produto");
        RuleFor(a => a.Marca).NotNull().NotEmpty().WithMessage("É necessário informar uma marca para o produto");
        RuleFor(a => a.Tipo).NotNull().NotEmpty().WithMessage("É necessário informar o tipo do produto");
        RuleFor(a => a.Preco).GreaterThan(0).WithMessage("O preço do produto deve ser informado");
        RuleFor(a => a.CodigoDeBarra).NotNull().NotEmpty().WithMessage("É necessário informar o código de barras do produto");
    }
}