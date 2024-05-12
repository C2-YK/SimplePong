using UnityEngine;

public class AIPlayerController : MonoBehaviour
{
    private Player player;
    private Rigidbody2D ballRigidbody;
    private Vector2 threshold;
    private float reactionTime;
    private float lastReactionTime;

    enum AIStage
    {
        movingUp = 0, 
        movingDown = 1, 
        stop = 2
    };
    private AIStage stage;
    private bool stageChanged = false;
    
    private void Awake()
    {
        player = GetComponent<Player>();
        ballRigidbody = FindObjectOfType<Ball>().gameObject.GetComponent<Rigidbody2D>();
        threshold = GameInstance.instance.AIThreshold;
        reactionTime = GameInstance.instance.AIReactionTime;
    }
    
    private void Update()
    {
        if (Time.time - lastReactionTime > reactionTime)
        {
            AIReact();
            lastReactionTime = Time.time;
        }

        if (!stageChanged)
            return;

        stageChanged = false;

        switch(stage)
        {
            case AIStage.movingUp:
                player.MoveUp();
                break;
            case AIStage.movingDown:
                player.MoveDown();
                break;
            default:
                player.MoveStop();
                break;
        }
    }

    private void ChangeStage(AIStage stage)
    {
        if (this.stage == stage)
        {
            stageChanged = false;
        }
        else
        {
            this.stage = stage;
            stageChanged = true;
        }
    }

    private void AIReact()
    {
        if(ballRigidbody.velocity.x < 0)
        {
            ChangeStage(AIStage.stop);
            return;
        }

        // Check if the ball is within the activation distance on the x-axis
        if (Mathf.Abs(ballRigidbody.position.x - transform.position.x) <= threshold.x)
        {
            // Move the AI player towards the ball's y position
            if (Mathf.Abs(ballRigidbody.position.y - transform.position.y) > threshold.y)  // Adding a threshold to prevent jittering
            {
                if (ballRigidbody.position.y > transform.position.y)
                {
                    ChangeStage(AIStage.movingUp);
                }
                else
                {
                    ChangeStage(AIStage.movingDown);
                }
            }
            else
            {
                ChangeStage(AIStage.stop);  // Stop moving if close enough to the ball's y position
            }
        }
        else
        {
            ChangeStage(AIStage.stop);  // Stop moving if the ball is too far
        }
    }
}
