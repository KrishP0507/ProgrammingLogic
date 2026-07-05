using System;

  class Program
  {
    static void Main(string[] args)
    {
       // Step 1
       /* 
       Name: Krish Patel
       Title: IT-1050-Lab 1
       */
        // Step 2
        Console.WriteLine("Name: Krish Patel");
        Console.WriteLine("Course Title: IT-1050-Programming Logic");
        
        // Step 3
        int favoriteNumber = 5;
        string favoriteLanguage = "Python";
        double programsWritten = 40;
        bool programmingExperience = true;

        Console.WriteLine("My favorite number is " + favoriteNumber);
        Console.WriteLine("My favorite programming language is " + favoriteLanguage);
        Console.WriteLine("I have written " + programsWritten + " programs in python before this");
        Console.WriteLine("Programming experience " + programmingExperience);
        
        // Step 4
        const string schoolName = "Cuyahoga Community College Western Campus";
        Console.WriteLine("School name is " + schoolName);
      
        // Step 5
        double doubleValue = 9.78;
        int intValue = (int)doubleValue;

        int number = 5;
        bool isStudent = true;

        string intToString = Convert.ToString(number);
        string boolToString = Convert.ToString(isStudent);

        Console.WriteLine("Double value is " + doubleValue);
        Console.WriteLine("Int using Explicit Cast is " + intValue);
        Console.WriteLine("Int to String " + intToString);
        Console.WriteLine("Bool to String " + boolToString);
        
        // Step 6
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + ". You are " + age + " years old.");
       
        // Step 7
        int num1 = 5;
        int num2 = 8;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num2 * 3): " + (num2 * 3));
        Console.WriteLine("Division (num2 / 2): " + (num2 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));
        
        // Step 8
        float floatValue = 1.123456789f;
        double preciseDouble = 1.123456789;

        Console.WriteLine("Float Value: " + floatValue);
        Console.WriteLine("Double Value: " + preciseDouble);
        Console.WriteLine("I noticed that the double stores more decimal precision than the float.");
        
        // Step 9
        int var = 15;

        Console.WriteLine("Initial value is "+ var);

        var+=1;
        Console.WriteLine("After increment the number is " + var);

        var-=1;
        Console.WriteLine("After decrement the number is " + var);
    }
}