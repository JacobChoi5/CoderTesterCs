using System;
using System.Globalization;
using System.IO;
namespace CoderTesterCs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var rand = new Random();
                int ranDumb;
                string[] lines = File.ReadAllLines("C:\\Users\\jaked\\Documents\\SD_ClassList.txt");
                string[] names = new string[lines.Length];
                string[] names2 = new string[lines.Length];
                bool[] checker = new bool[lines.Length];
                bool[] checker2 = new bool[lines.Length];
                bool flag;
                for (int i = 0; i<lines.Length; i++)
                {
                    while (true) {
                        flag = false;
                        ranDumb = rand.Next(lines.Length);
                        for(int j = 0; j < lines.Length; j++)
                        {
                            if (lines[ranDumb].Equals(names[j]))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (checker[i]||flag)
                        {
                            continue;
                        }
                        else
                        {
                            names[i] = lines[ranDumb];
                            checker[i] = true;
                            break;
                        }
                    }
                }
                Array.Sort(names);
                for (int i = 0; i < lines.Length; i++)
                {
                    while (true)
                    {
                        flag = false;
                        ranDumb = rand.Next(lines.Length);
                        for (int j = 0; j < lines.Length; j++)
                        {
                            if (lines[ranDumb].Equals(names2[j]))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (checker2[i] || flag || lines[ranDumb].Equals(names[i]))
                        {
                            continue;
                        }
                        else
                        {
                            names2[i] = lines[ranDumb];
                            checker2[i] = true;
                            break;
                        }
                    }
                }
                var sb = new System.Text.StringBuilder();
                Console.WriteLine(String.Format("{0,-20}{1,-20}", "Coder", "Tester"));
                Console.WriteLine("---------------------------------------");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(String.Format("{0,-20}{1,-20}", names[i], names2[i]));
                }
                //Rearranging for Tester than Coder
                string[] sortedNames = new string[names.Length];
                string[] sortedNames2 = new string[names.Length];
                for (int i = 0; i < names.Length; i++)
                {
                    sortedNames[i] = names[i];
                    sortedNames2[i] = names2[i];
                }
                Array.Sort(sortedNames2);
                for(int i = 0; i < names.Length; i++)
                {
                    for (int j = 0; j < names.Length; j++)
                    {
                        if (sortedNames2[i].Equals(names2[j]))
                        {
                            sortedNames[i] = names[j];
                        }
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine(String.Format("{0,-20}{1,-20}", "Tester", "Coder"));
                Console.WriteLine("---------------------------------------");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(String.Format("{0,-20}{1,-20}", sortedNames2[i], sortedNames[i]));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}