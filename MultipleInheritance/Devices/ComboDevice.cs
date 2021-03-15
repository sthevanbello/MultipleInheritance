using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {

        
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print: " + document);
        }


        public string Scan()
        {
            return "ComboDevice Scan Result";
        }
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing: " + document);
        }
    }
}
