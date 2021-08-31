using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class done : MonoBehaviour
{   
    public float apples_shot = 0;
    public bool all_shot = false;
    
    void Update()
    {
        Debug.Log(apples_shot);
        if (apples_shot == 5)
        {
            all_shot = true;
        }

    }

    public void inc()
    {
        apples_shot++;
    }

    public bool isDone()
    {
        return all_shot;
    }

    

    
}
