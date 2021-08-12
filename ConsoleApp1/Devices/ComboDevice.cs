using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ComboDevice : Device, IPrinter, IScan
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("processing: "+doc);
        }
        public void printer(string doc)
        {
            Console.WriteLine("printer doc: "+doc);
        }

        public string scan()
        {
           return "scan object: ";
        }
    }
}
