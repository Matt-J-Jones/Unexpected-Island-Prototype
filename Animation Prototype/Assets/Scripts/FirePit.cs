using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePit : MonoBehaviour
{

    public int LogCount = 0;
    public Item Fire;
    public Item TextEnd;

    public bool CondMet = false;
    public bool LogCollect = false;
    public Item Log1;
    public Item Log2;
    public Item Log3;

    public bool PlayerInTrigger = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (!Log1.isActiveAndEnabled &&
          !Log2.isActiveAndEnabled &&
          !Log3.isActiveAndEnabled)
      {
        LogCollect = true;
      } else
      {
        LogCollect = false;
      }
      
      if (LogCount == 3 && LogCollect)
      {
        CondMet = true;
      }

      if (CondMet && 
          PlayerInTrigger && 
          Input.GetKeyDown(KeyCode.Q))
      {
        Fire.gameObject.SetActive(true);
        TextEnd.gameObject.SetActive(true);
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

