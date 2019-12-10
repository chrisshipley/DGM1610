using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    private WaitForSeconds updateRate = new WaitForSeconds(0.2f);
    private bool gameActive = true;
    public IntData score;
    public FloatData health;
    public Image victoryScreen;
    public Image defeatScreen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckStatus());
    }

    private IEnumerator CheckStatus()
    {
        while (gameActive)
        {
            yield return updateRate;

            if (score.value >= 30)
            {
                gameActive = false;
                victoryScreen.gameObject.SetActive(true);
            }
            else if (health.value <= 0)
            {
                gameActive = false;
                defeatScreen.gameObject.SetActive(true);
            }
        }
    }

}
