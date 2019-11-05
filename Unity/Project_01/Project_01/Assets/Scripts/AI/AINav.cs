using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AINav : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3Data destination;

    // Start is called before the first frame update
    void Start()
    {
        destination.value = new Vector3(0, 0, 0);
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.value;
    }
}
