using System.Collections.Generic;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProductFeatures.Queries 
{
    public class GetAllProductsQuery : IRequest<List<Product>> 
    {
        public GetAllProductsQuery()
        {
            
        }
    }
}