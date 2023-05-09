using System.Numerics;
using UnityEngine;

public class AirShipMove2 : MonoBehaviour
{
    public float distance = 5f; // Distance to move
    public float speed = 2f; // Speed of movement
    private bool movingForward = true; // Flag to indicate if moving left or right
    private UnityEngine.Vector3 startPos; // Starting position of the sprite

    void Start()
    {
        startPos = transform.position; // Save the starting position of the sprite
    }

    void Update()
    {
        if (movingForward)
        {
            transform.Translate(UnityEngine.Vector3.left * speed * Time.deltaTime); // Move left
            transform.Translate(UnityEngine.Vector3.back * (speed/10) * Time.deltaTime); // Move left

            // Check if the object has moved the specified distance
            if (transform.position.x > startPos.x + distance)
            {
                // If it has, teleport the object back to its starting position and set the flag to start moving forward again
                transform.position = startPos;
                movingForward = true;
            }
        }
        else
        {
            transform.position = startPos;

            // Set the flag to start moving forward again
            movingForward = true;
        }
    }
}
