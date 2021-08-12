using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("my letter");
            p.printer("my letter");

            Scan s = new Scan() { SerialNumber=2020};
            s.ProcessDoc("my email:");

            ComboDevice c = new ComboDevice() {SerialNumber=2109 };
            c.printer("text1");
            Console.WriteLine(c.scan());
        }
    }
}
