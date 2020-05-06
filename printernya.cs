using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    public class printernya
    {
        public string PrinterName { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Printer display dimension");
        }
        public virtual void Show()
        {
            Console.WriteLine("Printer printer printing.....");
        }


    }
    public class Epson : printernya
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing.....");
        }


    }
    public class Canon : printernya
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing.....");
        }
    }
    public class LaserJet : printernya
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
    }


