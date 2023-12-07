using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace CarShoppie
{
    public class Cars
    {
        public class Brands
        {
            public string BrandModelName { get; set; }

            public class ModelPackage
            {
                public string[] PackageName = new string[2];

                public class Tools
                {
                    public string[] ToolName = new string[10];
                    public int ToolWeHaveNumber { get; set; }
                }
            }
        }


        public void list_cars()
        {
            string cumle = "Jaguar F Type";
            string[] kelimeler = cumle.Split(" ");
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.WriteLine(kelimeler[i]);
            }

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1 = Admin Login");
            Console.WriteLine("Type 2 = Customer Login");
            Console.WriteLine("Type 3 = Dealer Login");
            Console.WriteLine("Type 0 = EXIT");
            Console.WriteLine("Please, select the action you want to take : ");
            int choice;
            while (!(int.TryParse(Console.ReadLine(), out choice) && choice>=0 && choice<=3))
            {
                Console.Clear();
                Console.WriteLine("Invalid selection. Please, try again...");
                Console.WriteLine("Type 1 = Admin Login");
                Console.WriteLine("Type 2 = Customer Login");
                Console.WriteLine("Type 3 = Dealer Login");
                Console.WriteLine("Type 0 = EXIT");
                Console.WriteLine("Please, select the action you want to take : ");
            }
            
            while (true)
            {
                if (choice == 0)
                { 
                    Console.Clear(); 
                    Console.WriteLine("See you again...");
                    break;
                }
                else if (choice == 1) 
                {
                    Console.Clear();
                    Console.WriteLine("admin login basliyooooo");
                    Cars cars = new Cars();
                    cars.list_cars();
                    
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("customer login basliyooo");
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("dealer login basliyooo");
                }
                

                else
                { 
                    Console.Clear();
                    Console.WriteLine("See you again...");
                    break; 
                }

                Console.WriteLine("Do you have any request??");
                Console.WriteLine("Type 1 - YES // Type 2 - No : ");
                int continchoice;
                while (!(int.TryParse(Console.ReadLine(), out continchoice) && continchoice >= 1 && continchoice <= 2))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Please, try again...");
                    Console.WriteLine("Do you have any request??");
                    Console.WriteLine("Type 1 - YES // Type 2 - No : ");
                }

                if (continchoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Type 1 = Admin Login");
                    Console.WriteLine("Type 2 = Customer Login");
                    Console.WriteLine("Type 3 = Dealer Login");
                    Console.WriteLine("Type 0 = EXIT");
                    Console.WriteLine("Please, select the action you want to take : ");
                    choice = 0;
                    while (!(int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= 3))
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection. Please, try again...");
                        Console.WriteLine("Type 1 = Admin Login");
                        Console.WriteLine("Type 2 = Customer Login");
                        Console.WriteLine("Type 3 = Dealer Login");
                        Console.WriteLine("Type 0 = EXIT");
                        Console.WriteLine("Please, select the action you want to take : ");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("See you again...");
                    break;
                }
                    



            }
        }
    }
}