using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float rotationSpeed = 20f;
    [SerializeField] private float jumpForce = 50f;
    [SerializeField] private Rigidbody penguinBody;
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            Vector3 direction = transform.right * Input.GetAxis("Vertical");
            transform.Translate(direction * speed * Time.deltaTime);
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 direction = transform.up * Input.GetAxis("Horizontal");
            transform.Rotate(direction * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            penguinBody.AddForce(Vector3.up * jumpForce);
        }
    }
}
