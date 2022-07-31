using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebRazorHome.Models;

namespace WebRazorHome.Services
{
    //Паттерн "Репозиторий"
    public interface ICountrie 
    {
        IEnumerable<Countrie> GetCountrie();
    }
}
