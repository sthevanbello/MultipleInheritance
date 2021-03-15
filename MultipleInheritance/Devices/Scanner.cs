using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Process Doc Scanner: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
