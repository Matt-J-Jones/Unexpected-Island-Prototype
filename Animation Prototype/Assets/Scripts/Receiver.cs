using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    // Start is called before the first frame update
    [Range (0f,1f)]
    public float T = 0f;

    // [Range (0f,1f)]
    // public float DecayPerSecond = 0.0001f;

    public Item Tree_Cut;
    public Item Reward;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // T -= DecayPerSecond * Time.deltaTime;
        // T = Mathf.Clamp01(T);

        if (T >= 0.95)
        {
            Tree_Cut.gameObject.SetActive(false);
            Reward.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    public void Power (float t)
    {
        T += t;
        T = Mathf.Clamp01(T);
    }

}
