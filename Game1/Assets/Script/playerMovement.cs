using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

   public GameObject snowballCloneTemplate;

    Animator animator;

    Collider collider;

    public float horizonatalMove;

    public float verticalMove;

    public AudioSource shootingSound;

    private float movementSpeed = 5f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    //this is a note 
    // Update is called once per frame
    void Update()
    {

        horizonatalMove = Input.GetAxis("Horizontal");

        verticalMove = Input.GetAxis("Vertical");




        if (Input.GetMouseButtonDown(0))
        {
            GameObject newSnowballGO = Instantiate(snowballCloneTemplate, transform.position + transform.forward + Vector3.up, Quaternion.identity);
            SnowballScript myNewSnowball = newSnowballGO.GetComponent<SnowballScript>();
            myNewSnowball.throwSnowball(transform);
        }

        //set off for default

        animator.SetBool("ifRun", false);



        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime;

            animator.SetBool("ifRun", true);

        }





            if (Input.GetKey(KeyCode.Space)) { transform.position += Vector3.up * Time.deltaTime; }

            if (Input.GetKey(KeyCode.S)) { transform.position -= Vector3.forward * Time.deltaTime; }



        if (Input.GetKey(KeyCode.A)) { transform.Rotate(Vector3.up, -30 * Time.deltaTime); }

        if (Input.GetKey(KeyCode.D)) { transform.Rotate(Vector3.up, 30 * Time.deltaTime); }
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);

        collision.gameObject.transform.position += Vector3.forward;

        footballScript myFootball = collision.gameObject.GetComponent<footballScript>();
        if (myFootball != null)
        {
           myFootball.Kick();
        }
    }
}