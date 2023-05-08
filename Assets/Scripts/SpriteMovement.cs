using System.Numerics;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float distance = 5f; // Distance to move
    public float speed = 2f; // Speed of movement
    private bool movingLeft = true; // Flag to indicate if moving left or right
    private UnityEngine.Vector3 startPos; // Starting position of the sprite

    void Start()
    {
        startPos = transform.position; // Save the starting position of the sprite
    }

    void Update()
    {
        if (movingLeft)
        {
            transform.Translate(UnityEngine.Vector3.left * speed * Time.deltaTime); // Move left
            if (UnityEngine.Vector3.Distance(transform.position, startPos) >= distance)
            {
                FlipSprite(); // Flip sprite when it reaches the end
                movingLeft = false; // Switch direction
            }
        }
        else
        {
            transform.Translate(UnityEngine.Vector3.right * speed * Time.deltaTime); // Move right
            if (UnityEngine.Vector3.Distance(transform.position, startPos) >= distance)
            {
                FlipSprite(); // Flip sprite when it reaches the end
                movingLeft = true; // Switch direction
            }
        }
    }

    void FlipSprite()
    {
        UnityEngine.Vector3 scale = transform.localScale;
        scale.x *= -1; // Flip vertically
        transform.localScale = scale;
    }
}
