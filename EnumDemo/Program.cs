namespace EnumDemo
{
    enum Beverage
    {
        coffee,
        tea,
        water,
        soda,
        juice
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Cloud23!");
            Console.WriteLine("This is version 2");
            Console.WriteLine("Welcome to the awesome vending machine::");
            Console.WriteLine("Which bevarage do you prefer? (coffee, tea, water, soda,juice)");
            string userInput= Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.coffee);
                    break;
                case "Tea":
                    Respond(Beverage.tea);
                    break;
                case "water":
                    Respond(Beverage.water);
                    break;
                case "soda":
                    Respond(Beverage.soda);
                    break;
                case "juice":
                    Respond(Beverage.juice);
                    break;
                default: 
                    Console.WriteLine("Invalid choice");
                    break;

            }

        }

        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.coffee:
                    Console.WriteLine("You ordered coffee cappacinoo");
                    break;

                case Beverage.tea:
                    Console.WriteLine("You ordered masala tea");
                    break;

                case Beverage.water:
                    Console.WriteLine("You choose mineral water");
                    break;
                case Beverage.soda:
                    Console.WriteLine("Good choice cola");
                    break;
                case Beverage.juice:
                    Console.WriteLine("Your juice coming to you");
                    break;

            }
        }

    }
}