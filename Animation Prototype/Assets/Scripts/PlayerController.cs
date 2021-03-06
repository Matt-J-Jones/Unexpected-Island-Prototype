using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float rotationRate = 360;

    public float moveSpeed = 0.1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        Applyinput(moveAxis, turnAxis);
    }

    private void Applyinput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }
    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * moveSpeed);
    }
    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
    }
}
