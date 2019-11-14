using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineClass : MonoBehaviour
{
    private WaitForSeconds startTimer = new WaitForSeconds(1f);
    public bool canRun = false;
    public bool canRun2 = true;
    private int count = 0;

    IEnumerator OnMouseDown()
    {
        canRun = !canRun;
        while (canRun)
        {
            yield return startTimer;
            Debug.Log("Run: " + count++);
        }
    }


    public void Run()
    {
        StartCoroutine(OnRun());
    }


    IEnumerator OnRun()
    {
        while(canRun2)
        {
            yield return startTimer;
            Debug.Log("Run");
        }
    }


}
