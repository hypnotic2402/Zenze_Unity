using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_Mouse : MonoBehaviour
{
    // Start is called before the first frame update


    public float mSens = 100f; // Mouse sensitivity
    public Transform playerBody;
    float rot_aroundX = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxis("Mouse X") * Time.deltaTime * mSens;
        float mY = Input.GetAxis("Mouse Y") * Time.deltaTime * mSens;

        rot_aroundX -= mY;
        rot_aroundX = Mathf.Clamp(rot_aroundX,-90f , 90f);
        

        transform.localRotation = Quaternion.Euler(rot_aroundX , 0f, 0f);
        playerBody.Rotate(Vector3.up * mX);
        

        

        



    }
}
