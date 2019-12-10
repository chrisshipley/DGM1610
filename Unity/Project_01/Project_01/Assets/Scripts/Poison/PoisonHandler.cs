using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonHandler : MonoBehaviour
{
    public FloatData playerHealth;
    public PoisonEffect poison;
    private WaitForSeconds tickRate = new WaitForSeconds(1f);
    public Image healthBar;

    void Start()
    {
        StartCoroutine(PoisonDamage());
    }

    private IEnumerator PoisonDamage()
    {
        while (true)
        {
            yield return tickRate;
            playerHealth.UpdateValue(poison.GetTickDamage());
            healthBar.GetComponent<UIHealthBarController>().UpdateHealthBar();
        }
    }
}
