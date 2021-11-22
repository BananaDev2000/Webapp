using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniWebsite.Models
{
    public class Gebruiker
    {
        public string naam { get; set; }
        public void start()
        {
            naam = "Frank";
        }
    }
}
