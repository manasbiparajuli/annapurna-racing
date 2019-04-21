using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
	[SerializeField] public float speed = 60.0f;
	[SerializeField] public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Get the horizontal and vertical axis
		// The axis are mapped to the arrow keys for up, down, right and left motion
		float horizontalInput = Input.GetAxis("Horizontal");
		float verticalInput = Input.GetAxis("Vertical");

		float translation = verticalInput * speed * Time.deltaTime;
		float rotation = horizontalInput * rotationSpeed * Time.deltaTime;

		// Move translation along the object's z-axis
		transform.Translate(0, 0, translation * -1.0f);

		// Rotate the car around y-axis
		transform.Rotate(0, rotation, 0);
    }
}
