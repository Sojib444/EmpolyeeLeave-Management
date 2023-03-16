namespace Interfaces
{
	public interface IunitofWork : IDisposable
	{
		Task Savechange();
	}
}
