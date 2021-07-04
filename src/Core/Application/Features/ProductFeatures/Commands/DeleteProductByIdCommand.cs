using Domain.Entities;
using MediatR;

namespace Application.Features.ProductFeatures.Commands
{
    public class DeleteProductByIdCommand : IRequest<int> 
    {
        public int Id { get; set; }

        public DeleteProductByIdCommand(int Id)
        {
            this.Id = Id;
        }
    }
}