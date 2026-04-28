using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Test_API_1.Models;

namespace Test_API_1.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
