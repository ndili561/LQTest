using System;
using Xunit;
using LiquidThinkingTest;


namespace Test
{
    public class UnitTest1
    {
        Program process;
        string[] Inpt;
        public UnitTest1()
        {
            process = new Program();
        }

        [Fact]
        public void Test1()
        {
            Inpt = new string[4];
            Inpt[0] = "The";
            Inpt[1] = "quick";
            Inpt[2] = "brown";
            Inpt[3] = "fox";
            Assert.Equal("The quick brown fox", process.ProcessInput(Inpt));
        }

        [Fact]
        public void Test2()
        {
            Inpt = new string[5];
            Inpt[0] = "-w";
            Inpt[1] = "The";
            Inpt[2] = "quick";
            Inpt[3] = "brown";
            Inpt[4] = "fox";
            Assert.Equal("fox brown quick The", process.ProcessInput(Inpt));
        }
        [Fact]
        public void Test3()
        {
            Inpt = new string[5];
            Inpt[0] = "-l";
            Inpt[1] = "The";
            Inpt[2] = "quick";
            Inpt[3] = "brown";
            Inpt[4] = "fox";
            Assert.Equal("ehT kciuq nworb xof", process.ProcessInput(Inpt));
        }
        [Fact]
        public void Test4()
        {
            Inpt = new string[6];
            Inpt[0] = "-l";
            Inpt[1] = "-w";
            Inpt[2] = "The";
            Inpt[3] = "quick";
            Inpt[4] = "brown";
            Inpt[5] = "fox";
            Assert.Equal("xof nworb kciuq ehT", process.ProcessInput(Inpt));
        }

        [Fact]
        public void Test5()
        {
            Inpt = new string[6];
            Inpt[0] = "-w";
            Inpt[1] = "-v";
            Inpt[2] = "The";
            Inpt[3] = "quick";
            Inpt[4] = "brown";
            Inpt[5] = "fox";
            string result = process.ProcessInput(Inpt);
            Assert.Contains("4", result);

        }

        [Fact]
        public void Test6()
        {
            Inpt = new string[5];
            Inpt[0] = "-v";
            Inpt[1] = "The";
            Inpt[2] = "quick";
            Inpt[3] = "brown";
            Inpt[4] = "fox";
            string result = process.ProcessInput(Inpt);
            Assert.Contains("4", result);

        }

        [Fact]
        public void Test7()
        {
            Inpt = new string[6];
            Inpt[0] = "-l";
            Inpt[1] = "-v";
            Inpt[2] = "The";
            Inpt[3] = "quick";
            Inpt[4] = "brown";
            Inpt[5] = "fox";
            string result = process.ProcessInput(Inpt);
            Assert.Contains("4", result);

        }
        [Fact]
        public void Test8()
        {
            Inpt = new string[7];
            Inpt[0] = "-l";
            Inpt[1] = "-w";
            Inpt[2] = "-v";
            Inpt[3] = "The";
            Inpt[4] = "quick";
            Inpt[5] = "brown";
            Inpt[6] = "fox";
            string result = process.ProcessInput(Inpt);
            Assert.Contains("4", result);

        }

        [Fact]
        public void Test9()
        {
            Inpt = new string[6];
            Inpt[0] = "-l";
            Inpt[1] = "-v";
            Inpt[2] = "The";
            Inpt[3] = "quick";
            Inpt[4] = "brown";
            Inpt[5] = "fox";
            string result = process.ProcessInput(Inpt);
            Assert.Contains("4", result);

        }
     
    }
}
