using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Get input from keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;

        // Move the car
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }
}
