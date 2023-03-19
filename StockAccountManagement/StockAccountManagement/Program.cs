namespace StockAccountManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come To Stock Account Management");

            while (true)
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine("1:Add Stock- Please Enter 1 For Add Stock \n\n" + "2:Display -Please Enter 2 For Display Stock Report");
                //.WriteLine("********************************************************");
               
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        StockPortfolio.AddStock(); //call the AddStock method to add the stock info
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        StockPortfolio.Display(); //call the display method to display stock report
                        Console.WriteLine("\n");
                        break;
                    

                    default:
                        Console.WriteLine("Incorrect Option");
                        break;
                }
            }
        }
    }
}