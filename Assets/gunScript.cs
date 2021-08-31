// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class gunScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float dmg = 10f;
    public float range = 100f;

    public Camera MainCam;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitinfo; //Structure used to get information back from a raycast
        
        if (Physics.Raycast(MainCam.transform.position, MainCam.transform.forward , out hitinfo , range ))
        {
            //Debug.Log(hitinfo.transform.name);

            Target target = hitinfo.transform.GetComponent<Target>();
            if (target != null)
            {
                target.takeDmg(dmg);
                //Debug.Log(target.health);
            }

        }
    }
    
}
