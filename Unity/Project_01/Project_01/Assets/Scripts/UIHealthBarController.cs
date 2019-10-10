using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
[RequireComponent(typeof(FloatData))]

public class UIHealthBarController : MonoBehaviour
{
    public Image healthBar;
    public FloatData healthValue;
    private float healthBarWidth;
    private float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthBarWidth = healthBar.flexibleWidth;
        maxHealth = healthValue.value;
    }

    void UpdateHealthBar()
    {
        
    }
}
