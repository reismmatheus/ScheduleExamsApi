using Microsoft.EntityFrameworkCore;
using ScheduleExams.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Data.Context
{
    public class ScheduleExamsContext : DbContext
    {
        public ScheduleExamsContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
    }
}
