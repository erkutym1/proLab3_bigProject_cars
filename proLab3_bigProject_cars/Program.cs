using System;
using System.ComponentModel.Design;

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
                


                Console.WriteLine("Do you have another request?");
                Console.WriteLine("Type 1 to YES, Type 2 to NO : ");
                int continchoice;
                while (!(int.TryParse(Console.ReadLine(), out continchoice) && continchoice == 1 || continchoice == 2))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Please, try again...");
                    Console.WriteLine("Do you have another request?");
                    Console.WriteLine("Type 1 to YES, Type 2 to NO : ");
                }

                if (continchoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Type 1 = Admin Login");
                    Console.WriteLine("Type 2 = Customer Login");
                    Console.WriteLine("Type 3 = Dealer Login");
                    Console.WriteLine("Type 0 = EXIT");
                    Console.WriteLine("Please, select the action you want to take : ");
                    int rechoice;
                    while (!(int.TryParse(Console.ReadLine(), out rechoice) && rechoice >= 0 && rechoice <= 3))
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid selection. Please, try again...");
                        Console.WriteLine("Type 1 = Admin Login");
                        Console.WriteLine("Type 2 = Customer Login");
                        Console.WriteLine("Type 3 = Dealer Login");
                        Console.WriteLine("Type 0 = EXIT");
                        Console.WriteLine("Please, select the action you want to take : ");
                    }
                    if (rechoice == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("See you again...");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        continue;
                    }

                }
                else
                { 
                    Console.Clear();
                    Console.WriteLine("See you again...");
                    break; 
                }


            }




































            /*
                        string NewBrand = "NewBrand";
                        string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                        projectPath += "\\theDatabase\\carsTotalData";
                        string folderPath = Path.Combine(projectPath, NewBrand);

                        if (Directory.Exists(folderPath))
                        {
                            Console.WriteLine($"Klasör var: {folderPath}");
                        }
                        else
                        {
                            Console.WriteLine($"Klasör yok: {folderPath}");
                            Directory.CreateDirectory(folderPath);
                        }

                        if (Directory.Exists(folderPath))
                        {
                            Console.WriteLine($"Klasör var: {folderPath}");
                        }
                        else
                        {
                            Console.WriteLine($"Klasör yok: {folderPath}");
                        }

                        */

        }
    }
}