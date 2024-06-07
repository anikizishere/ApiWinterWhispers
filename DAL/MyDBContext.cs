using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiWinterWhispers.DAL
{
    public class MyDBContext: DbContext
    {

        public MyDBContext(DbContextOptions<MyDBContext> options): base(options)
        {
        }

        public DbSet<Models.Topic> Topic { get; set; }
    }
}
