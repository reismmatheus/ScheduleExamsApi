using ScheduleExams.Data.Interface;
using ScheduleExams.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        public Task<Client> AddAsync(Client client)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetByCpfAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<Client> UpdateAsync(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
