﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Victor's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
            var stats = book.GetStatistics();
            Console.WriteLine($"The highest grade is {stats.High}. The lowest grade is {stats.Low}. The average grade is {stats.Average:N1}.");
        }
    }
}
