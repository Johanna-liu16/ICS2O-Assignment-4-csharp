// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        const double tax = 1.13;
        string size;
        double toppingChoice;
        double sizePrice = 0;
        double toppingPrice = 0;
        double totalCost;

        // input
        Console.WriteLine("Welcome to Kenny's Pizzeria!");
        Console.WriteLine("Today we will be calculating your pizza order");
        Console.WriteLine("");
        Console.WriteLine("Please enter the size of pizza you would like (use the abbreviation):");
        Console.WriteLine("");
        Console.WriteLine("Large (L) - $6.00");
        Console.WriteLine("Extra Large (XL) - $10.00");
        size = Console.ReadLine();

        if (size == "L")
        {
            sizePrice = 6.00;
        }
        else if (size == "XL")
        {
            sizePrice = 10.00;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please choose a valid pizza size.");
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Please enter the amount of toppings you would like:");
        Console.WriteLine("");
        Console.WriteLine("One Topping (1) - $1.00");
        Console.WriteLine("Two Toppings (2) - $1.75");
        Console.WriteLine("Three Toppings (3) - $2.50");
        Console.WriteLine("Four Toppings (4) - $3.35");
        toppingChoice = Convert.ToDouble(Console.ReadLine());

        if (toppingChoice == 1)
        {
            toppingPrice = 1.00;
        }
        else if (toppingChoice == 2)
        {
            toppingPrice = 1.75;
        }
        else if (toppingChoice == 3)
        {
            toppingPrice = 2.50;
        }
        else if (toppingChoice == 4)
        {
            toppingPrice = 3.35;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please choose a valid amount of toppings.");
        }

        // process
        Console.WriteLine("");
        totalCost = (sizePrice + toppingPrice) * tax;

        // output
        Console.WriteLine("The cost of a " + size + "arge" + " " + toppingChoice + " topping" + " pizza is $" + totalCost.ToString("0.00") + ".");

        Console.WriteLine("\nDone.");
    }
}