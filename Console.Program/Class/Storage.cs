using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Class
{
    public class Storage
    {
        public List<Knjiga> Knjige = new List<Knjiga>
        {
            new Knjiga{Naziv="Dom",Autor="Ivan",GodinaIzdavanja=2023,BrojStranica=150},
            new Knjiga{Naziv="Uskoplje",Autor="Marko",GodinaIzdavanja=2001,BrojStranica=140},
            new Knjiga{Naziv="C#",Autor="Josipa",GodinaIzdavanja=2016,BrojStranica=150},
            new Knjiga{Naziv="BiH",Autor="Ivica",GodinaIzdavanja=2014,BrojStranica=250},
            new Knjiga{Naziv="Sloga",Autor="Marija",GodinaIzdavanja=2022,BrojStranica=270}
        };

        public List<DVD> dVDs = new List<DVD>
        {
            new DVD{Naziv="C#", Autor="Luka",GodinaIzdavanja=2017,DuzinaTrajanja=50},
            new DVD{Naziv="Programiranje", Autor="Marina",GodinaIzdavanja=2016,DuzinaTrajanja=50},
            new DVD{Naziv="OOP", Autor="Marko",GodinaIzdavanja=2014,DuzinaTrajanja=50},
            new DVD{Naziv="Baze podatake", Autor="Ivana",GodinaIzdavanja=2013,DuzinaTrajanja=50},
            new DVD{Naziv="NET Core", Autor="Josip",GodinaIzdavanja=2010,DuzinaTrajanja=50}
        };

        public List<AudioBook> audioBooks = new List<AudioBook>
        {
            new AudioBook{Naziv="C#",Autor="Kristina",GodinaIzdavanja=2016,Velicina="50 MB"},
            new AudioBook{Naziv="ASP.NET",Autor="Jelena",GodinaIzdavanja=2019,Velicina="90 MB"},
            new AudioBook{Naziv="Microsoft",Autor="Marin",GodinaIzdavanja=2014,Velicina="150 MB"},
            new AudioBook{Naziv="Programiranje",Autor="Mario",GodinaIzdavanja=2022,Velicina="80 MB"},
            new AudioBook{Naziv="OOP",Autor="Pear",GodinaIzdavanja=2021,Velicina="135 MB"}
        };
    }
}
