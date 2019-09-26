using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactorialFilter
{
    void Factorial(int[] t_input)
    {
        int[] output = new int [t_input.Length];
        int temp = 0;
        int fact = 0;
        for (int i = 0; i < t_input.Length; i++)
        {
            temp = t_input[i];
            while (temp != 0)
            {
                fact = temp * (temp - 1);
                temp -= 1;
            }
            output[i] = fact;
        }
    }
}
