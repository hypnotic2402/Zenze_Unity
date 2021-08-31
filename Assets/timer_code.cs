using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_code : MonoBehaviour
{

    public float t;
    private float ti;
    // Start is called before the first frame update
    void Start()
    {
        ti = 0f;
        t = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        ti += Time.deltaTime;
        if (ti > 1f)
        {
            t += 1;
            //Debug.Log(t);
            ti = 0;
        }

        // t += 1;
        // Debug.Log(t);
        // ti = 0;
    }

    public float tellTime()
    {
        return t;
    }
}
