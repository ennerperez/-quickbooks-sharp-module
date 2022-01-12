using System.Threading.Tasks;

namespace QuickBooks.Interfaces
{
    public interface IQuickBooksService
    {
        Task<string> GetOption(string key);
    }
}