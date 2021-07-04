using System.Collections.Generic;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProductFeatures.Queries 
{
    public class GetProductByIdQuery : IRequest<Product> 
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int Id)
        {
            this.Id = Id;
        }
    }
}