using System;
using System.Collections.Generic;
using System.Text;

namespace GitBrachingExample
{
    class Super
    {
        public string SuperCool { get; set; }

        public Super()
        {

        }

        public Super(string superCool)
        {
            SuperCool = superCool;
        }

        public void PrintInfo()
        {
            Console.WriteLine("This is a SUPER class");
        }
    }
}
