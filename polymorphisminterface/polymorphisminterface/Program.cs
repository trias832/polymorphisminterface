using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphisminterface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama\t: Trias Handayani");
            Console.WriteLine("NIM\t: 19.11.2733");
            Console.WriteLine("Kelas\t: 19-IF03");


            IPrinterWindows printer= new Epson();


            Console.WriteLine("\n\nPilih printer : ");
            Console.WriteLine("\n1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. Laserjet\n");

            Console.WriteLine("\nNomor Printer[1...3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (nomorPrinter > 0 && nomorPrinter < 4)
            {
                if (nomorPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (nomorPrinter == 2)
                {
                    printer = new Canon();
                }
                else // if (nomorPrinter == 3)
                {
                    printer = new LaserJet();
                }
                printer.Show();
                printer.Print();
            }
            else
            {
                Console.WriteLine("Pilihan Tidak Ada");
            }


            Console.ReadKey();
        }
    }
}
