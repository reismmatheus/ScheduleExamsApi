using ScheduleExams.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleExams.Application.Interface
{
    public interface IClientBusiness
    {
        Task<Client> GetByCpfAsync(string cpf);
        Task<List<Client>> GetAllAsync();
        Task<Client> AddAsync(Client client);
        Task<Client> UpdateAsync(Client client);
        Task<bool> DeleteAsync(Guid id);
    }
}
