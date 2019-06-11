using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Module1.Models;

namespace Module1.Data
{
    public class ProductsDbContext : DbContext
    {

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

       public DbSet<Products> Products { get; set; }
    }
   }
 
