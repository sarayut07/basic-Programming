using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace basic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Grads Calculator Program ===");
                Console.WriteLine("Enter score (0-100)");
                Console.WriteLine("Type X toexit");
                Console.Write("Score:");
                
                string input= Console.ReadLine();

                //ออกจากโปรแกรม
                if(input.ToUpper() == "X")
                {
                    Console.WriteLine("Programterminated");
                    break;
                }

                try
                {
                    int score = int.Parse(input);

                    if (score < 0 || score > 100) 
                    {
                      Console.WriteLine("Invalid score. Please enter a value between 0 and 100");
                    }

                    else
                    {
                        string grade;

                        if (score >= 80) grade = "A";
                        else if (score >= 75) grade = "B+";
                        else if (score >= 70) grade = "B";
                        else if (score >= 65) grade = "C+";
                        else if (score >= 60) grade = "C";
                        else if (score >= 55) grade = "D+";
                        else if (score >= 50) grade = "D";
                        else grade = "F";

                 Console.WriteLine($"Yourscore: {score}");
                 Console.WriteLine($"Yourgrade is: {grade}");
                    }

                }
                catch
                {
                    Console.WriteLine("Invalidinput. Please enter a numeric value.");
                }

                Console.WriteLine("\nPress Enter to restart ...");
                Console.ReadLine();
            }
        }
    }
}
