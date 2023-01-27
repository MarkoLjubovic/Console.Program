using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Interfaces
{
    public interface ICommon
    {
        string Naziv { get; set; }
        string Autor { get; set; }
        int GodinaIzdavanja { get; set; }
    }
}
