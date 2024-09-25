using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) { transform.position += Vector3.forward * Time.deltaTime;}

        if (Input.GetKey(KeyCode.Space)) { transform.position += Vector3.up * Time.deltaTime; }

        if (Input.GetKey(KeyCode.S)) { transform.position -= Vector3.forward * Time.deltaTime; }

        if (Input.GetKey(KeyCode.A)) transform.Rotate(Vector3.up, -30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D)) transform.Rotate(Vector3.up, 30 * Time.deltaTime);
    }
}
