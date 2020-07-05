using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Underc0deApi.Core.Entities;

namespace Underc0deApi.Core.Contexts
{
    public class ObjetoPruebaContext : DbContext
    {
        public ObjetoPruebaContext(DbContextOptions<ObjetoPruebaContext> options)
           : base(options)
        {
        }

        public DbSet<ObjetoPrueba> ObjetoPrueba { get; set; }
    }
}
