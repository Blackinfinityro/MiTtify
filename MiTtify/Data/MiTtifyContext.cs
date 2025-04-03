using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiTtify.DataBase;

namespace MiTtify.Data
{
    public class MiTtifyContext : DbContext
    {
        public MiTtifyContext (DbContextOptions<MiTtifyContext> options)
            : base(options)
        {
        }

        public DbSet<MiTtify.DataBase.Canzone> Canzone { get; set; } = default!;
    }
}
