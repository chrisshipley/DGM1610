using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3Data forceDirection;
    public float force = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(forceDirection.value * force);
    }
}
