﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentmyPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==RENT MY PLACE==");
            Console.Write("Enter the ID to delete listing: ");
            string ID = Console.ReadLine();
            Listing.DeleteListing(ID);
        }
    }
}
