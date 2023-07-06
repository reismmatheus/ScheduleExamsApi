using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Domain
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedIn { get; set; }
        public DateTime? UpdatedIn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
