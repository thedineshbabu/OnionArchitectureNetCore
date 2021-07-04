using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces
{
    public interface IApplicationDbContext 
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChanges();
    }
}