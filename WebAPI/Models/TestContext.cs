using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Controllers;

namespace WebAPI.Models
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }

        public DbSet<Value> values { get; set;  }
    }
}
