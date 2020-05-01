using System;
using System.Collections.Generic;
using System.Text;

namespace bowling.domain
{
    public class Frame
    {
        public int Score { get; set; }

        public void Add(int pins)
        {
            Score += pins;
        }
    }
}
