using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAxe : MonoBehaviour
{
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKeyUp(KeyCode.E
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Animator.SetBool("Use", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Animator.SetBool("Use", false);

        }
    }
}
