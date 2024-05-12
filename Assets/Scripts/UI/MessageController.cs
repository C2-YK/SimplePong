using UnityEngine;
using TMPro;

public class MessageController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text OutputText;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager != null)
        {
            switch(gameManager.gameState)
            {
                case GameStateEnum.waitingToStart:
                    OutputText.text = "[Press Space to Serve the ball]";
                    break;
                case GameStateEnum.playing:
                    OutputText.text = "";
                    break;
                case GameStateEnum.halftime:
                    if (gameManager.lastWinner == PlayerEnum.Player1)
                    {
                        OutputText.text = "Player1 Goal!\n[Press Space to Serve the ball]";
                    }
                    else
                    {
                        OutputText.text = "Player2 Goal!\n[Press Space to Serve the ball]";
                    }
                    break;
                case GameStateEnum.gameOver:
                    if(gameManager.lastWinner == PlayerEnum.Player1)
                    {
                        OutputText.text = "Player1 win!";
                    }
                    else
                    {
                        OutputText.text = "Player2 win!";
                    }
                    break;
                case GameStateEnum.pause:
                    OutputText.text = "Pause";
                    break;
                default:
                    OutputText.text = "Something wrong with this game, please refund.";
                    break;
            }
        }
    }
}
