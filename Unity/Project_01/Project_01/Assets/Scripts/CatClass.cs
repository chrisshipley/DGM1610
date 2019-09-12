using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public GameObject light;
    public GameObject dog;
    public ParticleController particles;

    private void OnMouseDown()
    {
        light.SetActive(false);
        dog.SetActive(true);
        particles.SpewParticles(100);
    }
}
