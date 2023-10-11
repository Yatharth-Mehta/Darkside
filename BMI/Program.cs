using System;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float choice = 1;
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Do you want to calculate your BMI ?\n");
            Console.WriteLine("Press (1) for Yes\n");
            Console.WriteLine("Press (2) for Exit\n");
            string ch = Console.ReadLine();
            choice = Single.Parse(ch);



            for(; choice < 2;)
            {

                Console.WriteLine("\n\nEnter Your Weight : ");
                string weight = Console.ReadLine();
                float f = Single.Parse(weight);

                Console.WriteLine("Enter Your Height : ");
                string height = Console.ReadLine();
                float x = Single.Parse(height);

                float BMI = f / (x * x);

                Console.WriteLine("Enter Your Gender 'M' or 'F' : ");
                string gender = Console.ReadLine();

                Console.WriteLine("\n\nThe BMI is " + BMI);
                Console.WriteLine("\n");

                if (gender == "M")
                {
                    if (BMI < 18.5)
                    {
                        Console.WriteLine("Severely Underweight");
                    }
                    else if (BMI > 18.5 && BMI < 20.7)
                    {
                        Console.WriteLine("Underweight");
                    }
                    else if (BMI > 20.7 && BMI < 26.4)
                    {
                        Console.WriteLine("Normal Range");
                    }
                    else if (BMI > 26.4 && BMI < 27.8)
                    {
                        Console.WriteLine("Marginally Overweight");
                    }
                    else if (BMI > 27.8 && BMI < 31.1)
                    {
                        Console.WriteLine("Overweight");
                    }
                    else if (BMI > 31.1 && BMI < 35)
                    {
                        Console.WriteLine("Obese");
                    }
                    else if (BMI > 35 && BMI < 40)
                    {
                        Console.WriteLine("Severely Obese");
                    }
                    else if (BMI > 40 && BMI < 50)
                    {
                        Console.WriteLine("Morbidly Obese");
                    }
                    else if (BMI > 40 && BMI < 50)
                    {
                        Console.WriteLine("Super Obese");
                    }
                }
                else if (gender == "F")
                {
                    if (BMI < 17.5)
                    {
                        Console.WriteLine("Severely Underweight");
                    }
                    else if (BMI > 17.5 && BMI < 19.1)
                    {
                        Console.WriteLine("Underweight");
                    }
                    else if (BMI > 19.1 && BMI < 25.8)
                    {
                        Console.WriteLine("Normal Range");
                    }
                    else if (BMI > 25.8 && BMI < 27.3)
                    {
                        Console.WriteLine("Marginally Overweight");
                    }
                    else if (BMI > 27.3 && BMI < 32.3)
                    {
                        Console.WriteLine("Overweight");
                    }
                    else if (BMI > 32.3 && BMI < 35)
                    {
                        Console.WriteLine("Obese");
                    }
                    else if (BMI > 35 && BMI < 40)
                    {
                        Console.WriteLine("Severely Obese");
                    }
                    else if (BMI > 40 && BMI < 50)
                    {
                        Console.WriteLine("Morbidly Obese");
                    }
                    else if (BMI > 40 && BMI < 50)
                    {
                        Console.WriteLine("Super Obese");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Proper Gender !");
                    Console.ReadLine();
                }
                Console.WriteLine("\n\n");
                Console.WriteLine("-------------------------------------------\n");
                Console.WriteLine("Do you want to calculate your BMI ?\n");
                Console.WriteLine("Press (1) for Yes\n");
                Console.WriteLine("Press (2) for Exit\n");
                string ch1 = Console.ReadLine();
                choice = Single.Parse(ch1);
            } 

        }
    }
}