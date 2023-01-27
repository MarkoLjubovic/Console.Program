using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Validations.Interfaces
{
    public interface IValidation
    {
        void ProvjeraImena(string prviUnos);
        void ProvjeraPrezimena(string drugiUnos);
        void OdabirOpcije(int unos);
    }
}
