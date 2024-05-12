using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject controlDiscription;
    [SerializeField]
    private GameObject MenuButtons;

    public int scorePlayer1 { get; private set; } = 0;
    public int scorePlayer2 { get; private set; } = 0;
    public GameStateEnum gameState { get; private set; } = GameStateEnum.waitingToStart;
    public PlayerEnum lastWinner { get; private set; } = PlayerEnum.Player1;

    private Ball ball;
    private int maxScore;
    private GameStateEnum gameStateTemp;

    void Start()
    {
        ball = FindObjectOfType<Ball>();
        if (ball == null)
        {
            gameState = GameStateEnum.error; // Exception
        }

        maxScore = GameInstance.instance.maxScore;

        if (controlDiscription != null)
            controlDiscription.SetActive(true);

        if (MenuButtons != null)
            MenuButtons.SetActive(false);
    }

    public void StartGame()
    {
        if(gameState == GameStateEnum.waitingToStart || gameState == GameStateEnum.halftime)
        {
            ball.StartBallMovement();
            gameState = GameStateEnum.playing;
        }
    }

    public void IncrementScore(PlayerEnum playerEnum)
    {
        switch (playerEnum)
        {
            case PlayerEnum.Player1:
                scorePlayer1++;
                break;
            case PlayerEnum.Player2:
                scorePlayer2++;
                break;
        }

        lastWinner = playerEnum;

        if(scorePlayer1 == maxScore || scorePlayer2 == maxScore)
        {
            gameState = GameStateEnum.gameOver;
            if (MenuButtons != null)
                MenuButtons.SetActive(true);
        }
        else
        {
            gameState = GameStateEnum.halftime;
        }

        Player[] players = FindObjectsOfType<Player>();
        foreach (Player player in players)
        {
            player.ResetPosition();
        }

        ball.ResetPosition();
    }

    public void PauseGame()
    {
        if (gameState == GameStateEnum.gameOver)
            return;

        if (MenuButtons != null)
            MenuButtons.SetActive(true);
        Time.timeScale = 0;
        gameStateTemp = gameState;
        gameState = GameStateEnum.pause;
    }

    public void ResumeGame()
    {
        if (gameState == GameStateEnum.gameOver)
            return;

        if (MenuButtons != null)
            MenuButtons.SetActive(false);
        Time.timeScale = 1;
        gameState = gameStateTemp;
    }

    public void TogglePause()
    {
        if (gameState == GameStateEnum.pause)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }
}
