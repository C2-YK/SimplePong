using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public void ReplayMainGame()
    {
        LoadMainGameScene(GameInstance.instance.singlePlayerMode);
    }

    public void LoadMainGameScene(bool singlePlayerMode)
    {
        GameInstance.instance.singlePlayerMode = singlePlayerMode;
        SceneManager.LoadScene("MainGame");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void CloseGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stops the game if running in the Unity Editor
    #else
        Application.Quit(); // Quits the game when built
    #endif
    }
}
