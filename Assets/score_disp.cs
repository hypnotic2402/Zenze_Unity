using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_disp : MonoBehaviour
{   

    public done doneScrpit;
    public Text score_text;
    public float completion_time = 0;

    public timer_code timer_sc;
    private bool score_displayed = false;
    

    // Update is called once per frame
    void Update()
    {
        if ((doneScrpit.isDone() == true) && !score_displayed)
        {
            score_text.text = timer_sc.tellTime().ToString();
            score_displayed = true;
            completion_time = timer_sc.tellTime();
        }



    }
}
