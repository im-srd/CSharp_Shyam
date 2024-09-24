using System;
using System.Collections.Generic;

namespace September23
{
    class MainMethod
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("How many Venues are there?");
            int noOfVenues = int.Parse(Console.ReadLine());
            Venue[] venues = new Venue[noOfVenues];
            // Add venues
            for (int i = 0; i<noOfVenues; i++)
                venues[i] = Venue.addVenue();

            // Book Venue
            while (true)
            {
                Console.WriteLine("\n**** VENUE BOOKING SYSTEM ****");
                Console.WriteLine("\n1. Book Hotels\n2. Show All Bookings\n3. Exit\n\n");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1: // Show hotel names and then book hotels
                        for (int i = 0; i < venues.Length; i++)
                        {
                            Console.WriteLine(venues[i].venueName+"\tPress ---"+(i+1)+"\n");
                        }
                        Console.WriteLine("\nEnter your choice:");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                venues[0].booking(); break;
                            case 2:
                                venues[1].booking(); break;
                            case 3:
                                venues[2].booking(); break;
                            default: Console.WriteLine("\n#### Wrong choice.#### \n"); break;
                        }
                        break;
                    
                    case 2: // Show all booked hotel with date.
                        for (int i=0; i<venues.Length; i++)
                            venues[i].showDetails();
                        break;


                    case 3: return;
                }
            }
        }
    }

    class Venue
    {
        public string venueName; // By default data memebers are private
        List<string> bookedOn = new List<string>();
        List<string> customerName = new List<string>(); // Make this as list because, a venue can be booked by more than one customers on different dates. And make the changes accordingly.

        public void showDetails()
        {
            if (bookedOn.Count > 0)
            {
                Console.WriteLine("Venue Name:" + venueName);
                Console.WriteLine("Already booked on:");
                for (int i = 0; i < bookedOn.Count; i++)
                {
                    Console.WriteLine(bookedOn[i] + "\t"+"by " + customerName[i]);
                }
                Console.WriteLine();
            }
            
        }

        public static Venue addVenue()
        {
            Venue venue = new Venue();
            Console.WriteLine("Enter the Venue Name:");
            venue.venueName = Console.ReadLine();
            return venue;
        }

        public void booking()
        {
            Console.WriteLine("Enter your name:");
            string cusName = Console.ReadLine();
            customerName.Add(cusName);
            Console.WriteLine("Enter the date(DD/MM/YYYY) :");
            string date = Console.ReadLine();
            if (bookedOn.Contains(date))
            {
                Console.WriteLine("Venue is already booked on " + date);
            }
            else
            {
                bookedOn.Add(date);
            }
        }
    }
}