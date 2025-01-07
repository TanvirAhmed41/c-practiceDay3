using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
class Test{

    public static void Main(string[] args){

      Console.Write ("Enter your number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      for (int i = 1; i <=10 ; i++){
        Console.WriteLine($"{number} X {i} = {number*i}");
      }

    }





}