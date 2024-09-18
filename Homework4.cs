namespace HomeWork4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input both integers");
        int x = Convert.ToInt16(Console.ReadLine());
        int y = Convert.ToInt16(Console.ReadLine());
        number(x,y);
    }
    static int number(int x,int y){
        if(x>y){
            Console.WriteLine($"The Largest Number is {x}");
            return x;
        }
        else{
            Console.WriteLine($"The largest number is {y}");
            return y;
        }
    
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please input your integer");
        int rows = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the shape");
        string y = Console.ReadLine();
        if(y=="right" || y=="Right"){
        Right(rows,y);
        }
        if(y=="left" || y=="Left"){
        Left(rows,y);
        }
    }
    static void Right(int rows, string y){
            Console.WriteLine($"N = {rows}, Shape = Right");
 
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
 
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
 
                Console.WriteLine();
            }
    }
            static void Left(int rows, string y){
            Console.WriteLine($"N = {rows}, Shape = Left");
 
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
