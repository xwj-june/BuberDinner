using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Common.Behaviors;

public class ValidateRegisterCommandBehavior : IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(
        RegisterCommand request,
        CancellationToken cancellationToken,
        RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next)
    {
        // before the handler
        var result = await next();
        // after the handler
        return result;
    }
}