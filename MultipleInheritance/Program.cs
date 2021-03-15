using MultipleInheritance.Devices;
using System;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer() { SerialNumber = 1080 };

            printer.ProcessDoc("My letter");

            printer.Print("Print: My letter");

            Scanner scanner = new Scanner() { SerialNumber = 2003 };

            scanner.ProcessDoc("Scan: My Email");

            Console.WriteLine(scanner.Scan());


            ComboDevice comboDevice = new ComboDevice() { SerialNumber = 3921};

            comboDevice.Print("Combo device Print");

            Console.WriteLine(comboDevice.Scan());

            comboDevice.ProcessDoc("ProcessDoc ComboDevice");

            Console.ReadKey();
        }
    }
}
