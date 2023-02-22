using FluentValidation;
using IntegracaoOmie.Models.Cliente;

namespace IntegracaoOmie.Validator.Cliente;

public class ClienteCadastroValidator : AbstractValidator<ClienteCadastro>
{
    public ClienteCadastroValidator()
    {
        RuleFor(c => c.codigo_cliente_integracao).NotEmpty().WithMessage("Informe o código cliente integração");
        RuleFor(c => c.razao_social).NotEmpty().WithMessage("Informe a razão social");
        When(c => !string.IsNullOrWhiteSpace(c.Email), () =>
        {
            RuleFor(c => c.Email).EmailAddress().WithMessage("Informe um e-mail válido");
        });
    }
}
