using System;
namespace BBWallmart;

class MainMethod
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("How many Suppliers you want to add?");
        int noOfsup = int.Parse(Console.ReadLine());
        Suppliers[] s = new Suppliers[noOfsup];
        
        // Add suppliers
        for (int i = 0; i < noOfVenues; i++)
            s[i] = Suppliers.addSuppliers();
        while (true)
        {
            Console.WriteLine("\n*** BHAI BHAI WALLMART ***\n");
            Console.WriteLine("\n1. Suppliers detail\n2. Main Branch details\n3. Outlets\n4. Exit");
            int ch1 = int.Parse(Console.ReadLine());
            switch (ch1)
            {
                case 1: 
            }
        }
    }
}