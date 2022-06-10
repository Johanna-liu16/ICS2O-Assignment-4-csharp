// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        var large = Console.ReadLine();
        var extraLarge = Console.ReadLine();
        var topping1 = Console.ReadLine();
        var topping2 = Console.ReadLine();
        var topping3 = Console.ReadLine();
        var topping4 = Console.ReadLine();
        var top = 0;
        double price = 0;
        double tax;
        double total;
        var size = Console.ReadLine();
        var topping = Console.ReadLine();
            
        //Input 
        Console.WriteLine("This program calculates the cost of a pizza.");
        Console.WriteLine("");
        Console.Write("Would you like large or extra large? ");
        size = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Would you like topping1, topping2, topping3, or topping4?");
        topping = Console.ReadLine();

        //Process
        if (size == large) {
            top = 6;
        } else if (size == extraLarge) {
        }   top = 10;

        if (topping == topping1) {
            price = 1;
        } else if (topping == topping2) {
            price = 1.75;
        } else if (topping == topping3) {
            price = 2.5;
        } else if (topping == topping4) {
            price = 3.35;
        }
        
        tax = (price + top) * 0.13;
        total = tax + (price + top);
            Console.WriteLine("Your total is: $ " + total);

        Console.WriteLine("\nDone.");
    }
}