using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebRazorHome.Models;

namespace WebRazorHome.Services
{
    public class MockCountrie : ICountrie
    {
        private List<Countrie> _countrieList;
        public MockCountrie()
        {
            _countrieList = new List<Countrie>()
            {
                new Countrie()
                {
                    Name = "Россия", Capital="Москва", Population = 143666931, PhotoPath = "rossiy.jpg"
                },
                new Countrie()
                {
                    Name = "США", Capital="Вашингтон", Population = 320194478, PhotoPath = "USA.jpg"
                },
                new Countrie()
                {
                    Name = "Китай", Capital="Пекин", Population = 1430075000, PhotoPath = "kitay.jpg"
                },
                new Countrie()
                {
                    Name = "Индия", Capital="Нью-Дели", Population = 1220800359, PhotoPath = "indiy.jpg"
                },
                new Countrie()
                {
                    Name = "Италия", Capital="Рим", Population = 61482297, PhotoPath = "italiy.jpg"
                },
                new Countrie()
                {
                    Name = "Франция", Capital="Париж", Population = 66200000, PhotoPath = "franciy.jpg"
                },
                new Countrie()
                {
                    Name = "Германия", Capital="Берлин", Population = 80523746, PhotoPath = "germaniy.jpg"
                }
            };
        }
        public IEnumerable<Countrie> GetCountrie()
        {
           return _countrieList;
        }
    }
}
