using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRobot
{
    public class Task
    {
        //Total no of chips installed
        public  int nochips = 2;
        // Sort Array based on order they give
        //if order  = asc then array should return ascending order
        //if order = desc then array should return descending order
        public int[] sortArray(int[] input, string order)
        {
            if (order == "asc")
            {
                for (int i = input.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (input[j] > input[j + 1])
                        {
                            int highValue = input[j];

                            input[j] = input[j + 1];
                            input[j + 1] = highValue;
                        }
                    }
                }
                return input;

            }
            else
            {
                for (int i = input.Length - 1; i > 0; i--)
                {
                    for (int j = 0; j <= i - 1; j++)
                    {
                        if (input[j] < input[j + 1])
                        {
                            int highValue = input[j];

                            input[j] = input[j + 1];
                            input[j + 1] = highValue;
                        }
                    }
                }
                return input;
            }
        }
        //Return Sum of array
        public int SumOfArray(int[] input)
        {
            int sum = 0;
            for (int j = 0; j <= input.Length - 1; j++)
            {
                sum = sum + input[j];
            }
            return sum;
        }
        // it should not return anything.
        public void donotreturnanything()
        { }
    }
}
