using Console.Program.Class;
using Console.Program.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Interfaces
{
    public interface IService
    {
        void Pozdrav();
        public void UnosPodatak(Validation validation);
        public void Izbornik(List<Knjiga> knjige, List<DVD> dVDs, List<AudioBook> audioBooks, Validation validation);
        public void OdabirAudioBooks(List<AudioBook> audioBooks, Validation validation);
        public void OdabirDVDa(List<DVD> dVDs, Validation validation);
        public void OdabirKnjiga(List<Knjiga> knjige, Validation validation);
    }
}
