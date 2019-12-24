using Domain.Commands.Interfaces;

namespace Domain.Handlers.Interfaces
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}