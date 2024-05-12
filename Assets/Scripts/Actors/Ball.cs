using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed;
    private float velocityIncreaseFactor;
    private Rigidbody2D rb;
    private GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();

        GameInstance gameInstance = GameInstance.instance;
        speed = gameInstance.ballSpeed;
        velocityIncreaseFactor = gameInstance.ballVelocityIncreaseFactor;

        ResetPosition();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            Goal goal = collision.gameObject.GetComponent<Goal>(); // Try to get the Goal component from the collider
            if (goal != null)
            {
                gameManager.IncrementScore(goal.PlayerEnum); // Increment the score for the respective player
            }
        }
        else if (collision.gameObject.tag == "Player")
        {
            rb.velocity *= velocityIncreaseFactor;
        }
    }

    public void StartBallMovement()
    {
        float angleOffset = GetRandomAngle();
        Vector2 startDirection;

        // Determine the initial direction based on the last winner
        if (gameManager.lastWinner == PlayerEnum.Player1)
        {
            // Player 1 won; start to the right
            startDirection = Vector2.right;
        }
        else
        {
            // Player 2 won; start to the left
            startDirection = Vector2.left;
        }

        // Apply the random angle offset avoiding perpendicular angles
        startDirection = Quaternion.Euler(0, 0, angleOffset) * startDirection;
        rb.velocity = startDirection * speed;
    }

    public void ResetPosition()
    {
        rb.velocity = Vector2.zero;  // Start with no movement
        transform.position = Vector2.zero;  // Start at the center
    }

    float GetRandomAngle()
    {
        float angle;
        do
        {
            angle = Random.Range(-90f, 90f);
        } while (IsNearPerpendicular(angle));
        return angle;
    }

    bool IsNearPerpendicular(float angle)
    {
        // Define a small threshold around perpendicular angles
        float threshold = 10.0f;
        return Mathf.Abs(angle) < threshold || Mathf.Abs(angle - 90) < threshold || Mathf.Abs(angle + 90) < threshold;
    }
}
