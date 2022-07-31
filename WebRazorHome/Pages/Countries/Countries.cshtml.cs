using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebRazorHome.Models;
using WebRazorHome.Services;

namespace WebRazorHome.Pages.Countries
{
    public class CountriesModel : PageModel
    {
        private readonly ICountrie _db;
        public CountriesModel(ICountrie db)
        {
            _db = db;   
        }
        public IEnumerable<Countrie> Countries { get; set; }

        public void OnGet()
        {
            Countries = _db.GetCountrie(); 
        }
    }
}
