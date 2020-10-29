using System;
using System.Collections.Generic;
using System.Text;

namespace GitBrachingExample
{
    class Branching
    {
        public string BranchName { get; set; }

        public string Something { get; set; }

        public Branching()
        {

        }

        public Branching(string branchName, string something)
        {
            BranchName = branchName;
            Something = something;
        }
    }
}
