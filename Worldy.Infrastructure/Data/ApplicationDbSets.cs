using Microsoft.EntityFrameworkCore;
using Worldy.Core.Entities;

namespace Worldy.Infrastructure.Data
{
    public partial class ApplicationDbContext
    {
        public virtual DbSet<Product> Products { get; set; }
    }
}