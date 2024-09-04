﻿using System;
using System.IO.Compression;

public class Program
{
    static void Main(string[]args)
    {
        
        //Q1
        Console.WriteLine("Please Input a Letter Grade");
       string b = Console.ReadLine();
       if(b=="A"){
        Console.WriteLine("GPA Point: 4");
       }
       else if(b=="B"){
        Console.WriteLine("GPA Point: 3");
       }
       else if(b=="C"){
        Console.WriteLine("GPA Point: 2");
       }
       else if(b=="D"){
        Console.WriteLine("GPA Point: 1");
       }
       else if(b=="F"){
        Console.WriteLine("GPA Point: 0");
       }
       else{
        Console.WriteLine($"Wrong Letter Grade!");
       } 
        //Q2
       Console.WriteLine("Please input the first number");
    int x =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second number");
    int y =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third number");
    int z =Convert.ToInt16(Console.ReadLine());
    if(x<y && x<z){
        Console.WriteLine($"The smallest number value is: {x}");
    }
    else if(y<x && y<z){
        Console.WriteLine($"The smallest number value is: {y}");
    }
    else if(z<x && z<y){
        Console.WriteLine($"The smallest number value is: {z}");
        
        //BonusQ
        Console.WriteLine("Please input a year");
        int year = Convert.ToInt16(Console.ReadLine());
        if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
            Console.WriteLine("This is a leap year!");
        }
        else{
            Console.WriteLine("This is not a leap year!");
        }
    }
    }
}
