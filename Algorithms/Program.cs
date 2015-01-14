using HackerRank.Algorithms.Combinatorics;
using HackerRank.Algorithms.GraphTheory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class Program
    {
        static void Main(String[] args)
        {
            //Insertion Sort
            //int _ar_size;
            //_ar_size = 9;
            //int[] _ar = new int[_ar_size];
            //String elements = "9 8 6 7 3 5 4 1 2";
            //String[] split_elements = elements.Split(' ');
            //for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            //{
            //    _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            //}
            //insertionSort(_ar);

            //Are Anagram
            //    Console.WriteLine(AreAnagram("walid", "dilaw"));
            //    Console.WriteLine(AreAnagram("SHady Soltan", "ntlaoS yHSad"));
            //    Console.WriteLine(AreAnagram("SH", "ntla"));
            //    Console.ReadKey();

            //KnapSack
            //KnapSack knapSack = new KnapSack();

            //Even Tree
            //EvenTreeTests evenTreeTests = new EvenTreeTests();
            //evenTreeTests.Test1();
            //evenTreeTests.Test2();
            //evenTreeTests.Test3();
            //evenTreeTests.Test4();

            //ConnectingTownsTests connectingTownsTests = new ConnectingTownsTests();
            ////connectingTownsTests.Test1();
            //connectingTownsTests.Test2();

            //AJourneyToTheMoonTests journeyToTheMoonTests = new AJourneyToTheMoonTests();
            //journeyToTheMoonTests.Test1();
            //journeyToTheMoonTests.Test3();
            //journeyToTheMoonTests.Test2();
            //journeyToTheMoonTests.Test4();
            //journeyToTheMoonTests.Test5();
        }

        public static bool AreAnagram(string str1, string str2)
        {
            char[] orderedStr1 = str1.ToCharArray().OrderBy(s => s).ToArray();
            char[] orderedStr2 = str2.ToCharArray().OrderBy(s => s).ToArray();
            str1 = new String(orderedStr1);
            str2 = new String(orderedStr2);
            return string.Equals(str1, str2);
        }
    }

    public interface IOutputWriter
    {
        void WriteLine(string s);
    }

    public interface IInputReader
    {
        String ReadLine();
    }

    // Use this console writer for your live code
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
    public class TestInputReader : IInputReader
    {
        private List<string> _buffer;
        public TestInputReader(string[] buffer)
        {
            _buffer = new List<string>();
            _buffer = buffer.ToList();
        }

        public string ReadLine()
        {
            string input = _buffer[0];
            _buffer.RemoveAt(0);
            return input;
        }
    }

    public class TestOutputWriter : IOutputWriter
    {
        public List<string> _buffer { get; set; }

        public TestOutputWriter()
        {
            _buffer = new List<string>();
        }
        public void WriteLine(string s)
        {
            _buffer.Add(s);
        }
    }
}
