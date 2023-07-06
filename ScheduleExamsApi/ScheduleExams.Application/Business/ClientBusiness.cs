using ScheduleExams.Application.Interface;
using ScheduleExams.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Application.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly IClientRepository _clientRepository;
        public ClientBusiness(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

    }
}
