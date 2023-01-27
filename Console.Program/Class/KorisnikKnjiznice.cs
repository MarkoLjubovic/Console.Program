using Console.Program.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Class
{
    public class KorisnikKnjiznice:IKorisnikKnjiznice
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateOnly DatumPosuđivanja { get; set; }
        public TimeOnly VrijemePrijave { get; set; }

        public KorisnikKnjiznice(string ime, string prezime, DateOnly datumPosudivanja, TimeOnly vrijemePosudivanja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumPosuđivanja = datumPosudivanja;
            VrijemePrijave = vrijemePosudivanja;
        }
    }
}
