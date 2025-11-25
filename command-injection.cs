using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // BAD: direct use of untrusted input in a system command
        string userInput = args[0];
        Process.Start("cmd.exe", "/c " + userInput);
    }
}
