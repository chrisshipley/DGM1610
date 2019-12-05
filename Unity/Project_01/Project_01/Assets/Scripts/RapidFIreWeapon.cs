using System.Collections;
using UnityEngine;

public class RapidFIreWeapon : MonoBehaviour
{
    public float holdTime = 0.3f;
    public WaitForSeconds waitTimer;
    private bool canRun = true;

    private void Awake()
    {
        waitTimer = new WaitForSeconds(holdTime);    
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            yield return waitTimer;
            Debug.Log("BANG!");
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
