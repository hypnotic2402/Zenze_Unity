using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame

    public  CharacterController controller;
    public float movementSpeed = 10f;
    Vector3 playerVel;
    public float g = -12f;

    public Transform gCheck;
    public float gcRad = 0.4f;
    public LayerMask gCheckMask;
    bool isGrounded;

    public float jumpH = 3f;

    void Update()
    {

        isGrounded = Physics.CheckSphere(gCheck.position , gcRad , gCheckMask);

        if (isGrounded && playerVel.y < 0)
        {
            playerVel.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            playerVel.y = Mathf.Sqrt(jumpH * -2f * g);
        }

        float xIN = Input.GetAxis("Horizontal");
        float zIN = Input.GetAxis("Vertical");

        Vector3 moveDir = transform.right * xIN + transform.forward * zIN;
        controller.Move(moveDir * Time.deltaTime * movementSpeed);

        playerVel.y += g * Time.deltaTime;

        controller.Move(playerVel * Time.deltaTime);



    }
}
