using FluentValidation;
using IntegracaoOmie.Models.Cliente;

namespace IntegracaoOmie.Validator.Cliente;

public class ClienteCadastroValidator : AbstractValidator<ClienteCadastro>
{
    public ClienteCadastroValidator()
    {
        RuleFor(c => c.codigo_cliente_integracao).NotEmpty().WithMessage("Informe o código cliente integração");
        RuleFor(c => c.razao_social).NotEmpty().WithMessage("Informe a razão social");
        RuleFor(c => c.Tags).Custom((tags, contexto) =>
        {
            var bitVazio = false;
            foreach(var item in tags)
            {
                if (string.IsNullOrWhiteSpace(item.tag))
                { bitVazio = true; break; }
            }

            if (bitVazio)
            {
                contexto.AddFailure(new FluentValidation.Results.ValidationFailure(nameof(Models.Tag), "Informe uma tag válida"));
            }
        });
        When(c => !string.IsNullOrWhiteSpace(c.Email), () =>
        {
            RuleFor(c => c.Email).EmailAddress().WithMessage("Informe um e-mail válido");
        });
    }
}
