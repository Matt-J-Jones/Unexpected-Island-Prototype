using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTree : MonoBehaviour
{
    public Receiver Receiver;

    public ChopWood ChopWood;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChopWood.PlayerInTrigger && Input.GetKey(KeyCode.E))
        {
            Receiver.Power(0.002f); 
        }
    }
}
