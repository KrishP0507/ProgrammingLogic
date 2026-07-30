using System;

// Step 1 - Create a Base Class
class Animal
{
    // Virtual method
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 - Create the Cat Class
class Cat : Animal
{
    // Override the virtual method
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

// Step 2 - Create the Dog Class
class Dog : Animal
{
    // Override the virtual method
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3 - Test Runtime Polymorphism

        // Create objects using Animal as the reference type
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        // Call the animalSound() method
        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}
