using UnityEngine;
using UnityEngine.InputSystem;

public class GameController : MonoBehaviour
{
    public PlayerControls controls;
    public GameManager gameManager;

    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void Start()
    {
        Player[] players = FindObjectsOfType<Player>();
        bool singlePlayerMode = GameInstance.instance.singlePlayerMode;

        // Game Start keybinds
        controls.InGameKeys.ServeBall.performed += ctx => gameManager.StartGame();
        controls.InGameKeys.Pause.performed += ctx => gameManager.TogglePause();

        // Players control keybinds
        foreach (Player player in players)
        {
            if(player.PlayerEnum == PlayerEnum.Player1)
            {
                controls.InGameKeys.Player1MoveUp.performed += ctx => player.MoveUp();
                controls.InGameKeys.Player1MoveDown.performed += ctx => player.MoveDown();
                controls.InGameKeys.Player1MoveUp.canceled += ctx => player.MoveStop();
                controls.InGameKeys.Player1MoveDown.canceled += ctx => player.MoveStop();
            }
            else if(player.PlayerEnum == PlayerEnum.Player2)
            {
                if (!singlePlayerMode)
                {
                    controls.InGameKeys.Player2MoveUp.performed += ctx => player.MoveUp();
                    controls.InGameKeys.Player2MoveDown.performed += ctx => player.MoveDown();
                    controls.InGameKeys.Player2MoveUp.canceled += ctx => player.MoveStop();
                    controls.InGameKeys.Player2MoveDown.canceled += ctx => player.MoveStop();
                }
                else
                {
                    player.gameObject.AddComponent<AIPlayerController>();
                }
            }
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
