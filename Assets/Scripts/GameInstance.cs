using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInstance : MonoBehaviour
{
    public static GameInstance instance { get; private set; }
    
    // Game Setting
    public bool singlePlayerMode = false;
    public int maxScore = 3;
    public float ballSpeed = 5.0f;
    public float ballVelocityIncreaseFactor = 1.2f;
    public float playerSpeed = 10.0f;
    public Vector2 AIThreshold = new Vector2(7.0f, 1.1f);
    public float AIReactionTime = 0.2f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Make this persistent
        }
        else
        {
            Destroy(gameObject); // Ensure that there is only one instance
        }
    }
}
