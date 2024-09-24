using System;
namespace September23
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s1 = "i am a Student"; // Find total number of space present in the string.

			while (true)
			{
				Console.WriteLine(s1+"Which operation you want to perform ?\n1.\tFind length of string and display\r\n2.\tConvert to uppercase\r\n3.\tFind number of spaces in s1\r\n4.\tIndex of every occurence of some character\r\n5.\tReverse s1 and display\r\n6.\tConvert every occurrence of ‘a’ to ‘A’\r\n7.\tConvert s1 to title case\r\n8.\tAverage weight of ‘Ankylosaurus’ in lbs.\r\n");
				int ch = int.Parse(Console.ReadLine());
				switch (ch)
				{
					case 1: lengthOfString(s1); break;
					case 2: Console.WriteLine(s1.ToUpper()); break;
					case 3: countSpaces(s1); break;
					case 4: indexOf('a'); break;
					case 5: reverseofString(s1); break;
					case 6: findANDconvert('a', 'A', s1);
					case 7: convert2TitleCase(s1); break;
					case 8: 
				}
			}
		}

		static void countSpaces(string str)
		{
			int count = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == ' ')
				{
					count++;
				}
			}
			Console.WriteLine("Total Spaces in " + str + ":" + count);
		}
		// ----------------------------------------------------------------------------------
		static void lengthOfString(string str)
		{

		}


	}
}