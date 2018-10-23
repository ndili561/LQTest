using System;
using System.Linq;
using System.Diagnostics;

namespace LiquidThinkingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.StartProgram(args);
        }

        public static string result;
        public static Stopwatch MyWatchTime;

        public static void StartProgram(string[] args)
        {
            Program program = new Program();
            program.ProcessInput(args);
            Program.WriteToConsole(result);

                           
        }
        public static void WriteToConsole(string res)
        {
            Console.WriteLine(res);
            Console.ReadKey();
        }

        public static void Startime()
        {
           MyWatchTime = Stopwatch.StartNew();
        }

        public static int StopTime()
        {
            MyWatchTime.Stop();
            return (int) MyWatchTime.ElapsedTicks;
        }
               
        public string ProcessInput(string[] args)
        {
            
            if (args[0].Substring(0,2).Equals("-v") | !args[0].Substring(0, 1).Equals("-"))
            {
               return result = StringProcess.Simple(args);
               
            }
            switch (args[0])
            {
                case "-w":
                    return result = StringProcess.ProcessW(args);                                                         
                case "-l":
                    return result = StringProcess.ProcessL(args);
                   default:
                    result = "usage: Reverser.exe input [-l] [-w] [-v] \n" +
                    "Reverses the string inputs \n" +
                    "-l Reverse the letters in the string \n" +
                    "-w Reverse the words in the string \n" +
                    "-v verbose";
                    return result;
            }
        }

    }

}

      
       

