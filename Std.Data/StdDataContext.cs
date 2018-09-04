using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Std.Data;
using Std.Data.Domain;

namespace Std.Data
{
    public class StdDataContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CashFlow> CashFlows { get; set; }


        public StdDataContext(DbContextOptions<StdDataContext> options) : base(options)
        {

        }

    }
}
