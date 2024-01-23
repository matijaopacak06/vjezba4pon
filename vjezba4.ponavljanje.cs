using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace vj4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a: ");
            double cijenaBezPDV = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite stopu PDV-a (%): ");
            double stopaPDV = Convert.ToDouble(Console.ReadLine());

            double iznosPDV = cijenaBezPDV * (stopaPDV / 100);
            double cijenaSaPDV = cijenaBezPDV + iznosPDV;

            Console.WriteLine("Iznos PDV-a: " + iznosPDV);
            Console.WriteLine("Cijena sa PDV-om: " + cijenaSaPDV);
            Console.WriteLine();
        }
    }
}

