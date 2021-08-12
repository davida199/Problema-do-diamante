using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Printer:Device,IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: "+doc);
        }
        public void printer(string doc)
        {
            Console.WriteLine("Printer doc "+doc);
        }
    }
}
