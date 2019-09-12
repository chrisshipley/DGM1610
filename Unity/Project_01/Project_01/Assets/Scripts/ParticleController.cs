using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleController : MonoBehaviour
{

    public ParticleSystem particles;

    public void SpewParticles(int x)
    {
        particles.Emit(x);
    }

}
