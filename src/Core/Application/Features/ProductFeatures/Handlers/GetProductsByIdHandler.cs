using System.Threading;
using Application.Features.ProductFeatures.Queries;
using Domain.Entities;
using System.Threading.Tasks;
using MediatR;
using Application.Interfaces;
using System.Linq;

namespace Application.Features.ProductFeatures.Handlers 
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IApplicationDbContext _context;

        public GetProductByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = _context.Products.Where(a => a.Id == request.Id).FirstOrDefault();
            if (product == null) return null;
            return await Task.FromResult(product);
        }
    }
}