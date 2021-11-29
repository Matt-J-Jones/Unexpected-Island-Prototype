using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public Rigidbody rb;
    Vector3 EulerAngleVelocity;
    private Vector3 moveDirection = Vector3.zero;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        EulerAngleVelocity = new Vector3(0, 100, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * Speed; 
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Speed * Time.deltaTime; 
        }
	    if (Input.GetKey(KeyCode.D))
        {
            Quaternion deltaRotation = Quaternion.Euler(EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Quaternion deltaRotation = Quaternion.Euler(-EulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }
}
