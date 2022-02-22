using System;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            FirstNumber = FirstNumber + SecondNumber;
            return FirstNumber;
        }

        public int Divide()
        {
            FirstNumber = FirstNumber / SecondNumber;
            return FirstNumber;
        }

        public int Subtract()
        {
            FirstNumber = FirstNumber - SecondNumber;
            return FirstNumber;
        }

        public int Modulo()
        {
            FirstNumber = FirstNumber % SecondNumber;
            return FirstNumber;
        }

        public int Multiply()
        {
            FirstNumber *= SecondNumber;
            return FirstNumber;
        }
    }
}