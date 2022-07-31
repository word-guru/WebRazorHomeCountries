using WebRazorHome.Models;

namespace WebRazorHome.Services
{
    //Паттерн "Репозиторий"
    public interface ICountrie 
    {
        IEnumerable<Countrie> GetCountrie();
    }
}
