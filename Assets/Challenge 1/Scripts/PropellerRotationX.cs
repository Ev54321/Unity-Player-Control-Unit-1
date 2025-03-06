using UnityEngine;

public class PropellerRotationX : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 20.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Makes the propeller spin
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * speed);
    }
}
