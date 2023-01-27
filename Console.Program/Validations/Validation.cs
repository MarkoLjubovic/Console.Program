using Console.Program.Validations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Program.Validations
{
    public class Validation:IValidation
    {
        public string unosPrvogTeksta;
        public string unosDrugogTeksta;
        public int unosOpcija;

        public void OdabirOpcije(int unos)
        {
            bool flag = true;
            if (unos != 1 && unos != 2 && unos != 3)
            {
                flag = false;
            }

            if (flag == true)
            {
                unosOpcija = unos;
            }

            if (flag == false)
            {
                System.Console.WriteLine("Odaberi opciju ponovno.");
                unos = Convert.ToInt32(System.Console.ReadLine());
                unosOpcija = unos;
            }
        }

        public void ProvjeraImena(string prviUnos)
        {
            bool flag = true;

            foreach (var e in prviUnos)
            {
                if (!Char.IsLetter(e))
                {
                    flag = false;
                }
            }

            if (flag == true)
            {
                unosPrvogTeksta = prviUnos;
            }

            if (flag == false)
            {
                System.Console.WriteLine("Potrebno je unijeti samo slova. Ime nije dobro.");
                System.Console.WriteLine($"Unesi ponovno:");
                prviUnos = System.Console.ReadLine();
                unosPrvogTeksta = prviUnos;
            }
        }

        public void ProvjeraPrezimena(string drugiUnos)
        {
            bool flag = true;

            foreach (var e in drugiUnos)
            {
                if (!Char.IsLetter(e))
                {
                    flag = false;
                }
            }


            if (flag == true)
            {
                unosDrugogTeksta = drugiUnos;
            }

            if (flag == false)
            {
                System.Console.WriteLine("Potrebno je unijeti samo slova. Prezime nije dobro.");
                System.Console.WriteLine($"Unesi ponovno:");
                drugiUnos = System.Console.ReadLine();
                unosDrugogTeksta = drugiUnos;
            }
        }
    }
}
