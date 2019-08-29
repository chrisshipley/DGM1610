using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = -1; i < 10; ++i) // Loop from -1 to 9
        {
            int fact = 0; // Factorial value

            if (i % 2 == 1) // If the "i" value is odd
            {
                fact = RecursiveFactorial(i); // Solve recursively
            }
            else // If the "i" value is even
            {
                fact = IterativeFactorial(i); // Solve iteratively
            }

            Debug.Log("Factorial of the value \"" + i + "\" is: " + fact); // Print the factorial report to the debug console
        }
    }

    /// <summary>
    /// Recursive function to find the factorial value of x
    /// </summary>
    /// <param name="x">Number to find the factorial of</param>
    /// <returns>Returns 1 if value is 0. Returns 0 if the value is negative. Otherwise returns the value multiplied by the previous factorial.</returns>
    private int RecursiveFactorial(int x)
    {
        if (x == 0) // If the number is 0, return 1 and stop the recursive chain
        {
            return 1;
        }
        else if (x < 0) // If the number is negative, return 0 and stop the recursive chain
        {
            return 0;
        }
        else // Multiply the current value by the factorial of the number one less than the current
        {
            return x * RecursiveFactorial(x - 1);
        }
    }

    /// <summary>
    /// Iterative function to find the factorial value of x
    /// </summary>
    /// <param name="x">Number to find the factorial of</param>
    /// <returns>Returns 0 if negative. Otherwise returns the factorial value of "x"</returns>
    private int IterativeFactorial(int x)
    {
        if (x < 0) // If the value is negative
        {
            return 0; 
        }

        int fact = 1; // Place holder value for the factorial
        
        while (x > 0) // Loop until the value is 0
        {
            fact *= x--; // Multiply the factorial value by the current value of x and then decrement x
        }

        return fact; // Return the factorial value
    }

    // Update is called once per frame
    void Update()
    {
        // Toxic for performance
    }
}
