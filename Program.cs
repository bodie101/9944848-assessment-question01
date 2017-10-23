using System;
using System.Collections.Generic;

namespace assessment31
{
    class Program
    {
        static List<string> falcons = new List<string> { "Hisan", "Ka kite", "Siren", "koa", "Stella", "mojo" };
        static List<string> falconers = new List<string> { "Debbie", "Heidi", "Noel", "Melissa", "Kirsten", "koshy" };

        static void Main(string[] args)
        {
            var rand = new Random();
            Console.WriteLine(DisplayFalconers());
            
        }       

        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }

        static string DisplayFalconers()
        {

            var selectedFalcons = falcons[GenerateRandomNumber(falcons)];
            var selectedFalconers = falconers[GenerateRandomNumber(falconers)];

            
            return $"Selected Falconer = {selectedFalconers} - Selected Falcon = {selectedFalcons}";
        }

    }
}