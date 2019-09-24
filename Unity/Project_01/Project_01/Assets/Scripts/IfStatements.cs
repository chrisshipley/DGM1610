using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a;
    public int b;
    public int c;

    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(0, 10);
        b = Random.Range(0, 10);
        string result;

        Debug.Log("a: " + a + ", b: " + b);

        if (a > b)
        {
            result = "greater than";
        }
        else if (a < b)
        {
            result = "less than";
        }
        else
        {
            result = "equivalent to";
        }

        Debug.Log("a is " + result + " b");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
