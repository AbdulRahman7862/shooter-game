// using UnityEngine;

// public class EnemyMovement : MonoBehaviour
// {
//     private float speed = 2f;

//     void Update()
//     {
//         // Move enemy downward
//         transform.Translate(Vector2.down * speed * Time.deltaTime);

//         // Destroy the enemy if it goes off-screen
//         if (transform.position.y < Camera.main.ViewportToWorldPoint(new Vector2(0, 0)).y - 1)
//         {
//             Destroy(gameObject);
//         }
//     }

//     // Method to set the speed dynamically
//     public void SetSpeed(float newSpeed)
//     {
//         speed = newSpeed;
//     }
// }


using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        // Move the enemy upward (positive Y direction)
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        // Destroy the enemy when it goes out of the screen (above the top)
        if (transform.position.y > Camera.main.orthographicSize + 1)
        {
            Destroy(gameObject);
        }
    }
}
