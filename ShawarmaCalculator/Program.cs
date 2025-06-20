/*
 * <summary>
 * 
 * The purpose of this program is for the user to select a shawarma that they want to eat,
 * and have the program calculate their order
 * 
 * Author: William Cendana
 * Date: June 20, 2025
 * 
 * Input: User would enter values that align with their order. If user misinputs any value, program would continue running and create a loop
 * Output: Program will calculate the total cost of the donair and would prompt the user to try again if chosen
 * 
 * <summary>
 */


namespace ShawarmaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Welcome to Dilly's Donair, home of the good donair," +
                "can I take your order? ");

            Console.WriteLine();
            Console.Write("Please choose and write donair size: Regular, Large, Super: ");
            string input = Console.ReadLine().ToLower();

            const double GST = 0.05,
                         DISCOUNT = 0.10;

            double donairPrice,
                   donairSubPrice,
                   rawValue,
                   quantity,
                   addOn,
                   discountedPrice,
                   normalTotal,
                   sum;

            // this is where the user inputs their size of shawarma
            switch (input)
            {
                case "regular":

                    donairPrice = 6.50;
                    break;
                case "large":

                    donairPrice = 8.00;
                    break;
                case "super":

                    donairPrice = 9.50;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please restart the program and choose a valid option.");
                    return;
            }

            // adding add-ons for the order
            Console.Write("Would you like to add cheese or meat? Please type cheese / meat / none: ");
            string secondInput = Console.ReadLine().ToLower();
            switch (secondInput)
            {
                case "cheese":
                    addOn = 1.25;
                    break;
                case "meat":
                    addOn = 2.00;
                    break;
                case "none":
                    addOn = 0;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please restart the program and choose a valid option.");
                    return;
            }

            Console.Write("How many do you want to order?: ");
            quantity = int.Parse(Console.ReadLine());

            rawValue = donairPrice + addOn;
            donairSubPrice = rawValue * quantity;

            // calculating the final result 

            normalTotal = donairSubPrice * GST;
            sum = normalTotal + donairSubPrice;

            Console.WriteLine($"Your total is {sum}");



        }
    }
}
