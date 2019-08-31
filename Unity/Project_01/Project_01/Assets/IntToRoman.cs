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
            int x = (int)Random.Range(0, 3999);
            Debug.Log("The roman numeral version of \"" + x + "\" is: \"" + ToRoman(x) + "\"");
        }
	}

    private string ToRoman(int x)
    {
        string roman = "";

        while (x > 0)
        {
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
        }

        return roman;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
