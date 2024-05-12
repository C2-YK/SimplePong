using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private GameManager gameManager;

    [SerializeField]
    private TMP_Text player1ScoreText, player2ScoreText;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if(gameManager != null)
        {
            player1ScoreText.text = gameManager.scorePlayer1.ToString();
            player2ScoreText.text = gameManager.scorePlayer2.ToString();
        }
    }
}
