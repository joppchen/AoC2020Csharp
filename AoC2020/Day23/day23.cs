﻿using System;
using System.IO;
using AoC2020.Common;

namespace AoC2020.Day23
{
    internal static class Main
    {
        public static void Solve()
        {
            const string folder = "Day23";
            Console.WriteLine(folder);

            //var textFile = $"../../../{folder}/input.txt";
            var textFile = $"../../../{folder}/example.txt";

            if (File.Exists(textFile)) //
            {
                //var lines = File.ReadAllLines(textFile);
                var lines = File.ReadAllText(textFile);
                //var integers = SharedMethods.ParseStringArrayToInt(lines);

                /*foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }*/
                Console.WriteLine($"Number of input lines; {lines.Length}");

                /*var linesRaw = new string[lines.Length];
                lines.CopyTo(linesRaw, 0);*/

                var watch = System.Diagnostics.Stopwatch.StartNew();
                //Solver.Task1(lines);
                //linesRaw.CopyTo(lines, 0);

                Solver.Task2(lines);
                watch.Stop();
                Console.WriteLine($"Time consumption Task 2: {watch.ElapsedMilliseconds} [ms]");
            }
            else
            {
                Console.WriteLine("Fant IKKE filen");
            }
        }
    }
}