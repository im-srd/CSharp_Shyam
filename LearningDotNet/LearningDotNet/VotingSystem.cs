using System;

namespace LearningDotNet
{
    class VotingSystem
    {
        static int candidate1Count = 0;
        static int candidate2Count = 0;
        static int candidate3Count = 0;
        static string[] vote_casted = new string[5];
        static int index = 0;

        static bool checkName(string name)
        {
            for (int i=0; i<vote_casted.Length; i++)
            {
                if (vote_casted[i] == name)
                {
                    return true;
                }
            }
                return false;
        }
        // -------------------------------------------------------------------------
        static void CastVote(string name)
        {
            Console.WriteLine("Enter your Year of Birth:");
            int birth_year = int.Parse(Console.ReadLine());
            int age = FindAge(birth_year);

            if (age >= 18 && !checkName(name))
            {
                Console.WriteLine("Select your candidate:");
                Console.WriteLine("BJP---Press 1\nINC---Press 2\nAAP---Press 3");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1: candidate1Count++; break;
                    case 2: candidate2Count++; break;
                    case 3: candidate3Count++; break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }

                vote_casted[index] = name;
                index++;
            }
            else
            {
                Console.WriteLine("You are either not eligible to vote or have already voted.");
            }
        }

        static void ShowResult()
        {
            if (candidate1Count > candidate2Count && candidate1Count > candidate3Count)
            {
                Console.WriteLine("BJP:" + candidate1Count);
                Console.WriteLine("INC:" + candidate2Count);
                Console.WriteLine("AAP:" + candidate3Count);
                Console.WriteLine("BJP Wins !!!");
            }
            else if (candidate2Count > candidate1Count && candidate2Count > candidate3Count)
            {
                Console.WriteLine("BJP:" + candidate1Count);
                Console.WriteLine("INC:" + candidate2Count);
                Console.WriteLine("AAP:" + candidate3Count);
                Console.WriteLine("INC Wins !!!");
            }
            else if (candidate3Count > candidate1Count && candidate3Count > candidate2Count)
            {
                Console.WriteLine("BJP:" + candidate1Count);
                Console.WriteLine("INC:" + candidate2Count);
                Console.WriteLine("AAP:" + candidate3Count);
                Console.WriteLine("AAP Wins !!!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        static int FindAge(int year)
        {
            return DateTime.Now.Year - year;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("********* VOTING SYSTEM **********");

            while (true)
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine("WELCOME, " + name);
                Console.WriteLine("1. CAST VOTE\n2. SHOW RESULT");
                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CastVote(name);
                        break;
                    case 2:
                        Console.WriteLine("Voting Ends...\n");
                        ShowResult();
                        return;
                    default:
                        Console.WriteLine("INVALID CHOICE. CHOOSE AGAIN.");
                        break;
                }
            }
        }
    }
}
