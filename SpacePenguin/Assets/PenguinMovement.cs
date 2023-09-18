using UnityEngine;

public class PenguinMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float rotationSpeed = 20f;
    [SerializeField] private float jumpForce = 50f;
    [SerializeField] private Rigidbody penguinBody;
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 direction = transform.up * Input.GetAxis("Horizontal");
            transform.Rotate(direction * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            Vector3 direction = transform.forward * Input.GetAxis("Vertical");
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !IsTouchingFloor())
        {
            penguinBody.AddForce(Vector3.up * jumpForce);
        }
    }

    private bool IsTouchingFloor()
    {
        RaycastHit hit;
        bool result = Physics.SphereCast(transform.position, 0.15f, -transform.up, out hit, 1);
        return result;
    }
}
