using System.Threading;
public class MyFirstConsoleApp
{
    public static void Main()
    {
        // Task1:Create a program that swaps two numbers

        //int a = 5;
        //int b = 15;
        //int temp;

        //temp = a;
        //a = b;
        //b = temp;

        //Console.WriteLine("a is:" + a + " b is:" + b);

        // Task2:Just call a method

        //MyFirstConsoleApp obj;
        //obj = new MyFirstConsoleApp();
        //obj.callMethod();

        // Task3:Cath input error by using user input

        while (true)
        {
            Console.Write("Enter a number:");
            string numberAsString = Console.ReadLine();

            try
            {
                int numberAsInt = int.Parse(numberAsString);
                Console.WriteLine("You have entered valid number,program will be closed in 3 seconds...");
                Thread.Sleep(3000);
                Environment.Exit(0);
                return;
            }
            //It is possible to add multiple cath block with different exception types individually
            catch (FormatException ex)
            {
                throw;
                //Console.WriteLine(ex);
                Console.Write("Please enter a number that valid formatted !!");
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            //This block will run anyways doesn't matter what happened
            finally
            {
                // May log here either successed or failed
            }
        }

    }

    public void callMethod()
    {
        Console.WriteLine("Called a method");
        Console.Read();
    }
}
