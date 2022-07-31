using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebRazorHome.Models
{
    public class Countrie
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public uint Population { get; set; }
        public string PhotoPath { get; set; } = String.Empty;
    }
}
