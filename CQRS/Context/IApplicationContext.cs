using CQRS.Model;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}