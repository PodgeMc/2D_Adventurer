using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Method to start a new game
    public void BeginGame()
    {
        // Replace "OpenWorld" with the name of your open world scene
        SceneManager.LoadScene("OpenWorld");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("");
    }

    // Method to load the settings menu
    public void OpenSettings()
    {
        // Replace "Settings" with the name of your settings scene
        SceneManager.LoadScene("Settings");
    }

    // Method to quit the game
    public void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
