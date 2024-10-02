using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    Animator animator;

    private float movementSpeed = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    //this is a note 
    // Update is called once per frame
    void Update()
    {
        animator.SetBool("ifRun", false);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;
            
                animator.SetBool("ifRun", true);

            


            if (Input.GetKey(KeyCode.Space)) { transform.position += Vector3.up * Time.deltaTime; }

            if (Input.GetKey(KeyCode.S)) { transform.position -= Vector3.forward * Time.deltaTime; }

            if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.up, -30 * Time.deltaTime);

            if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
    }
}