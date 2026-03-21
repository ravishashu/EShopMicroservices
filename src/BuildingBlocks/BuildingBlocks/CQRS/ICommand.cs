using MediatR;

namespace BuildingBlocks.CQRS
{
    //Unit is a struct that represents a void type, it is used to indicate that a command does not return any data.
    public interface ICommand : ICommand<Unit>
    {
    }

    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
