using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Application.Model
{
    public class ClientModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
    }
}
