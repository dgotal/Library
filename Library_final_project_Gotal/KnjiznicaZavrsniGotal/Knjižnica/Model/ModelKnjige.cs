using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnjiznicaZavrsniGotal.Knjižnica.Model
{
    public class ModelKnjige
    {
        public Guid id { get; set; }
        public int Kolicina { get; set; }
        public string NazivKnjige { get; set; }
        public string ImeAutora { get; set; }
    }
}
