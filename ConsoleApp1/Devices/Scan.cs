
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Scan:Device,IScan
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: "+doc);
        }

        public string scan()
        {
            return "Scanner scan result: ";
        }
    }
}
