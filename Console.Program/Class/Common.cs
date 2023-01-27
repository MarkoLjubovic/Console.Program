using Console.Program.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Class
{
    public abstract class Common:ICommon
    {
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public int GodinaIzdavanja { get; set; }
    }
}
