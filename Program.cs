using System;

int numberToGuess = new Random().Next(1, 101);
int UserGuess = 0, tries = 0;
    
    while (UserGuess != numberToGuess)
    {
        tries++;
        Console.WriteLine("Enter the guess:");
        bool result = int.TryParse(Console.ReadLine(), out UserGuess);
    if (result && (UserGuess>=1 && UserGuess<=100))
    {
        if (UserGuess < numberToGuess) Console.WriteLine($"{UserGuess} is Lower");
        else if (UserGuess > numberToGuess) Console.WriteLine($"{UserGuess} is higher");
        else Console.WriteLine($"{UserGuess} is a correct guess after {tries} tries");
    }
    else Console.WriteLine("Invalid input. Please provide a number between 1 and 100");
    }    
