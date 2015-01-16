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
