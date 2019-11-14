using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonScript : MonoBehaviour
{
    public FloatData playerHealth;
    public bool poisoned = false;

    private WaitForSeconds poisonTimer = new WaitForSeconds(1f);
    private float poisonDot = -0.1f;
    public Image healthBar;

    public void PoisonPlayer()
    {
        poisoned = true;
        StartCoroutine(PoisonDamage());
    }

    private IEnumerator PoisonDamage()
    {
        while (poisoned)
        {
            yield return poisonTimer;
            playerHealth.UpdateValue(poisonDot);
            healthBar.GetComponent<UIHealthBarController>().UpdateHealthBar();
            Debug.Log("Poisoned...");
        }
    }
}
