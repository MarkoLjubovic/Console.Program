using Console.Program.Interfaces;
using Console.Program.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Class
{
    public class Service : IService
    {

        public void Izbornik(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation)
        {
            System.Console.WriteLine("Što od navedenog želite odabrati?");
            System.Console.WriteLine("1. Knjige");
            System.Console.WriteLine("2. DVD");
            System.Console.WriteLine("3. AudioBook");

            System.Console.WriteLine("Odaberite opciju unosom broja:");
            int unos = Convert.ToInt32(System.Console.ReadLine());
            validation.OdabirOpcije(unos);
            switch (validation.unosOpcija)
            {
                case 1:
                    OdabirKnjiga(knjige, dVDs, audioBooks, validation);
                    break;

                case 2:
                    OdabirDVDa(knjige, dVDs, audioBooks, validation);
                    break;

                case 3:
                    OdabirAudioBooks(knjige, dVDs, audioBooks, validation);
                    break;

            }
        }

        public void OdabirAudioBooks(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation)
        {
            System.Console.WriteLine("Izbornik AudioBooks je otvoren, molimo vas da unesete ime naziv i ime autora.");

            System.Console.WriteLine("Trenutno dostupni AudioBooks:");
            foreach (var audioBook in audioBooks)
            {
                System.Console.WriteLine($"Naziv AudioBooka - {audioBook.Naziv} | Autor AudioBooka - {audioBook.Autor}");

            }

            System.Console.WriteLine("Naziv AudioBook-a:");
            var naziv = System.Console.ReadLine();
            System.Console.WriteLine("Autor AudioBook-a:");
            var autor = System.Console.ReadLine();
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var nextDate = currentDate.AddDays(7);
            var now = TimeOnly.FromDateTime(DateTime.Now);
            bool flag = false;

            foreach (var audioBook in audioBooks)
            {
                if (autor.Equals(audioBook.Autor) && naziv.Equals(audioBook.Naziv))
                {
                    System.Console.WriteLine($"AudioBook je uspješno posuđen!");
                    System.Console.WriteLine($"Naziv: {audioBook.Naziv}, Autor: {audioBook.Autor}, " +
                        $"Godina izdavanja: {audioBook.GodinaIzdavanja}, Duzina trajanja: {audioBook.Velicina}");
                    System.Console.WriteLine($"Datum i vrijeme posudbe je {currentDate} {now} i AudioBook je potrebno vratiti do {nextDate}{now}.");
                    Izbornik(knjige, dVDs, audioBooks, validation);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                System.Console.WriteLine("DVD ne postoji.");
                Izbornik(knjige, dVDs, audioBooks, validation);
            }
        }

        public void OdabirDVDa(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation)
        {
            System.Console.WriteLine("Izbornik DVD-a je otvoren, molimo vas da unesete ime naziv i ime autora.");

            System.Console.WriteLine("Trenutno dostupni DVD-ovi:");
            foreach (var dvd in dVDs)
            {
                System.Console.WriteLine($"Naziv DVD-a - {dvd.Naziv} | Autor DVD-a - {dvd.Autor}");

            }

            System.Console.WriteLine("Naziv DVD-a:");
            var naziv = System.Console.ReadLine();
            System.Console.WriteLine("Autor DVD-a:");
            var autor = System.Console.ReadLine();
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var nextDate = currentDate.AddDays(7);
            var now = TimeOnly.FromDateTime(DateTime.Now);
            bool flag = false;

            foreach (var dvd in dVDs)
            {
                if (autor.Equals(dvd.Autor) && naziv.Equals(dvd.Naziv))
                {
                    System.Console.WriteLine($"DVD je uspješno posuđen!");
                    System.Console.WriteLine($"Naziv: {dvd.Naziv}, Autor: {dvd.Autor}, " +
                        $"Godina izdavanja: {dvd.GodinaIzdavanja}, Duzina trajanja: {dvd.DuzinaTrajanja}");
                    System.Console.WriteLine($"Datum i vrijeme posudbe je {currentDate} {now} i DVD je potrebno vratiti do {nextDate}{now}.");
                    Izbornik(knjige, dVDs, audioBooks, validation);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                System.Console.WriteLine("DVD ne postoji.");
                Izbornik(knjige, dVDs, audioBooks, validation);
            }
        }

        public void OdabirKnjiga(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation)
        {
            System.Console.WriteLine("Izbornik knjiga je otvoren, molimo vas da unesete naziv i ime autora.");
            System.Console.WriteLine("Trenutno dostupne knjige:");
            foreach (var knjiga in knjige)
            {
                System.Console.WriteLine($"Naziv knjige - {knjiga.Naziv} | Autor knjige - {knjiga.Autor}");

            }

            System.Console.WriteLine("Posudite jednu od knjiga:");
            System.Console.WriteLine("Naziv knjige:");
            var naziv = System.Console.ReadLine();
            System.Console.WriteLine("Autor knjige:");
            var autor = System.Console.ReadLine();
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var nextDate = currentDate.AddDays(7);
            var now = TimeOnly.FromDateTime(DateTime.Now);
            bool flag = false;
            foreach (Knjiga knjiga in knjige)
            {
                if (autor.Equals(knjiga.Autor) && naziv.Equals(knjiga.Naziv))
                {
                    System.Console.WriteLine($"Knjiga je uspješno posuđena!");
                    System.Console.WriteLine($"Naziv: {knjiga.Naziv}, Autor: {knjiga.Autor}, " +
                        $"Godina izdavanja: {knjiga.GodinaIzdavanja}, Broj stranica: {knjiga.BrojStranica}");
                    System.Console.WriteLine($"Datum i vrijeme posudbe je {currentDate} {now} i knjigu je potrebno vratiti do {nextDate}{now}.");
                    Izbornik(knjige, dVDs, audioBooks, validation);
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                System.Console.WriteLine("Knjiga ne postoji.");
                Izbornik(knjige, dVDs, audioBooks, validation);
            }
        }

        public void Pozdrav()
        {
            System.Console.WriteLine($"Dobrodošli na sustav, molimo vas da unesete vaše podatke za pristup knjiznici.");
        }


        public void UnosPodatak(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation)
        {
            System.Console.WriteLine("Unesi ime korisnika:");
            string ime = System.Console.ReadLine();
            System.Console.WriteLine("Unesi prezime korisnika:");
            string prezime = System.Console.ReadLine();
            validation.UnosTeksta(ime, prezime);
            var currentDate = DateOnly.FromDateTime(DateTime.Now);
            var now = TimeOnly.FromDateTime(DateTime.Now);
            KorisnikKnjiznice korisnikKnjiznice = new KorisnikKnjiznice(ime, prezime, currentDate, now);

            System.Console.WriteLine($"Uspješna prijava na sustav {validation.unosPrvogTeksta} {validation.unosDrugogTeksta} - datum pristupa je {korisnikKnjiznice.DatumPosuđivanja}, " +
                $"dok je samo vrijeme prijave na sustav {korisnikKnjiznice.VrijemePrijave}");
            System.Console.WriteLine(" ");
            Izbornik(knjige, dVDs, audioBooks, validation);
        }
    }
}
