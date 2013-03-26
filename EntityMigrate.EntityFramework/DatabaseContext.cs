using System.Data.Entity;
using EntityMigrate.Models;

namespace EntityMigrate.EntityFramework
{
    public class DatabaseContext:DbContext
    {
         public DbSet<TradeSubmission> TradeSubmissions { get; set; } 

         public DbSet<TradeOrder> TradeOrders { get; set; } 
    }
}