using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntToRoman : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {

        for (int i = 0; i < 10; ++i)
        {
            int x = (int)Random.Range(0, 3999); // Grab a random float between the ranges of "0" andf "3999". Cast to int value
            Debug.Log("The roman numeral version of \"" + x + "\" is: \"" + ToRoman(x) + "\""); // Print the conversion report to the debug console
        }
	}

    /// <summary>
    /// Generates a string value to denote the roman numeral version of a given number
    /// </summary>
    /// <param name="x">The int value to be denoted</param>
    /// <returns>The roman numeral string</returns>
    private string ToRoman(int x)
    {
        string roman = ""; // Start string

        while (x > 0) // Loop until the value has reached 0
        {
            /* Each iteration through the loop will check for the largest token that can be subtracted from the current
             * number. When the largest token is found, the token will be added to the end of the string and its value
             * will be subtracted from the number. */
            if (x - 1000 >= 0)
            {
                roman += "M";
                x -= 1000;
            }
            else if (x - 500 >= 0)
            {
                roman += "D";
                x -= 500;
            }
            else if (x - 400 >= 0)
            {
                roman += "CD";
                x -= 400;
            }
            else if (x - 100 >= 0)
            {
                roman += "C";
                x -= 100;
            }
            else if (x - 90 >= 0)
            {
                roman += "XC";
                x -= 90;
            }
            else if (x - 50 >= 0)
            {
                roman += "L";
                x -= 50;
            }
            else if (x - 40 >= 0)
            {
                roman += "XL";
                x -= 40;
            }
            else if (x - 10 >= 0)
            {
                roman += "X";
                x -= 10;
            }
            else if (x - 9 >= 0)
            {
                roman += "IX";
                x -= 9;
            }
            else if (x - 5 >= 0)
            {
                roman += "V";
                x -= 5;
            }
            else if (x - 4 >= 0)
            {
                roman += "IV";
                x -= 4;
            }
            else if (x - 1 >= 0)
            {
                roman += "I";
                x -= 1;
            }
        } // Loop until the value has reached 0

        return roman;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
