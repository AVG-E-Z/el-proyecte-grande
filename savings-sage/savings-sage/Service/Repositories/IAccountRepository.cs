using savings_sage.Model.Accounts;

namespace savings_sage.Service.Repositories;

public interface IAccountRepository
{
    Task<IEnumerable<Account>> GetAll();
    Task<Account?> GetById(int id);
    Task<IEnumerable<Account>> GetAllByOwner(string userId);
    Task<IEnumerable<Account>> GetAllByOwnerByType(string userId, AccountType type);
    Task<IEnumerable<Account>> GetAllSubAccounts(int accountId);
    Task<Account> AddAsync(Account account);
    Task DeleteWithSubAccounts(Account account);
    Task Update(Account account);
}