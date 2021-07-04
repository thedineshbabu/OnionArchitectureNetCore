using System.Threading;
using System.Threading.Tasks;
using Application.Features.ProductFeatures.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProductFeatures.Handlers 
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IApplicationDbContext context;

        public CreateProductHandler(IApplicationDbContext context)
        {
            this.context = context;
        }
        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product() 
            {
                Name = request.Name,
                Barcode = request.Barcode,
                Description = request.Description,
                Rate = request.Rate
            };
            context.Products.Add(product);
            context.SaveChanges();
            return Task.FromResult(product.Id);
        }
    }
}