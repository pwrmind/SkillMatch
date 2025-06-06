
namespace CLI.Handlers;

public interface ICommandHandler<TCommand>
{
    Task HandleAsync(TCommand command);
}
