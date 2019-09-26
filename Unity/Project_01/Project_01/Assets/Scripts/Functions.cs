using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Functions : MonoBehaviour
{
    public int myNumber;
    public string playerName;
    public float speed = 5;
    public GameObject player;
    public Color playerColor = Color.blue;

    // Start is called before the first frame update
    void Start()
    {
        ConfigureGameObject();
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(2);
    }

    private int AddNumbers(int a, int b)
    {
        Debug.Log("a + b is: " + a + b);
        return a + b;
    }

    private string WelcomePlayer()
    {
        return "Hello " + playerName + ". Welcome to the Game. . .";
    }

    private float IncreaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }

    private void ConfigureGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        newPlayer.SetActive(true);
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
    }

}
