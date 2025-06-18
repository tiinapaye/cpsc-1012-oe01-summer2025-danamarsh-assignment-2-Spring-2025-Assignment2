/*
 * <summary>
 * 
 * The purpose of this program is for the user to select a shawarma that they want to eat,
 * and have the program calculate their order
 * 
 * Author: William Cendana
 * Date: June 17, 2025
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
                " can I take your order?");

            // variables
            // string(?) = donairSize,extras, addOnItem
            // int = quantity
            // double = addOnsprice, discountedSubTotal, subTotal, totalCost 
            // "that one variable that stays the same" = gst, discount

            // pseudocode portion:
            // User inputs preferred donair size
            // -> then prompts addOnItem cheese or meat in seperate lines
            // -> then prompts quantity - value should be calculated here then assign to a variable
            // --> each option should have an associated price; when clicked program will add the price to
            // formula
            // |--> incorrect input forces back to last prompt (dunno how to do that for now)
            // Then, program should calculate base donair cost, add-ons, then subtotal
            // If subtotal is > 40 CAD program adds discount, then calculate subtotal with discount
            // Apply GST then calculate the total cost
            // Display result 
            // Ask if they want to order again
            
          
        }
    }
}
