class Customer
{
    public string customerName { get; set; }
    public int customerAge { get; set; }
    public string customerCity { get; set; }
    public double customerCredit { get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);
    }

    public static void TotalCredits(Customer[] customerList)
    {
        double totalCredit = 0;
        foreach (Customer customer in customerList)
        {
            totalCredit += customer.customerCredit;
        }
        Console.WriteLine("Total credit of all customers: " + totalCredit);
    }

    public static void AmarilloAverageAge(Customer[] customerList)
    {
        int count = 0;
        int totalAge = 0;
        foreach (Customer customer in customerList)
        {
            if (customer.customerCity == "Amarillo")
            {
                count++;
                totalAge += customer.customerAge;
            }
        }
        double averageAge = (double)totalAge / count;
        Console.WriteLine("Average age of customers in Amarillo: " + averageAge);
    }

    public static void CanyonAge(Customer[] customerList)
    {
        Console.WriteLine("Customers in Canyon older than 30:");
        foreach (Customer customer in customerList)
        {
            if (customer.customerCity == "Canyon" && customer.customerAge > 30)
            {
                Console.WriteLine(customer.customerName);
            }
        }
    }
}
