using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Features.ProductFeatures.Commands;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.ProductFeatures.Handlers 
{
    public class DeleteProductByIdHandler : IRequestHandler<DeleteProductByIdCommand, int>
    {
        private readonly IApplicationDbContext _context;
        public DeleteProductByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.Where(a => a.Id == request.Id).FirstOrDefaultAsync();
            if (product == null) return default;
            _context.Products.Remove(product);
            await _context.SaveChanges();
            return product.Id;
        }
    }
}