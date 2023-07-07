using ScheduleExams.Data.Context;
using ScheduleExams.Data.Interface;
using ScheduleExams.Domain;

namespace ScheduleExams.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ScheduleExamsContext _context;
        public async Task<Client> AddAsync(Client client)
        {
            await _context.AddAsync(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task DeleteAsync(Guid id)
        {
            var client = _context.Clients.FirstOrDefault(x => x.Id == id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return _context.Clients.ToList();
        }

        public async Task<Client> GetByCpfAsync(string cpf)
        {
            return _context.Clients.FirstOrDefault(x => x.Cpf == cpf);
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            var clientDb = _context.Clients.FirstOrDefault(x => x.Id == client.Id);
            if (clientDb == null)
            {
                clientDb.Cpf = client.Cpf;
                clientDb.BirthDate = client.BirthDate;
                clientDb.Name = client.Name;
                await _context.SaveChangesAsync();
            }
            return clientDb;
        }
    }
}
