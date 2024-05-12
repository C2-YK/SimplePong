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
        SceneManager.LoadScene("MainGame"); // Replace "MainGame" with your actual scene name
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with your actual scene name
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
