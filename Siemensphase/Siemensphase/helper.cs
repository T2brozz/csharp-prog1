using System;

namespace Siemensphase
{
    public class helper
    {
        public static string Seperator => "\n--------------------------------------------------------------\n";
        public static string InputWithPrompt(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }

        public static int InputWithPromptInt(string output)
        {
            bool isnum = false;
            int num=-1;
            while (!isnum)
            {
                Console.WriteLine(output);
                string input = Console.ReadLine();
                isnum = int.TryParse(input, out num);
            }

            return num;
        }
    }
}