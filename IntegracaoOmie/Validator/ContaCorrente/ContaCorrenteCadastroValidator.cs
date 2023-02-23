using FluentValidation;
using IntegracaoOmie.Models.Cliente;
using IntegracaoOmie.Models.ContaCorrente;

namespace IntegracaoOmie.Validator.ContaCorrente
{
    public class ContaCorrenteCadastroValidator : AbstractValidator<IncluirContaCorrente>
    {
        public ContaCorrenteCadastroValidator()
        {
            RuleFor(c => c.CCodCCInt).NotEmpty().WithMessage("Informe o código da conta corrente de integração");
            RuleFor(c => c.TipoContaCorrente).NotEmpty().WithMessage("Informe o tipo da conta");
            RuleFor(c => c.CodigoBanco).NotEmpty().WithMessage("Informe o código do banco");
            RuleFor(c => c.Descricao).NotEmpty().WithMessage("Informe a descrição do banco");
        }
    }
}
