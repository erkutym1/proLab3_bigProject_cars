using System;
using System.ComponentModel.Design;
using System.Collections.Generic;

namespace CarShoppie
{
    public class Cars
    {
        public string BrandModelName { get; set; }
        public string[] PackageName = new string[2];
        public string[] ToolName = new string[10];
        public int[] ToolWeHaveNumber = new int[10];

        public void carShow(Cars theCar)
        {
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine(theCar.BrandModelName);
                Console.WriteLine(theCar.PackageName[i]);

                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(theCar.ToolName[i]);
                    Console.WriteLine(theCar.ToolWeHaveNumber[i]);
                }
            }
        }

        public void carDataCreate(Cars theCar)
        {
            string[] carBrandModelFolder = theCar.BrandModelName.Split(" ");
            string carBrandModelFolderName = "";
            for (int filenameWord = 0; filenameWord < carBrandModelFolder.Length; filenameWord++)
            {
                carBrandModelFolderName += carBrandModelFolder[filenameWord];
                if (filenameWord != carBrandModelFolder.Length-1)
                    carBrandModelFolderName += "_";
            }

            carBrandModelFolderName = carBrandModelFolderName.ToLower();

            string NewBrand = carBrandModelFolderName;
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

                    Console.WriteLine("YENİ ARABA MARKASI MODELİ GİR : ");
                    Cars newCar = new Cars();
                    newCar.BrandModelName = Console.ReadLine();


                    newCar.carDataCreate(newCar);
                    
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