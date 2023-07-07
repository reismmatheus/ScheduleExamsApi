using ScheduleExams.Application.Interface;
using ScheduleExams.Data.Interface;
using ScheduleExams.Domain;
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

        public async Task<Client> GetByCpfAsync(string cpf)
        {
            var result = await _clientRepository.GetByCpfAsync(cpf);
            return result;
        }
        public async Task<List<Client>> GetAllAsync()
        {
            var result = await _clientRepository.GetAllAsync();
            return result;
        }
        public async Task<Client> AddAsync(Client client)
        {
            var result = await _clientRepository.AddAsync(client);
            return result;
        }
        public async Task<Client> UpdateAsync(Client client)
        {
            var result = await _clientRepository.UpdateAsync(client);
            return result;
        }
        public async Task<bool> DeleteAsync(Guid id)
        {
            await _clientRepository.DeleteAsync(id);
            return true;
        }
    }
}
