﻿using static System.Console;
using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");

            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }

            string fullName = "Alan Jones";
            int indexOfTheSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(
                startIndex: 0, length: indexOfTheSpace);
            string lastName = fullName.Substring(
                startIndex: indexOfTheSpace + 1);
            string lastThenFirst = $"{lastName}, {firstName}";
            WriteLine(lastThenFirst);
            string firstThenLast = $"{firstName} {lastName}";
            WriteLine(firstThenLast);

            string company = "Microsoft";
            bool startsWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            string fruit = "Apples";
            decimal price = 0.39M;
            DateTime when = DateTime.Today;
            WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
            WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.",
            fruit, price, when));
        }
    }
}
