﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_assignment_2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("\nArea of circle: " + area);
            Console.ReadKey();
        }
    }
}
