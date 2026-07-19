using System;

class Program
    {
        static void Main(string[] args)
        {
            // Problem 1: Simple For Loop
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Problem 2: Even Numbers from 1 to 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Problem 3: While Loop Countdown
            int count = 5;

            while (count >= 1)
            {
                Console.WriteLine(count);
                count--;
            }

            // Problem 4: Multiples of 10 from 10 to 1000
            int number = 10;

            while (number <= 1000)
            {
                Console.WriteLine(number);
                number += 10;
            }

            // Problem 5: Seasons of the Year

            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }

            // Problem 6: Days of the Week

            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.Write("Enter a number from 1 to 7: ");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(days[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            // Problem 7: Favorite Books and Authors

            string[] books =
            {
                "Harry Potter",
                "The Hobbit",
                "Atomic Habits"
            };

            string[] authors =
            {
                "J.K. Rowling",
                "J.R. Tolkien",
                "James Clear"
            };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i] + " by " + authors[i]);
            }

            // Problem 8: Temperature Tracker

            int[] temperatures = { 102, 76, 65, 98, 15};

            Array.Sort(temperatures);

            Console.WriteLine("Temperatures in ascending order:");

            foreach (int temp in temperatures)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("Lowest Temperature: " + temperatures[0]);
            Console.WriteLine("Highest Temperature: " + temperatures[temperatures.Length - 1]);

            // Problem 9: Reverse Countdown

            int[] countdown = { 5, 4, 3, 2, 1 };

            Array.Reverse(countdown);

            for (int i = 0; i < countdown.Length; i++)
            {
                Console.WriteLine(countdown[i]);
            }
        }
    }

