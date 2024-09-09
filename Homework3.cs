﻿namespace HomeWork3;

class Program
{
    static void Main(string[] args)
    {
        //Q1
        Console.WriteLine("Please Input an integer");
        int n = Convert.ToInt16(Console.ReadLine());

        for(int i = 2; i <= n-1; i++){
            if(n%i == 0){
                Console.WriteLine("N is non-prime");
                break;
            }
            else{
                Console.WriteLine("N is prime");
                break;
            }
            
        }
        if(n==2){
                Console.WriteLine("N is prime");
            } 
        //Q2
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<=n-1; row++){
            
        
        for(int col = 0; col<=n-1; col++){
        Console.Write("#");
        }
        Console.WriteLine("");
        }  
        //Q3
        Console.WriteLine("Assign an int value to N:");
        int n = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<n; row++){
            for(int col = 0; col<n; col++)
                {
        if(row>=col)
            Console.Write('*');
                }
            Console.WriteLine("");
                                      } 
            
        

}
}