using HackerRank.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class ConsoleTester : IDisplayHandler
    {
        private List<string> _inputBuffer;
        public List<string> _outputBuffer { get; set; }
        public ConsoleTester(string[] inputBuffer)
        {
            _inputBuffer = new List<string>();
            _inputBuffer = inputBuffer.ToList();

            _outputBuffer = new List<string>();
        }

        public string ReadLine()
        {
            string input = _inputBuffer[0];
            _inputBuffer.RemoveAt(0);
            return input;
        }

        public void WriteLine(string s)
        {
            _outputBuffer.Add(s);
        }

    }
}
