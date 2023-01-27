using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Validations.Interfaces
{
    public interface IValidation
    {
        void UnosTeksta(string prviUnos, string drugiUnos);
        void OdabirOpcije(int unos);
    }
}
