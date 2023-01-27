using Console.Program.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Class
{
    public class DVD:Common,IDVD
    {
        public int DuzinaTrajanja { get; set; }
    }
}
