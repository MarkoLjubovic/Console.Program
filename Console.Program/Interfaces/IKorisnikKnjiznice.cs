using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Interfaces
{
    public interface IKorisnikKnjiznice
    {
        string Ime { get; set; }
        string Prezime { get; set; }
        DateOnly DatumPosuđivanja { get; set; }
        TimeOnly VrijemePrijave { get; set; }
    }
}
