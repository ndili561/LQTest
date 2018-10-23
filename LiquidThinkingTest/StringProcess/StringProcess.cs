using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LiquidThinkingTest
{
     public class StringProcess
    {
        public static string ProcessL(string[] args)
        {
            string result = string.Empty;
            if (args[1] == "-w")
            {
                if (CheckTimeRequested(args))
                {
                    Program.Startime();
                    result = ReverseLettersAndWord(args);
                    return WatchString(args, Program.StopTime());

                }
                result = ReverseLettersAndWord(args);
                return result;
            }
            if (CheckTimeRequested(args))
            {
                Program.Startime();
                result = ReverseWords(args);
                return WatchString(args, Program.StopTime());


            }
            else
            {
                result = ReverseWords(args);
                return result;

            }

        }


        public static string ProcessW(string[] args)
        {
            string result = string.Empty;
            if (CheckTimeRequested(args))
            {
                Program.Startime();
                result = ReverseString(args);
                return WatchString(args, Program.StopTime());


            }
            result = ReverseString(args);
            return result;

        }


        public static string Simple(string[] args)
        {
            string result = string.Empty;
            if (CheckTimeRequested(args))
            {
                Program.Startime();
                result = ReturnString(args);
                return WatchString(args, Program.StopTime());
            }
            result = ReturnString(args);
            return result;
        }
        private  static bool CheckTimeRequested(string[] args)
        {
            if (ContainsVerbose(args))
            {
                return true;
            }
            return false;
        }
        public static string ReverseLettersAndWord(string[] input)
        {
            if (ContainsVerbose(input))
            {
                int index = Array.IndexOf(input, "-v");
                input[index] = string.Empty;

            }
            input[0] = string.Empty;
            input[1] = string.Empty;
            char[] charArray = string.Join(" ", input).ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray).Trim();

        }

        public static string ReverseWords(string[] input)
        {

            input[0] = string.Empty;
            if (ContainsVerbose(input))
            {
                input[1] = string.Empty;

            }
            string[] res = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char[] arr = input[i].ToCharArray();
                Array.Reverse(arr);
                res[i] = new string(arr);
            }
            return string.Join(" ", res).Trim();


        }
        public static string ReturnString(string[] input)
        {
            if (ContainsVerbose(input))
            {
                input[0] = string.Empty;
            }

            return string.Join(" ", input).Trim();
        }

        public static string ReverseString(string[] input)
        {
            input[0] = string.Empty;
            if (ContainsVerbose(input))
            {
                input[1] = string.Empty;

            }

            string temp = string.Join(" ", input);
            return string.Join(" ", temp.Split(" ").Reverse()).Trim();
        }

        public static bool ContainsVerbose(string[] args)
        {
            if (args[0].Equals("-v") | args[1].Equals("-v") | args[2].Equals("-v"))
            {
                return true;
            }
            return false;

        }
        public static string WatchString(string[] args, int sec)
        {
            return "Reversing " + args.Where(c => !string.IsNullOrEmpty(c)).Count() + " words with " + CountLetters(args) + " letters in total. " +
                          "\n" + string.Join(" ", args).Trim()+ " Completed in " + sec;
        }

        public static int CountLetters(string[] input)
        {
            return string.Join(" ", input.Where(c => !string.IsNullOrWhiteSpace(c))).ToCharArray().Length;
        }

    }
}
