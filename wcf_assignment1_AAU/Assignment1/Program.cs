using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            

            //Menu Options
            
            var KeyPressed = string.Empty;
            while (KeyPressed != "6")
            {
                Console.WriteLine("1.Prime Number");
                Console.WriteLine("2.Sum of Digits");
                Console.WriteLine("3.Reverse a String");
                Console.WriteLine("4.Print HTML tags");
                Console.WriteLine("5. Sort 5 Numbers");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your Choice:");
            
                KeyPressed = Console.ReadLine();
            
             //Selection
                switch (KeyPressed)
                {
                    case "1":
                        Console.WriteLine("Please enter a Prime Number:");
                        var NumEntered = Console.ReadLine();
                        var res = client.Check_Prime(Int32.Parse(NumEntered));
                        Console.WriteLine(res);
                        break;
                    case "2":
                        Console.WriteLine("Please enter a number");
                        var NumEnter = Console.ReadLine();
                        var sumRes = client.Sum_Digit(Int32.Parse(NumEnter));
                        Console.WriteLine("The sum of the digfit is:"+sumRes);
                        break;
                    case "3":
                        Console.WriteLine("Please enter a string to reverse:");
                        var stringToBeReversed = Console.ReadLine();
                        var stringReversed = client.Reverse_String(stringToBeReversed);
                        Console.WriteLine(stringReversed);
                        break;
                    case "4":
                        Console.WriteLine("Please enter a tag");
                        var tag = Console.ReadLine();
                        Console.WriteLine("Please enter data");
                        var data = Console.ReadLine();
                        var output = client.Print_Tag(tag, data);
                        Console.WriteLine(output);
                        break;
                    case "5":  //TODO: Ask prof if i need to Validate the inputs
                        Console.WriteLine("Please enter Sort Type Ascending or Descending:");
                        var sortType = Console.ReadLine();

                       
                        Console.WriteLine("Please enter a list of 5 number space separated");
                        var inputNumbers = Console.ReadLine();
                      
                        string[] arrayNumbers = inputNumbers.Split(' ');
                        int[] numbers = new int[arrayNumbers.Length];

                        for (int i=0; i<arrayNumbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(arrayNumbers[i]);
                        }

                        
                        
                        var sortedNum = client.sorting(sortType, numbers);
                        foreach (int value in sortedNum)
                        {
                            Console.Write(value + " ");
                        }
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("default");
                        break;
                } 

            }
          
        


        }
    }
}
