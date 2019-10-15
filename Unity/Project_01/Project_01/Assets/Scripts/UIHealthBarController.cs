using UnityEngine;
using UnityEngine.UI;



public class UIHealthBarController : MonoBehaviour
{
    public Image healthBar;
    public FloatData healthValue;
    private float healthBarWidth;
    private float healthBarHeight;
    private float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthBarWidth = healthBar.rectTransform.sizeDelta.x;
        healthBarHeight = healthBar.rectTransform.sizeDelta.y;
        maxHealth = healthValue.value;
    }

    public void UpdateHealthBar()
    {
        float healthPercentage = healthValue.value / maxHealth;
        if (healthPercentage > 1.0f)
        {
            healthPercentage = 1.0f;
        }
        float newHealthBarWidth = healthBarWidth * healthPercentage;

        // age.rectTransform.sizeDelta = new Vector2(width, height);
        healthBar.rectTransform.sizeDelta = new Vector2(newHealthBarWidth, healthBarHeight);

    }
}
