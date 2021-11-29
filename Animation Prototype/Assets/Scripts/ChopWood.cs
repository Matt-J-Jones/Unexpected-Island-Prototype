using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopWood : MonoBehaviour
{
    public Animator Animator;
    public bool PlayerInTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInTrigger && Input.GetKey(KeyCode.E))
        {
            Animator.SetBool("Chop", true);
        }
        if (Input.GetKeyUp(KeyCode.E)|| !PlayerInTrigger)
        {
            Animator.SetBool("Chop", false);
        }

    }
    void OnTriggerEnter(Collider other) // Player has entered collider
    {
        if(other.CompareTag("Player"))
        {
            PlayerInTrigger = true; //Set variable
        }
    }

    void OnTriggerExit(Collider other) // Player leaves collider
    {
        if(other.CompareTag("Player"))
        {
            PlayerInTrigger = false; //unset variable
        }
    }
}
