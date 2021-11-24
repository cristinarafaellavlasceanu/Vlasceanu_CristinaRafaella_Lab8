using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlasceanu_CristinaRafaella_Lab8.Models;

namespace Vlasceanu_CristinaRafaella_Lab8.Data
{
    public class Vlasceanu_CristinaRafaella_Lab8Context : DbContext
    {
        public Vlasceanu_CristinaRafaella_Lab8Context (DbContextOptions<Vlasceanu_CristinaRafaella_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Vlasceanu_CristinaRafaella_Lab8.Models.Book> Book { get; set; }

        public DbSet<Vlasceanu_CristinaRafaella_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Vlasceanu_CristinaRafaella_Lab8.Models.Category> Category { get; set; }
    }
}
