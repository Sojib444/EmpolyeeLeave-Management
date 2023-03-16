namespace Interfaces.Repository
{
	public interface IRepository<TEmployee>
	{
		Task Add(TEmployee employee);
		Task<List<TEmployee>> GetAll();
		Task<TEmployee> GetEmployee(Guid id);
		Task<TEmployee> UpdateEmployee(Guid id);
		Task DeleteEmployee(Guid id);
	}
}
