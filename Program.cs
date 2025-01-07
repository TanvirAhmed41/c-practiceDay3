using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
class Test{

    public static void Main(string[] args){

        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int fact = 1;
        for (int i = 1; i <= num ; i++){
            fact = fact * i;
        }
        Console.WriteLine($"Factorial of({num})= {fact}");


    }





}