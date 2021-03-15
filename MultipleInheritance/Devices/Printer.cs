using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Process doc Printer: " + document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Print of printer: " + document);
            
        }

    }
}
