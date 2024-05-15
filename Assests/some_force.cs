using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class some_force : MonoBehaviour
{
    public float Speed;
    protected Rigidbody r;
    public Vector3 force;
    public float mag;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        mag = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        Speed = r.velocity.magnitude;
        force = new Vector3(Random.Range(-1.0f, 1.0f),
                        Random.Range(-1.0f, 1.0f),
                        Random.Range(-1.0f, 1.0f));
        force = force.normalized;
        force *= mag;
        r.AddForce(force);
        
    }
}
