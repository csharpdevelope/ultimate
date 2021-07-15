using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ultimate.Models;

namespace Ultimate.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}