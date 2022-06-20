using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckScript : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Transform dir;
    Vector3 direction;
    Rigidbody rigidbody;
    public bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        // rigidbody.velocity = Vector3.up*jumpForce;
    }

    // Update is called once per frame
    void Update()
    {
        if(jump){
            jump = false;
            direction = (dir.position-transform.position).normalized;
            rigidbody.AddForce(direction*speed,ForceMode.Impulse);
        }
    }
}
