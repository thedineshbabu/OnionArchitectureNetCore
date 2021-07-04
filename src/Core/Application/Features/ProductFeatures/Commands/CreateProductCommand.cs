using Domain.Entities;
using MediatR;

namespace Application.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public CreateProductCommand(int Id, string Name, string Barcode, string Description, decimal Rate)
        {
            this.Id = Id;
            this.Name = Name;
            this.Barcode = Barcode;
            this.Description = Description;
            this.Rate = Rate;
        }

        public int Id { get; set; }
        public string Name { get; set;  }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
    }
}